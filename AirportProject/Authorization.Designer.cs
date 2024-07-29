
namespace AirportProject
{
    partial class Authorization
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
            this.incorrectValues = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.showPasCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.dontReg = new System.Windows.Forms.LinkLabel();
            this.enterButton = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.incorrectValues);
            this.panel1.Controls.Add(this.phoneNumber);
            this.panel1.Controls.Add(this.phoneNumberTextBox);
            this.panel1.Controls.Add(this.showPasCheckBox);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Controls.Add(this.dontReg);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Controls.Add(this.Password);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 293);
            this.panel1.TabIndex = 6;
            // 
            // incorrectValues
            // 
            this.incorrectValues.AutoSize = true;
            this.incorrectValues.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.incorrectValues.ForeColor = System.Drawing.Color.Red;
            this.incorrectValues.Location = new System.Drawing.Point(113, 193);
            this.incorrectValues.Name = "incorrectValues";
            this.incorrectValues.Size = new System.Drawing.Size(388, 20);
            this.incorrectValues.TabIndex = 17;
            this.incorrectValues.Text = "Вы ввели неправильный номер телефона или пароль";
            this.incorrectValues.Visible = false;
            // 
            // phoneNumber
            // 
            this.phoneNumber.AutoSize = true;
            this.phoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(23, 54);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(152, 25);
            this.phoneNumber.TabIndex = 16;
            this.phoneNumber.Text = "Номер телфона";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(183, 55);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.phoneNumberTextBox.Mask = "+7 (000) 000-0000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(351, 27);
            this.phoneNumberTextBox.TabIndex = 15;
            // 
            // showPasCheckBox
            // 
            this.showPasCheckBox.AutoSize = true;
            this.showPasCheckBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPasCheckBox.Location = new System.Drawing.Point(398, 163);
            this.showPasCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showPasCheckBox.Name = "showPasCheckBox";
            this.showPasCheckBox.Size = new System.Drawing.Size(136, 19);
            this.showPasCheckBox.TabIndex = 9;
            this.showPasCheckBox.Text = "Показывать пароль";
            this.showPasCheckBox.UseVisualStyleBackColor = true;
            this.showPasCheckBox.CheckedChanged += new System.EventHandler(this.showPasCheckBox_CheckedChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(183, 126);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(351, 27);
            this.passwordTextBox.TabIndex = 8;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // dontReg
            // 
            this.dontReg.ActiveLinkColor = System.Drawing.Color.Blue;
            this.dontReg.AutoSize = true;
            this.dontReg.LinkColor = System.Drawing.Color.Black;
            this.dontReg.Location = new System.Drawing.Point(221, 261);
            this.dontReg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dontReg.Name = "dontReg";
            this.dontReg.Size = new System.Drawing.Size(149, 13);
            this.dontReg.TabIndex = 6;
            this.dontReg.TabStop = true;
            this.dontReg.Text = "Ещё не зарегистрированы?";
            this.dontReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.dontReg_LinkClicked);
            // 
            // enterButton
            // 
            this.enterButton.BackColor = System.Drawing.Color.White;
            this.enterButton.FlatAppearance.BorderSize = 0;
            this.enterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.enterButton.Location = new System.Drawing.Point(240, 218);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(101, 38);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Войти";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.Location = new System.Drawing.Point(96, 125);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(79, 25);
            this.Password.TabIndex = 3;
            this.Password.Text = "Пароль";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 293);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label incorrectValues;
        private System.Windows.Forms.Label phoneNumber;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.CheckBox showPasCheckBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.LinkLabel dontReg;
        public System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label Password;
    }
}