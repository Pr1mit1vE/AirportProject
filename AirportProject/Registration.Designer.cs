
namespace AirportProject
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.showPasCheckBox = new System.Windows.Forms.CheckBox();
            this.falseEmailLabel = new System.Windows.Forms.Label();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.showPasCheckBox);
            this.panel1.Controls.Add(this.falseEmailLabel);
            this.panel1.Controls.Add(this.patronymicTextBox);
            this.panel1.Controls.Add(this.Patronymic);
            this.panel1.Controls.Add(this.phoneNumberTextBox);
            this.panel1.Controls.Add(this.regButton);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.PhoneNumber);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.Surname);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 477);
            this.panel1.TabIndex = 1;
            // 
            // showPasCheckBox
            // 
            this.showPasCheckBox.AutoSize = true;
            this.showPasCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasCheckBox.Location = new System.Drawing.Point(416, 143);
            this.showPasCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showPasCheckBox.Name = "showPasCheckBox";
            this.showPasCheckBox.Size = new System.Drawing.Size(151, 21);
            this.showPasCheckBox.TabIndex = 17;
            this.showPasCheckBox.Text = "Показывать пароль";
            this.showPasCheckBox.UseVisualStyleBackColor = true;
            this.showPasCheckBox.CheckedChanged += new System.EventHandler(this.showPasCheckBox_CheckedChanged);
            this.showPasCheckBox.TextChanged += new System.EventHandler(this.showPasCheckBox_CheckedChanged);
            // 
            // falseEmailLabel
            // 
            this.falseEmailLabel.AutoSize = true;
            this.falseEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.falseEmailLabel.ForeColor = System.Drawing.Color.Red;
            this.falseEmailLabel.Location = new System.Drawing.Point(375, 84);
            this.falseEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.falseEmailLabel.Name = "falseEmailLabel";
            this.falseEmailLabel.Size = new System.Drawing.Size(192, 17);
            this.falseEmailLabel.TabIndex = 16;
            this.falseEmailLabel.Text = "Вы ввели неправильную почту";
            this.falseEmailLabel.Visible = false;
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Location = new System.Drawing.Point(216, 294);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(351, 27);
            this.patronymicTextBox.TabIndex = 15;
            // 
            // Patronymic
            // 
            this.Patronymic.AutoSize = true;
            this.Patronymic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Patronymic.Location = new System.Drawing.Point(106, 297);
            this.Patronymic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(81, 21);
            this.Patronymic.TabIndex = 14;
            this.Patronymic.Text = "Отчество";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(216, 354);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneNumberTextBox.Mask = "+7 (000) 000-0000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(351, 27);
            this.phoneNumberTextBox.TabIndex = 13;
            // 
            // regButton
            // 
            this.regButton.BackColor = System.Drawing.Color.White;
            this.regButton.FlatAppearance.BorderSize = 0;
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Location = new System.Drawing.Point(269, 417);
            this.regButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(184, 42);
            this.regButton.TabIndex = 12;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(216, 234);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(351, 27);
            this.surnameTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(216, 174);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(351, 27);
            this.nameTextBox.TabIndex = 8;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(216, 114);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(351, 27);
            this.passwordTextBox.TabIndex = 7;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(216, 52);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(351, 27);
            this.emailTextBox.TabIndex = 6;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PhoneNumber.Location = new System.Drawing.Point(110, 357);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(75, 21);
            this.PhoneNumber.TabIndex = 5;
            this.PhoneNumber.Text = "Телефон";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.FirstName.Location = new System.Drawing.Point(149, 177);
            this.FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(43, 21);
            this.FirstName.TabIndex = 4;
            this.FirstName.Text = "Имя";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Surname.Location = new System.Drawing.Point(108, 237);
            this.Surname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(80, 21);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Фамилия";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Password.Location = new System.Drawing.Point(122, 117);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(67, 21);
            this.Password.TabIndex = 2;
            this.Password.Text = "Пароль";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(132, 55);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 21);
            this.Email.TabIndex = 1;
            this.Email.Text = "Почта";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 477);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox showPasCheckBox;
        private System.Windows.Forms.Label falseEmailLabel;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label Email;
    }
}