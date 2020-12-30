using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlusUltraGymProject
{
    public partial class SignInThanks : Form
    {
        public SignInThanks()
        {
            InitializeComponent();
            lblFirstName.Text = MemberSignIn.firstName;
            lblLastName.Text = MemberSignIn.lastName;
            lblMemberID.Text = MemberSignIn.memberID;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            StartPage start = new StartPage();
            this.Close();
        }
    }
}
