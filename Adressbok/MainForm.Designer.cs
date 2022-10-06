namespace Adressbok
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grpAddInfo = new System.Windows.Forms.GroupBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCityTown = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblStreetAdress = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lstAddressBook = new System.Windows.Forms.ListBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.grpAddInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(1072, 563);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(200, 65);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Ändra";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1325, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 65);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1256, 82);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 46);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Sök";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(195, 561);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(200, 65);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpAddInfo
            // 
            this.grpAddInfo.Controls.Add(this.txtCity);
            this.grpAddInfo.Controls.Add(this.txtAddress);
            this.grpAddInfo.Controls.Add(this.lblLastName);
            this.grpAddInfo.Controls.Add(this.lblEmail);
            this.grpAddInfo.Controls.Add(this.lblPhoneNumber);
            this.grpAddInfo.Controls.Add(this.lblCityTown);
            this.grpAddInfo.Controls.Add(this.lblZipCode);
            this.grpAddInfo.Controls.Add(this.lblStreetAdress);
            this.grpAddInfo.Controls.Add(this.lblFirstName);
            this.grpAddInfo.Controls.Add(this.txtEmail);
            this.grpAddInfo.Controls.Add(this.txtPhone);
            this.grpAddInfo.Controls.Add(this.txtZipCode);
            this.grpAddInfo.Controls.Add(this.txtLastName);
            this.grpAddInfo.Controls.Add(this.txtFirstName);
            this.grpAddInfo.Controls.Add(this.btnAdd);
            this.grpAddInfo.Location = new System.Drawing.Point(31, 24);
            this.grpAddInfo.Name = "grpAddInfo";
            this.grpAddInfo.Size = new System.Drawing.Size(576, 632);
            this.grpAddInfo.TabIndex = 4;
            this.grpAddInfo.TabStop = false;
            this.grpAddInfo.Text = "Kontakt information";
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(181, 334);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(361, 39);
            this.txtCity.TabIndex = 21;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(181, 186);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(361, 39);
            this.txtAddress.TabIndex = 20;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 119);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(124, 32);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Efternamn";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 489);
            this.lblEmail.MinimumSize = new System.Drawing.Size(50, 30);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 32);
            this.lblEmail.TabIndex = 18;
            this.lblEmail.Text = "Email";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(15, 415);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(93, 32);
            this.lblPhoneNumber.TabIndex = 17;
            this.lblPhoneNumber.Text = "Telefon";
            // 
            // lblCityTown
            // 
            this.lblCityTown.AutoSize = true;
            this.lblCityTown.Location = new System.Drawing.Point(15, 341);
            this.lblCityTown.Name = "lblCityTown";
            this.lblCityTown.Size = new System.Drawing.Size(88, 32);
            this.lblCityTown.TabIndex = 16;
            this.lblCityTown.Text = "Postort";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(15, 267);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(149, 32);
            this.lblZipCode.TabIndex = 15;
            this.lblZipCode.Text = "Postnummer";
            // 
            // lblStreetAdress
            // 
            this.lblStreetAdress.AutoSize = true;
            this.lblStreetAdress.Location = new System.Drawing.Point(15, 193);
            this.lblStreetAdress.Name = "lblStreetAdress";
            this.lblStreetAdress.Size = new System.Drawing.Size(84, 32);
            this.lblStreetAdress.TabIndex = 14;
            this.lblStreetAdress.Text = "Adress";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 45);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 32);
            this.lblFirstName.TabIndex = 13;
            this.lblFirstName.Text = "Namn";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(181, 482);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(361, 39);
            this.txtEmail.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(181, 408);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(361, 39);
            this.txtPhone.TabIndex = 11;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(181, 260);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(361, 39);
            this.txtZipCode.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(181, 112);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(361, 39);
            this.txtLastName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(181, 38);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(361, 39);
            this.txtFirstName.TabIndex = 7;
            // 
            // lstAddressBook
            // 
            this.lstAddressBook.FormattingEnabled = true;
            this.lstAddressBook.ItemHeight = 32;
            this.lstAddressBook.Location = new System.Drawing.Point(677, 159);
            this.lstAddressBook.Name = "lstAddressBook";
            this.lstAddressBook.Size = new System.Drawing.Size(1080, 388);
            this.lstAddressBook.TabIndex = 5;
            this.lstAddressBook.SelectedIndexChanged += new System.EventHandler(this.lstAddressBook_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(677, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(513, 39);
            this.txtSearch.TabIndex = 6;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(680, 41);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(167, 32);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Sök adressbok";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1882, 679);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstAddressBook);
            this.Controls.Add(this.grpAddInfo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Name = "MainForm";
            this.Text = "Addressbook";
            this.grpAddInfo.ResumeLayout(false);
            this.grpAddInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnChange;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnAdd;
        private GroupBox grpAddInfo;
        private ListBox lstAddressBook;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtZipCode;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private TextBox txtSearch;
        private Label lblEmail;
        private Label lblPhoneNumber;
        private Label lblCityTown;
        private Label lblZipCode;
        private Label lblStreetAdress;
        private Label lblFirstName;
        private TextBox txtAddress;
        private Label lblLastName;
        private Label lblSearch;
        private TextBox txtCity;
    }
}