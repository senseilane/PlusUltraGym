namespace PlusUltraGymProject
{
    partial class Billing
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
            this.btnContinueToList = new System.Windows.Forms.Button();
            this.btnPreviousToPersonal = new System.Windows.Forms.Button();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lblZip = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtStreet2 = new System.Windows.Forms.TextBox();
            this.lblStreet2 = new System.Windows.Forms.Label();
            this.txtStreet1 = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.gbBillingAddress = new System.Windows.Forms.GroupBox();
            this.lblZipError = new System.Windows.Forms.Label();
            this.lblStateError = new System.Windows.Forms.Label();
            this.lblStreet1Error = new System.Windows.Forms.Label();
            this.lblLastNameError = new System.Windows.Forms.Label();
            this.lblFirstError = new System.Windows.Forms.Label();
            this.gbPayment = new System.Windows.Forms.GroupBox();
            this.lblCVVError = new System.Windows.Forms.Label();
            this.lblExpError = new System.Windows.Forms.Label();
            this.lblCardNumberError = new System.Windows.Forms.Label();
            this.lblCardNameError = new System.Windows.Forms.Label();
            this.lblCVV = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.lblExpDate = new System.Windows.Forms.Label();
            this.txtExpDate = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblNameOnCard = new System.Windows.Forms.Label();
            this.txtNameOnCard = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.gbBillingAddress.SuspendLayout();
            this.gbPayment.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnContinueToList
            // 
            this.btnContinueToList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnContinueToList.Location = new System.Drawing.Point(696, 671);
            this.btnContinueToList.Name = "btnContinueToList";
            this.btnContinueToList.Size = new System.Drawing.Size(75, 28);
            this.btnContinueToList.TabIndex = 0;
            this.btnContinueToList.Text = "Continue";
            this.btnContinueToList.UseVisualStyleBackColor = true;
            this.btnContinueToList.Click += new System.EventHandler(this.btnContinueToList_Click);
            // 
            // btnPreviousToPersonal
            // 
            this.btnPreviousToPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnPreviousToPersonal.Location = new System.Drawing.Point(44, 670);
            this.btnPreviousToPersonal.Name = "btnPreviousToPersonal";
            this.btnPreviousToPersonal.Size = new System.Drawing.Size(75, 29);
            this.btnPreviousToPersonal.TabIndex = 1;
            this.btnPreviousToPersonal.Text = "Back";
            this.btnPreviousToPersonal.UseVisualStyleBackColor = true;
            this.btnPreviousToPersonal.Click += new System.EventHandler(this.btnPreviousToPersonal_Click);
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(144, 243);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(69, 20);
            this.txtZip.TabIndex = 30;
            this.txtZip.Leave += new System.EventHandler(this.Zip_Leave);
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblZip.Location = new System.Drawing.Point(65, 246);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(73, 17);
            this.lblZip.TabIndex = 31;
            this.lblZip.Text = "Zip Code: ";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(144, 205);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(33, 20);
            this.txtState.TabIndex = 28;
            this.txtState.Leave += new System.EventHandler(this.State_Leave);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblState.Location = new System.Drawing.Point(89, 208);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(49, 17);
            this.lblState.TabIndex = 29;
            this.lblState.Text = "State: ";
            // 
            // txtStreet2
            // 
            this.txtStreet2.Location = new System.Drawing.Point(144, 167);
            this.txtStreet2.Name = "txtStreet2";
            this.txtStreet2.Size = new System.Drawing.Size(161, 20);
            this.txtStreet2.TabIndex = 26;
            // 
            // lblStreet2
            // 
            this.lblStreet2.AutoSize = true;
            this.lblStreet2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStreet2.Location = new System.Drawing.Point(16, 170);
            this.lblStreet2.Name = "lblStreet2";
            this.lblStreet2.Size = new System.Drawing.Size(122, 17);
            this.lblStreet2.TabIndex = 27;
            this.lblStreet2.Text = "Street Address 2: ";
            // 
            // txtStreet1
            // 
            this.txtStreet1.Location = new System.Drawing.Point(144, 129);
            this.txtStreet1.Name = "txtStreet1";
            this.txtStreet1.Size = new System.Drawing.Size(161, 20);
            this.txtStreet1.TabIndex = 24;
            this.txtStreet1.Leave += new System.EventHandler(this.StreetAddress1_Leave);
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStreet.Location = new System.Drawing.Point(16, 132);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(122, 17);
            this.lblStreet.TabIndex = 25;
            this.lblStreet.Text = "Street Address 1: ";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(144, 91);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 19;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblLastName.Location = new System.Drawing.Point(54, 94);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 17);
            this.lblLastName.TabIndex = 22;
            this.lblLastName.Text = "Last Name: ";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(144, 53);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 18;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFirstName.Location = new System.Drawing.Point(54, 56);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(84, 17);
            this.lblFirstName.TabIndex = 21;
            this.lblFirstName.Text = "First Name: ";
            // 
            // gbBillingAddress
            // 
            this.gbBillingAddress.Controls.Add(this.lblZipError);
            this.gbBillingAddress.Controls.Add(this.lblStateError);
            this.gbBillingAddress.Controls.Add(this.lblStreet1Error);
            this.gbBillingAddress.Controls.Add(this.lblLastNameError);
            this.gbBillingAddress.Controls.Add(this.lblFirstError);
            this.gbBillingAddress.Controls.Add(this.txtStreet1);
            this.gbBillingAddress.Controls.Add(this.txtZip);
            this.gbBillingAddress.Controls.Add(this.lblFirstName);
            this.gbBillingAddress.Controls.Add(this.lblZip);
            this.gbBillingAddress.Controls.Add(this.txtFirstName);
            this.gbBillingAddress.Controls.Add(this.txtState);
            this.gbBillingAddress.Controls.Add(this.lblLastName);
            this.gbBillingAddress.Controls.Add(this.lblState);
            this.gbBillingAddress.Controls.Add(this.txtLastName);
            this.gbBillingAddress.Controls.Add(this.txtStreet2);
            this.gbBillingAddress.Controls.Add(this.lblStreet2);
            this.gbBillingAddress.Controls.Add(this.lblStreet);
            this.gbBillingAddress.Location = new System.Drawing.Point(258, 306);
            this.gbBillingAddress.Name = "gbBillingAddress";
            this.gbBillingAddress.Size = new System.Drawing.Size(325, 316);
            this.gbBillingAddress.TabIndex = 32;
            this.gbBillingAddress.TabStop = false;
            this.gbBillingAddress.Text = "Billing Address";
            // 
            // lblZipError
            // 
            this.lblZipError.AutoSize = true;
            this.lblZipError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZipError.ForeColor = System.Drawing.Color.Red;
            this.lblZipError.Location = new System.Drawing.Point(219, 246);
            this.lblZipError.Name = "lblZipError";
            this.lblZipError.Size = new System.Drawing.Size(13, 17);
            this.lblZipError.TabIndex = 38;
            this.lblZipError.Text = "*";
            // 
            // lblStateError
            // 
            this.lblStateError.AutoSize = true;
            this.lblStateError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStateError.ForeColor = System.Drawing.Color.Red;
            this.lblStateError.Location = new System.Drawing.Point(183, 208);
            this.lblStateError.Name = "lblStateError";
            this.lblStateError.Size = new System.Drawing.Size(13, 17);
            this.lblStateError.TabIndex = 37;
            this.lblStateError.Text = "*";
            // 
            // lblStreet1Error
            // 
            this.lblStreet1Error.AutoSize = true;
            this.lblStreet1Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStreet1Error.ForeColor = System.Drawing.Color.Red;
            this.lblStreet1Error.Location = new System.Drawing.Point(306, 132);
            this.lblStreet1Error.Name = "lblStreet1Error";
            this.lblStreet1Error.Size = new System.Drawing.Size(13, 17);
            this.lblStreet1Error.TabIndex = 37;
            this.lblStreet1Error.Text = "*";
            // 
            // lblLastNameError
            // 
            this.lblLastNameError.AutoSize = true;
            this.lblLastNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastNameError.ForeColor = System.Drawing.Color.Red;
            this.lblLastNameError.Location = new System.Drawing.Point(250, 92);
            this.lblLastNameError.Name = "lblLastNameError";
            this.lblLastNameError.Size = new System.Drawing.Size(13, 17);
            this.lblLastNameError.TabIndex = 37;
            this.lblLastNameError.Text = "*";
            // 
            // lblFirstError
            // 
            this.lblFirstError.AutoSize = true;
            this.lblFirstError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstError.ForeColor = System.Drawing.Color.Red;
            this.lblFirstError.Location = new System.Drawing.Point(250, 56);
            this.lblFirstError.Name = "lblFirstError";
            this.lblFirstError.Size = new System.Drawing.Size(13, 17);
            this.lblFirstError.TabIndex = 37;
            this.lblFirstError.Text = "*";
            // 
            // gbPayment
            // 
            this.gbPayment.Controls.Add(this.lblCVVError);
            this.gbPayment.Controls.Add(this.lblExpError);
            this.gbPayment.Controls.Add(this.lblCardNumberError);
            this.gbPayment.Controls.Add(this.lblCardNameError);
            this.gbPayment.Controls.Add(this.lblCVV);
            this.gbPayment.Controls.Add(this.txtCVV);
            this.gbPayment.Controls.Add(this.lblExpDate);
            this.gbPayment.Controls.Add(this.txtExpDate);
            this.gbPayment.Controls.Add(this.lblCardNumber);
            this.gbPayment.Controls.Add(this.txtCardNumber);
            this.gbPayment.Controls.Add(this.lblNameOnCard);
            this.gbPayment.Controls.Add(this.txtNameOnCard);
            this.gbPayment.Location = new System.Drawing.Point(258, 69);
            this.gbPayment.Name = "gbPayment";
            this.gbPayment.Size = new System.Drawing.Size(325, 170);
            this.gbPayment.TabIndex = 33;
            this.gbPayment.TabStop = false;
            this.gbPayment.Text = "Payment Information";
            // 
            // lblCVVError
            // 
            this.lblCVVError.AutoSize = true;
            this.lblCVVError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCVVError.ForeColor = System.Drawing.Color.Red;
            this.lblCVVError.Location = new System.Drawing.Point(188, 135);
            this.lblCVVError.Name = "lblCVVError";
            this.lblCVVError.Size = new System.Drawing.Size(13, 17);
            this.lblCVVError.TabIndex = 39;
            this.lblCVVError.Text = "*";
            // 
            // lblExpError
            // 
            this.lblExpError.AutoSize = true;
            this.lblExpError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpError.ForeColor = System.Drawing.Color.Red;
            this.lblExpError.Location = new System.Drawing.Point(206, 97);
            this.lblExpError.Name = "lblExpError";
            this.lblExpError.Size = new System.Drawing.Size(13, 17);
            this.lblExpError.TabIndex = 38;
            this.lblExpError.Text = "*";
            // 
            // lblCardNumberError
            // 
            this.lblCardNumberError.AutoSize = true;
            this.lblCardNumberError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblCardNumberError.Location = new System.Drawing.Point(292, 60);
            this.lblCardNumberError.Name = "lblCardNumberError";
            this.lblCardNumberError.Size = new System.Drawing.Size(13, 17);
            this.lblCardNumberError.TabIndex = 37;
            this.lblCardNumberError.Text = "*";
            // 
            // lblCardNameError
            // 
            this.lblCardNameError.AutoSize = true;
            this.lblCardNameError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardNameError.ForeColor = System.Drawing.Color.Red;
            this.lblCardNameError.Location = new System.Drawing.Point(292, 25);
            this.lblCardNameError.Name = "lblCardNameError";
            this.lblCardNameError.Size = new System.Drawing.Size(13, 17);
            this.lblCardNameError.TabIndex = 36;
            this.lblCardNameError.Text = "*";
            // 
            // lblCVV
            // 
            this.lblCVV.AutoSize = true;
            this.lblCVV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCVV.Location = new System.Drawing.Point(95, 135);
            this.lblCVV.Name = "lblCVV";
            this.lblCVV.Size = new System.Drawing.Size(43, 17);
            this.lblCVV.TabIndex = 29;
            this.lblCVV.Text = "CVV: ";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(144, 132);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(38, 20);
            this.txtCVV.TabIndex = 28;
            this.txtCVV.Leave += new System.EventHandler(this.CVV_Leave);
            // 
            // lblExpDate
            // 
            this.lblExpDate.AutoSize = true;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblExpDate.Location = new System.Drawing.Point(61, 97);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(77, 17);
            this.lblExpDate.TabIndex = 27;
            this.lblExpDate.Text = "Exp. Date: ";
            // 
            // txtExpDate
            // 
            this.txtExpDate.Location = new System.Drawing.Point(144, 94);
            this.txtExpDate.Name = "txtExpDate";
            this.txtExpDate.Size = new System.Drawing.Size(56, 20);
            this.txtExpDate.TabIndex = 26;
            this.txtExpDate.Leave += new System.EventHandler(this.Exp_Leave);
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCardNumber.Location = new System.Drawing.Point(38, 60);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.Size = new System.Drawing.Size(100, 17);
            this.lblCardNumber.TabIndex = 25;
            this.lblCardNumber.Text = "Card Number: ";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Location = new System.Drawing.Point(144, 57);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(146, 20);
            this.txtCardNumber.TabIndex = 24;
            this.txtCardNumber.Leave += new System.EventHandler(this.CardNumber_Leave);
            // 
            // lblNameOnCard
            // 
            this.lblNameOnCard.AutoSize = true;
            this.lblNameOnCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblNameOnCard.Location = new System.Drawing.Point(31, 25);
            this.lblNameOnCard.Name = "lblNameOnCard";
            this.lblNameOnCard.Size = new System.Drawing.Size(107, 17);
            this.lblNameOnCard.TabIndex = 23;
            this.lblNameOnCard.Text = "Name on Card: ";
            // 
            // txtNameOnCard
            // 
            this.txtNameOnCard.Location = new System.Drawing.Point(144, 22);
            this.txtNameOnCard.Name = "txtNameOnCard";
            this.txtNameOnCard.Size = new System.Drawing.Size(146, 20);
            this.txtNameOnCard.TabIndex = 22;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 265);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 17);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Same as Home Address";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.AutoSize = true;
            this.lblErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMessage.Location = new System.Drawing.Point(353, 682);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(134, 17);
            this.lblErrorMessage.TabIndex = 35;
            this.lblErrorMessage.Text = "* is a required value";
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 743);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.gbPayment);
            this.Controls.Add(this.gbBillingAddress);
            this.Controls.Add(this.btnPreviousToPersonal);
            this.Controls.Add(this.btnContinueToList);
            this.MaximizeBox = false;
            this.Name = "Billing";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            this.gbBillingAddress.ResumeLayout(false);
            this.gbBillingAddress.PerformLayout();
            this.gbPayment.ResumeLayout(false);
            this.gbPayment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnContinueToList;
        private System.Windows.Forms.Button btnPreviousToPersonal;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtStreet2;
        private System.Windows.Forms.Label lblStreet2;
        private System.Windows.Forms.TextBox txtStreet1;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox gbBillingAddress;
        private System.Windows.Forms.GroupBox gbPayment;
        private System.Windows.Forms.Label lblNameOnCard;
        private System.Windows.Forms.TextBox txtNameOnCard;
        private System.Windows.Forms.Label lblExpDate;
        private System.Windows.Forms.TextBox txtExpDate;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblCVV;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblErrorMessage;
        private System.Windows.Forms.Label lblZipError;
        private System.Windows.Forms.Label lblStateError;
        private System.Windows.Forms.Label lblStreet1Error;
        private System.Windows.Forms.Label lblLastNameError;
        private System.Windows.Forms.Label lblFirstError;
        private System.Windows.Forms.Label lblCVVError;
        private System.Windows.Forms.Label lblExpError;
        private System.Windows.Forms.Label lblCardNumberError;
        private System.Windows.Forms.Label lblCardNameError;
    }
}