using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace QuickNote2
{
    public partial class ViewNote : MetroFramework.Forms.MetroForm
    {
        string reverse = "desc";
        SqlConnection connection = new SqlConnection(App.connect);
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        public ViewNote()
        {
            InitializeComponent();
            
        }

         
        private void Note_Load(object sender, EventArgs e)
        {
            table.Clear();
            adapter = new SqlDataAdapter("SELECT * FROM TagTable order by Frequency " + reverse, connection);
            adapter.Fill(table);
            listBox1.DataSource = null;
            listBox1.Items.Clear();
            listView1.Items.Clear();
            listView1.Update();
            listBox1.DataSource = table;
            listBox1.DisplayMember = "Name_tag";
            listBox1.ValueMember = "Name_tag";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.noteTableAdapter.FillBy(this.quickNodeDataSet.Note);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        /*
        void fillListBox()

        {

            var connString = @"Data Source=LENOVO\JIMAI;Initial Catalog=QuịckNote1;Integrated Security=True";
            using (SqlConnection c = new SqlConnection(connString))
            {
                c.Open();

                // use a SqlAdapter to execute the query
                using (SqlDataAdapter a = new SqlDataAdapter("SELECT Name_Tag FROM TagTable", c))
                {
                    // fill a data table
                    var t = new DataTable();
                    a.Fill(t);

                    // Bind the table to the list box
                    listBox1.DisplayMember = "NameOfColumnToBeDisplayed";
                    listBox1.ValueMember = "NameOfColumnToUseValueFrom";
                    listBox1.DataSource = t;
                }
            }

        }*/

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, MouseEventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
                return;
            listView1.Clear();
            listView1.Columns.Add("ID").Width = 50;
            listView1.Columns.Add("Date").Width = 90;
            listView1.Columns.Add("Tag").Width = 150;
            listView1.Columns.Add("Sample Content").Width = 300;


            string TagKeyWord = listBox1.SelectedValue.ToString();
            string SqlContent = "Select Content,ID_Tag, ID_Note, Date From NoteTable Where ID_Tag like N'%" + TagKeyWord + "%' order by Date desc, ID_Note desc";
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
            //string selected = listBox1.SelectedValue.ToString();
            //string SqlContent = "Select ID_Note as 'ID Note',Content ,ID_Tag as Tags From NoteTable Where ID_Tag like '%" + selected + "%'";
            //SqlDataAdapter da = new SqlDataAdapter(SqlContent, connection);
            //DataSet dt = new DataSet();
            //da.Fill(dt);
          
            //if ( dt.Tables.Count > 0)
            //{
            //    dataGridView1.DataSource = dt.Tables[0];
            //}
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        

        

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
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
            if (listView1.SelectedItems == null)
                return;
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
                if(dr["Frequency"].ToString() == "1"){
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
            Note_Load(new object(), new EventArgs());
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

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            Note_Load(new object(), new EventArgs());
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (reverse == "desc")
                reverse = "asc";
            else
                reverse = "desc";
            Note_Load(new object(), new EventArgs());
        }
    }
}
