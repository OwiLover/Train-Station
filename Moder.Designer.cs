namespace Kursach
{
    partial class Moder
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
            this.IdModer = new System.Windows.Forms.Label();
            this.labelIdModer = new System.Windows.Forms.Label();
            this.listViewSched = new System.Windows.Forms.ListView();
            this.schedId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tripName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.destCity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schedDep = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.schedArr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.modelTrain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLogout = new System.Windows.Forms.LinkLabel();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxLine = new System.Windows.Forms.ComboBox();
            this.comboBoxTrain = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDepart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArriv = new System.Windows.Forms.DateTimePicker();
            this.listViewTrains = new System.Windows.Forms.ListView();
            this.IdTrain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.train = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewVagons = new System.Windows.Forms.ListView();
            this.comboBoxVagons = new System.Windows.Forms.ComboBox();
            this.buttonAddVagon = new System.Windows.Forms.Button();
            this.idVagon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameVagon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonChange = new System.Windows.Forms.Button();
            this.labelidSched = new System.Windows.Forms.Label();
            this.idSched = new System.Windows.Forms.Label();
            this.labelTripName = new System.Windows.Forms.Label();
            this.labelTrainId = new System.Windows.Forms.Label();
            this.TrainId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(13, 13);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            // 
            // IdModer
            // 
            this.IdModer.AutoSize = true;
            this.IdModer.Location = new System.Drawing.Point(1378, 428);
            this.IdModer.Name = "IdModer";
            this.IdModer.Size = new System.Drawing.Size(46, 13);
            this.IdModer.TabIndex = 1;
            this.IdModer.Text = "IdModer";
            // 
            // labelIdModer
            // 
            this.labelIdModer.AutoSize = true;
            this.labelIdModer.Location = new System.Drawing.Point(1323, 428);
            this.labelIdModer.Name = "labelIdModer";
            this.labelIdModer.Size = new System.Drawing.Size(49, 13);
            this.labelIdModer.TabIndex = 2;
            this.labelIdModer.Text = "IdModer:";
            // 
            // listViewSched
            // 
            this.listViewSched.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.schedId,
            this.tripName,
            this.destCity,
            this.line,
            this.schedDep,
            this.schedArr,
            this.modelTrain});
            this.listViewSched.FullRowSelect = true;
            this.listViewSched.HideSelection = false;
            this.listViewSched.Location = new System.Drawing.Point(77, 114);
            this.listViewSched.Name = "listViewSched";
            this.listViewSched.Size = new System.Drawing.Size(689, 190);
            this.listViewSched.TabIndex = 3;
            this.listViewSched.UseCompatibleStateImageBehavior = false;
            this.listViewSched.View = System.Windows.Forms.View.Details;
            this.listViewSched.ItemActivate += new System.EventHandler(this.listViewSched_ItemActivate);
            // 
            // schedId
            // 
            this.schedId.Text = "idSched";
            this.schedId.Width = 55;
            // 
            // tripName
            // 
            this.tripName.Text = "Trip Name";
            this.tripName.Width = 112;
            // 
            // destCity
            // 
            this.destCity.Text = "City";
            this.destCity.Width = 108;
            // 
            // line
            // 
            this.line.Text = "Line";
            this.line.Width = 45;
            // 
            // schedDep
            // 
            this.schedDep.Text = "Departure";
            this.schedDep.Width = 120;
            // 
            // schedArr
            // 
            this.schedArr.Text = "Arrival";
            this.schedArr.Width = 120;
            // 
            // modelTrain
            // 
            this.modelTrain.Text = "Train Name";
            this.modelTrain.Width = 119;
            // 
            // labelLogout
            // 
            this.labelLogout.AutoSize = true;
            this.labelLogout.Location = new System.Drawing.Point(1379, 9);
            this.labelLogout.Name = "labelLogout";
            this.labelLogout.Size = new System.Drawing.Size(45, 13);
            this.labelLogout.TabIndex = 12;
            this.labelLogout.TabStop = true;
            this.labelLogout.Text = "Log Out";
            this.labelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelLogout_LinkClicked);
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.Enabled = false;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(77, 322);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCity.TabIndex = 13;
            // 
            // comboBoxLine
            // 
            this.comboBoxLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLine.Enabled = false;
            this.comboBoxLine.FormattingEnabled = true;
            this.comboBoxLine.Location = new System.Drawing.Point(204, 322);
            this.comboBoxLine.Name = "comboBoxLine";
            this.comboBoxLine.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLine.TabIndex = 14;
            // 
            // comboBoxTrain
            // 
            this.comboBoxTrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrain.Enabled = false;
            this.comboBoxTrain.FormattingEnabled = true;
            this.comboBoxTrain.Location = new System.Drawing.Point(615, 322);
            this.comboBoxTrain.Name = "comboBoxTrain";
            this.comboBoxTrain.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrain.TabIndex = 15;
            // 
            // dateTimePickerDepart
            // 
            this.dateTimePickerDepart.CustomFormat = "d.MM.yyyy HH:mm";
            this.dateTimePickerDepart.Enabled = false;
            this.dateTimePickerDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDepart.Location = new System.Drawing.Point(331, 323);
            this.dateTimePickerDepart.MinDate = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            this.dateTimePickerDepart.Name = "dateTimePickerDepart";
            this.dateTimePickerDepart.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerDepart.TabIndex = 16;
            this.dateTimePickerDepart.Value = new System.DateTime(2022, 2, 8, 21, 22, 58, 0);
            // 
            // dateTimePickerArriv
            // 
            this.dateTimePickerArriv.CustomFormat = "d.MM.yyyy HH:mm";
            this.dateTimePickerArriv.Enabled = false;
            this.dateTimePickerArriv.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerArriv.Location = new System.Drawing.Point(471, 323);
            this.dateTimePickerArriv.MinDate = new System.DateTime(2022, 2, 8, 0, 0, 0, 0);
            this.dateTimePickerArriv.Name = "dateTimePickerArriv";
            this.dateTimePickerArriv.Size = new System.Drawing.Size(134, 20);
            this.dateTimePickerArriv.TabIndex = 17;
            this.dateTimePickerArriv.Value = new System.DateTime(2022, 2, 8, 21, 23, 3, 0);
            // 
            // listViewTrains
            // 
            this.listViewTrains.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdTrain,
            this.train});
            this.listViewTrains.FullRowSelect = true;
            this.listViewTrains.HideSelection = false;
            this.listViewTrains.Location = new System.Drawing.Point(842, 114);
            this.listViewTrains.Name = "listViewTrains";
            this.listViewTrains.Size = new System.Drawing.Size(171, 190);
            this.listViewTrains.TabIndex = 18;
            this.listViewTrains.UseCompatibleStateImageBehavior = false;
            this.listViewTrains.View = System.Windows.Forms.View.Details;
            this.listViewTrains.ItemActivate += new System.EventHandler(this.listViewTrains_ItemActivate);
            this.listViewTrains.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // IdTrain
            // 
            this.IdTrain.Text = "id";
            this.IdTrain.Width = 28;
            // 
            // train
            // 
            this.train.Text = "Train Name";
            this.train.Width = 139;
            // 
            // listViewVagons
            // 
            this.listViewVagons.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idVagon,
            this.nameVagon});
            this.listViewVagons.FullRowSelect = true;
            this.listViewVagons.HideSelection = false;
            this.listViewVagons.Location = new System.Drawing.Point(1084, 114);
            this.listViewVagons.Name = "listViewVagons";
            this.listViewVagons.Size = new System.Drawing.Size(199, 190);
            this.listViewVagons.TabIndex = 19;
            this.listViewVagons.UseCompatibleStateImageBehavior = false;
            this.listViewVagons.View = System.Windows.Forms.View.Details;
            this.listViewVagons.ItemActivate += new System.EventHandler(this.listViewVagons_ItemActivate);
            // 
            // comboBoxVagons
            // 
            this.comboBoxVagons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVagons.Enabled = false;
            this.comboBoxVagons.FormattingEnabled = true;
            this.comboBoxVagons.Location = new System.Drawing.Point(1084, 310);
            this.comboBoxVagons.Name = "comboBoxVagons";
            this.comboBoxVagons.Size = new System.Drawing.Size(121, 21);
            this.comboBoxVagons.TabIndex = 20;
            // 
            // buttonAddVagon
            // 
            this.buttonAddVagon.Enabled = false;
            this.buttonAddVagon.Location = new System.Drawing.Point(1208, 308);
            this.buttonAddVagon.Name = "buttonAddVagon";
            this.buttonAddVagon.Size = new System.Drawing.Size(75, 23);
            this.buttonAddVagon.TabIndex = 21;
            this.buttonAddVagon.Text = "Add Vagon";
            this.buttonAddVagon.UseVisualStyleBackColor = true;
            this.buttonAddVagon.Click += new System.EventHandler(this.buttonAddVagon_Click);
            // 
            // idVagon
            // 
            this.idVagon.Text = "id";
            // 
            // nameVagon
            // 
            this.nameVagon.Text = "Vagon Name";
            this.nameVagon.Width = 135;
            // 
            // buttonChange
            // 
            this.buttonChange.Enabled = false;
            this.buttonChange.Location = new System.Drawing.Point(691, 349);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 22;
            this.buttonChange.Text = "Update";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // labelidSched
            // 
            this.labelidSched.AutoSize = true;
            this.labelidSched.Location = new System.Drawing.Point(12, 306);
            this.labelidSched.Name = "labelidSched";
            this.labelidSched.Size = new System.Drawing.Size(78, 13);
            this.labelidSched.TabIndex = 23;
            this.labelidSched.Text = "Current Sched:";
            // 
            // idSched
            // 
            this.idSched.AutoSize = true;
            this.idSched.Location = new System.Drawing.Point(86, 306);
            this.idSched.Name = "idSched";
            this.idSched.Size = new System.Drawing.Size(33, 13);
            this.idSched.TabIndex = 24;
            this.idSched.Text = "None";
            // 
            // labelTripName
            // 
            this.labelTripName.AutoSize = true;
            this.labelTripName.Location = new System.Drawing.Point(138, 306);
            this.labelTripName.Name = "labelTripName";
            this.labelTripName.Size = new System.Drawing.Size(25, 13);
            this.labelTripName.TabIndex = 25;
            this.labelTripName.Text = "Trip";
            this.labelTripName.Visible = false;
            // 
            // labelTrainId
            // 
            this.labelTrainId.AutoSize = true;
            this.labelTrainId.Location = new System.Drawing.Point(1081, 98);
            this.labelTrainId.Name = "labelTrainId";
            this.labelTrainId.Size = new System.Drawing.Size(83, 13);
            this.labelTrainId.TabIndex = 26;
            this.labelTrainId.Text = "Current Train Id:";
            // 
            // TrainId
            // 
            this.TrainId.AutoSize = true;
            this.TrainId.Location = new System.Drawing.Point(1161, 98);
            this.TrainId.Name = "TrainId";
            this.TrainId.Size = new System.Drawing.Size(33, 13);
            this.TrainId.TabIndex = 27;
            this.TrainId.Text = "None";
            // 
            // Moder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 450);
            this.Controls.Add(this.TrainId);
            this.Controls.Add(this.labelTrainId);
            this.Controls.Add(this.labelTripName);
            this.Controls.Add(this.idSched);
            this.Controls.Add(this.labelidSched);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonAddVagon);
            this.Controls.Add(this.comboBoxVagons);
            this.Controls.Add(this.listViewVagons);
            this.Controls.Add(this.listViewTrains);
            this.Controls.Add(this.dateTimePickerArriv);
            this.Controls.Add(this.dateTimePickerDepart);
            this.Controls.Add(this.comboBoxTrain);
            this.Controls.Add(this.comboBoxLine);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.labelLogout);
            this.Controls.Add(this.listViewSched);
            this.Controls.Add(this.labelIdModer);
            this.Controls.Add(this.IdModer);
            this.Controls.Add(this.labelLogin);
            this.Name = "Moder";
            this.Text = "Moder";
            this.Load += new System.EventHandler(this.Moder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label IdModer;
        private System.Windows.Forms.Label labelIdModer;
        private System.Windows.Forms.ListView listViewSched;
        private System.Windows.Forms.ColumnHeader schedId;
        private System.Windows.Forms.ColumnHeader tripName;
        private System.Windows.Forms.ColumnHeader destCity;
        private System.Windows.Forms.ColumnHeader line;
        private System.Windows.Forms.ColumnHeader schedDep;
        private System.Windows.Forms.ColumnHeader schedArr;
        private System.Windows.Forms.ColumnHeader modelTrain;
        private System.Windows.Forms.LinkLabel labelLogout;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxLine;
        private System.Windows.Forms.ComboBox comboBoxTrain;
        private System.Windows.Forms.DateTimePicker dateTimePickerDepart;
        private System.Windows.Forms.DateTimePicker dateTimePickerArriv;
        private System.Windows.Forms.ListView listViewTrains;
        private System.Windows.Forms.ColumnHeader IdTrain;
        private System.Windows.Forms.ColumnHeader train;
        private System.Windows.Forms.ListView listViewVagons;
        private System.Windows.Forms.ColumnHeader idVagon;
        private System.Windows.Forms.ColumnHeader nameVagon;
        private System.Windows.Forms.ComboBox comboBoxVagons;
        private System.Windows.Forms.Button buttonAddVagon;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label labelidSched;
        private System.Windows.Forms.Label idSched;
        private System.Windows.Forms.Label labelTripName;
        private System.Windows.Forms.Label labelTrainId;
        private System.Windows.Forms.Label TrainId;
    }
}