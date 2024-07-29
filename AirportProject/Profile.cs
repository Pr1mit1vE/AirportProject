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
    public partial class Profile : Form
    {
        public Users UserInfo { get; set; }
        private static AirportDBEntities entities = new AirportDBEntities();

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            entities = new AirportDBEntities();
            UserInfo = entities.Users.Where(s => s.PhoneNumber == UserInfo.PhoneNumber).FirstOrDefault();
            emailTextBox.Text = UserInfo.email;
            nameTextBox.Text = UserInfo.Name;
            surnameTextBox.Text = UserInfo.Surname_;
            patronymicTextBox.Text = UserInfo.Patronymic;
            phoneNumberTextBox.Text = UserInfo.PhoneNumber;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (editButton.Text != "Сохранить изменения")
            {
                foreach (var textBox in panel1.Controls.OfType<TextBox>())
                    textBox.Enabled = true;
                phoneNumberTextBox.Enabled = true;
                editButton.Text = "Сохранить изменения";
                purchaseHistoryBtn.Enabled = false;
            }
            else
            {
                var email = emailTextBox.Text;
                var name = nameTextBox.Text;
                var surname = surnameTextBox.Text;
                var patronymic = patronymicTextBox.Text;
                var phoneNumber = phoneNumberTextBox.Text;


                if (email == "" || name == "" || surname == ""
                    || patronymic == "" || phoneNumberTextBox.MaskCompleted == false)
                    MessageBox.Show("Для завершения редактирования необходимо заполнить все поля!");
                else if (!IsValidEmail(emailTextBox.Text))
                    emailTextBox.ForeColor = Color.Red;
                else
                {
                    entities.Users.Attach(UserInfo);
                    UserInfo.email = email;
                    UserInfo.Name = name;
                    UserInfo.Surname_ = surname;
                    UserInfo.Patronymic = patronymic;
                    if (phoneNumber != UserInfo.PhoneNumber)
                    {
                        if (entities.Users.Any(s => s.PhoneNumber == phoneNumber))
                            MessageBox.Show("Пользователь с таким  номером телефона уже зарегистрирован!");
                        else
                        {
                            UserInfo.PhoneNumber = phoneNumber;
                            entities.SaveChanges();
                            MessageBox.Show("Данные успешно имзенены!");
                        }
                    }
                    else
                    {
                        entities.SaveChanges();
                        MessageBox.Show("Данные успешно имзенены!");
                    }

                    foreach (var textBox in panel1.Controls.OfType<TextBox>())
                        textBox.Enabled = false;
                    phoneNumberTextBox.Enabled = false;
                    editButton.Text = "Редактировать";
                    purchaseHistoryBtn.Enabled = true;
                }
            }
        }

        bool IsValidEmail(string email)
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

        private void emailTextBox_TextChanged(object sender, EventArgs e) => emailTextBox.ForeColor = Color.Black;

        private void purchaseHistoryBtn_Click(object sender, EventArgs e)
        {
            var flightInfo = from ИнформацияОПолёте in entities.FlightInfo
                             join Откуда in entities.City on ИнформацияОПолёте.CityIdFrom equals Откуда.Id
                             join Куда in entities.City on ИнформацияОПолёте.CityIdWhere equals Куда.Id
                             join Название_компании in entities.Airline on ИнформацияОПолёте.IdAirline equals Название_компании.Id
                             select new
                             {
                                 Id = ИнформацияОПолёте.Id,
                                 Название_компании = Название_компании.Name,
                                 Откуда = Откуда.City1,
                                 Куда = Куда.City1,
                                 Дата_и_время_вылета = ИнформацияОПолёте.DateFrom,
                                 Дата_и_время_прилёта = ИнформацияОПолёте.DateWhere,
                                 Цена = ИнформацияОПолёте.Price * (100 - ИнформацияОПолёте.Discount) / 100,
                             };

            var purchaseHistory = from ИсторияПокупок in entities.PurchaseHistory
                                  join ИнформацияОПолёте in flightInfo on ИсторияПокупок.IdFlightInfo equals ИнформацияОПолёте.Id
                                  where UserInfo.Id == ИсторияПокупок.IdUser
                                  select new
                                  {
                                      Id = ИнформацияОПолёте.Id,
                                      Название_компании = ИнформацияОПолёте.Название_компании,
                                      Откуда = ИнформацияОПолёте.Откуда,
                                      Куда = ИнформацияОПолёте.Куда,
                                      Дата_и_время_вылета = ИнформацияОПолёте.Дата_и_время_вылета,
                                      Дата_и_время_прилёта = ИнформацияОПолёте.Дата_и_время_прилёта,
                                      Цена = ИнформацияОПолёте.Цена,
                                      Количество_билетов = ИсторияПокупок.TIcketsCount,
                                  };

            dataGridView1.DataSource = purchaseHistory.OrderBy(s => s.Дата_и_время_вылета).ToArray();
        }
    }
}
