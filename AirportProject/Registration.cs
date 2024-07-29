using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace AirportProject
{
    public partial class Registration : Form
    {
        private bool successfulReg;
        public bool SuccessfulReg { get => successfulReg; }
        Users user;
        public Users UserInfo { get => user; }
        public static AirportDBEntities entities = new AirportDBEntities();

        public Registration()
        {
            InitializeComponent();
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;
            var name = nameTextBox.Text;
            var surname = surnameTextBox.Text;
            var patronymic = patronymicTextBox.Text;
            var phoneNumber = phoneNumberTextBox.Text;
            if (email == "" || password == "" || name == ""
                || surname == "" || patronymic == "" || phoneNumberTextBox.MaskCompleted == false)
            {
                MessageBox.Show("Для регистрации нужно заполнить все поля!");
            }
            else if (!IsValidEmail(email))
            {
                emailTextBox.ForeColor = Color.Red;
                falseEmailLabel.Visible = true;
            }
            else
            {
                if (entities.Users.Any(s => s.PhoneNumber == phoneNumber))
                    MessageBox.Show("Пользователь с таким  номером телефона уже зарегистрирован!");
                else
                {
                    Users user = new Users
                    {
                        email = email,
                        Password = password,
                        Name = name,
                        Surname_ = surname,
                        Patronymic = patronymic,
                        PhoneNumber = phoneNumber,
                    };
                    entities.Users.Add(user);
                    entities.SaveChanges();
                    this.user = user;
                    successfulReg = true;
                    this.Close();
                    Owner.Close();
                    MessageBox.Show("Вы зарегистрированы!");
                }
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            successfulReg = false;
            user = null;
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            patronymicTextBox.Text = "";
            phoneNumberTextBox.Text = "";
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {
            emailTextBox.ForeColor = Color.Black;
            falseEmailLabel.Visible = false;
        }

        private void showPasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasCheckBox.Checked)
                passwordTextBox.UseSystemPasswordChar = false;
            else
                passwordTextBox.UseSystemPasswordChar = true;
        }
    }
}
