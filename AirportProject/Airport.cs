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
    public partial class Airport : Form
    {
        private static AirportDBEntities entities = new AirportDBEntities();
        private bool userLoggedIn;
        private Users user;
        Authorization authForm = new Authorization();
        double resultCost;

        public Airport()
        {
            InitializeComponent();
        }

        private void Airport_Load(object sender, EventArgs e)
        {
            authForm.Owner = this;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void buyTickectsButton_Click(object sender, EventArgs e)
        {
            if (thereAndBackCheck.Checked == false)
            {
                if (resultCost != 0 && userLoggedIn == true)
                {
                    var dialogResult = MessageBox.Show("Вы действительно хотите купить выбранные билеты?", "Сообщение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        TicketPurchaseProcess();
                }
                else if (userLoggedIn == false)
                    MessageBox.Show("Вы не авторизовались!");
                else
                    MessageBox.Show("Вы не выбрали билет!");
            }
            else
            {
                if (resultCost != 0 && directionFrom.Visible == true && directionWhere.Visible == true && userLoggedIn == true)
                {
                    var dialogResult = MessageBox.Show("Вы действительно хотите купить выбранные билеты?", "Сообщение", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                        TicketPurchaseProcess();
                }
                else if (userLoggedIn == false)
                    MessageBox.Show("Вы не авторизоваись!");
                else if (resultCost == 0)
                    MessageBox.Show("Вы не выбрали билеты!");
                else if (directionFrom.Visible == false)
                    MessageBox.Show($"Вы не выбрали билеты в {cityWhereTB.Text}!");
                else
                    MessageBox.Show($"Вы не выбрали билеты в {cityFromTB.Text}!");
            }
        }

        private void AddPurchaseHistory(string IdFlightInfo)
        {
            PurchaseHistory purchaseHistoryFrom = new PurchaseHistory
            {
                IdFlightInfo = IdFlightInfo,
                IdUser = user.Id,
                TIcketsCount = (int)numericUpDown1.Value,
            };
            entities.PurchaseHistory.Add(purchaseHistoryFrom);
        }

        private void TicketPurchaseProcess()
        {
            FlightInfo flightInfoFrom = null;
            FlightInfo flightInfoWhere = null;
            var selectedFlightFrom = dataGridView1.SelectedCells;
            var selectedFlightWhere = dataGridView2.SelectedCells;
            var idFrom = selectedFlightFrom[0].Value.ToString();
            flightInfoFrom = entities.FlightInfo.Where(s => s.Id == idFrom).FirstOrDefault();
            var idWhere = "";
            if (selectedFlightWhere.Count != 0)
            {
                idWhere = selectedFlightWhere[0].Value.ToString();
                flightInfoWhere = entities.FlightInfo.Where(s => s.Id == idWhere).FirstOrDefault();
            }
            if (flightInfoFrom != null)
            {
                var ticktesCountFrom = flightInfoFrom.NumberOfSeats.Split('/');
                var remainingSeatsFrom = int.Parse(ticktesCountFrom[0]) - (int)numericUpDown1.Value;
                flightInfoFrom.NumberOfSeats = remainingSeatsFrom.ToString() + "/" + ticktesCountFrom[1];
                AddPurchaseHistory(idFrom);
                if (flightInfoWhere != null)
                {
                    var ticktesCountWhere = flightInfoWhere.NumberOfSeats.Split('/');
                    var remainingSeatsWhere = int.Parse(ticktesCountWhere[0]) - (int)numericUpDown2.Value;
                    flightInfoWhere.NumberOfSeats = remainingSeatsWhere.ToString() + "/" + ticktesCountWhere[1];
                    AddPurchaseHistory(idWhere);
                }
                entities.SaveChanges();
                MakePanelVisibleOrNot(false, panelWhere);
                MakePanelVisibleOrNot(false, panelFrom);
                dataGridView1.DataSource = null;
                dataGridView2.DataSource = null;
                resultCost = 0;
                totalCost.Text = "Итоговая стоимость:";
                MessageBox.Show("Поздравляем с покупкой! Притяного полёта!");
            }
            else
                MessageBox.Show("Упс!Что-то пошло не так");
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (userLoggedIn == false)
            {
                authForm.ShowDialog();
                if (authForm.UserLoggedIn == true)
                {
                    enterButton.Text = "Выйти";
                    userLoggedIn = true;
                    this.user = authForm.UserInfo;
                    profileButton.Text = user.Name + " " + user.Surname_;
                    profileButton.Visible = true;
                    profileButton.Enabled = true;
                }
            }
            else
            {
                var dialogRes = MessageBox.Show("Вы действительно хотите выйти из аккаунта?", "Сообщение", MessageBoxButtons.YesNo);
                if (dialogRes == DialogResult.Yes)
                {
                    enterButton.Text = "Войти";
                    profileButton.Visible = false;
                    profileButton.Enabled = false;
                    userLoggedIn = false;
                    user = null;
                }
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            Profile profileForm = new Profile();
            profileForm.Owner = this;
            profileForm.UserInfo = user;
            profileForm.ShowDialog();
            user = profileForm.UserInfo;
            profileButton.Text = user.Name + " " + user.Surname_;
        }

        private Tuple<IQueryable<FlightInformation>, IQueryable<FlightInformation>> SearchProcess(object sender)
        {
            if (dateTimePicker1.Value != DateTime.Today)
            {
                var dtp1 = dateTimePicker1;
                dateTimePicker1.Value = new DateTime(dtp1.Value.Year, dtp1.Value.Month, dtp1.Value.Day, 0, 0, 0);
            }
            if (dateTimePicker2.Enabled == true)
            {
                var dtp2 = dateTimePicker2;
                if (dtp2.Value != DateTime.Today)
                    dateTimePicker2.Value = new DateTime(dtp2.Value.Year, dtp2.Value.Month, dtp2.Value.Day, 0, 0, 0);
            }
            IQueryable<FlightInformation> flightInfo = null;
            if ((sender as Button).Name == "searchButton")
            {
                flightInfo = from ИнформацияОПолёте in entities.FlightInfo
                             join Откуда in entities.City on ИнформацияОПолёте.CityIdFrom equals Откуда.Id
                             join Куда in entities.City on ИнформацияОПолёте.CityIdWhere equals Куда.Id
                             join Название_компании in entities.Airline on ИнформацияОПолёте.IdAirline equals Название_компании.Id
                             select new FlightInformation
                             {
                                 Id = ИнформацияОПолёте.Id,
                                 Название_компании = Название_компании.Name,
                                 Откуда = Откуда.City1,
                                 Куда = Куда.City1,
                                 Дата_и_время_вылета = ИнформацияОПолёте.DateFrom,
                                 Дата_и_время_прилёта = ИнформацияОПолёте.DateWhere,
                                 Количество_Мест = ИнформацияОПолёте.NumberOfSeats,
                                 Цена = ИнформацияОПолёте.Price * (100 - ИнформацияОПолёте.Discount) / 100,
                             };
            }
            else if ((sender as Button).Name == "favorableOffersBtn")
            {
                flightInfo = from ИнформацияОПолёте in entities.FlightInfo
                             where ИнформацияОПолёте.Discount != 0
                             join Откуда in entities.City on ИнформацияОПолёте.CityIdFrom equals Откуда.Id
                             join Куда in entities.City on ИнформацияОПолёте.CityIdWhere equals Куда.Id
                             join Название_компании in entities.Airline on ИнформацияОПолёте.IdAirline equals Название_компании.Id
                             select new FlightInformation
                             {
                                 Id = ИнформацияОПолёте.Id,
                                 Название_компании = Название_компании.Name,
                                 Откуда = Откуда.City1,
                                 Куда = Куда.City1,
                                 Дата_и_время_вылета = ИнформацияОПолёте.DateFrom,
                                 Дата_и_время_прилёта = ИнформацияОПолёте.DateWhere,
                                 Количество_Мест = ИнформацияОПолёте.NumberOfSeats,
                                 Цена = ИнформацияОПолёте.Price * (100 - ИнформацияОПолёте.Discount) / 100,
                             };
            }
            else
            {
                MessageBox.Show("Ошибка!");
                return new Tuple<IQueryable<FlightInformation>, IQueryable<FlightInformation>>(null, null);
            }
            var dtpFrom = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month + 1, dateTimePicker1.Value.Day);
            var flightFrom = flightInfo.Where(s => s.Откуда.Contains(cityFromTB.Text)
                                               && s.Куда.Contains(cityWhereTB.Text)
                                               && s.Дата_и_время_вылета >= dateTimePicker1.Value && s.Дата_и_время_вылета <= dtpFrom
                                               && !s.Количество_Мест.StartsWith("0"));
            var dtpWhere = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month + 1, dateTimePicker2.Value.Day);
            var flightWhere = flightInfo.Where(s => s.Откуда.Contains(cityWhereTB.Text)
                                        && s.Куда.Contains(cityFromTB.Text)
                                        && s.Дата_и_время_вылета >= dateTimePicker2.Value && s.Дата_и_время_вылета <= dtpWhere
                                        && !s.Количество_Мест.StartsWith("0"));
            return new Tuple<IQueryable<FlightInformation>, IQueryable<FlightInformation>>(flightFrom, flightWhere);
        }

        private void CheckCityTextBoxes()
        {
            totalCost.Text = "Итоговая стоимость: ";
            resultCost = 0;
            priceFromLabel.Text = "Стоимость билета:";
            priceWhereLabel.Text = "Стоимость билета:";
            MakePanelVisibleOrNot(false, panelWhere);
            MakePanelVisibleOrNot(false, panelFrom);
            numericUpDown1.Value = 1;
            if (cityFromTB.Text == "" || cityWhereTB.Text == "")
            {
                MessageBox.Show("Введите город вылета и город прилёта!");
                return;
            }
            if (cityFromTB.Text == cityWhereTB.Text)
            {
                MessageBox.Show("Нужно ввести разные города!");
                return;
            }
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CheckCityTextBoxes();
            var flightFrom = SearchProcess(sender).Item1;
            if (!thereAndBackCheck.Checked)
            {
                if (flightFrom.Count() != 0)
                {
                    dataGridView1.DataSource = flightFrom.OrderBy(s => s.Дата_и_время_вылета).ToArray();
                    dataGridView1.Rows[0].Selected = false;
                }
                else
                    MessageBox.Show($"Рейсы из города {cityFromTB.Text} в {cityWhereTB.Text} не найдены!");
            }
            else
            {
                if (cityWhereTB.Text != "")
                {
                    if (flightFrom.Count() != 0)
                    {
                        var flightWhere = SearchProcess(sender).Item2;

                        if (flightWhere.Count() != 0)
                        {
                            dataGridView1.DataSource = flightFrom.OrderBy(s => s.Дата_и_время_вылета).ToArray();
                            dataGridView1.Rows[0].Selected = false;
                            dataGridView2.DataSource = flightWhere.OrderBy(s => s.Дата_и_время_вылета).ToArray();
                            dataGridView2.Rows[0].Selected = false;
                        }
                        else
                            MessageBox.Show($"Рейсы обратно не были найдены!");
                    }
                    else
                        MessageBox.Show($"Рейсы в город {cityWhereTB.Text} из {cityFromTB.Text} не найдены!");
                }
                else
                    MessageBox.Show("Вы не указали город, в который хотите улететь!");
            }
        }

        private void favorableOffers_Click(object sender, EventArgs e)
        {
            CheckCityTextBoxes();
            var flightFrom = SearchProcess(sender).Item1;
            if (!thereAndBackCheck.Checked)
            {
                if (flightFrom.Count() != 0)
                {
                    dataGridView1.DataSource = flightFrom.OrderBy(s => s.Дата_и_время_вылета).ToArray();
                    dataGridView1.Rows[0].Selected = false;
                }
                else
                    MessageBox.Show($"Рейсы из города {cityFromTB.Text} в {cityWhereTB.Text} не найдены!");
            }
            else
            {
                if (cityWhereTB.Text != "")
                {
                    if (flightFrom.Count() != 0)
                    {
                        var flightWhere = SearchProcess(sender).Item2;

                        if (flightWhere.Count() != 0)
                        {
                            dataGridView1.DataSource = flightFrom.OrderBy(s => s.Дата_и_время_вылета).ToArray();
                            dataGridView1.Rows[0].Selected = false;
                            dataGridView2.DataSource = flightWhere.OrderBy(s => s.Дата_и_время_вылета).ToArray();
                            dataGridView2.Rows[0].Selected = false;
                        }
                        else
                            MessageBox.Show($"Рейсы обратно не были найдены!");
                    }
                    else
                        MessageBox.Show($"Рейсы в город {cityWhereTB.Text} из {cityFromTB.Text} не найдены!");
                }
                else
                    MessageBox.Show("Вы не указали город, в который хотите улететь!");
            }
        }

        private void MakePanelVisibleOrNot(bool visibility, Panel panel)
        {
            foreach (var label in panel.Controls.OfType<Label>())
                label.Visible = visibility;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedFlightInfo = dataGridView1.SelectedCells;
            if (selectedFlightInfo.Count != 0)
            {
                MakePanelVisibleOrNot(true, panelFrom);

                directionFrom.Text = "Направление: " + selectedFlightInfo[2].Value + " -> " + selectedFlightInfo[3].Value;
                airlineFromLabel.Text = "Название компании: " + selectedFlightInfo[1].Value;
                departureDateAndTimeFrom.Text = "Дата и время вылета: " + selectedFlightInfo[4].Value;
                arrivalDateAndTimeFrom.Text = "Дата и время прилёта: " + selectedFlightInfo[5].Value;
                priceFromLabel.Text = "Стоимость билета: " + selectedFlightInfo[7].Value;
                var ticktesCount = selectedFlightInfo[6].Value.ToString().Split('/');
                var maxTickets = int.Parse(ticktesCount[0]);
                numericUpDown1.Maximum = maxTickets;
                GetTotalCost();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedFlightInfo = dataGridView2.SelectedCells;
            if (selectedFlightInfo.Count != 0)
            {
                MakePanelVisibleOrNot(true, panelWhere);
                directionWhere.Text = "Направление: " + selectedFlightInfo[2].Value + " -> " + selectedFlightInfo[3].Value;
                airlaneWhereLabel.Text = "Название компании: " + selectedFlightInfo[1].Value;
                departureDateAndTimeWhere.Text = "Дата и время вылета: " + selectedFlightInfo[4].Value;
                arrivalDateAndTimeWhere.Text = "Дата и время прилёта: " + selectedFlightInfo[5].Value;
                priceWhereLabel.Text = "Стоимость билета: " + selectedFlightInfo[7].Value;
                var ticktesCount = selectedFlightInfo[6].Value.ToString().Split('/');
                var maxTickets = int.Parse(ticktesCount[0]);
                numericUpDown2.Maximum = maxTickets;
                GetTotalCost();
            }
        }

        private void GetTotalCost()
        {
            resultCost = 0;
            char[] separtors = " \r\n\"'".ToCharArray();
            var strArrayWhere = priceWhereLabel.Text.Split(separtors);
            var strArrayFrom = priceFromLabel.Text.Split(separtors);
            var priceWhere = strArrayWhere.Where(x => double.TryParse(x, out double result)).ToArray();
            var priceFrom = strArrayFrom.Where(x => double.TryParse(x, out double result)).ToArray();
            if (priceWhere.Length != 0)
                resultCost = resultCost + double.Parse(priceWhere[0]) * (int)numericUpDown2.Value;
            if (priceFrom.Length != 0)
                resultCost = resultCost + double.Parse(priceFrom[0]) * (int)numericUpDown1.Value;
            totalCost.Text = "Итоговая стоимость: " + resultCost;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            MakePanelVisibleOrNot(false, panelFrom);
            priceFromLabel.Text = "Стоимость билета: ";
            GetTotalCost();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            MakePanelVisibleOrNot(false, panelWhere);
            priceWhereLabel.Text = "Стоимость билета: ";
            GetTotalCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e) => GetTotalCost();

        private void numericUpDown2_ValueChanged(object sender, EventArgs e) => GetTotalCost();

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dtp = sender as DateTimePicker;
            if (!dtp.ShowCheckBox || dtp.Checked)
                dtp.CustomFormat = "dd.MM.yyyy";
            else
                dtp.CustomFormat = "''";
            dateTimePicker2.MinDate = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day + 1);
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            var dtp = sender as DateTimePicker;
            if (!dtp.ShowCheckBox || dtp.Checked)
                dtp.CustomFormat = "dd.MM.yyyy";
            else
                dtp.CustomFormat = "''";
        }

        private void thereAndBackCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (thereAndBackCheck.Checked == false)
            {
                dateTimePicker2.Enabled = false;
                numericUpDown2.Enabled = false;
                numericUpDown2.Value = 1;
                dataGridView2.DataSource = null;
                MakePanelVisibleOrNot(false, panelFrom);
                MakePanelVisibleOrNot(false, panelWhere);
                priceFromLabel.Text = "Стоимость билета: ";
                GetTotalCost();
            }
            else
            {
                dateTimePicker2.Enabled = true;
                numericUpDown2.Enabled = true;
            }
        }
    }

    public class FlightInformation
    {
        public FlightInformation()
        {
        }
        public string Id { get; set; }
        public string Название_компании { get; set; }
        public string Откуда { get; set; }
        public string Куда { get; set; }
        public DateTime Дата_и_время_вылета { get; set; }
        public DateTime Дата_и_время_прилёта { get; set; }
        public string Количество_Мест { get; set; }
        public Decimal? Цена { get; set; }
    }
}
