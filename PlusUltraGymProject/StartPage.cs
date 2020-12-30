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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //this is the New Member button
            PersonalInformation personal = new PersonalInformation();
            personal.Show();
            this.Hide();
        }

        private void btnMemberSignIn_Click(object sender, EventArgs e)
        {
            MemberSignIn signIn = new MemberSignIn();
            signIn.ShowDialog();
        }

        private void btnToSearch_Click(object sender, EventArgs e)
        {
            SearchExistingMembers search = new SearchExistingMembers();
            search.Show();
            this.Hide();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
