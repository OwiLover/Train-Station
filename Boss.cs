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

namespace Kursach
{
    public partial class Boss : Form
    {
        public Boss(string Login, int Id)
        {
            InitializeComponent();
            if (Login != null)
            {
                labelLogin.Text = Login;
            }
            else labelLogin.Text = "Error";
            IdBoss.Text = Id.ToString();
        }

        
        private void labelLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private SqlConnection sqlConnection = null;
        private void Boss_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection("Data Source = OWILOVER; Initial Catalog = TrainStation; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            try

            {

                sqlConnection.Open();
                if (sqlConnection.State == ConnectionState.Open)
                    MessageBox.Show("Conneted!!!!", "Connection", MessageBoxButtons.OK);

            }

            catch (Exception)

            {

                MessageBox.Show("Connection failed!!", "Connection", MessageBoxButtons.OK);

            }
            SqlCommand CityList = new SqlCommand("SELECT * FROM City", sqlConnection);
            SqlDataReader reader = CityList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[3];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    comboBoxCity.Items.Add(reader.GetString(1));
                    list[2] = reader.GetSqlMoney(2).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewCity.Items.Add(lvi);
                } reader.Close();
            } else reader.Close();
            SqlCommand VagonList = new SqlCommand("SELECT * FROM Vagon", sqlConnection);
            reader = VagonList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[4];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(3);
                    list[2] = reader.GetInt32(2).ToString();
                    comboBoxVagon.Items.Add(reader.GetString(3));
                    list[3] = reader.GetSqlMoney(1).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewVagons.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand TrainList = new SqlCommand("SELECT * FROM Model", sqlConnection);
            reader = TrainList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[3];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    comboBoxTrain.Items.Add(reader.GetString(1));
                    comboBoxTrains.Items.Add(reader.GetString(1));
                    list[2] = reader.GetSqlMoney(2).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewTrain.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand ItemList = new SqlCommand("SELECT * FROM Item", sqlConnection);
            reader = ItemList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[4];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    comboBoxItem.Items.Add(reader.GetString(1));
                    list[2] = reader.GetInt32(3).ToString();
                    list[3] = reader.GetSqlMoney(2).ToString();
                    
                    ListViewItem lvi = new ListViewItem(list);
                    listViewItem.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();

            SqlCommand trainsList = new SqlCommand("SELECT MT.id, M.ModelName, MT.TrainName FROM ModelTrain MT JOIN Model M on M.id = MT.idModel", sqlConnection);
            reader = trainsList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[3];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(2);
                    list[2] = reader.GetString(1);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewTrains.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand AdminList = new SqlCommand("SELECT Administrator.Id, Auth.Login, Administrator.First, Administrator.Second FROM Administrator JOIN Auth on Auth.Id = Administrator.IdAuth", sqlConnection);
            reader = AdminList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[4];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    list[2] = reader.GetString(2);
                    list[3] = reader.GetString(3);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewAdmin.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand UserList = new SqlCommand("SELECT P.IdAuth, A.Login, P.First, P.Second From Passenger P JOIN Auth A on A.Id=P.IdAuth", sqlConnection);
            reader = UserList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string list = reader.GetInt32(0).ToString() + " "+ reader.GetString(1)+" | " + reader.GetString(2) + " "+ reader.GetString(3);

                    ListViewItem lvi = new ListViewItem(list);
                    comboBoxAdmin.Items.Add(list);
                    comboBoxModer.Items.Add(list);
                }
                reader.Close();
            }
            SqlCommand ModerList = new SqlCommand("SELECT Moderator.Id, Auth.Login, Moderator.First, Moderator.Second FROM Moderator JOIN Auth on Auth.Id = Moderator.IdAuth", sqlConnection);
            reader = ModerList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[4];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    list[2] = reader.GetString(2);
                    list[3] = reader.GetString(3);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewModer.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand getMoney = new SqlCommand($"SELECT City.cityCost FROM City WHERE City.cityName ='{comboBoxCity.Text}';", sqlConnection);
            SqlDataReader reader = getMoney.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    textBoxCityMoney.Value = reader.GetDecimal(0);
                }
                reader.Close();
            }
            else reader.Close();
            textBoxCityMoney.Enabled = true;
            buttonCityAdd.Enabled = true;
        }

        private void listViewCity_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this City?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteCity = new SqlCommand("deleteCity", sqlConnection);
                deleteCity.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter cityId = new SqlParameter
                {
                    ParameterName = "@IdCity",
                    Value = listViewCity.FocusedItem.SubItems[0].Text
                };
                deleteCity.Parameters.Add(cityId);
                try
                {
                    deleteCity.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                listViewCity.Items.Clear();
                comboBoxCity.Items.Clear();
                SqlCommand CityList = new SqlCommand("SELECT * FROM City", sqlConnection);
                SqlDataReader reader = CityList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[3];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        comboBoxCity.Items.Add(reader.GetString(1));
                        list[2] = reader.GetSqlMoney(2).ToString();
                        ListViewItem lvi = new ListViewItem(list);
                        listViewCity.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                textBoxCityMoney.Enabled = false;
                buttonCityAdd.Enabled = true;
                textBoxCityMoney.Enabled = false;
                buttonCityAdd.Enabled = false;
                textBoxNewCity.Visible = false;
                buttonAddNew.Visible = false;
                buttonNewCity.Visible = true;
                buttonCityAdd.Visible = true;
                comboBoxCity.Visible = true;
                buttonBack.Visible = false;
            }
        }

        private void buttonCityAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change this City's Value?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand updateCity = new SqlCommand("costCity", sqlConnection);
                updateCity.CommandType = System.Data.CommandType.StoredProcedure;
                Decimal money = Convert.ToDecimal(textBoxCityMoney.Value);
                Decimal money2 = Decimal.Round(decimal.Parse(money.ToString()), 2, MidpointRounding.AwayFromZero);
                SqlParameter cityName = new SqlParameter
                {
                    ParameterName = "@CityName",
                    Value = comboBoxCity.Text
                };
                SqlParameter cityCost = new SqlParameter
                {
                    ParameterName = "@Cost",
                    Value = money2
                };
                updateCity.Parameters.Add(cityName);
                updateCity.Parameters.Add(cityCost);
                updateCity.ExecuteNonQuery();
            }
            listViewCity.Items.Clear();
            comboBoxCity.Items.Clear();
            SqlCommand CityList = new SqlCommand("SELECT * FROM City", sqlConnection);
            SqlDataReader reader = CityList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[3];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    comboBoxCity.Items.Add(reader.GetString(1));
                    list[2] = reader.GetSqlMoney(2).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewCity.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            textBoxCityMoney.Enabled = false;
            buttonCityAdd.Enabled = false;

        }

        private void buttonNewCity_Click(object sender, EventArgs e)
        {
            comboBoxCity.Visible = false;
            buttonCityAdd.Visible = false;
            buttonAddNew.Visible = true;
            textBoxNewCity.Visible = true;
            textBoxNewCity.Text = "";
            textBoxCityMoney.Value = 0;
            textBoxCityMoney.Enabled = true;
            buttonBack.Visible = true;
            buttonNewCity.Visible = false;
        }

        private void textBoxNewCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i =0; i<comboBoxCity.Items.Count; i++)
            {
                if (String.Equals (comboBoxCity.Items[i].ToString().ToLower().Trim(), textBoxNewCity.Text.ToLower()))
                {
                    flag = 1;
                }  
            }
            if (textBoxNewCity.Text == "")
            {
                MessageBox.Show("Please, write City's name");
            } else if (flag == 1)
            {
                MessageBox.Show("This City already exist");
            }
            else if (MessageBox.Show("Do you want to add new City?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string boxName = textBoxNewCity.Text;
                string name = boxName.First().ToString().ToUpper() + String.Join("", boxName.Skip(1));
                SqlCommand addCity = new SqlCommand("addCity", sqlConnection);
                addCity.CommandType = System.Data.CommandType.StoredProcedure;
                Decimal money = Convert.ToDecimal(textBoxCityMoney.Value);
                Decimal money2 = Decimal.Round(decimal.Parse(money.ToString()), 2, MidpointRounding.AwayFromZero);
                SqlParameter cityName = new SqlParameter
                {
                    ParameterName = "@CityName",
                    Value = name 
                };
                SqlParameter cityCost = new SqlParameter
                {
                    ParameterName = "@Cost",
                    Value = money2
                };
                addCity.Parameters.Add(cityName);
                addCity.Parameters.Add(cityCost);
                addCity.ExecuteNonQuery();

                listViewCity.Items.Clear();
                comboBoxCity.Items.Clear();
                SqlCommand CityList = new SqlCommand("SELECT * FROM City", sqlConnection);
                SqlDataReader reader = CityList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[3];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        comboBoxCity.Items.Add(reader.GetString(1));
                        list[2] = reader.GetSqlMoney(2).ToString();
                        ListViewItem lvi = new ListViewItem(list);
                        listViewCity.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                textBoxCityMoney.Enabled = false;
                buttonCityAdd.Enabled = false;
                textBoxNewCity.Visible = false;
                buttonAddNew.Visible = false;
                buttonNewCity.Visible = true;
                buttonCityAdd.Visible = true;
                comboBoxCity.Visible = true;
                buttonBack.Visible = false;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            textBoxCityMoney.Enabled = false;
            buttonCityAdd.Enabled = false;
            textBoxNewCity.Visible = false;
            buttonAddNew.Visible = false;
            buttonNewCity.Visible = true;
            buttonCityAdd.Visible = true;
            comboBoxCity.Visible = true;
            buttonBack.Visible = false;
            buttonNewCity.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listViewVagons_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Vagon?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteVagon = new SqlCommand("vagonDelete", sqlConnection);
                deleteVagon.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter vagonId = new SqlParameter
                {
                    ParameterName = "@IdVagon",
                    Value = listViewVagons.FocusedItem.SubItems[0].Text
                };
                deleteVagon.Parameters.Add(vagonId);
                try
                {
                    deleteVagon.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                listViewVagons.Items.Clear();
                comboBoxVagon.Items.Clear();
                SqlCommand VagonList = new SqlCommand("SELECT * FROM Vagon", sqlConnection);
                SqlDataReader reader = VagonList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[4];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(3);
                        list[2] = reader.GetInt32(2).ToString();
                        comboBoxVagon.Items.Add(reader.GetString(3));
                        list[3] = reader.GetSqlMoney(1).ToString();
                        ListViewItem lvi = new ListViewItem(list);
                        listViewVagons.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                vagonMoney.Enabled = false;
                buttonUpdateVagon.Enabled = false;
                textBoxVagSeats.Enabled = false;
                textBoxVagon.Visible = false;
                buttonAddVagon.Visible = true;
                buttonNewVagon.Visible = true;
                buttonUpdateVagon.Visible = true;
                comboBoxVagon.Visible = true;
                buttonBackVagon.Visible = false;

            }
        }

        private void comboBoxVagon_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand getMoney = new SqlCommand($"SELECT Vagon.vagonCost, Vagon.Seats FROM Vagon WHERE Vagon.Name ='{comboBoxVagon.Text}';", sqlConnection);
            SqlDataReader reader = getMoney.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    vagonMoney.Value = reader.GetDecimal(0);
                    textBoxVagSeats.Text = reader.GetInt32(1).ToString();
                }
                reader.Close();
            }
            else reader.Close();
            vagonMoney.Enabled = true;
            textBoxVagSeats.Enabled = true;
            buttonUpdateVagon.Enabled = true;
        }

        private void buttonBackVagon_Click(object sender, EventArgs e)
        {
            vagonMoney.Enabled = false;
            buttonUpdateVagon.Enabled = false;
            textBoxVagon.Visible = false;
            buttonAddVagon.Visible = false;
            buttonUpdateVagon.Visible = true;
            comboBoxVagon.Visible = true;
            buttonBackVagon.Visible = false;
            buttonNewVagon.Visible = true;
            textBoxVagSeats.Enabled = false;
        }

        private void buttonUpdateVagon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change this Vagon's Values?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand updateVagon = new SqlCommand("updateVagons", sqlConnection);
                updateVagon.CommandType = System.Data.CommandType.StoredProcedure;
                Decimal money = Convert.ToDecimal(vagonMoney.Value);
                Decimal money2 = Decimal.Round(decimal.Parse(money.ToString()), 2, MidpointRounding.AwayFromZero);
                SqlParameter vagonName = new SqlParameter
                {
                    ParameterName = "@VagonName",
                    Value = comboBoxVagon.Text
                };
                SqlParameter vagonCost = new SqlParameter
                {
                    ParameterName = "@Cost",
                    Value = money2
                };
                SqlParameter vagonSeats = new SqlParameter
                {
                    ParameterName = "@Seats",
                    Value = textBoxVagSeats.Text
                };
                updateVagon.Parameters.Add(vagonName);
                updateVagon.Parameters.Add(vagonCost);
                updateVagon.Parameters.Add(vagonSeats);
                updateVagon.ExecuteNonQuery();
            }
            listViewVagons.Items.Clear();
            comboBoxVagon.Items.Clear();
            SqlCommand VagonList = new SqlCommand("SELECT * FROM Vagon", sqlConnection);
            SqlDataReader reader = VagonList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[4];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(3);
                    list[2] = reader.GetInt32(2).ToString();
                    comboBoxVagon.Items.Add(reader.GetString(3));
                    list[3] = reader.GetSqlMoney(1).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewVagons.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            vagonMoney.Enabled = false;
            buttonUpdateVagon.Enabled = false;
            textBoxVagSeats.Enabled = false;
        }

        private void textBoxVagSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxVagSeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonNewVagon_Click(object sender, EventArgs e)
        {
            buttonNewVagon.Visible = false;
            buttonBackVagon.Visible = true;
            buttonAddVagon.Visible=true;
            comboBoxVagon.Visible = false;
            textBoxVagon.Visible = true;
            textBoxVagSeats.Enabled = true;
            vagonMoney.Enabled = true;
            buttonAddVagon.Enabled = true;
            textBoxVagSeats.Text = "";
            textBoxVagon.Text = "";
            vagonMoney.Value = 0;
        }

        private void buttonAddVagon_Click(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < comboBoxVagon.Items.Count; i++)
            {
                if (String.Equals(comboBoxVagon.Items[i].ToString().ToLower().Trim(), textBoxVagon.Text.ToLower()))
                {
                    flag = 1;
                }
            }
            if (textBoxVagon.Text == "" || textBoxVagSeats.Text=="")
            {
                MessageBox.Show("Please, fill everything");
            }
            else if (flag == 1)
            {
                MessageBox.Show("This Vagon already exist");
            }
            else if (MessageBox.Show("Do you want to add new Vagon?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string boxName = textBoxVagon.Text;
                string name = boxName.First().ToString().ToUpper() + String.Join("", boxName.Skip(1));
                SqlCommand addVagon = new SqlCommand("addVagon", sqlConnection);
                addVagon.CommandType = System.Data.CommandType.StoredProcedure;
                Decimal money = Convert.ToDecimal(vagonMoney.Value);
                Decimal money2 = Decimal.Round(decimal.Parse(money.ToString()), 2, MidpointRounding.AwayFromZero);
                SqlParameter vagName = new SqlParameter
                {
                    ParameterName = "@VagonName",
                    Value = name
                };
                SqlParameter vagSeats = new SqlParameter
                {
                    ParameterName = "@Seats",
                    Value = textBoxVagSeats.Text
                };
                SqlParameter vagCost = new SqlParameter
                {
                    ParameterName = "@Price",
                    Value = money2
                };
                addVagon.Parameters.Add(vagName);
                addVagon.Parameters.Add(vagCost);
                addVagon.Parameters.Add(vagSeats);
                addVagon.ExecuteNonQuery();
                comboBoxVagon.Items.Clear();
                listViewVagons.Items.Clear();
                SqlCommand VagonList = new SqlCommand("SELECT * FROM Vagon", sqlConnection);
                SqlDataReader reader = VagonList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[4];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(3);
                        list[2] = reader.GetInt32(2).ToString();
                        comboBoxVagon.Items.Add(reader.GetString(3));
                        list[3] = reader.GetSqlMoney(1).ToString();
                        ListViewItem lvi = new ListViewItem(list);
                        listViewVagons.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                vagonMoney.Enabled = false;
                buttonUpdateVagon.Enabled = false;
                textBoxVagon.Visible = false;
                buttonAddVagon.Visible = false;
                buttonUpdateVagon.Visible = true;
                comboBoxVagon.Visible = true;
                buttonBackVagon.Visible = false;
                buttonNewVagon.Visible = true;
                textBoxVagSeats.Enabled = false;
            }
            
        }

        private void textBoxVagon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar) && !Char.IsPunctuation(e.KeyChar))
                e.Handled = true;
        }

        private void comboBoxTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand getMoney = new SqlCommand($"SELECT Model.costModel FROM Model WHERE Model.ModelName ='{comboBoxTrain.Text}';", sqlConnection);
            SqlDataReader reader = getMoney.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    moneyTrain.Value = reader.GetDecimal(0);
                }
                reader.Close();
            }
            else reader.Close();
            moneyTrain.Enabled = true;
            buttonUpdateTrain.Enabled = true;
        }

        private void buttonUpdateTrain_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change this Model's Values?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand updateTrain = new SqlCommand("updateModel", sqlConnection);
                updateTrain.CommandType = System.Data.CommandType.StoredProcedure;
                Decimal money = Convert.ToDecimal(moneyTrain.Value);
                Decimal money2 = Decimal.Round(decimal.Parse(money.ToString()), 2, MidpointRounding.AwayFromZero);
                SqlParameter trainName = new SqlParameter
                {
                    ParameterName = "@ModelName",
                    Value = comboBoxTrain.Text
                };
                SqlParameter trainCost = new SqlParameter
                {
                    ParameterName = "@Cost",
                    Value = money2
                };
                updateTrain.Parameters.Add(trainName);
                updateTrain.Parameters.Add(trainCost);
                updateTrain.ExecuteNonQuery();
            }
            comboBoxTrain.Items.Clear();
            listViewTrain.Items.Clear();
            SqlCommand TrainList = new SqlCommand("SELECT * FROM Model", sqlConnection);
            SqlDataReader reader = TrainList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[3];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    comboBoxTrain.Items.Add(reader.GetString(1));
                    list[2] = reader.GetSqlMoney(2).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewTrain.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            moneyTrain.Enabled = false;
            buttonUpdateTrain.Enabled = false;
        }

        private void buttonNewModel_Click(object sender, EventArgs e)
        {
            comboBoxTrain.Visible = false;
            buttonNewModel.Visible = false;
            buttonBackModel.Visible = true;
            buttonAddModel.Visible = true;
            textBoxModel.Visible = true;
            moneyTrain.Enabled = true;
            buttonAddModel.Enabled = true;
            textBoxModel.Text = "";
            moneyTrain.Value = 0;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonBackModel_Click(object sender, EventArgs e)
        {
            moneyTrain.Enabled = false;
            buttonUpdateTrain.Enabled = false;
            textBoxModel.Visible = false;
            buttonAddModel.Visible = false;
            buttonUpdateTrain.Visible = true;
            comboBoxTrain.Visible = true;
            buttonBackModel.Visible = false;
            buttonNewModel.Visible = true;
        }

        private void buttonAddModel_Click(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < comboBoxTrain.Items.Count; i++)
            {
                if (String.Equals(comboBoxTrain.Items[i].ToString().ToLower().Trim(), textBoxModel.Text.ToLower()))
                {
                    flag = 1;
                }
            }
            if (textBoxModel.Text == "")
            {
                MessageBox.Show("Please, write Model's name");
            }
            else if (flag == 1)
            {
                MessageBox.Show("This Model already exist");
            }
            else if (MessageBox.Show("Do you want to add new Model?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string boxName = textBoxModel.Text;
                string name = boxName.First().ToString().ToUpper() + String.Join("", boxName.Skip(1));
                SqlCommand addModel = new SqlCommand("addModel", sqlConnection);
                addModel.CommandType = System.Data.CommandType.StoredProcedure;
                Decimal money = Convert.ToDecimal(moneyTrain.Value);
                Decimal money2 = Decimal.Round(decimal.Parse(money.ToString()), 2, MidpointRounding.AwayFromZero);
                SqlParameter modelName = new SqlParameter
                {
                    ParameterName = "@ModelName",
                    Value = name
                };
                SqlParameter modelCost = new SqlParameter
                {
                    ParameterName = "@Cost",
                    Value = money2
                };
                addModel.Parameters.Add(modelName);
                addModel.Parameters.Add(modelCost);
                addModel.ExecuteNonQuery();
                comboBoxTrain.Items.Clear();
                listViewTrain.Items.Clear();
                comboBoxTrains.Items.Clear();
                SqlCommand TrainList = new SqlCommand("SELECT * FROM Model", sqlConnection);
                SqlDataReader reader = TrainList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[3];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        comboBoxTrain.Items.Add(reader.GetString(1));
                        comboBoxTrains.Items.Add(reader.GetString(1));
                        list[2] = reader.GetSqlMoney(2).ToString();
                        ListViewItem lvi = new ListViewItem(list);
                        listViewTrain.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                listViewTrains.Items.Clear();
                SqlCommand trainsList = new SqlCommand("SELECT MT.id, M.ModelName, MT.TrainName FROM ModelTrain MT JOIN Model M on M.id = MT.idModel", sqlConnection);
                reader = trainsList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[3];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        list[2] = reader.GetString(2);
                        ListViewItem lvi = new ListViewItem(list);
                        listViewTrains.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                moneyTrain.Enabled = false;
                buttonUpdateTrain.Enabled = false;
                textBoxModel.Visible = false;
                buttonAddModel.Visible = false;
                buttonUpdateTrain.Visible = true;
                comboBoxTrain.Visible = true;
                buttonBackModel.Visible = false;
                buttonNewModel.Visible = true;
            }
        }

        private void listViewTrain_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Model?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteModel = new SqlCommand("deleteModel", sqlConnection);
                deleteModel.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter modelId = new SqlParameter
                {
                    ParameterName = "@IdModel",
                    Value = listViewTrain.FocusedItem.SubItems[0].Text
                };
                deleteModel.Parameters.Add(modelId);
                try
                {
                    deleteModel.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                listViewTrain.Items.Clear();
                comboBoxTrain.Items.Clear();
                comboBoxTrains.Items.Clear();
                SqlCommand CityList = new SqlCommand("SELECT * FROM Model", sqlConnection);
                SqlDataReader reader = CityList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[3];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        comboBoxTrain.Items.Add(reader.GetString(1));
                        comboBoxTrains.Items.Add(reader.GetString(1));
                        list[2] = reader.GetSqlMoney(2).ToString();
                        ListViewItem lvi = new ListViewItem(list);
                        listViewTrain.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                listViewTrains.Items.Clear();

                SqlCommand trainsList = new SqlCommand("SELECT MT.id, M.ModelName, MT.TrainName FROM ModelTrain MT JOIN Model M on M.id = MT.idModel", sqlConnection);
                reader = trainsList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[3];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        list[2] = reader.GetString(2);

                        ListViewItem lvi = new ListViewItem(list);
                        listViewTrains.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                moneyTrain.Enabled = false;
                buttonUpdateTrain.Enabled = false;
                textBoxModel.Visible = false;
                buttonAddModel.Visible = true;
                buttonNewModel.Visible = true;
                buttonUpdateTrain.Visible = true;
                comboBoxTrain.Visible = true;
                buttonBackModel.Visible = false;


            }
        }

        private void buttonBackItem_Click(object sender, EventArgs e)
        {
            moneyItem.Enabled = false;
            buttonUpdateItem.Enabled = false;
            textBoxItem.Visible = false;
            buttonAddItem.Visible = false;
            buttonUpdateItem.Visible = true;
            comboBoxItem.Visible = true;
            buttonBackItem.Visible = false;
            buttonNewItem.Visible = true;
            textBoxItemStor.Enabled = false;
        }

        private void buttonNewItem_Click(object sender, EventArgs e)
        {
            comboBoxItem.Visible = false;
            buttonNewItem.Visible = false;
            buttonBackItem.Visible = true;
            buttonAddItem.Visible = true;
            textBoxItem.Visible = true;
            moneyItem.Enabled = true;
            buttonAddItem.Enabled = true;
            textBoxItemStor.Enabled = true;
            textBoxItemStor.Text = "";
            textBoxItem.Text = "";
            moneyItem.Value = 0;
        }

        private void comboBoxItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand getMoney = new SqlCommand($"SELECT Item.Price, Item.Storage FROM Item WHERE Item.Name ='{comboBoxItem.Text}';", sqlConnection);
            SqlDataReader reader = getMoney.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    moneyItem.Value = reader.GetDecimal(0);
                    textBoxItemStor.Text = reader.GetInt32(1).ToString();
                }
                reader.Close();
            }
            else reader.Close();
            moneyItem.Enabled = true;
            textBoxItemStor.Enabled = true;
            buttonUpdateItem.Enabled = true;
        }

        private void moneyTrain_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBoxItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonUpdateItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to change this Item's Values?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand updateItem = new SqlCommand("updateItem", sqlConnection);
                updateItem.CommandType = System.Data.CommandType.StoredProcedure;
                Decimal money = Convert.ToDecimal(moneyItem.Value);
                Decimal money2 = Decimal.Round(decimal.Parse(money.ToString()), 2, MidpointRounding.AwayFromZero);
                SqlParameter itemName = new SqlParameter
                {
                    ParameterName = "@ItemName",
                    Value = comboBoxItem.Text
                };
                SqlParameter itemCost = new SqlParameter
                {
                    ParameterName = "@Cost",
                    Value = money2
                };
                SqlParameter itemSeats = new SqlParameter
                {
                    ParameterName = "@Storage",
                    Value = textBoxItemStor.Text
                };
                updateItem.Parameters.Add(itemName);
                updateItem.Parameters.Add(itemCost);
                updateItem.Parameters.Add(itemSeats);
                updateItem.ExecuteNonQuery();
            }
            listViewItem.Items.Clear();
            comboBoxItem.Items.Clear();
            SqlCommand ItemList = new SqlCommand("SELECT * FROM Item", sqlConnection);
            SqlDataReader reader = ItemList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[4];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    list[2] = reader.GetInt32(3).ToString();
                    comboBoxItem.Items.Add(reader.GetString(1));
                    list[3] = reader.GetSqlMoney(2).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewItem.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            moneyItem.Enabled = false;
            buttonUpdateItem.Enabled = false;
            textBoxItemStor.Enabled = false;
        }

        private void textBoxItemStor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonAddItem_Click(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < comboBoxItem.Items.Count; i++)
            {
                if (String.Equals(comboBoxItem.Items[i].ToString().ToLower().Trim(), textBoxItem.Text.ToLower()))
                {
                    flag = 1;
                }
            }
            if (textBoxItem.Text == "" || textBoxItemStor.Text == "")
            {
                MessageBox.Show("Please, fill everything");
            }
            else if (flag == 1)
            {
                MessageBox.Show("This Item already exist");
            }
            else if (MessageBox.Show("Do you want to add new Item?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string boxName = textBoxItem.Text;
                string name = boxName.First().ToString().ToUpper() + String.Join("", boxName.Skip(1));
                SqlCommand addItem = new SqlCommand("addItem", sqlConnection);
                addItem.CommandType = System.Data.CommandType.StoredProcedure;
                Decimal money = Convert.ToDecimal(moneyItem.Value);
                Decimal money2 = Decimal.Round(decimal.Parse(money.ToString()), 2, MidpointRounding.AwayFromZero);
                SqlParameter itemName = new SqlParameter
                {
                    ParameterName = "@ItemName",
                    Value = name
                };
                SqlParameter itemStorage = new SqlParameter
                {
                    ParameterName = "@Storage",
                    Value = textBoxItemStor.Text
                };
                SqlParameter itemCost = new SqlParameter
                {
                    ParameterName = "@Cost",
                    Value = money2
                };
                addItem.Parameters.Add(itemName);
                addItem.Parameters.Add(itemCost);
                addItem.Parameters.Add(itemStorage);
                addItem.ExecuteNonQuery();
                comboBoxItem.Items.Clear();
                listViewItem.Items.Clear();
                SqlCommand ItemList = new SqlCommand("SELECT * FROM Item", sqlConnection);
                SqlDataReader reader = ItemList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[4];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        list[2] = reader.GetInt32(3).ToString();
                        comboBoxItem.Items.Add(reader.GetString(1));
                        list[3] = reader.GetSqlMoney(2).ToString();
                        ListViewItem lvi = new ListViewItem(list);
                        listViewItem.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                moneyItem.Enabled = false;
                buttonUpdateItem.Enabled = false;
                textBoxItem.Visible = false;
                buttonAddItem.Visible = false;
                buttonUpdateItem.Visible = true;
                comboBoxItem.Visible = true;
                buttonBackItem.Visible = false;
                buttonNewItem.Visible = true;
                textBoxItemStor.Enabled = false;
            }
        }

        private void listViewItem_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Item?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteItem = new SqlCommand("deleteItem", sqlConnection);
                deleteItem.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter itemId = new SqlParameter
                {
                    ParameterName = "@IdItem",
                    Value = listViewItem.FocusedItem.SubItems[0].Text
                };
                deleteItem.Parameters.Add(itemId);
                try
                {
                    deleteItem.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                listViewItem.Items.Clear();
                comboBoxItem.Items.Clear();
                SqlCommand ItemList = new SqlCommand("SELECT * FROM Item", sqlConnection);
                SqlDataReader reader = ItemList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[4];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        comboBoxItem.Items.Add(reader.GetString(1));
                        list[2] = reader.GetInt32(3).ToString();
                        list[3] = reader.GetSqlMoney(2).ToString();

                        ListViewItem lvi = new ListViewItem(list);
                        listViewItem.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                moneyItem.Enabled = false;
                buttonUpdateItem.Enabled = false;
                textBoxItem.Visible = false;
                buttonAddItem.Visible = false;
                buttonUpdateItem.Visible = true;
                comboBoxItem.Visible = true;
                buttonBackItem.Visible = false;
                buttonNewItem.Visible = true;
                textBoxItemStor.Enabled = false;
            }
        }

        private void textBoxTrains_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void buttonAddTrains_Click(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < listViewTrains.Items.Count; i++)
            {
                if (String.Equals(listViewTrains.Items[i].SubItems[1].Text.ToLower().Trim(), textBoxTrains.Text.ToLower()))
                {
                    flag = 1;
                }
            }
            if (textBoxTrains.Text=="")
            {
                MessageBox.Show("Please, name the train");
            } else if (comboBoxTrains.SelectedIndex==-1)
            {
                MessageBox.Show("Please, choose train's model");
            } else if (flag == 1)
            {
                MessageBox.Show("This name already exist");
            }
                else if (MessageBox.Show("Do you want to add new Train?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string boxName = textBoxTrains.Text;
                    string name = boxName.First().ToString().ToUpper() + String.Join("", boxName.Skip(1));
                    SqlCommand addModel = new SqlCommand("addTrain", sqlConnection);
                    addModel.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter modelName = new SqlParameter
                    {
                        ParameterName = "@TrainName",
                        Value = name
                    };
                    SqlParameter modelCost = new SqlParameter
                    {
                        ParameterName = "@ModelName",
                        Value = comboBoxTrains.SelectedItem
                    };
                    addModel.Parameters.Add(modelName);
                    addModel.Parameters.Add(modelCost);
                    addModel.ExecuteNonQuery();
                }
            listViewTrains.Items.Clear();
            textBoxTrains.Text = "";
            comboBoxTrains.SelectedIndex = -1;
            SqlCommand trainsList = new SqlCommand("SELECT MT.id, M.ModelName, MT.TrainName FROM ModelTrain MT JOIN Model M on M.id = MT.idModel", sqlConnection);
            SqlDataReader reader = trainsList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[3];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(2);
                    list[2] = reader.GetString(1);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewTrains.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
        }

        private void listViewTrains_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Train?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteModel = new SqlCommand("deleteTrains", sqlConnection);
                deleteModel.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter modelId = new SqlParameter
                {
                    ParameterName = "@IdTrain",
                    Value = listViewTrains.FocusedItem.SubItems[0].Text
                };
                deleteModel.Parameters.Add(modelId);
                try
                {
                    deleteModel.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                listViewTrains.Items.Clear();
                SqlCommand trainsList = new SqlCommand("SELECT MT.id, M.ModelName, MT.TrainName FROM ModelTrain MT JOIN Model M on M.id = MT.idModel", sqlConnection);
                SqlDataReader reader = trainsList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[3];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(2);
                        list[2] = reader.GetString(1);
                        ListViewItem lvi = new ListViewItem(list);
                        listViewTrains.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            string[] id = comboBoxAdmin.SelectedItem.ToString().Split(' ');
            SqlParameter idParam = new SqlParameter
            {
                ParameterName = "@IdAuth",
                Value = id[0]
            };
            try
            {
                SqlCommand MakeAdmin = new SqlCommand("MakeAdmin", sqlConnection);
                MakeAdmin.CommandType = System.Data.CommandType.StoredProcedure;
                MakeAdmin.Parameters.Add(idParam);
                MakeAdmin.ExecuteNonQuery();
                MessageBox.Show($"{id[1]} теперь Админ!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            comboBoxModer.Items.Clear();
            comboBoxAdmin.Items.Clear();
            listViewAdmin.Items.Clear();
            SqlCommand UserList = new SqlCommand("SELECT P.IdAuth, A.Login, P.First, P.Second From Passenger P JOIN Auth A on A.Id=P.IdAuth", sqlConnection);
            SqlDataReader reader = UserList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string list = reader.GetInt32(0).ToString() + " " + reader.GetString(1) + " | " + reader.GetString(2) + " " + reader.GetString(3);

                    ListViewItem lvi = new ListViewItem(list);
                    comboBoxAdmin.Items.Add(list);
                    comboBoxModer.Items.Add(list);
                }
                reader.Close();
            }
            SqlCommand AdminList = new SqlCommand("SELECT Administrator.Id, Auth.Login, Administrator.First, Administrator.Second FROM Administrator JOIN Auth on Auth.Id = Administrator.IdAuth", sqlConnection);
            reader = AdminList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[4];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    list[2] = reader.GetString(2);
                    list[3] = reader.GetString(3);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewAdmin.Items.Add(lvi);
                }
                reader.Close();
            }
        }

        private void listViewAdmin_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void listViewAdmin_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this user from Admins?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@IdAdmin",
                    Value = listViewAdmin.FocusedItem.SubItems[0].Text
                };
                try
                {
                    SqlCommand MakeAdmin = new SqlCommand("deleteAdmin", sqlConnection);
                    MakeAdmin.CommandType = System.Data.CommandType.StoredProcedure;
                    MakeAdmin.Parameters.Add(idParam);
                    MakeAdmin.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                comboBoxModer.Items.Clear();
                comboBoxAdmin.Items.Clear();
                listViewAdmin.Items.Clear();
                SqlCommand UserList = new SqlCommand("SELECT P.IdAuth, A.Login, P.First, P.Second From Passenger P JOIN Auth A on A.Id=P.IdAuth", sqlConnection);
                SqlDataReader reader = UserList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string list = reader.GetInt32(0).ToString() + " " + reader.GetString(1) + " | " + reader.GetString(2) + " " + reader.GetString(3);

                        ListViewItem lvi = new ListViewItem(list);
                        comboBoxAdmin.Items.Add(list);
                        comboBoxModer.Items.Add(list);
                    }
                    reader.Close();
                }
                SqlCommand AdminList = new SqlCommand("SELECT Administrator.Id, Auth.Login, Administrator.First, Administrator.Second FROM Administrator JOIN Auth on Auth.Id = Administrator.IdAuth", sqlConnection);
                reader = AdminList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[4];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        list[2] = reader.GetString(2);
                        list[3] = reader.GetString(3);
                        ListViewItem lvi = new ListViewItem(list);
                        listViewAdmin.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
            }
        }

        private void listViewModer_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this user from Moders?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlParameter idParam = new SqlParameter
                {
                    ParameterName = "@IdModer",
                    Value = listViewModer.FocusedItem.SubItems[0].Text
                };
                try
                {
                    SqlCommand MakeAdmin = new SqlCommand("deleteModer", sqlConnection);
                    MakeAdmin.CommandType = System.Data.CommandType.StoredProcedure;
                    MakeAdmin.Parameters.Add(idParam);
                    MakeAdmin.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                comboBoxModer.Items.Clear();
                comboBoxAdmin.Items.Clear();
                listViewModer.Items.Clear();
                SqlCommand UserList = new SqlCommand("SELECT P.IdAuth, A.Login, P.First, P.Second From Passenger P JOIN Auth A on A.Id=P.IdAuth", sqlConnection);
                SqlDataReader reader = UserList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string list = reader.GetInt32(0).ToString() + " " + reader.GetString(1) + " | " + reader.GetString(2) + " " + reader.GetString(3);

                        ListViewItem lvi = new ListViewItem(list);
                        comboBoxAdmin.Items.Add(list);
                        comboBoxModer.Items.Add(list);
                    }
                    reader.Close();
                }
                SqlCommand ModerList = new SqlCommand("SELECT Moderator.Id, Auth.Login, Moderator.First, Moderator.Second FROM Moderator JOIN Auth on Auth.Id = Moderator.IdAuth", sqlConnection);
                reader = ModerList.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[4];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        list[2] = reader.GetString(2);
                        list[3] = reader.GetString(3);
                        ListViewItem lvi = new ListViewItem(list);
                        listViewModer.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
            }
        }

        private void comboBoxModer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonModer_Click(object sender, EventArgs e)
        {
            string[] id = comboBoxModer.SelectedItem.ToString().Split(' ');
            SqlParameter idParam = new SqlParameter
            {
                ParameterName = "@IdAuth",
                Value = id[0]
            };
            try
            {
                SqlCommand MakeAdmin = new SqlCommand("MakeModer", sqlConnection);
                MakeAdmin.CommandType = System.Data.CommandType.StoredProcedure;
                MakeAdmin.Parameters.Add(idParam);
                MakeAdmin.ExecuteNonQuery();
                MessageBox.Show($"{id[1]} теперь Модератор!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            comboBoxModer.Items.Clear();
            listViewModer.Items.Clear();
            comboBoxAdmin.Items.Clear();
            SqlCommand UserList = new SqlCommand("SELECT P.IdAuth, A.Login, P.First, P.Second From Passenger P JOIN Auth A on A.Id=P.IdAuth", sqlConnection);
            SqlDataReader reader = UserList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string list = reader.GetInt32(0).ToString() + " " + reader.GetString(1) + " | " + reader.GetString(2) + " " + reader.GetString(3);

                    ListViewItem lvi = new ListViewItem(list);
                    comboBoxAdmin.Items.Add(list);
                    comboBoxModer.Items.Add(list);
                }
                reader.Close();
            }
            SqlCommand ModerList = new SqlCommand("SELECT Moderator.Id, Auth.Login, Moderator.First, Moderator.Second FROM Moderator JOIN Auth on Auth.Id = Moderator.IdAuth", sqlConnection);
            reader = ModerList.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[4];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    list[2] = reader.GetString(2);
                    list[3] = reader.GetString(3);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewModer.Items.Add(lvi);
                }
                reader.Close();
            }
        }

        private void buttonReincar_Click(object sender, EventArgs e)
        {
            SqlCommand delete = new SqlCommand("DELETE FROM Director", sqlConnection);
            delete.ExecuteNonQuery();
            MessageBox.Show("Legends Never Die!");
        }
    }
}


//UPDATE City SET cityCost ={Convert.ToDecimal(textBoxCityMoney.Value)} WHERE City.cityName = '{comboBoxCity.Text}';