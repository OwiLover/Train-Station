namespace Kursach
{
    partial class Admin
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelIdAdmin = new System.Windows.Forms.Label();
            this.IdAdmin = new System.Windows.Forms.Label();
            this.listViewTrips = new System.Windows.Forms.ListView();
            this.idTrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trainId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameTrain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdDestCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cityName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameTrip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxTrain = new System.Windows.Forms.ComboBox();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxLine = new System.Windows.Forms.ComboBox();
            this.labelTripCreator = new System.Windows.Forms.Label();
            this.labelTripList = new System.Windows.Forms.Label();
            this.labelLogout = new System.Windows.Forms.LinkLabel();
            this.listViewSched = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelSched = new System.Windows.Forms.Label();
            this.labelSchedCreate = new System.Windows.Forms.Label();
            this.comboBoxTrip = new System.Windows.Forms.ComboBox();
            this.comboBoxModer = new System.Windows.Forms.ComboBox();
            this.dateTimePickerArriv = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
            this.buttonSched = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(13, 13);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(36, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Admin";
            // 
            // labelIdAdmin
            // 
            this.labelIdAdmin.AutoSize = true;
            this.labelIdAdmin.Location = new System.Drawing.Point(547, 370);
            this.labelIdAdmin.Name = "labelIdAdmin";
            this.labelIdAdmin.Size = new System.Drawing.Size(47, 13);
            this.labelIdAdmin.TabIndex = 1;
            this.labelIdAdmin.Text = "IDAdmin";
            // 
            // IdAdmin
            // 
            this.IdAdmin.AutoSize = true;
            this.IdAdmin.Location = new System.Drawing.Point(600, 370);
            this.IdAdmin.Name = "IdAdmin";
            this.IdAdmin.Size = new System.Drawing.Size(45, 13);
            this.IdAdmin.TabIndex = 2;
            this.IdAdmin.Text = "IdAdmin";
            this.IdAdmin.Click += new System.EventHandler(this.IdAdmin_Click);
            // 
            // listViewTrips
            // 
            this.listViewTrips.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idTrip,
            this.trainId,
            this.NameTrain,
            this.IdDestCity,
            this.cityName,
            this.nameTrip,
            this.Line});
            this.listViewTrips.FullRowSelect = true;
            this.listViewTrips.HideSelection = false;
            this.listViewTrips.Location = new System.Drawing.Point(40, 82);
            this.listViewTrips.Name = "listViewTrips";
            this.listViewTrips.Size = new System.Drawing.Size(527, 174);
            this.listViewTrips.TabIndex = 3;
            this.listViewTrips.UseCompatibleStateImageBehavior = false;
            this.listViewTrips.View = System.Windows.Forms.View.Details;
            this.listViewTrips.ItemActivate += new System.EventHandler(this.listViewTrips_ItemActivate);
            // 
            // idTrip
            // 
            this.idTrip.Text = "Trip Id";
            this.idTrip.Width = 58;
            // 
            // trainId
            // 
            this.trainId.Text = "IdTrain";
            this.trainId.Width = 45;
            // 
            // NameTrain
            // 
            this.NameTrain.Text = "Train Name";
            this.NameTrain.Width = 87;
            // 
            // IdDestCity
            // 
            this.IdDestCity.Text = "IdDestinationCity";
            this.IdDestCity.Width = 94;
            // 
            // cityName
            // 
            this.cityName.Text = "City Name";
            this.cityName.Width = 95;
            // 
            // nameTrip
            // 
            this.nameTrip.Text = "Trip Name";
            this.nameTrip.Width = 104;
            // 
            // Line
            // 
            this.Line.Text = "Line";
            this.Line.Width = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create Trip";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxTrain
            // 
            this.comboBoxTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrain.FormattingEnabled = true;
            this.comboBoxTrain.Location = new System.Drawing.Point(40, 275);
            this.comboBoxTrain.Name = "comboBoxTrain";
            this.comboBoxTrain.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrain.TabIndex = 5;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(167, 275);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(294, 276);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 20);
            this.textBoxName.TabIndex = 7;
            // 
            // comboBoxLine
            // 
            this.comboBoxLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLine.FormattingEnabled = true;
            this.comboBoxLine.Location = new System.Drawing.Point(421, 275);
            this.comboBoxLine.Name = "comboBoxLine";
            this.comboBoxLine.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLine.TabIndex = 8;
            // 
            // labelTripCreator
            // 
            this.labelTripCreator.AutoSize = true;
            this.labelTripCreator.Location = new System.Drawing.Point(37, 259);
            this.labelTripCreator.Name = "labelTripCreator";
            this.labelTripCreator.Size = new System.Drawing.Size(62, 13);
            this.labelTripCreator.TabIndex = 9;
            this.labelTripCreator.Text = "Trip Creator";
            // 
            // labelTripList
            // 
            this.labelTripList.AutoSize = true;
            this.labelTripList.Location = new System.Drawing.Point(37, 66);
            this.labelTripList.Name = "labelTripList";
            this.labelTripList.Size = new System.Drawing.Size(44, 13);
            this.labelTripList.TabIndex = 10;
            this.labelTripList.Text = "Trip List";
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Location = new System.Drawing.Point(1307, 9);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(45, 13);
            this.labelLogout.TabIndex = 11;
            this.labelLogout.TabStop = true;
            this.labelLogout.Text = "Log Out";
            this.labelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLogout_LinkClicked);
            // 
            // listViewSched
            // 
            this.listViewSched.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewSched.FullRowSelect = true;
            this.listViewSched.HideSelection = false;
            this.listViewSched.Location = new System.Drawing.Point(630, 82);
            this.listViewSched.Name = "listViewSched";
            this.listViewSched.Size = new System.Drawing.Size(637, 174);
            this.listViewSched.TabIndex = 12;
            this.listViewSched.UseCompatibleStateImageBehavior = false;
            this.listViewSched.View = System.Windows.Forms.View.Details;
            this.listViewSched.ItemActivate += new System.EventHandler(this.listViewSched_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Trip Id";
            this.columnHeader2.Width = 49;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trip Name";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Departure";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Arrival";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Duration";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "IdModer";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Moder Name";
            this.columnHeader8.Width = 106;
            // 
            // labelSched
            // 
            this.labelSched.AutoSize = true;
            this.labelSched.Location = new System.Drawing.Point(627, 66);
            this.labelSched.Name = "labelSched";
            this.labelSched.Size = new System.Drawing.Size(71, 13);
            this.labelSched.TabIndex = 13;
            this.labelSched.Text = "Schedule List";
            // 
            // labelSchedCreate
            // 
            this.labelSchedCreate.AutoSize = true;
            this.labelSchedCreate.Location = new System.Drawing.Point(627, 258);
            this.labelSchedCreate.Name = "labelSchedCreate";
            this.labelSchedCreate.Size = new System.Drawing.Size(89, 13);
            this.labelSchedCreate.TabIndex = 14;
            this.labelSchedCreate.Text = "Schedule Creator";
            // 
            // comboBoxTrip
            // 
            this.comboBoxTrip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrip.FormattingEnabled = true;
            this.comboBoxTrip.Location = new System.Drawing.Point(630, 274);
            this.comboBoxTrip.Name = "comboBoxTrip";
            this.comboBoxTrip.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrip.TabIndex = 15;
            // 
            // comboBoxModer
            // 
            this.comboBoxModer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxModer.FormattingEnabled = true;
            this.comboBoxModer.Location = new System.Drawing.Point(758, 274);
            this.comboBoxModer.Name = "comboBoxModer";
            this.comboBoxModer.Size = new System.Drawing.Size(121, 21);
            this.comboBoxModer.TabIndex = 16;
            // 
            // dateTimePickerArriv
            // 
            this.dateTimePickerArriv.CustomFormat = "d.MM.yyyy HH:mm";
            this.dateTimePickerArriv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerArriv.Location = new System.Drawing.Point(885, 305);
            this.dateTimePickerArriv.MinDate = new System.DateTime(2022, 2, 7, 17, 10, 49, 0);
            this.dateTimePickerArriv.Name = "dateTimePickerArriv";
            this.dateTimePickerArriv.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerArriv.TabIndex = 17;
            this.dateTimePickerArriv.Value = new System.DateTime(2022, 2, 7, 17, 11, 10, 0);
            // 
            // dateTimePickerDepart
            // 
            this.dateTimePickerDepart.CustomFormat = "d.MM.yyyy HH:mm";
            this.dateTimePickerDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDepart.Location = new System.Drawing.Point(885, 275);
            this.dateTimePickerDepart.MinDate = new System.DateTime(2022, 2, 7, 0, 0, 0, 0);
            this.dateTimePickerDepart.Name = "dateTimePickerDepart";
            this.dateTimePickerDepart.Size = new System.Drawing.Size(130, 20);
            this.dateTimePickerDepart.TabIndex = 18;
            // 
            // buttonSched
            // 
            this.buttonSched.Location = new System.Drawing.Point(1030, 302);
            this.buttonSched.Name = "buttonSched";
            this.buttonSched.Size = new System.Drawing.Size(96, 23);
            this.buttonSched.TabIndex = 19;
            this.buttonSched.Text = "Create Schedule";
            this.buttonSched.UseVisualStyleBackColor = true;
            this.buttonSched.Click += new System.EventHandler(this.buttonSched_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 450);
            this.Controls.Add(this.buttonSched);
            this.Controls.Add(this.dateTimePickerDepart);
            this.Controls.Add(this.dateTimePickerArriv);
            this.Controls.Add(this.comboBoxModer);
            this.Controls.Add(this.comboBoxTrip);
            this.Controls.Add(this.labelSchedCreate);
            this.Controls.Add(this.labelSched);
            this.Controls.Add(this.listViewSched);
            this.Controls.Add(this.labelLogout);
            this.Controls.Add(this.labelTripList);
            this.Controls.Add(this.labelTripCreator);
            this.Controls.Add(this.comboBoxLine);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.comboBoxTrain);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewTrips);
            this.Controls.Add(this.IdAdmin);
            this.Controls.Add(this.labelIdAdmin);
            this.Controls.Add(this.labelLogin);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelIdAdmin;
        private System.Windows.Forms.Label IdAdmin;
        private System.Windows.Forms.ListView listViewTrips;
        private System.Windows.Forms.ColumnHeader idTrip;
        private System.Windows.Forms.ColumnHeader trainId;
        private System.Windows.Forms.ColumnHeader NameTrain;
        private System.Windows.Forms.ColumnHeader IdDestCity;
        private System.Windows.Forms.ColumnHeader cityName;
        private System.Windows.Forms.ColumnHeader nameTrip;
        private System.Windows.Forms.ColumnHeader Line;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxTrain;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxLine;
        private System.Windows.Forms.Label labelTripCreator;
        private System.Windows.Forms.Label labelTripList;
        private System.Windows.Forms.LinkLabel labelLogout;
        private System.Windows.Forms.ListView listViewSched;
        private System.Windows.Forms.Label labelSched;
        private System.Windows.Forms.Label labelSchedCreate;
        private System.Windows.Forms.ComboBox comboBoxTrip;
        private System.Windows.Forms.ComboBox comboBoxModer;
        private System.Windows.Forms.DateTimePicker dateTimePickerArriv;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
        private System.Windows.Forms.Button buttonSched;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}