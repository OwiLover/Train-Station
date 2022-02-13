namespace Kursach
{
    partial class Passenger
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.buttonOrderHistory = new System.Windows.Forms.Button();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DestCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Depart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModTrain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModVag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TicketPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SeatsLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecretColumnIdTrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecretColumnIdVagon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SecretColumnIdSched = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxDate = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.comboBoxVagon = new System.Windows.Forms.ComboBox();
            this.labelFilter = new System.Windows.Forms.Label();
            this.labelSortDestCity = new System.Windows.Forms.Label();
            this.labelSortDate = new System.Windows.Forms.Label();
            this.labelSortTrainModel = new System.Windows.Forms.Label();
            this.labelSortVagon = new System.Windows.Forms.Label();
            this.listViewItems = new System.Windows.Forms.ListView();
            this.nameProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.stockProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.listView3 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bascet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secretColumnId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonBuy = new System.Windows.Forms.Button();
            this.IdTrip = new System.Windows.Forms.Label();
            this.IdVagons = new System.Windows.Forms.Label();
            this.labelIdTrip = new System.Windows.Forms.Label();
            this.labelIdVagons = new System.Windows.Forms.Label();
            this.labelIdPAss = new System.Windows.Forms.Label();
            this.IdPassenger = new System.Windows.Forms.Label();
            this.listViewOrderHistory = new System.Windows.Forms.ListView();
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelTrain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameVagon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secretId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.secretOrder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdSchedule = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewItemHistory = new System.Windows.Forms.ListView();
            this.ItemName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSched = new System.Windows.Forms.Label();
            this.IdSched = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.labelSelectOrd = new System.Windows.Forms.Label();
            this.IdOrderss = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(1087, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(193, 285);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(113, 23);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Make an Order";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(12, 9);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(14, 13);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "A";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonOrderHistory
            // 
            this.buttonOrderHistory.Location = new System.Drawing.Point(671, 285);
            this.buttonOrderHistory.Name = "buttonOrderHistory";
            this.buttonOrderHistory.Size = new System.Drawing.Size(99, 23);
            this.buttonOrderHistory.TabIndex = 3;
            this.buttonOrderHistory.Text = "Order History";
            this.buttonOrderHistory.UseVisualStyleBackColor = true;
            this.buttonOrderHistory.Click += new System.EventHandler(this.buttonOrderHistory_Click);
            // 
            // labelSchedule
            // 
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Location = new System.Drawing.Point(12, 121);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(66, 13);
            this.labelSchedule.TabIndex = 4;
            this.labelSchedule.Text = "Avalible trips";
            this.labelSchedule.Visible = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DestCity,
            this.Depart,
            this.Dur,
            this.ModTrain,
            this.ModVag,
            this.TicketPrice,
            this.SeatsLeft,
            this.SecretColumnIdTrip,
            this.SecretColumnIdVagon,
            this.SecretColumnIdSched});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(85, 121);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowGroups = false;
            this.listView1.Size = new System.Drawing.Size(745, 158);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // DestCity
            // 
            this.DestCity.Text = "Destination City";
            this.DestCity.Width = 111;
            // 
            // Depart
            // 
            this.Depart.Text = "Departure";
            this.Depart.Width = 125;
            // 
            // Dur
            // 
            this.Dur.Text = "Duration";
            this.Dur.Width = 64;
            // 
            // ModTrain
            // 
            this.ModTrain.Text = "Train Model";
            this.ModTrain.Width = 112;
            // 
            // ModVag
            // 
            this.ModVag.Text = "Vagon Model";
            this.ModVag.Width = 109;
            // 
            // TicketPrice
            // 
            this.TicketPrice.Text = "Ticket Price";
            this.TicketPrice.Width = 104;
            // 
            // SeatsLeft
            // 
            this.SeatsLeft.Text = "Seats Left";
            this.SeatsLeft.Width = 119;
            // 
            // SecretColumnIdTrip
            // 
            this.SecretColumnIdTrip.Text = "SecretColumnIdTrip";
            this.SecretColumnIdTrip.Width = 0;
            // 
            // SecretColumnIdVagon
            // 
            this.SecretColumnIdVagon.Text = "SecretColumnIdVagon";
            this.SecretColumnIdVagon.Width = 0;
            // 
            // SecretColumnIdSched
            // 
            this.SecretColumnIdSched.Text = "ScheduleId";
            this.SecretColumnIdSched.Width = 0;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            " "});
            this.comboBoxCity.Location = new System.Drawing.Point(835, 121);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 7;
            this.comboBoxCity.Visible = false;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // comboBoxDate
            // 
            this.comboBoxDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDate.FormattingEnabled = true;
            this.comboBoxDate.Items.AddRange(new object[] {
            " "});
            this.comboBoxDate.Location = new System.Drawing.Point(835, 148);
            this.comboBoxDate.Name = "comboBoxDate";
            this.comboBoxDate.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDate.TabIndex = 8;
            this.comboBoxDate.Visible = false;
            this.comboBoxDate.SelectedIndexChanged += new System.EventHandler(this.comboBoxDate_SelectedIndexChanged);
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Items.AddRange(new object[] {
            " "});
            this.comboBoxModel.Location = new System.Drawing.Point(836, 175);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModel.TabIndex = 10;
            this.comboBoxModel.Visible = false;
            this.comboBoxModel.SelectedIndexChanged += new System.EventHandler(this.comboBoxModel_SelectedIndexChanged);
            // 
            // comboBoxVagon
            // 
            this.comboBoxVagon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVagon.FormattingEnabled = true;
            this.comboBoxVagon.Items.AddRange(new object[] {
            " "});
            this.comboBoxVagon.Location = new System.Drawing.Point(836, 202);
            this.comboBoxVagon.Name = "comboBoxVagon";
            this.comboBoxVagon.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVagon.TabIndex = 11;
            this.comboBoxVagon.Visible = false;
            this.comboBoxVagon.SelectedIndexChanged += new System.EventHandler(this.comboBoxVagon_SelectedIndexChanged);
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(835, 102);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(34, 13);
            this.labelFilter.TabIndex = 13;
            this.labelFilter.Text = "Filters";
            this.labelFilter.Visible = false;
            // 
            // labelSortDestCity
            // 
            this.labelSortDestCity.AutoSize = true;
            this.labelSortDestCity.Location = new System.Drawing.Point(963, 124);
            this.labelSortDestCity.Name = "labelSortDestCity";
            this.labelSortDestCity.Size = new System.Drawing.Size(24, 13);
            this.labelSortDestCity.TabIndex = 15;
            this.labelSortDestCity.Text = "City";
            this.labelSortDestCity.Visible = false;
            // 
            // labelSortDate
            // 
            this.labelSortDate.AutoSize = true;
            this.labelSortDate.Location = new System.Drawing.Point(962, 151);
            this.labelSortDate.Name = "labelSortDate";
            this.labelSortDate.Size = new System.Drawing.Size(30, 13);
            this.labelSortDate.TabIndex = 16;
            this.labelSortDate.Text = "Date";
            this.labelSortDate.Visible = false;
            this.labelSortDate.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelSortTrainModel
            // 
            this.labelSortTrainModel.AutoSize = true;
            this.labelSortTrainModel.Location = new System.Drawing.Point(962, 178);
            this.labelSortTrainModel.Name = "labelSortTrainModel";
            this.labelSortTrainModel.Size = new System.Drawing.Size(36, 13);
            this.labelSortTrainModel.TabIndex = 17;
            this.labelSortTrainModel.Text = "Model";
            this.labelSortTrainModel.Visible = false;
            // 
            // labelSortVagon
            // 
            this.labelSortVagon.AutoSize = true;
            this.labelSortVagon.Location = new System.Drawing.Point(962, 205);
            this.labelSortVagon.Name = "labelSortVagon";
            this.labelSortVagon.Size = new System.Drawing.Size(38, 13);
            this.labelSortVagon.TabIndex = 18;
            this.labelSortVagon.Text = "Vagon";
            this.labelSortVagon.Visible = false;
            // 
            // listViewItems
            // 
            this.listViewItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameProd,
            this.priceProd,
            this.stockProd,
            this.columnHeader4});
            this.listViewItems.FullRowSelect = true;
            this.listViewItems.HideSelection = false;
            this.listViewItems.Location = new System.Drawing.Point(282, 148);
            this.listViewItems.Name = "listViewItems";
            this.listViewItems.Size = new System.Drawing.Size(405, 116);
            this.listViewItems.TabIndex = 20;
            this.listViewItems.UseCompatibleStateImageBehavior = false;
            this.listViewItems.View = System.Windows.Forms.View.Details;
            this.listViewItems.Visible = false;
            this.listViewItems.ItemActivate += new System.EventHandler(this.listViewItems_ItemActivate);
            // 
            // nameProd
            // 
            this.nameProd.Text = "Product Name";
            this.nameProd.Width = 146;
            // 
            // priceProd
            // 
            this.priceProd.Text = "Price";
            this.priceProd.Width = 123;
            // 
            // stockProd
            // 
            this.stockProd.Text = "In Stock";
            this.stockProd.Width = 132;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SecretColumnId";
            this.columnHeader4.Width = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(705, 406);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(34, 13);
            this.labelTotal.TabIndex = 21;
            this.labelTotal.Text = "Total:";
            this.labelTotal.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(745, 406);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(25, 13);
            this.labelPrice.TabIndex = 22;
            this.labelPrice.Text = "aaa";
            this.labelPrice.Visible = false;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.Bascet,
            this.columnHeader3,
            this.secretColumnId});
            this.listView3.FullRowSelect = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(282, 314);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(405, 131);
            this.listView3.TabIndex = 24;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            this.listView3.Visible = false;
            this.listView3.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView3_DrawItem);
            this.listView3.ItemActivate += new System.EventHandler(this.listView3_ItemActivate);
            this.listView3.VisibleChanged += new System.EventHandler(this.listView3_VisibleChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Price";
            this.columnHeader2.Width = 81;
            // 
            // Bascet
            // 
            this.Bascet.Text = "In the basket";
            this.Bascet.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Total Price";
            this.columnHeader3.Width = 107;
            // 
            // secretColumnId
            // 
            this.secretColumnId.Text = "SecretColumnId";
            this.secretColumnId.Width = 0;
            // 
            // buttonBuy
            // 
            this.buttonBuy.Location = new System.Drawing.Point(708, 422);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(75, 23);
            this.buttonBuy.TabIndex = 25;
            this.buttonBuy.Text = "Buy";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Visible = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // IdTrip
            // 
            this.IdTrip.AutoSize = true;
            this.IdTrip.Location = new System.Drawing.Point(980, 314);
            this.IdTrip.Name = "IdTrip";
            this.IdTrip.Size = new System.Drawing.Size(25, 13);
            this.IdTrip.TabIndex = 26;
            this.IdTrip.Text = "Trip";
            this.IdTrip.Visible = false;
            // 
            // IdVagons
            // 
            this.IdVagons.AutoSize = true;
            this.IdVagons.Location = new System.Drawing.Point(980, 342);
            this.IdVagons.Name = "IdVagons";
            this.IdVagons.Size = new System.Drawing.Size(43, 13);
            this.IdVagons.TabIndex = 27;
            this.IdVagons.Text = "Vagons";
            this.IdVagons.Visible = false;
            // 
            // labelIdTrip
            // 
            this.labelIdTrip.AutoSize = true;
            this.labelIdTrip.Location = new System.Drawing.Point(937, 314);
            this.labelIdTrip.Name = "labelIdTrip";
            this.labelIdTrip.Size = new System.Drawing.Size(37, 13);
            this.labelIdTrip.TabIndex = 28;
            this.labelIdTrip.Text = "IdTrip:";
            this.labelIdTrip.Visible = false;
            // 
            // labelIdVagons
            // 
            this.labelIdVagons.AutoSize = true;
            this.labelIdVagons.Location = new System.Drawing.Point(921, 342);
            this.labelIdVagons.Name = "labelIdVagons";
            this.labelIdVagons.Size = new System.Drawing.Size(55, 13);
            this.labelIdVagons.TabIndex = 29;
            this.labelIdVagons.Text = "IdVagons:";
            this.labelIdVagons.Visible = false;
            // 
            // labelIdPAss
            // 
            this.labelIdPAss.AutoSize = true;
            this.labelIdPAss.Location = new System.Drawing.Point(907, 369);
            this.labelIdPAss.Name = "labelIdPAss";
            this.labelIdPAss.Size = new System.Drawing.Size(69, 13);
            this.labelIdPAss.TabIndex = 30;
            this.labelIdPAss.Text = "IdPassenger:";
            this.labelIdPAss.Visible = false;
            // 
            // IdPassenger
            // 
            this.IdPassenger.AutoSize = true;
            this.IdPassenger.Location = new System.Drawing.Point(980, 369);
            this.IdPassenger.Name = "IdPassenger";
            this.IdPassenger.Size = new System.Drawing.Size(57, 13);
            this.IdPassenger.TabIndex = 31;
            this.IdPassenger.Text = "Passenger";
            this.IdPassenger.Visible = false;
            // 
            // listViewOrderHistory
            // 
            this.listViewOrderHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.date,
            this.line,
            this.cityName,
            this.modelTrain,
            this.nameVagon,
            this.secretId,
            this.secretOrder,
            this.IdSchedule});
            this.listViewOrderHistory.FullRowSelect = true;
            this.listViewOrderHistory.HideSelection = false;
            this.listViewOrderHistory.Location = new System.Drawing.Point(193, 121);
            this.listViewOrderHistory.Name = "listViewOrderHistory";
            this.listViewOrderHistory.Size = new System.Drawing.Size(577, 158);
            this.listViewOrderHistory.TabIndex = 32;
            this.listViewOrderHistory.UseCompatibleStateImageBehavior = false;
            this.listViewOrderHistory.View = System.Windows.Forms.View.Details;
            this.listViewOrderHistory.Visible = false;
            this.listViewOrderHistory.ItemActivate += new System.EventHandler(this.listViewOrderHistory_ItemActivate);
            // 
            // date
            // 
            this.date.Text = "Date and Time";
            this.date.Width = 170;
            // 
            // line
            // 
            this.line.Text = "Line";
            this.line.Width = 36;
            // 
            // cityName
            // 
            this.cityName.Text = "City Name";
            this.cityName.Width = 76;
            // 
            // modelTrain
            // 
            this.modelTrain.Text = "Train Model";
            this.modelTrain.Width = 100;
            // 
            // nameVagon
            // 
            this.nameVagon.Text = "Vagon Name";
            this.nameVagon.Width = 125;
            // 
            // secretId
            // 
            this.secretId.Text = "SecretIdTrip";
            this.secretId.Width = 0;
            // 
            // secretOrder
            // 
            this.secretOrder.Text = "SecretIdOrder";
            this.secretOrder.Width = 0;
            // 
            // IdSchedule
            // 
            this.IdSchedule.Text = "SecretIdSched";
            this.IdSchedule.Width = 0;
            // 
            // listViewItemHistory
            // 
            this.listViewItemHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ItemName,
            this.Number,
            this.priceTotal});
            this.listViewItemHistory.HideSelection = false;
            this.listViewItemHistory.Location = new System.Drawing.Point(835, 118);
            this.listViewItemHistory.Name = "listViewItemHistory";
            this.listViewItemHistory.Size = new System.Drawing.Size(216, 295);
            this.listViewItemHistory.TabIndex = 33;
            this.listViewItemHistory.UseCompatibleStateImageBehavior = false;
            this.listViewItemHistory.View = System.Windows.Forms.View.Details;
            this.listViewItemHistory.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.Text = "Name";
            this.ItemName.Width = 75;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 61;
            // 
            // priceTotal
            // 
            this.priceTotal.Text = "Total Price";
            this.priceTotal.Width = 76;
            // 
            // labelSched
            // 
            this.labelSched.AutoSize = true;
            this.labelSched.Location = new System.Drawing.Point(937, 422);
            this.labelSched.Name = "labelSched";
            this.labelSched.Size = new System.Drawing.Size(50, 13);
            this.labelSched.TabIndex = 34;
            this.labelSched.Text = "IdSched:";
            this.labelSched.Visible = false;
            // 
            // IdSched
            // 
            this.IdSched.AutoSize = true;
            this.IdSched.Location = new System.Drawing.Point(980, 422);
            this.IdSched.Name = "IdSched";
            this.IdSched.Size = new System.Drawing.Size(47, 13);
            this.IdSched.TabIndex = 35;
            this.IdSched.Text = "IdSched";
            this.IdSched.Visible = false;
            this.IdSched.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Enabled = false;
            this.buttonReturn.Location = new System.Drawing.Point(427, 285);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(106, 23);
            this.buttonReturn.TabIndex = 36;
            this.buttonReturn.Text = "Revoke Order";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Visible = false;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // labelSelectOrd
            // 
            this.labelSelectOrd.AutoSize = true;
            this.labelSelectOrd.Location = new System.Drawing.Point(539, 290);
            this.labelSelectOrd.Name = "labelSelectOrd";
            this.labelSelectOrd.Size = new System.Drawing.Size(81, 13);
            this.labelSelectOrd.TabIndex = 37;
            this.labelSelectOrd.Text = "Selected Order:";
            this.labelSelectOrd.Visible = false;
            // 
            // IdOrderss
            // 
            this.IdOrderss.AutoSize = true;
            this.IdOrderss.Location = new System.Drawing.Point(616, 290);
            this.IdOrderss.Name = "IdOrderss";
            this.IdOrderss.Size = new System.Drawing.Size(33, 13);
            this.IdOrderss.TabIndex = 38;
            this.IdOrderss.Text = "None";
            this.IdOrderss.Visible = false;
            this.IdOrderss.Click += new System.EventHandler(this.IdOrderss_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(193, 422);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 39;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Visible = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // Passenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 584);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.IdOrderss);
            this.Controls.Add(this.labelSelectOrd);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.IdSched);
            this.Controls.Add(this.labelSched);
            this.Controls.Add(this.listViewItemHistory);
            this.Controls.Add(this.listViewOrderHistory);
            this.Controls.Add(this.IdPassenger);
            this.Controls.Add(this.labelIdPAss);
            this.Controls.Add(this.labelIdVagons);
            this.Controls.Add(this.labelIdTrip);
            this.Controls.Add(this.IdVagons);
            this.Controls.Add(this.IdTrip);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.listViewItems);
            this.Controls.Add(this.labelSortVagon);
            this.Controls.Add(this.labelSortTrainModel);
            this.Controls.Add(this.labelSortDate);
            this.Controls.Add(this.labelSortDestCity);
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.comboBoxVagon);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.comboBoxDate);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.buttonOrderHistory);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.linkLabel1);
            this.Name = "Passenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passenger";
            this.Load += new System.EventHandler(this.Passenger_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Button buttonOrderHistory;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DestCity;
        private System.Windows.Forms.ColumnHeader Depart;
        private System.Windows.Forms.ColumnHeader Dur;
        private System.Windows.Forms.ColumnHeader ModTrain;
        private System.Windows.Forms.ColumnHeader ModVag;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxDate;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.ComboBox comboBoxVagon;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label labelSortDestCity;
        private System.Windows.Forms.Label labelSortDate;
        private System.Windows.Forms.Label labelSortTrainModel;
        private System.Windows.Forms.Label labelSortVagon;
        private System.Windows.Forms.ColumnHeader TicketPrice;
        private System.Windows.Forms.ColumnHeader SeatsLeft;
        private System.Windows.Forms.ListView listViewItems;
        private System.Windows.Forms.ColumnHeader nameProd;
        private System.Windows.Forms.ColumnHeader priceProd;
        private System.Windows.Forms.ColumnHeader stockProd;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader Bascet;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.ColumnHeader SecretColumnIdTrip;
        private System.Windows.Forms.ColumnHeader SecretColumnIdVagon;
        private System.Windows.Forms.Label IdTrip;
        private System.Windows.Forms.Label IdVagons;
        private System.Windows.Forms.Label labelIdTrip;
        private System.Windows.Forms.Label labelIdVagons;
        private System.Windows.Forms.Label labelIdPAss;
        private System.Windows.Forms.Label IdPassenger;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader secretColumnId;
        private System.Windows.Forms.ListView listViewOrderHistory;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader cityName;
        private System.Windows.Forms.ColumnHeader modelTrain;
        private System.Windows.Forms.ColumnHeader nameVagon;
        private System.Windows.Forms.ColumnHeader line;
        private System.Windows.Forms.ListView listViewItemHistory;
        private System.Windows.Forms.ColumnHeader ItemName;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader priceTotal;
        private System.Windows.Forms.ColumnHeader secretId;
        private System.Windows.Forms.ColumnHeader secretOrder;
        private System.Windows.Forms.Label labelSched;
        private System.Windows.Forms.Label IdSched;
        private System.Windows.Forms.ColumnHeader SecretColumnIdSched;
        private System.Windows.Forms.ColumnHeader IdSchedule;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Label labelSelectOrd;
        private System.Windows.Forms.Label IdOrderss;
        private System.Windows.Forms.Button buttonBack;
    }
}