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
    public partial class Statistics : MetroFramework.Forms.MetroForm
    {
        public Statistics()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(App.connect);
            SqlDataAdapter ada = new SqlDataAdapter("select Name_tag, Frequency from TagTable order by Frequency desc", con);
            DataTable dt = new DataTable();
            ada.Fill(dt);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                ListViewItem listitem = new ListViewItem(dr["Name_tag"].ToString());
                listitem.SubItems.Add(dr["Frequency"].ToString());
                listView1.Items.Add(listitem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadList(DataSet _DataSet)
        {

        }

    private void Statistics_Load(object sender, EventArgs e)
    {

    }

    private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
    {

    }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {

        }
    }
}
