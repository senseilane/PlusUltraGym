namespace PlusUltraGymProject
{
    partial class StartPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewMember = new System.Windows.Forms.Button();
            this.btnMemberSignIn = new System.Windows.Forms.Button();
            this.btnToSearch = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewMember
            // 
            this.btnNewMember.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnNewMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.btnNewMember.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnNewMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewMember.ForeColor = System.Drawing.Color.White;
            this.btnNewMember.Location = new System.Drawing.Point(505, 149);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(107, 65);
            this.btnNewMember.TabIndex = 0;
            this.btnNewMember.Text = "New Member";
            this.btnNewMember.UseVisualStyleBackColor = false;
            this.btnNewMember.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnMemberSignIn
            // 
            this.btnMemberSignIn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMemberSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.btnMemberSignIn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMemberSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnMemberSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberSignIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMemberSignIn.ForeColor = System.Drawing.Color.White;
            this.btnMemberSignIn.Location = new System.Drawing.Point(505, 78);
            this.btnMemberSignIn.Name = "btnMemberSignIn";
            this.btnMemberSignIn.Size = new System.Drawing.Size(107, 65);
            this.btnMemberSignIn.TabIndex = 0;
            this.btnMemberSignIn.Text = "Member Sign In";
            this.btnMemberSignIn.UseVisualStyleBackColor = false;
            this.btnMemberSignIn.Click += new System.EventHandler(this.btnMemberSignIn_Click);
            // 
            // btnToSearch
            // 
            this.btnToSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnToSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.btnToSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnToSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnToSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToSearch.ForeColor = System.Drawing.Color.White;
            this.btnToSearch.Location = new System.Drawing.Point(505, 220);
            this.btnToSearch.Name = "btnToSearch";
            this.btnToSearch.Size = new System.Drawing.Size(107, 65);
            this.btnToSearch.TabIndex = 1;
            this.btnToSearch.Text = "Lookup Members";
            this.btnToSearch.UseVisualStyleBackColor = false;
            this.btnToSearch.Click += new System.EventHandler(this.btnToSearch_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(220)))));
            this.btnLogOut.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(505, 291);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(107, 65);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PlusUltraGymProject.Properties.Resources.PlusUltraTitle3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(796, 434);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnToSearch);
            this.Controls.Add(this.btnMemberSignIn);
            this.Controls.Add(this.btnNewMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StartPage";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewMember;
        private System.Windows.Forms.Button btnMemberSignIn;
        private System.Windows.Forms.Button btnToSearch;
        private System.Windows.Forms.Button btnLogOut;
    }
}

