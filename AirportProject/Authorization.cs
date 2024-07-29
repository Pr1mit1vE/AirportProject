using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirportProject
{
    public partial class Authorization : Form
    {
        public static AirportDBEntities entities = new AirportDBEntities();
        private bool userLoggedIn;
        public bool UserLoggedIn { get => userLoggedIn; }
        private Users user;
        public Users UserInfo { get => user; }
        Registration regForm = new Registration();

        public Authorization()
        {
            InitializeComponent();
        }

        private void Authorization_Load(object sender, EventArgs e)
        {
            entities = new AirportDBEntities();
            user = null;
            userLoggedIn = false;
            phoneNumberTextBox.Text = "";
            passwordTextBox.Text = "";
            passwordTextBox.UseSystemPasswordChar = true;
            showPasCheckBox.Checked = false;
            regForm.Owner = this;
            incorrectValues.Visible = false;
        }

        private void dontReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            regForm.ShowDialog();
            userLoggedIn = regForm.SuccessfulReg;
            user = regForm.UserInfo;
        }

        private void showPasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasCheckBox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            var phoneNumber = phoneNumberTextBox.Text;
            var password = passwordTextBox.Text;
            if (phoneNumber == "+7 (   )    -" || password == "")
            {
                if (phoneNumber == "+7 (   )    -" && password == "")
                    MessageBox.Show("Для входа нужно ввести номер телфона и пароль!");
                else if (phoneNumber == "+7 (   )    -")
                    MessageBox.Show("Для входа нужно ввести номер телефона!");
                else if (phoneNumberTextBox.MaskCompleted == false)
                    MessageBox.Show("Вы ввели неполный номер телефона!");
                else
                    MessageBox.Show("Для входа нужно ввести пароль!");
            }
            else if (entities.Users.Any(s => s.PhoneNumber == phoneNumber && s.Password == password))
            {
                userLoggedIn = true;
                user = entities.Users.Where(s => s.PhoneNumber == phoneNumber && s.Password == password).FirstOrDefault();
                MessageBox.Show("Атворизация прошла успешно!");
                this.Close();
            }
            else
            {
                incorrectValues.Visible = true;
                userLoggedIn = false;
            }
        }
    }
}
