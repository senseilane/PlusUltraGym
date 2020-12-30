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

namespace PlusUltraGymProject
{
    public partial class SearchExistingMembers : Form
    {
        public SearchExistingMembers()
        {
            InitializeComponent();
            BindGrid();
        }

        private void BindGrid()
        {
            string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""W:\Volstate\Programming 2\Project\PlusUltraGymProject\PlusUltraGymProject\PlusUltraDatabase.mdf"";Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("SELECT * FROM PlusUltraGym", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            StartPage start = new StartPage();
            start.Show();
            this.Hide();
        }
    }
}
