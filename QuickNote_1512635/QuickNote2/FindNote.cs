using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickNote2
{
    public partial class FindNote : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(App.connect);
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        public FindNote()
        {
            InitializeComponent();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            listView1.Items.Clear();
            listView1.Update();
            listView1.Columns.Add("ID").Width = 50;
            listView1.Columns.Add("Date").Width = 90;
            listView1.Columns.Add("Tag").Width = 150;
            listView1.Columns.Add("Sample Content").Width = 300;


            string TagKeyWord = textBox1.Text;
            string SqlContent = "Select Content,ID_Tag, ID_Note, Date From NoteTable Where Content like N'%" + TagKeyWord + "%' order by Date desc, ID_Note desc";
            adapter = new SqlDataAdapter(SqlContent, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["ID_Note"].ToString());
                DateTime datevalue;
                DateTime.TryParse(dr["Date"].ToString(), out datevalue);
                string s = datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                listitem.SubItems.Add(s);
                listitem.SubItems.Add(dr["ID_Tag"].ToString());
                listitem.SubItems.Add(dr["Content"].ToString());
                listView1.Items.Add(listitem);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            string id = item.SubItems[0].Text;
            ViewAndSaveNote form5 = new ViewAndSaveNote(id);
            form5.Show();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            string TagList = item.SubItems[2].Text;
            char delim = ',';
            string[] substrings = TagList.Split(delim);
            foreach (var substring in substrings)
                Console.WriteLine(substring);
            //SqlConnection cnn = new SqlConnection();
            //cnn.ConnectionString = App.connect;
            //cnn.Open();
            for (int i = 0; i < substrings.Length; i++)
            {
                string SqlContent = "Select Frequency From TagTable Where Name_Tag = N'" + substrings[i] + "'";
                adapter = new SqlDataAdapter(SqlContent, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataRow dr = dt.Rows[0];
                if (dr["Frequency"].ToString() == "1")
                {
                    SqlContent = "Delete From TagTable Where Name_Tag = N'" + substrings[i] + "'";
                }
                else
                {
                    SqlContent = "Update TagTable Set Frequency-= 1 Where Name_Tag = N'" + substrings[i] + "'";
                }
                adapter = new SqlDataAdapter(SqlContent, connection);
                dt = new DataTable();
                adapter.Fill(dt);

            }
            string IDNote = item.SubItems[0].Text;
            string SqlContent1 = "Delete From NoteTable Where ID_Note = " + IDNote;
            adapter = new SqlDataAdapter(SqlContent1, connection);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);

            listView1.Items.Clear();
            listView1.Update();
            listView1.Columns.Add("ID").Width = 50;
            listView1.Columns.Add("Date").Width = 90;
            listView1.Columns.Add("Tag").Width = 150;
            listView1.Columns.Add("Sample Content").Width = 300;


            string TagKeyWord = textBox1.Text;
            string SqlContent2 = "Select Content,ID_Tag, ID_Note, Date From NoteTable Where Content like N'%" + TagKeyWord + "%' order by Date desc, ID_Note desc";
            adapter = new SqlDataAdapter(SqlContent2, connection);
            DataTable dt2 = new DataTable();
            adapter.Fill(dt2);

            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                DataRow dr = dt2.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["ID_Note"].ToString());
                DateTime datevalue;
                DateTime.TryParse(dr["Date"].ToString(), out datevalue);
                string s = datevalue.ToString("dd/M/yyyy", CultureInfo.InvariantCulture);
                listitem.SubItems.Add(s);
                listitem.SubItems.Add(dr["ID_Tag"].ToString());
                listitem.SubItems.Add(dr["Content"].ToString());
                listView1.Items.Add(listitem);
            }

            MessageBox.Show("You deleted this note successfully!");
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            TakeNote Tk = new TakeNote();
            Tk.Show();
        }
    }
}
