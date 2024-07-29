
namespace AirportProject
{
    partial class Profile
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
            this.editButton = new System.Windows.Forms.Button();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.Patronymic = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumber = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.purchaseHistoryBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.editButton);
            this.panel1.Controls.Add(this.patronymicTextBox);
            this.panel1.Controls.Add(this.Patronymic);
            this.panel1.Controls.Add(this.phoneNumberTextBox);
            this.panel1.Controls.Add(this.surnameTextBox);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.PhoneNumber);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.Surname);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Location = new System.Drawing.Point(12, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 340);
            this.panel1.TabIndex = 32;
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.editButton.BackColor = System.Drawing.Color.White;
            this.editButton.FlatAppearance.BorderSize = 0;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editButton.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.editButton.Location = new System.Drawing.Point(401, 272);
            this.editButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(122, 31);
            this.editButton.TabIndex = 31;
            this.editButton.Text = "Редактировать";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patronymicTextBox.Enabled = false;
            this.patronymicTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.patronymicTextBox.Location = new System.Drawing.Point(134, 189);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(389, 27);
            this.patronymicTextBox.TabIndex = 29;
            // 
            // Patronymic
            // 
            this.Patronymic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Patronymic.AutoSize = true;
            this.Patronymic.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Patronymic.Location = new System.Drawing.Point(38, 191);
            this.Patronymic.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Size = new System.Drawing.Size(81, 21);
            this.Patronymic.TabIndex = 28;
            this.Patronymic.Text = "Отчество";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneNumberTextBox.Enabled = false;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.phoneNumberTextBox.Location = new System.Drawing.Point(134, 232);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.phoneNumberTextBox.Mask = "+7 (000) 000-0000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(389, 27);
            this.phoneNumberTextBox.TabIndex = 27;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surnameTextBox.Enabled = false;
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.surnameTextBox.Location = new System.Drawing.Point(134, 146);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(389, 27);
            this.surnameTextBox.TabIndex = 26;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.nameTextBox.Location = new System.Drawing.Point(134, 104);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(389, 27);
            this.nameTextBox.TabIndex = 25;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emailTextBox.Enabled = false;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.emailTextBox.Location = new System.Drawing.Point(134, 58);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(389, 27);
            this.emailTextBox.TabIndex = 23;
            this.emailTextBox.TextChanged += new System.EventHandler(this.emailTextBox_TextChanged);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.PhoneNumber.Location = new System.Drawing.Point(44, 234);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(75, 21);
            this.PhoneNumber.TabIndex = 22;
            this.PhoneNumber.Text = "Телефон";
            // 
            // FirstName
            // 
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.FirstName.Location = new System.Drawing.Point(76, 106);
            this.FirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(43, 21);
            this.FirstName.TabIndex = 21;
            this.FirstName.Text = "Имя";
            // 
            // Surname
            // 
            this.Surname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Surname.Location = new System.Drawing.Point(39, 148);
            this.Surname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(80, 21);
            this.Surname.TabIndex = 20;
            this.Surname.Text = "Фамилия";
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Email.Location = new System.Drawing.Point(63, 60);
            this.Email.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(56, 21);
            this.Email.TabIndex = 18;
            this.Email.Text = "Почта";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(582, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(908, 340);
            this.panel2.TabIndex = 34;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.purchaseHistoryBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(908, 38);
            this.panel3.TabIndex = 1;
            // 
            // purchaseHistoryBtn
            // 
            this.purchaseHistoryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseHistoryBtn.BackColor = System.Drawing.Color.White;
            this.purchaseHistoryBtn.FlatAppearance.BorderSize = 0;
            this.purchaseHistoryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseHistoryBtn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseHistoryBtn.Location = new System.Drawing.Point(4, 4);
            this.purchaseHistoryBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.purchaseHistoryBtn.Name = "purchaseHistoryBtn";
            this.purchaseHistoryBtn.Size = new System.Drawing.Size(131, 30);
            this.purchaseHistoryBtn.TabIndex = 32;
            this.purchaseHistoryBtn.Text = "История покупок";
            this.purchaseHistoryBtn.UseVisualStyleBackColor = false;
            this.purchaseHistoryBtn.Click += new System.EventHandler(this.purchaseHistoryBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(908, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 438);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.Label Patronymic;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label PhoneNumber;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Button purchaseHistoryBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}