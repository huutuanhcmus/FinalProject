using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;

namespace QuickNote2
{
    public partial class ViewAndSaveNote : MetroFramework.Forms.MetroForm
    {
        SqlConnection connection = new SqlConnection(App.connect);
        SqlDataAdapter adapter;
        DataTable table = new DataTable();
        private String ID;
        
        public ViewAndSaveNote(String ID)
        {
            this.ID = ID;
            InitializeComponent();
            string SqlContent = "Select Content,ID_Tag From NoteTable Where ID_Note = '" + ID + "'";
            adapter = new SqlDataAdapter(SqlContent, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            textBox1.Text = dr["ID_Tag"].ToString();
            richTextBox1.Text = dr["Content"].ToString();
            textBox1.ReadOnly = true;
            richTextBox1.ReadOnly = true;
        }

        public ViewAndSaveNote()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if(button1.Text == "Change")
            {
                textBox1.ReadOnly = false;
                richTextBox1.ReadOnly = false;
                button1.Text = "Save";
            }
            else
            {
                if(textBox1.Text == "" || richTextBox1.Text == "")
                {
                    MessageBox.Show("You have not entered a tag or content yet!");
                    return;
                }
                string SqlContent = "Select ID_Tag From NoteTable Where ID_Note = " + ID;
                adapter = new SqlDataAdapter(SqlContent, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                DataRow dr = dt.Rows[0];
                string TagList = dr["ID_Tag"].ToString();
                char delim = ',';
                string[] substrings = TagList.Split(delim);
                foreach (var substring in substrings)
                    Console.WriteLine(substring);
                for (int i = 0; i < substrings.Length; i++)
                {
                    SqlContent = "Select Frequency From TagTable Where Name_Tag = N'" + substrings[i] + "'";
                    adapter = new SqlDataAdapter(SqlContent, connection);
                    dt = new DataTable();
                    adapter.Fill(dt);
                    dr = dt.Rows[0];
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
                SqlContent = "Delete From NoteTable Where ID_Note = " + ID;
                adapter = new SqlDataAdapter(SqlContent, connection);
                DataTable dt1 = new DataTable();
                adapter.Fill(dt1);

                string TagList1 = textBox1.Text;
                string[] substrings1 = TagList1.Split(delim);
                foreach (var substring1 in substrings1)
                    Console.WriteLine(substring1);
                SqlConnection cnn = new SqlConnection();
                cnn.ConnectionString = App.connect;
                cnn.Open();
                for (int i = 0; i < substrings1.Length; i++)
                {
                    string SqlExistTagOrNot = "Select ID_Tag from TagTable where Name_tag = N'" + substrings1[i] + "'";
                    SqlCommand command = new SqlCommand(SqlExistTagOrNot, cnn);
                    int temp;
                    string catid = "0";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            temp = reader.GetInt32(0);
                            catid = temp.ToString();
                        }
                    }
                    if (catid == "0")
                    {
                        string InsertTag = "Insert into TagTable (Name_tag, Frequency) Values (N'" + substrings1[i] + "',1)";
                        SqlCommand Insert = new SqlCommand(InsertTag, cnn);
                        Insert.ExecuteNonQuery();
                    }
                    else
                    {
                        string UpdateTag = "Update TagTable Set Frequency+=1 Where ID_Tag = " + catid;
                        SqlCommand Update = new SqlCommand(UpdateTag, cnn);
                        Update.ExecuteNonQuery();
                    }
                }

                string Note_Content = richTextBox1.Text;
                if (Note_Content != "")
                {
                    string InsertNote = "Insert into NoteTable (Date, ID_Tag, Content) Values ('" + DateTime.Now.ToString() + "', N'" + TagList1 + "', N'" + Note_Content + "')";
                    SqlCommand InsertNoteSql = new SqlCommand(InsertNote, cnn);
                    InsertNoteSql.ExecuteNonQuery();
                }
                textBox1.ReadOnly = true;
                richTextBox1.ReadOnly = true;
                button1.Text = "Change";
                MessageBox.Show("You have successfully saved this note!");
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            string SqlContent = "Select ID_Tag From NoteTable Where ID_Note = " + ID;
            adapter = new SqlDataAdapter(SqlContent, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            DataRow dr = dt.Rows[0];
            string TagList = dr["ID_Tag"].ToString();
            char delim = ',';
            string[] substrings = TagList.Split(delim);
            foreach (var substring in substrings)
                Console.WriteLine(substring);
            for (int i = 0; i < substrings.Length; i++)
            {
                SqlContent = "Select Frequency From TagTable Where Name_Tag = N'" + substrings[i] + "'";
                adapter = new SqlDataAdapter(SqlContent, connection);
                dt = new DataTable();
                adapter.Fill(dt);
                dr = dt.Rows[0];
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
            SqlContent = "Delete From NoteTable Where ID_Note = " + ID;
            adapter = new SqlDataAdapter(SqlContent, connection);
            DataTable dt1 = new DataTable();
            adapter.Fill(dt1);
            textBox1.Text = "";
            richTextBox1.Text = "";
            MessageBox.Show("You deleted this note successfully!");
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.SelectAll();
        }
    }
}
