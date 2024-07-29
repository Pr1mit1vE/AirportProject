
namespace AirportProject
{
    partial class Airport
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Airport));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.enterButton = new System.Windows.Forms.ToolStripButton();
            this.profileButton = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.favorableOffersBtn = new System.Windows.Forms.Button();
            this.thereAndBackCheck = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cityFromTB = new System.Windows.Forms.TextBox();
            this.From = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.cityWhereTB = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.Label();
            this.dateComeback = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ticketsCount = new System.Windows.Forms.Label();
            this.totalCost = new System.Windows.Forms.Label();
            this.informWhere = new System.Windows.Forms.Label();
            this.infoFrom = new System.Windows.Forms.Label();
            this.panelWhere = new System.Windows.Forms.Panel();
            this.arrivalDateAndTimeWhere = new System.Windows.Forms.Label();
            this.directionWhere = new System.Windows.Forms.Label();
            this.priceWhereLabel = new System.Windows.Forms.Label();
            this.departureDateAndTimeWhere = new System.Windows.Forms.Label();
            this.airlaneWhereLabel = new System.Windows.Forms.Label();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.arrivalDateAndTimeFrom = new System.Windows.Forms.Label();
            this.directionFrom = new System.Windows.Forms.Label();
            this.priceFromLabel = new System.Windows.Forms.Label();
            this.airlineFromLabel = new System.Windows.Forms.Label();
            this.departureDateAndTimeFrom = new System.Windows.Forms.Label();
            this.buyTickectsButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panelWhere.SuspendLayout();
            this.panelFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterButton,
            this.profileButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1310, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // enterButton
            // 
            this.enterButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.enterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.enterButton.Image = ((System.Drawing.Image)(resources.GetObject("enterButton.Image")));
            this.enterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(44, 22);
            this.enterButton.Text = "Войти";
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.profileButton.Enabled = false;
            this.profileButton.Image = ((System.Drawing.Image)(resources.GetObject("profileButton.Image")));
            this.profileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(63, 22);
            this.profileButton.Text = "Профиль";
            this.profileButton.Visible = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.favorableOffersBtn);
            this.panel2.Controls.Add(this.thereAndBackCheck);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.cityFromTB);
            this.panel2.Controls.Add(this.From);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchButton);
            this.panel2.Controls.Add(this.cityWhereTB);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.dateFrom);
            this.panel2.Controls.Add(this.dateComeback);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 25);
            this.panel2.TabIndex = 14;
            // 
            // favorableOffersBtn
            // 
            this.favorableOffersBtn.BackColor = System.Drawing.Color.White;
            this.favorableOffersBtn.Location = new System.Drawing.Point(948, 1);
            this.favorableOffersBtn.Name = "favorableOffersBtn";
            this.favorableOffersBtn.Size = new System.Drawing.Size(148, 23);
            this.favorableOffersBtn.TabIndex = 14;
            this.favorableOffersBtn.Text = "Выгодные предложения";
            this.favorableOffersBtn.UseVisualStyleBackColor = false;
            this.favorableOffersBtn.Click += new System.EventHandler(this.favorableOffers_Click);
            // 
            // thereAndBackCheck
            // 
            this.thereAndBackCheck.AutoSize = true;
            this.thereAndBackCheck.Location = new System.Drawing.Point(721, 5);
            this.thereAndBackCheck.Name = "thereAndBackCheck";
            this.thereAndBackCheck.Size = new System.Drawing.Size(103, 17);
            this.thereAndBackCheck.TabIndex = 13;
            this.thereAndBackCheck.Text = "Туда и обратно";
            this.thereAndBackCheck.UseVisualStyleBackColor = true;
            this.thereAndBackCheck.CheckedChanged += new System.EventHandler(this.thereAndBackCheck_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Checked = false;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dateTimePicker1.CustomFormat = "\'\'";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(367, 3);
            this.dateTimePicker1.MaxDate = new System.DateTime(2109, 11, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2022, 6, 11, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowCheckBox = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(145, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 11, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cityFromTB
            // 
            this.cityFromTB.Location = new System.Drawing.Point(57, 3);
            this.cityFromTB.Name = "cityFromTB";
            this.cityFromTB.Size = new System.Drawing.Size(100, 20);
            this.cityFromTB.TabIndex = 12;
            // 
            // From
            // 
            this.From.AutoSize = true;
            this.From.Location = new System.Drawing.Point(8, 6);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(43, 13);
            this.From.TabIndex = 1;
            this.From.Text = "Откуда";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Куда";
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(830, 1);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(112, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // cityWhereTB
            // 
            this.cityWhereTB.Location = new System.Drawing.Point(200, 3);
            this.cityWhereTB.Name = "cityWhereTB";
            this.cityWhereTB.Size = new System.Drawing.Size(100, 20);
            this.cityWhereTB.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Checked = false;
            this.dateTimePicker2.CustomFormat = "\'\'";
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(574, 3);
            this.dateTimePicker2.MaxDate = new System.DateTime(2023, 6, 9, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2022, 6, 11, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowCheckBox = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker2.TabIndex = 5;
            this.dateTimePicker2.Value = new System.DateTime(2022, 6, 11, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateFrom
            // 
            this.dateFrom.AutoSize = true;
            this.dateFrom.Location = new System.Drawing.Point(324, 6);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(37, 13);
            this.dateFrom.TabIndex = 6;
            this.dateFrom.Text = "Когда";
            // 
            // dateComeback
            // 
            this.dateComeback.AutoSize = true;
            this.dateComeback.Location = new System.Drawing.Point(518, 6);
            this.dateComeback.Name = "dateComeback";
            this.dateComeback.Size = new System.Drawing.Size(50, 13);
            this.dateComeback.TabIndex = 7;
            this.dateComeback.Text = "Обратно";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(950, 315);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 374);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(950, 331);
            this.dataGridView2.TabIndex = 20;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Enabled = false;
            this.numericUpDown2.Location = new System.Drawing.Point(1189, 636);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.ReadOnly = true;
            this.numericUpDown2.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown2.TabIndex = 33;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(959, 636);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 18);
            this.label2.TabIndex = 32;
            this.label2.Text = "Количество билетов обратно: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(1161, 604);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 31;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ticketsCount
            // 
            this.ticketsCount.AutoSize = true;
            this.ticketsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ticketsCount.Location = new System.Drawing.Point(961, 606);
            this.ticketsCount.Name = "ticketsCount";
            this.ticketsCount.Size = new System.Drawing.Size(197, 18);
            this.ticketsCount.TabIndex = 30;
            this.ticketsCount.Text = "Количество билетов туда: ";
            // 
            // totalCost
            // 
            this.totalCost.AutoSize = true;
            this.totalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalCost.Location = new System.Drawing.Point(959, 675);
            this.totalCost.Name = "totalCost";
            this.totalCost.Size = new System.Drawing.Size(161, 18);
            this.totalCost.TabIndex = 24;
            this.totalCost.Text = "Итоговая стоимость: ";
            // 
            // informWhere
            // 
            this.informWhere.AutoSize = true;
            this.informWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.informWhere.Location = new System.Drawing.Point(956, 332);
            this.informWhere.Name = "informWhere";
            this.informWhere.Size = new System.Drawing.Size(330, 20);
            this.informWhere.TabIndex = 29;
            this.informWhere.Text = "Информация о выбранном рейсе обратно:";
            // 
            // infoFrom
            // 
            this.infoFrom.AutoSize = true;
            this.infoFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoFrom.Location = new System.Drawing.Point(956, 53);
            this.infoFrom.Name = "infoFrom";
            this.infoFrom.Size = new System.Drawing.Size(303, 20);
            this.infoFrom.TabIndex = 28;
            this.infoFrom.Text = "Информация о выбранном рейсе туда:";
            // 
            // panelWhere
            // 
            this.panelWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelWhere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelWhere.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelWhere.Controls.Add(this.arrivalDateAndTimeWhere);
            this.panelWhere.Controls.Add(this.directionWhere);
            this.panelWhere.Controls.Add(this.priceWhereLabel);
            this.panelWhere.Controls.Add(this.departureDateAndTimeWhere);
            this.panelWhere.Controls.Add(this.airlaneWhereLabel);
            this.panelWhere.Location = new System.Drawing.Point(960, 355);
            this.panelWhere.Name = "panelWhere";
            this.panelWhere.Size = new System.Drawing.Size(338, 240);
            this.panelWhere.TabIndex = 27;
            // 
            // arrivalDateAndTimeWhere
            // 
            this.arrivalDateAndTimeWhere.AutoSize = true;
            this.arrivalDateAndTimeWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivalDateAndTimeWhere.Location = new System.Drawing.Point(14, 128);
            this.arrivalDateAndTimeWhere.Name = "arrivalDateAndTimeWhere";
            this.arrivalDateAndTimeWhere.Size = new System.Drawing.Size(188, 20);
            this.arrivalDateAndTimeWhere.TabIndex = 5;
            this.arrivalDateAndTimeWhere.Text = "Дата и время прилёта: ";
            this.arrivalDateAndTimeWhere.Visible = false;
            // 
            // directionWhere
            // 
            this.directionWhere.AutoSize = true;
            this.directionWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionWhere.Location = new System.Drawing.Point(14, 31);
            this.directionWhere.Name = "directionWhere";
            this.directionWhere.Size = new System.Drawing.Size(120, 20);
            this.directionWhere.TabIndex = 0;
            this.directionWhere.Text = "Напралвение: ";
            this.directionWhere.Visible = false;
            // 
            // priceWhereLabel
            // 
            this.priceWhereLabel.AutoSize = true;
            this.priceWhereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceWhereLabel.Location = new System.Drawing.Point(14, 162);
            this.priceWhereLabel.Name = "priceWhereLabel";
            this.priceWhereLabel.Size = new System.Drawing.Size(160, 20);
            this.priceWhereLabel.TabIndex = 4;
            this.priceWhereLabel.Text = "Стоимость билета: ";
            this.priceWhereLabel.Visible = false;
            // 
            // departureDateAndTimeWhere
            // 
            this.departureDateAndTimeWhere.AutoSize = true;
            this.departureDateAndTimeWhere.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureDateAndTimeWhere.Location = new System.Drawing.Point(14, 93);
            this.departureDateAndTimeWhere.Name = "departureDateAndTimeWhere";
            this.departureDateAndTimeWhere.Size = new System.Drawing.Size(181, 20);
            this.departureDateAndTimeWhere.TabIndex = 2;
            this.departureDateAndTimeWhere.Text = "Дата и время вылета: ";
            this.departureDateAndTimeWhere.Visible = false;
            // 
            // airlaneWhereLabel
            // 
            this.airlaneWhereLabel.AutoSize = true;
            this.airlaneWhereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airlaneWhereLabel.Location = new System.Drawing.Point(14, 61);
            this.airlaneWhereLabel.Name = "airlaneWhereLabel";
            this.airlaneWhereLabel.Size = new System.Drawing.Size(204, 20);
            this.airlaneWhereLabel.TabIndex = 3;
            this.airlaneWhereLabel.Text = "Название авиакомпании: ";
            this.airlaneWhereLabel.Visible = false;
            // 
            // panelFrom
            // 
            this.panelFrom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelFrom.Controls.Add(this.arrivalDateAndTimeFrom);
            this.panelFrom.Controls.Add(this.directionFrom);
            this.panelFrom.Controls.Add(this.priceFromLabel);
            this.panelFrom.Controls.Add(this.airlineFromLabel);
            this.panelFrom.Controls.Add(this.departureDateAndTimeFrom);
            this.panelFrom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelFrom.Location = new System.Drawing.Point(960, 74);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(339, 240);
            this.panelFrom.TabIndex = 26;
            // 
            // arrivalDateAndTimeFrom
            // 
            this.arrivalDateAndTimeFrom.AutoSize = true;
            this.arrivalDateAndTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.arrivalDateAndTimeFrom.Location = new System.Drawing.Point(14, 121);
            this.arrivalDateAndTimeFrom.Name = "arrivalDateAndTimeFrom";
            this.arrivalDateAndTimeFrom.Size = new System.Drawing.Size(188, 20);
            this.arrivalDateAndTimeFrom.TabIndex = 10;
            this.arrivalDateAndTimeFrom.Text = "Дата и время прилёта: ";
            this.arrivalDateAndTimeFrom.Visible = false;
            // 
            // directionFrom
            // 
            this.directionFrom.AutoSize = true;
            this.directionFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.directionFrom.Location = new System.Drawing.Point(14, 21);
            this.directionFrom.Name = "directionFrom";
            this.directionFrom.Size = new System.Drawing.Size(120, 20);
            this.directionFrom.TabIndex = 6;
            this.directionFrom.Text = "Напралвение: ";
            this.directionFrom.Visible = false;
            // 
            // priceFromLabel
            // 
            this.priceFromLabel.AutoSize = true;
            this.priceFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceFromLabel.Location = new System.Drawing.Point(14, 157);
            this.priceFromLabel.Name = "priceFromLabel";
            this.priceFromLabel.Size = new System.Drawing.Size(160, 20);
            this.priceFromLabel.TabIndex = 9;
            this.priceFromLabel.Text = "Стоимость билета: ";
            this.priceFromLabel.Visible = false;
            // 
            // airlineFromLabel
            // 
            this.airlineFromLabel.AutoSize = true;
            this.airlineFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.airlineFromLabel.Location = new System.Drawing.Point(14, 51);
            this.airlineFromLabel.Name = "airlineFromLabel";
            this.airlineFromLabel.Size = new System.Drawing.Size(204, 20);
            this.airlineFromLabel.TabIndex = 8;
            this.airlineFromLabel.Text = "Название авиакомпании: ";
            this.airlineFromLabel.Visible = false;
            // 
            // departureDateAndTimeFrom
            // 
            this.departureDateAndTimeFrom.AutoSize = true;
            this.departureDateAndTimeFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.departureDateAndTimeFrom.Location = new System.Drawing.Point(14, 84);
            this.departureDateAndTimeFrom.Name = "departureDateAndTimeFrom";
            this.departureDateAndTimeFrom.Size = new System.Drawing.Size(181, 20);
            this.departureDateAndTimeFrom.TabIndex = 7;
            this.departureDateAndTimeFrom.Text = "Дата и время вылета: ";
            this.departureDateAndTimeFrom.Visible = false;
            // 
            // buyTickectsButton
            // 
            this.buyTickectsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buyTickectsButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buyTickectsButton.Location = new System.Drawing.Point(1176, 671);
            this.buyTickectsButton.Name = "buyTickectsButton";
            this.buyTickectsButton.Size = new System.Drawing.Size(123, 29);
            this.buyTickectsButton.TabIndex = 25;
            this.buyTickectsButton.Text = "Купить билеты";
            this.buyTickectsButton.UseVisualStyleBackColor = false;
            this.buyTickectsButton.Click += new System.EventHandler(this.buyTickectsButton_Click);
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 715);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.ticketsCount);
            this.Controls.Add(this.totalCost);
            this.Controls.Add(this.informWhere);
            this.Controls.Add(this.infoFrom);
            this.Controls.Add(this.panelWhere);
            this.Controls.Add(this.panelFrom);
            this.Controls.Add(this.buyTickectsButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Airport";
            this.Text = "Airport";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panelWhere.ResumeLayout(false);
            this.panelWhere.PerformLayout();
            this.panelFrom.ResumeLayout(false);
            this.panelFrom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton enterButton;
        private System.Windows.Forms.ToolStripButton profileButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button favorableOffersBtn;
        private System.Windows.Forms.CheckBox thereAndBackCheck;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox cityFromTB;
        private System.Windows.Forms.Label From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox cityWhereTB;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label dateFrom;
        private System.Windows.Forms.Label dateComeback;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label ticketsCount;
        private System.Windows.Forms.Label totalCost;
        private System.Windows.Forms.Label informWhere;
        private System.Windows.Forms.Label infoFrom;
        private System.Windows.Forms.Panel panelWhere;
        private System.Windows.Forms.Label arrivalDateAndTimeWhere;
        private System.Windows.Forms.Label directionWhere;
        private System.Windows.Forms.Label priceWhereLabel;
        private System.Windows.Forms.Label departureDateAndTimeWhere;
        private System.Windows.Forms.Label airlaneWhereLabel;
        private System.Windows.Forms.Panel panelFrom;
        private System.Windows.Forms.Label arrivalDateAndTimeFrom;
        private System.Windows.Forms.Label directionFrom;
        private System.Windows.Forms.Label priceFromLabel;
        private System.Windows.Forms.Label airlineFromLabel;
        private System.Windows.Forms.Label departureDateAndTimeFrom;
        private System.Windows.Forms.Button buyTickectsButton;
    }
}

