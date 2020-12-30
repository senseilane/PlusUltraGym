namespace PlusUltraGymProject
{
    partial class PersonalInformation
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
            this.btnContinueToBilling = new System.Windows.Forms.Button();
            this.btnPreviousToStart = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblFirstError = new System.Windows.Forms.Label();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.lblLastError = new System.Windows.Forms.Label();
            this.lblDobError = new System.Windows.Forms.Label();
            this.lblStreetError1 = new System.Windows.Forms.Label();
            this.lblStateError = new System.Windows.Forms.Label();
            this.lblZipError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnContinueToBilling
            // 
            this.btnContinueToBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnContinueToBilling.Location = new System.Drawing.Point(664, 379);
            this.btnContinueToBilling.Name = "btnContinueToBilling";
            this.btnContinueToBilling.Size = new System.Drawing.Size(75, 27);
            this.btnContinueToBilling.TabIndex = 7;
            this.btnContinueToBilling.Text = "Continue";
            this.btnContinueToBilling.UseVisualStyleBackColor = true;
            this.btnContinueToBilling.Click += new System.EventHandler(this.btnContinueToBilling_Click);
            // 
            // btnPreviousToStart
            // 
            this.btnPreviousToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPreviousToStart.Location = new System.Drawing.Point(52, 379);
            this.btnPreviousToStart.Name = "btnPreviousToStart";
            this.btnPreviousToStart.Size = new System.Drawing.Size(75, 27);
            this.btnPreviousToStart.TabIndex = 8;
            this.btnPreviousToStart.Text = "Back";
            this.btnPreviousToStart.UseVisualStyleBackColor = true;
            this.btnPreviousToStart.Click += new System.EventHandler(this.btnPreviousToStart_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.White;
            this.txtLastName.ForeColor = System.Drawing.Color.Black;
            this.txtLastName.Location = new System.Drawing.Point(385, 116);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLastName.Location = new System.Drawing.Point(295, 119);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 17);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.White;
            this.txtFirstName.ForeColor = System.Drawing.Color.Black;
            this.txtFirstName.Location = new System.Drawing.Point(385, 78);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(295, 81);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 17);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name: ";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDate.Location = new System.Drawing.Point(385, 156);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 2;
            this.txtDate.Text = "MM/DD/YYYY";
            this.txtDate.Enter += new System.EventHandler(this.DOB_Enter);
            this.txtDate.Leave += new System.EventHandler(this.DOB_Leave);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDate.Location = new System.Drawing.Point(284, 159);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(95, 17);
            this.lblDate.TabIndex = 11;
            this.lblDate.Text = "Date of Birth: ";
            // 
            // txtStreet1
            // 
            this.txtStreet1.BackColor = System.Drawing.Color.White;
            this.txtStreet1.ForeColor = System.Drawing.Color.Black;
            this.txtStreet1.Location = new System.Drawing.Point(385, 194);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(161, 20);
            this.txtStreet1.TabIndex = 3;
            this.txtStreet1.Leave += new System.EventHandler(this.Street1_Leave);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStreet.Location = new System.Drawing.Point(257, 197);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(122, 17);
            this.lblStreet.TabIndex = 12;
            this.lblStreet.Text = "Street Address 1: ";
            // 
            // txtStreet2
            // 
            this.txtStreet2.BackColor = System.Drawing.Color.White;
            this.txtStreet2.ForeColor = System.Drawing.Color.Black;
            this.txtStreet2.Location = new System.Drawing.Point(385, 232);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(161, 20);
            this.txtStreet2.TabIndex = 4;
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStreet2.Location = new System.Drawing.Point(257, 235);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(122, 17);
            this.lblStreet2.TabIndex = 13;
            this.lblStreet2.Text = "Street Address 2: ";
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.Color.White;
            this.txtState.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.ForeColor = System.Drawing.Color.Black;
            this.txtState.Location = new System.Drawing.Point(385, 270);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(33, 20);
            this.txtState.TabIndex = 5;
            this.txtState.Leave += new System.EventHandler(this.State_Leave);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblState.Location = new System.Drawing.Point(330, 273);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(49, 17);
            this.lblState.TabIndex = 14;
            this.lblState.Text = "State: ";
            // 
            // txtZip
            // 
            this.txtZip.BackColor = System.Drawing.Color.White;
            this.txtZip.ForeColor = System.Drawing.Color.Black;
            this.txtZip.Location = new System.Drawing.Point(385, 308);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(69, 20);
            this.txtZip.TabIndex = 6;
            this.txtZip.Leave += new System.EventHandler(this.Zip_Leave);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblZip.Location = new System.Drawing.Point(306, 311);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(73, 17);
            this.lblZip.TabIndex = 15;
            this.lblZip.Text = "Zip Code: ";
            // 
            // lblFirstError
            // 
            this.lblFirstError.AutoSize = true;
            this.lblFirstError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstError.Location = new System.Drawing.Point(491, 81);
            this.lblFirstError.Name = "lblFirstError";
            this.lblFirstError.Size = new System.Drawing.Size(13, 17);
            this.lblFirstError.TabIndex = 16;
            this.lblFirstError.Text = "*";
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(333, 389);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(134, 17);
            this.lblErrorMessage.TabIndex = 17;
            this.lblErrorMessage.Text = "* is a required value";
            // 
            // lblLastError
            // 
            this.lblLastError.AutoSize = true;
            this.lblLastError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastError.ForeColor = System.Drawing.Color.Red;
            this.lblLastError.Location = new System.Drawing.Point(491, 119);
            this.lblLastError.Name = "lblLastError";
            this.lblLastError.Size = new System.Drawing.Size(13, 17);
            this.lblLastError.TabIndex = 18;
            this.lblLastError.Text = "*";
            // 
            // lblDobError
            // 
            this.lblDobError.AutoSize = true;
            this.lblDobError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDobError.ForeColor = System.Drawing.Color.Red;
            this.lblDobError.Location = new System.Drawing.Point(491, 159);
            this.lblDobError.Name = "lblDobError";
            this.lblDobError.Size = new System.Drawing.Size(13, 17);
            this.lblDobError.TabIndex = 19;
            this.lblDobError.Text = "*";
            // 
            // lblStreetError1
            // 
            this.lblStreetError1.AutoSize = true;
            this.lblStreetError1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreetError1.ForeColor = System.Drawing.Color.Red;
            this.lblStreetError1.Location = new System.Drawing.Point(552, 197);
            this.lblStreetError1.Name = "lblStreetError1";
            this.lblStreetError1.Size = new System.Drawing.Size(13, 17);
            this.lblStreetError1.TabIndex = 20;
            this.lblStreetError1.Text = "*";
            // 
            // lblStateError
            // 
            this.lblStateError.AutoSize = true;
            this.lblStateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateError.ForeColor = System.Drawing.Color.Red;
            this.lblStateError.Location = new System.Drawing.Point(424, 273);
            this.lblStateError.Name = "lblStateError";
            this.lblStateError.Size = new System.Drawing.Size(13, 17);
            this.lblStateError.TabIndex = 22;
            this.lblStateError.Text = "*";
            // 
            // lblZipError
            // 
            this.lblZipError.AutoSize = true;
            this.lblZipError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipError.ForeColor = System.Drawing.Color.Red;
            this.lblZipError.Location = new System.Drawing.Point(460, 311);
            this.lblZipError.Name = "lblZipError";
            this.lblZipError.Size = new System.Drawing.Size(13, 17);
            this.lblZipError.TabIndex = 23;
            this.lblZipError.Text = "*";
            // 
            // PersonalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblZipError);
            this.Controls.Add(this.lblStateError);
            this.Controls.Add(this.lblStreetError1);
            this.Controls.Add(this.lblDobError);
            this.Controls.Add(this.lblLastError);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.lblFirstError);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtStreet2);
            this.Controls.Add(this.lblStreet2);
            this.Controls.Add(this.txtStreet1);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.btnPreviousToStart);
            this.Controls.Add(this.btnContinueToBilling);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PersonalInformation";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinueToBilling;
        private System.Windows.Forms.Button btnPreviousToStart;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblFirstError;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblLastError;
        private System.Windows.Forms.Label lblDobError;
        private System.Windows.Forms.Label lblStreetError1;
        private System.Windows.Forms.Label lblStateError;
        private System.Windows.Forms.Label lblZipError;
    }
}