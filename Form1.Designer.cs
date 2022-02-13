namespace Kursach
{
    partial class Form1
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
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.labelDontHaveAcc = new System.Windows.Forms.Label();
            this.labelSignUp = new System.Windows.Forms.LinkLabel();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.ButtonCreateAcc = new System.Windows.Forms.Button();
            this.labelBack = new System.Windows.Forms.LinkLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxSex = new System.Windows.Forms.ComboBox();
            this.textBoxDoc = new System.Windows.Forms.TextBox();
            this.labelBirth = new System.Windows.Forms.Label();
            this.labelSex = new System.Windows.Forms.Label();
            this.labelDoc = new System.Windows.Forms.Label();
            this.buttonMakeVasyaAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=OWILOVER;Integrated Security=SSPI;Initial Catalog=" +
    "TrainStation";
            this.cn.InfoMessage += new System.Data.OleDb.OleDbInfoMessageEventHandler(this.oleDbConnection1_InfoMessage);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(345, 165);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(182, 20);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(345, 217);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(182, 20);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            this.textBoxSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSurname_KeyPress);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(399, 270);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.login_Click);
            // 
            // labelDontHaveAcc
            // 
            this.labelDontHaveAcc.AutoSize = true;
            this.labelDontHaveAcc.Location = new System.Drawing.Point(374, 340);
            this.labelDontHaveAcc.Name = "labelDontHaveAcc";
            this.labelDontHaveAcc.Size = new System.Drawing.Size(122, 13);
            this.labelDontHaveAcc.TabIndex = 3;
            this.labelDontHaveAcc.Text = "Don\'t have an account?";
            this.labelDontHaveAcc.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Location = new System.Drawing.Point(412, 376);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(45, 13);
            this.labelSignUp.TabIndex = 4;
            this.labelSignUp.TabStop = true;
            this.labelSignUp.Text = "Sign Up";
            this.labelSignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(345, 139);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(182, 20);
            this.textBoxLogin.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(345, 191);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(182, 20);
            this.textBoxName.TabIndex = 6;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(306, 142);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(33, 13);
            this.labelLogin.TabIndex = 7;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(286, 168);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Password";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(304, 194);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(290, 220);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(49, 13);
            this.labelSurname.TabIndex = 10;
            this.labelSurname.Text = "Surname";
            // 
            // ButtonCreateAcc
            // 
            this.ButtonCreateAcc.Location = new System.Drawing.Point(355, 330);
            this.ButtonCreateAcc.Name = "ButtonCreateAcc";
            this.ButtonCreateAcc.Size = new System.Drawing.Size(163, 23);
            this.ButtonCreateAcc.TabIndex = 11;
            this.ButtonCreateAcc.Text = "Create an account";
            this.ButtonCreateAcc.UseVisualStyleBackColor = true;
            this.ButtonCreateAcc.Click += new System.EventHandler(this.ButtonCreateAcc_Click);
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Location = new System.Drawing.Point(401, 376);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(73, 13);
            this.labelBack.TabIndex = 12;
            this.labelBack.TabStop = true;
            this.labelBack.Text = "Back to Login";
            this.labelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelBack_LinkClicked);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(345, 244);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 20);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // textBoxSex
            // 
            this.textBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textBoxSex.FormattingEnabled = true;
            this.textBoxSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.textBoxSex.Location = new System.Drawing.Point(345, 270);
            this.textBoxSex.Name = "textBoxSex";
            this.textBoxSex.Size = new System.Drawing.Size(182, 21);
            this.textBoxSex.TabIndex = 16;
            this.textBoxSex.Visible = false;
            // 
            // textBoxDoc
            // 
            this.textBoxDoc.Location = new System.Drawing.Point(345, 297);
            this.textBoxDoc.MaxLength = 8;
            this.textBoxDoc.Name = "textBoxDoc";
            this.textBoxDoc.Size = new System.Drawing.Size(182, 20);
            this.textBoxDoc.TabIndex = 17;
            this.textBoxDoc.Visible = false;
            this.textBoxDoc.TextChanged += new System.EventHandler(this.textBoxDoc_TextChanged);
            this.textBoxDoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDoc_KeyPress);
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Location = new System.Drawing.Point(285, 246);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(54, 13);
            this.labelBirth.TabIndex = 18;
            this.labelBirth.Text = "Birth Date";
            this.labelBirth.Visible = false;
            this.labelBirth.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelSex
            // 
            this.labelSex.AutoSize = true;
            this.labelSex.Location = new System.Drawing.Point(297, 275);
            this.labelSex.Name = "labelSex";
            this.labelSex.Size = new System.Drawing.Size(42, 13);
            this.labelSex.TabIndex = 19;
            this.labelSex.Text = "Gender";
            this.labelSex.Visible = false;
            // 
            // labelDoc
            // 
            this.labelDoc.AutoSize = true;
            this.labelDoc.Location = new System.Drawing.Point(243, 300);
            this.labelDoc.Name = "labelDoc";
            this.labelDoc.Size = new System.Drawing.Size(96, 13);
            this.labelDoc.TabIndex = 20;
            this.labelDoc.Text = "Document Number";
            this.labelDoc.Visible = false;
            // 
            // buttonMakeVasyaAdmin
            // 
            this.buttonMakeVasyaAdmin.Location = new System.Drawing.Point(591, 162);
            this.buttonMakeVasyaAdmin.Name = "buttonMakeVasyaAdmin";
            this.buttonMakeVasyaAdmin.Size = new System.Drawing.Size(131, 23);
            this.buttonMakeVasyaAdmin.TabIndex = 21;
            this.buttonMakeVasyaAdmin.Text = "Make Vasya Admin";
            this.buttonMakeVasyaAdmin.UseVisualStyleBackColor = true;
            this.buttonMakeVasyaAdmin.Visible = false;
            this.buttonMakeVasyaAdmin.Click += new System.EventHandler(this.buttonMakeVasyaAdmin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 545);
            this.Controls.Add(this.buttonMakeVasyaAdmin);
            this.Controls.Add(this.labelDoc);
            this.Controls.Add(this.labelSex);
            this.Controls.Add(this.labelBirth);
            this.Controls.Add(this.textBoxDoc);
            this.Controls.Add(this.textBoxSex);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.ButtonCreateAcc);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelSignUp);
            this.Controls.Add(this.labelDontHaveAcc);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxPassword);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label labelDontHaveAcc;
        private System.Windows.Forms.LinkLabel labelSignUp;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Button ButtonCreateAcc;
        private System.Windows.Forms.LinkLabel labelBack;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox textBoxSex;
        private System.Windows.Forms.TextBox textBoxDoc;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.Label labelDoc;
        private System.Windows.Forms.Button buttonMakeVasyaAdmin;
    }
}

