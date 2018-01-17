using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuickNote2
{
    public partial class TakeNote : MetroFramework.Forms.MetroForm
    {
        public TakeNote()
        {
            InitializeComponent();
        }

        private void TakeNote_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void TakeNote_Shown(object sender, EventArgs e)
        {

        }

        private void Save_b_Click(object sender, EventArgs e)
        {
            if (Tag_textbox.Text == "" || Note_textbox.Text == "")
            {
                MessageBox.Show("You have not entered a tag or content yet!");
                return;
            }
            string TagList = Tag_textbox.Text;
            char delim = ',';
            string[] substrings = TagList.Split(delim);
            foreach (var substring in substrings)
                Console.WriteLine(substring);
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = App.connect;
            cnn.Open();
            for (int i = 0; i < substrings.Length; i++)
            {
                string SqlExistTagOrNot = "Select ID_Tag from TagTable where Name_tag = N'" + substrings[i] + "'";
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
                    string InsertTag = "Insert into TagTable (Name_tag, Frequency) Values (N'" + substrings[i] + "',1)";
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

            string Note_Content = Note_textbox.Text;
            if (Note_Content != "")
            {
                string InsertNote = "Insert into NoteTable (Date, ID_Tag, Content) Values ('" + DateTime.Now.ToString() + "', N'" + TagList + "', N'" + Note_Content + "')";
                SqlCommand InsertNoteSql = new SqlCommand(InsertNote, cnn);
                InsertNoteSql.ExecuteNonQuery();
                Note_textbox.Clear();
                Tag_textbox.Clear();
                MessageBox.Show("You have successfully saved this note!");
            }
        }

        private void TakeNote_Load(object sender, EventArgs e)
        {

        }

        private void Note_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
