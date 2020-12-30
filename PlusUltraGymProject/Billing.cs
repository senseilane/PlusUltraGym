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
    public partial class Billing : Form
    {
        string key;
        string FirstName, LastName, Add1, Add2, State, Zip;
        bool isValid = false;
        public Billing()
        {
            InitializeComponent();
            
        }

        //The next two methods are for validating the textboxes.
        private void TextboxVerification()
        {
            CheckTextbox(txtNameOnCard);
            CheckTextbox(txtCardNumber);
            CheckTextbox(txtExpDate);
            CheckTextbox(txtCVV);
            if (!checkBox1.Checked)
            {
                CheckTextbox(txtFirstName);
                CheckTextbox(txtLastName);
                CheckTextbox(txtStreet1);
                CheckTextbox(txtState);
                CheckTextbox(txtZip);
            }

            //foreach (var text in Controls.OfType<TextBox>())
            //{
            //    if (string.IsNullOrEmpty(text.Text))
            //    {
            //        text.BackColor = Color.Red;
            //        text.ForeColor = Color.White;
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
        private void CardNumber_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?:4[0-9]{12}(?:[0-9]{3})?|[25][1-7][0-9]{14}|6(?:011|5[0-9][0-9])[0-9]{12}|3[47][0-9]{13}|3(?:0[0-5]|[68][0-9])[0-9]{11}|(?:2131|1800|35\d{3})\d{11})$"); //Regex for card number
            if (!regex.IsMatch(txtCardNumber.Text))
            {
                isValid = false;
                MessageBox.Show("Must be in XXXXXXXXXXXXXXXX format\nNo spaces or dashes");
            }
        }

        private void Exp_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(0[1-9]|1[0-2])\/?([0-9]{2})$"); //Regex for credit card exp date
            if (!regex.IsMatch(txtExpDate.Text))
            {
                isValid = false;
                MessageBox.Show("Invalid expiration date format\nMust be MM/YY");
            }
        }

        private void CVV_Leave(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[0-9]{3}|[0-9]{4}$"); //Regex for credit card CVV
            if (!regex.IsMatch(txtCVV.Text))
            {
                isValid = false;
                MessageBox.Show("Invalid CVV number\nMust be three or four numerical digits");
                txtCVV.Text = "";
            }
        }

        private void StreetAddress1_Leave(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                Regex regex = new Regex(@"^\d{1,6}\040([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^\d{1,6}\040([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$|^\d{1,6}\040([A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,}\040[A-Z]{1}[a-z]{1,})$"); //Regex for Street Address 1
                if (!regex.IsMatch(txtStreet1.Text))
                {
                    isValid = false;
                    MessageBox.Show("Invalid street address format");
                    txtStreet1.Focus();
                }
            }
        }

        private void State_Leave(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                Regex regex = new Regex(@"^((A[LKSZR])|(C[AOT])|(D[EC])|(F[ML])|(G[AU])|(HI)|(I[DLNA])|(K[SY])|(LA)|(M[EHDAINSOT])|(N[EVHJMYCD])|(MP)|(O[HKR])|(P[WAR])|(RI)|(S[CD])|(T[NX])|(UT)|(V[TIA])|(W[AVIY]))$");
                if (!regex.IsMatch(txtState.Text))
                {
                    isValid = false;
                    MessageBox.Show("Invalid state abbreviation");
                    txtState.Focus();
                }
            }
        }

        private void Zip_Leave(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
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

        
        private void btnPreviousToPersonal_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Going back to the previous form\nwill delete the previous entry.", "Caption", MessageBoxButtons.OKCancel);
            if(confirmResult == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""W:\Volstate\Programming 2\Project\PlusUltraGymProject\PlusUltraGymProject\PlusUltraDatabase.mdf"";Integrated Security=True");
                con.Open();
                SqlCommand delete = new SqlCommand("DELETE FROM PlusUltraGym WHERE MemberID = '"+key+"'", con);
                delete.ExecuteNonQuery();
                con.Close();
                PersonalInformation personal = new PersonalInformation();
                personal.Show();
                this.Hide();
            }
            
        }

        private void btnContinueToList_Click(object sender, EventArgs e)
        {
            TextboxVerification();
            if (isValid == true)
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""W:\Volstate\Programming 2\Project\PlusUltraGymProject\PlusUltraGymProject\PlusUltraDatabase.mdf"";Integrated Security=True");
                con.Open();
                //Card Info Collection
                SqlCommand card = new SqlCommand("UPDATE PlusUltraGym SET CardInfo = @CardInfo, NameOnCard = @Name, CardNumber = @Number, ExpDate = @ExpDate, CVV = @CVV WHERE MemberID = '"+key+"'", con); //This works with the variable. Success! Now I need to mix that with my passing the variable from one form to the next.
                card.Parameters.Add("@CardInfo", SqlDbType.Text).Value = "********";
                card.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtNameOnCard.Text;
                card.Parameters.Add("@Number", SqlDbType.NVarChar).Value = txtCardNumber.Text;
                card.Parameters.Add("@ExpDate", SqlDbType.Text).Value = txtExpDate.Text;
                card.Parameters.Add("@CVV", SqlDbType.Text).Value = txtCVV.Text;
                card.ExecuteNonQuery();
                con.Close();

                if (!checkBox1.Checked)
                {
                    con.Open();
                    SqlCommand b = new SqlCommand("UPDATE PlusUltraGym SET Billing = @Billing, BillingFirstName = @FirstName, BillingLastName = @LastName, BillingAddress1 = @Add1, BillingAddress2 = @Add2, BillingState = @State, BillingZipCode = @Zip WHERE MemberID = '"+key+"'", con);
                    b.Parameters.Add("@Billing", SqlDbType.Text).Value = "********";
                    b.Parameters.Add("@FirstName", SqlDbType.NChar).Value = txtFirstName.Text;
                    b.Parameters.Add("@LastName", SqlDbType.NChar).Value = txtLastName.Text;
                    b.Parameters.Add("@Add1", SqlDbType.VarChar).Value = txtStreet1.Text;
                    b.Parameters.Add("@Add2", SqlDbType.VarChar).Value = txtStreet2.Text;
                    b.Parameters.Add("@State", SqlDbType.VarChar).Value = txtState.Text;
                    b.Parameters.Add("@Zip", SqlDbType.NVarChar).Value = txtZip.Text;
                    b.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    con.Open();
                    SqlCommand b = new SqlCommand("UPDATE PlusUltraGym SET Billing = @Billing, BillingFirstName = @FirstName, BillingLastName = @LastName, BillingAddress1 = @Add1, BillingAddress2 = @Add2, BillingState = @State, BillingZipCode = @Zip WHERE MemberID = '"+key+"'", con);
                    b.Parameters.Add("@Billing", SqlDbType.Text).Value = "********";
                    b.Parameters.Add("@FirstName", SqlDbType.NVarChar).Value = FirstName;
                    b.Parameters.Add("@LastName", SqlDbType.NVarChar).Value = LastName;
                    b.Parameters.Add("@Add1", SqlDbType.VarChar).Value = Add1;
                    b.Parameters.Add("@Add2", SqlDbType.VarChar).Value = Add2;
                    b.Parameters.Add("@State", SqlDbType.VarChar).Value = State;
                    b.Parameters.Add("@Zip", SqlDbType.NVarChar).Value = Zip;
                    b.ExecuteNonQuery();
                    con.Close();
                }
                SearchExistingMembers search = new SearchExistingMembers();
                search.Show();
                this.Hide();
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                gbBillingAddress.Enabled = false;
            }
            else
                gbBillingAddress.Enabled = true;
        }

        private void Billing_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""W:\Volstate\Programming 2\Project\PlusUltraGymProject\PlusUltraGymProject\PlusUltraDatabase.mdf"";Integrated Security=True");
            con.Open();
            string id = "SELECT MemberID, FirstName, LastName, StreetAddress1, StreetAddress2, State, ZipCode FROM PlusUltraGym";
            SqlCommand cmd = new SqlCommand(id, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                key = reader[0].ToString();
                FirstName = reader[1].ToString();
                LastName = reader[2].ToString();
                Add1 = reader[3].ToString();
                Add2 = reader[4].ToString();
                State = reader[5].ToString();
                Zip = reader[6].ToString();
            }
            reader.Close();
            con.Close();
        }
    }
}
