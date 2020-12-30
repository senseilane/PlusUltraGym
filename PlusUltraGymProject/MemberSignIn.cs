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
    public partial class MemberSignIn : Form
    {
        public static string firstName, lastName, memberID;
        int ID;
        bool retrieveID;

        public MemberSignIn()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                retrieveID = Int32.TryParse(txtMemberID.Text, out ID);
                if (retrieveID == false)
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Please enter ID in a numeric format.");
                txtMemberID.Focus();
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""W:\Volstate\Programming 2\Project\PlusUltraGymProject\PlusUltraGymProject\PlusUltraDatabase.mdf"";Integrated Security=True");
            con.Open();
            string search = "SELECT FirstName, LastName FROM PlusUltraGym WHERE MemberID = '" + ID + "'";
            SqlCommand cmd = new SqlCommand(search, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                firstName = reader[0].ToString();
                lastName = reader[1].ToString();
            }
            if(firstName == null)
            {
                MessageBox.Show("Invalid Member ID");
                txtMemberID.Text = "";
                txtMemberID.Focus();
            }
            else
            {
                memberID = Convert.ToString(ID);
                SignInThanks thanks = new SignInThanks();
                thanks.ShowDialog();
                con.Close();
                this.Close();
            }

        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            StartPage start = new StartPage();
            this.Close();
        }
    }
}
