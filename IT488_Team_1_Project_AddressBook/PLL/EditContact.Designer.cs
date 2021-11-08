
namespace IT488_Team_1_Project_AddressBook.PLL
{
    partial class EditContact
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
            this.Name = new System.Windows.Forms.Label();
            this.Phone = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.Nickname = new System.Windows.Forms.Label();
            this.Other = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.OtherBox = new System.Windows.Forms.TextBox();
            this.NicknameBox = new System.Windows.Forms.TextBox();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(45, 61);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(78, 32);
            this.Name.TabIndex = 0;
            this.Name.Text = "Name";
            this.Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Location = new System.Drawing.Point(45, 123);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(82, 32);
            this.Phone.TabIndex = 1;
            this.Phone.Text = "Phone";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(45, 195);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(98, 32);
            this.Address.TabIndex = 2;
            this.Address.Text = "Address";
            // 
            // Nickname
            // 
            this.Nickname.AutoSize = true;
            this.Nickname.Location = new System.Drawing.Point(45, 265);
            this.Nickname.Name = "Nickname";
            this.Nickname.Size = new System.Drawing.Size(121, 32);
            this.Nickname.TabIndex = 3;
            this.Nickname.Text = "Nickname";
            this.Nickname.Click += new System.EventHandler(this.label4_Click);
            // 
            // Other
            // 
            this.Other.AutoSize = true;
            this.Other.Location = new System.Drawing.Point(45, 327);
            this.Other.Name = "Other";
            this.Other.Size = new System.Drawing.Size(75, 32);
            this.Other.TabIndex = 4;
            this.Other.Text = "Other";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(191, 54);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(200, 39);
            this.NameBox.TabIndex = 5;
            // 
            // OtherBox
            // 
            this.OtherBox.Location = new System.Drawing.Point(191, 327);
            this.OtherBox.Name = "OtherBox";
            this.OtherBox.Size = new System.Drawing.Size(200, 39);
            this.OtherBox.TabIndex = 6;
            // 
            // NicknameBox
            // 
            this.NicknameBox.Location = new System.Drawing.Point(191, 258);
            this.NicknameBox.Name = "NicknameBox";
            this.NicknameBox.Size = new System.Drawing.Size(200, 39);
            this.NicknameBox.TabIndex = 7;
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(191, 188);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(200, 39);
            this.AddressBox.TabIndex = 8;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Location = new System.Drawing.Point(191, 116);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(200, 39);
            this.PhoneBox.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(191, 448);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(200, 46);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // EditContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 706);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.NicknameBox);
            this.Controls.Add(this.OtherBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Other);
            this.Controls.Add(this.Nickname);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.Name);
            this.Name = "EditContact";
            this.Text = "EditContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Nickname;
        private System.Windows.Forms.Label Other;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox OtherBox;
        private System.Windows.Forms.TextBox NicknameBox;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.Button SaveButton;
    }
}