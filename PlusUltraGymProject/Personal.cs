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
using System.Text.RegularExpressions;

namespace PlusUltraGymProject
{
    public partial class PersonalInformation : Form
    {
        bool isValid = false;
        public PersonalInformation()
        {
            InitializeComponent();
            foreach(var control in Controls.OfType<TextBox>())
            {
                control.Enter += ChangeBack;
            }
            void ChangeBack(object sender, EventArgs e)
            {
                ((TextBox)sender).BackColor = Color.White;
                ((TextBox)sender).ForeColor = Color.Black;
            }
            
        }

        //The next two methods are for validating the textboxes.
        private void TextboxVerification()
        {
            CheckTextbox(txtFirstName);
            CheckTextbox(txtLastName);
            CheckTextbox(txtDate);
            CheckTextbox(txtStreet1);
            CheckTextbox(txtState);
            CheckTextbox(txtZip);
            //foreach(var control in Controls.OfType<TextBox>())
            //{
            //    if (string.IsNullOrEmpty(control.Text))
            //    {
            //        control.BackColor = Color.Red;
            //        control.ForeColor = Color.White;
            //    }
            //}
        }
        private void CheckTextbox(TextBox textbox)
        {
            if (string.IsNullOrEmpty(textbox.Text))
            {
                isValid = false;
            }
            else
                isValid = true;
        }
        //End validation methods

        private void btnPreviousToStart_Click(object sender, EventArgs e)
        {
            StartPage start = new StartPage();
            start.Show();
            this.Hide();
        }

        private void btnContinueToBilling_Click(object sender, EventArgs e)
        {
            TextboxVerification();
            if(isValid == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""W:\Volstate\Programming 2\Project\PlusUltraGymProject\PlusUltraGymProject\PlusUltraDatabase.mdf"";Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO PlusUltraGym (FirstName, LastName, DateOfBirth, StreetAddress1, StreetAddress2, State, ZipCode) VALUES (@FirstName, @LastName, @DOB, @Add1, @Add2, @State, @Zip)", con);
                cmd.Parameters.Add("@FirstName", SqlDbType.NChar).Value = txtFirstName.Text;
                cmd.Parameters.Add("@LastName", SqlDbType.NChar).Value = txtLastName.Text;
                cmd.Parameters.Add("@DOB", SqlDbType.NVarChar).Value = txtDate.Text;
                cmd.Parameters.Add("@Add1", SqlDbType.VarChar).Value = txtStreet1.Text;
                cmd.Parameters.Add("@Add2", SqlDbType.VarChar).Value = txtStreet2.Text;
                cmd.Parameters.Add("@State", SqlDbType.VarChar).Value = txtState.Text;
                cmd.Parameters.Add("@Zip", SqlDbType.NVarChar).Value = txtZip.Text;
                cmd.ExecuteNonQuery();
                Billing billing = new Billing();
                billing.Show();
                this.Hide();
            }
                
        }

        private void DOB_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^([0]?[1-9]|[1][0-2])[./-]([0]?[1-9]|[1|2][0-9]|[3][0|1])[./-]([0-9]{4}|[0-9]{2})$"); //Regex for birthday
            if (!regex.IsMatch(txtDate.Text))
            {
                isValid = false;
                MessageBox.Show("Must be in MM/DD/YYYY format");
                txtDate.Text = "MM/DD/YYYY";
            }
        }
        private void DOB_Enter(object sender, EventArgs e)
        {
            txtDate.Text = "";
            txtDate.ForeColor = Color.Black;
        }

        private void Street1_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^\d{1,6}\040([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^\d{1,6}\040([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^\d{1,6}\040([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$"); //Regex for Street Address 1
            if (!regex.IsMatch(txtStreet1.Text))
            {
                isValid = false;
                MessageBox.Show("Invalid street address format");
                txtStreet1.Focus();
            }
        }

        private void State_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^((A[LKSZR])|(C[AOT])|(D[EC])|(F[ML])|(G[AU])|(HI)|(I[DLNA])|(K[SY])|(LA)|(M[EHDAINSOT])|(N[EVHJMYCD])|(MP)|(O[HKR])|(P[WAR])|(RI)|(S[CD])|(T[NX])|(UT)|(V[TIA])|(W[AVIY]))$");
            if (!regex.IsMatch(txtState.Text))
            {
                isValid = false;
                MessageBox.Show("Invalid state abbreviation");
                txtState.Focus();
            }
        }

        private void Zip_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?(^00000(|-0000))|(\d{5}(|-\d{4})))$");
            if (!regex.IsMatch(txtZip.Text))
            {
                isValid = false;
                MessageBox.Show("Invalid zip code");
                txtZip.Focus();
            }
        }
    }
}
