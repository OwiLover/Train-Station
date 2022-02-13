using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace Kursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private SqlConnection sqlConnection = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxName.Hide();
            textBoxSurname.Hide();
            labelName.Hide();
            labelSurname.Hide();
            ButtonCreateAcc.Hide();
            labelBack.Hide();
            dateTimePicker1.Hide();
            sqlConnection = new SqlConnection("Data Source = OWILOVER; Initial Catalog = TrainStation; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            try

            {

                sqlConnection.Open();
                //if (sqlConnection.State == ConnectionState.Open)
                //MessageBox.Show("Conneted!!!!", "Connection", MessageBoxButtons.OK);

            }

            catch (Exception)

            {

                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);

            }
        }

        private void oleDbConnection1_InfoMessage(object sender, System.Data.OleDb.OleDbInfoMessageEventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string pass = textBoxPassword.Text;
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
            string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
            SqlCommand command = new SqlCommand($"SELECT Id, Login, Password FROM Auth WHERE Login ='{textBoxLogin.Text}';", sqlConnection);
            SqlDataReader userCheck = command.ExecuteReader();
            userCheck.Read();
            if (textBoxLogin.Text == "")
            {
                userCheck.Close();
                MessageBox.Show("Please, enter your login");
            }
            else if (!userCheck.HasRows)
            {
                userCheck.Close();
                MessageBox.Show("No user found, retry or register");
            }
            else if (textBoxPassword.Text =="")
            {
                MessageBox.Show("Please, enter your password");
                userCheck.Close();
            }
            else if (userCheck.GetString(2) != result)
            {

                MessageBox.Show("Password is incorrect");
                userCheck.Close();
            }
            else if (userCheck.GetString(1) == textBoxLogin.Text && userCheck.GetString(2) == result)
            {

                MessageBox.Show("Login successful!");
                string Login = textBoxLogin.Text;
                SqlCommand command1 = new SqlCommand($"SELECT First, Id FROM Passenger WHERE IdAuth ='{userCheck.GetInt32(0)}';", sqlConnection);
                SqlCommand command2 = new SqlCommand($"SELECT First, Id FROM Administrator WHERE IdAuth ='{userCheck.GetInt32(0)}';", sqlConnection);
                SqlCommand command3 = new SqlCommand($"SELECT First, Id FROM Moderator WHERE IdAuth ='{userCheck.GetInt32(0)}';", sqlConnection);
                SqlCommand command4 = new SqlCommand($"SELECT First, Id FROM Director WHERE IdAuth ='{userCheck.GetInt32(0)}';", sqlConnection);
                userCheck.Close();
                SqlDataReader PassCheck = command1.ExecuteReader();
                PassCheck.Read();
                
                
                //SqlDataReader ModCheck = command3.ExecuteReader();
                //ModCheck.Read();
                
                if (PassCheck.HasRows)
                {

                    Passenger passenger = new Passenger(Login, PassCheck.GetInt32(1)); 
                    passenger.Show();
                    this.Visible = false;
                    
                    //AdmCheck.Close();
                    //ModCheck.Close();
                }
                PassCheck.Close();
                SqlDataReader AdmCheck = command2.ExecuteReader();
                AdmCheck.Read();
                if (AdmCheck.HasRows)
                {
                    Admin admin = new Admin(Login, AdmCheck.GetInt32(1));
                    admin.Show();
                    this.Visible = false;
                }
                AdmCheck.Close();
                SqlDataReader ModCheck = command3.ExecuteReader();
                ModCheck.Read();
                if (ModCheck.HasRows)
                {
                    Moder moder = new Moder(Login, ModCheck.GetInt32(1));
                    moder.Show();
                    this.Visible=false;
                }
                ModCheck.Close();
                SqlDataReader DirCheck = command4.ExecuteReader();
                DirCheck.Read();
                if (DirCheck.HasRows)
                {
                    Boss boss = new Boss(Login, DirCheck.GetInt32(1));
                    boss.Show();
                    this.Visible = false;
                }
                AdmCheck.Close();
                sqlConnection.Close();

            }
            else MessageBox.Show("Whoops, something went wrong!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buttonLogin.Hide();
            labelDontHaveAcc.Hide();
            labelSignUp.Hide();
            buttonLogin.Hide();
            textBoxName.Show();
            textBoxSurname.Show();
            dateTimePicker1.Show();
            labelName.Show();
            labelSurname.Show();
            ButtonCreateAcc.Show();
            labelBack.Show();
            textBoxSex.Show();
            labelBirth.Show();
            labelSex.Show();
            labelDoc.Show();
            textBoxDoc.Show();
            textBoxPassword.UseSystemPasswordChar = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            buttonLogin.Show();
            labelDontHaveAcc.Show();
            labelSignUp.Show();
            buttonLogin.Show();
            textBoxName.Hide();
            textBoxSurname.Hide();
            labelName.Hide();
            labelSurname.Hide();
            ButtonCreateAcc.Hide();
            dateTimePicker1.Hide();
            labelBack.Hide();
            textBoxSex.Hide();
            labelBirth.Hide();
            labelSex.Hide();
            labelDoc.Hide();
            textBoxDoc.Hide();
            textBoxPassword.UseSystemPasswordChar = true;
        }

        private void ButtonCreateAcc_Click(object sender, EventArgs e)
        {
            
            SqlCommand spisok = new SqlCommand($"SELECT Id, Login FROM Auth WHERE Login ='{textBoxLogin.Text}';", sqlConnection);
            SqlDataReader reader = spisok.ExecuteReader();
            if (reader.HasRows)
            {
                MessageBox.Show("This user name already exists");
                textBoxLogin.BackColor = Color.Red;
                reader.Close();
            } else if (textBoxDoc.TextLength<8)
              {
                MessageBox.Show("Document must have 8 numbers");
                reader.Close();
                textBoxDoc.BackColor = Color.Red;


            } else if (textBoxLogin.Text=="" || textBoxPassword.Text=="" || textBoxName.Text=="" || textBoxSurname.Text=="" || textBoxSex.Text=="" || textBoxDoc.Text=="")
            {
                reader.Close();
                textBoxLogin.BackColor = Color.White;
                textBoxDoc.BackColor = Color.White;
                MessageBox.Show("Please, fill everything!");
            }
            else try
            {
                    reader.Close();
                    MD5 md5 = new MD5CryptoServiceProvider();
                    string pass = textBoxPassword.Text;
                    byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
                    string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                    SqlCommand command = new SqlCommand($"INSERT INTO [Auth] (Login, Password) VALUES (N'{textBoxLogin.Text}', N'{result}');", sqlConnection);
                    command.ExecuteNonQuery().ToString();
                    SqlCommand passConnect = new SqlCommand($"SELECT Id FROM Auth WHERE Login ='{textBoxLogin.Text}';", sqlConnection);
                    SqlDataReader reader2 = passConnect.ExecuteReader();
                    reader2.Read();
                    SqlCommand command2 = new SqlCommand($"INSERT INTO [Passenger] (First, Second, Birth, Gender, DocNum, IdAuth) VALUES (N'{textBoxName.Text}', N'{textBoxSurname.Text}', N'{dateTimePicker1.Value.Year.ToString()}-{dateTimePicker1.Value.Month.ToString()}-{dateTimePicker1.Value.Day.ToString()}',N'{textBoxSex.Text}',N'{textBoxDoc.Text}',N'{reader2.GetInt32(0)}');", sqlConnection);
                    reader2.Close();
                    command2.ExecuteNonQuery().ToString();

                    //SqlCommand command2 = new SqlCommand($"INSERT INTO [Passenger] (First, Second, Birth, Gender, DocNum, IdAuth) VALUES (N'{textBoxLogin.Text}', N'{textBoxPassword.Text}');", sqlConnection);
                    MessageBox.Show("Your Account was created!");
                    buttonLogin.Show();
                    labelDontHaveAcc.Show();
                    labelSignUp.Show();
                    buttonLogin.Show();
                    textBoxName.Hide();
                    textBoxSurname.Hide();
                    labelName.Hide();
                    labelSurname.Hide();
                    ButtonCreateAcc.Hide();
                    dateTimePicker1.Hide();
                    labelBack.Hide();
                    textBoxSex.Hide();
                    labelBirth.Hide();
                    labelSex.Hide();
                    labelDoc.Hide();
                    textBoxDoc.Hide();
                    textBoxPassword.UseSystemPasswordChar = true;
                } 
              catch (Exception)
                { 
                    MessageBox.Show("Something went wrong :(");
                }
        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
            //if (e.KeyChar != ((char)Keys.Back))
            //{
            //string Symbol = e.KeyChar.ToString();

            //if (!Regex.Match(Symbol, @"[а-яА-Я]|[a-zA-Z]").Success)
            //{
            //e.Handled = true;
            //}

            //}
            //else
            //{
            //MessageBox.Show("Ты нажал Backspace!");
            //e.Handled = true;
            //}
        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxDoc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBoxDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.Day.ToString());
        }
        string makeAdmin = "MakeAdmin";
        private void buttonMakeVasyaAdmin_Click(object sender, EventArgs e)
        {
            SqlParameter idParam = new SqlParameter
            {
                ParameterName = "@IdAuth",
                Value = 21
            };
            try
            {
                SqlCommand MakeAdmin = new SqlCommand(makeAdmin, sqlConnection);
                MakeAdmin.CommandType = System.Data.CommandType.StoredProcedure;
                MakeAdmin.Parameters.Add(idParam);
                MakeAdmin.ExecuteNonQuery();
                MessageBox.Show("Test теперь Админ!");
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
