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
    public partial class Moder : Form
    {
        public Moder(string Login, int Id)
        {
            InitializeComponent();
            if (Login != null)
            {
                labelLogin.Text = Login;
            }
            else labelLogin.Text = "Error";
            IdModer.Text = Id.ToString();
        }

        private SqlConnection sqlConnection = null;
        private void Moder_Load(object sender, EventArgs e)
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
            SqlCommand schedFill = new SqlCommand($"SELECT Sch.Id, T.Name, C.cityName, T.Line, Sch.Departure, Sch.Arrival, MT.trainName FROM Schedule Sch JOIN Trip T on T.Id=Sch.IdTrip JOIN City C on C.id = T.IdDestinationCity JOIN ModelTrain MT on MT.id=T.IdTrain WHERE Sch.IdModerator = {IdModer.Text};", sqlConnection);
            SqlDataReader reader = schedFill.ExecuteReader();
            if (reader.HasRows)
            {
                listViewSched.Items.Clear();
                while (reader.Read())
                {
                    string[] list = new string[7];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    list[2] = reader.GetString(2);
                    list[3] = reader.GetInt32(3).ToString();
                    list[4] = reader.GetDateTime(4).ToString();
                    list[5] = reader.GetDateTime(5).ToString();
                    list[6] = reader.GetString(6);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewSched.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();

            SqlCommand trainFill = new SqlCommand("SELECT id, trainName FROM ModelTrain;", sqlConnection);
            reader = trainFill.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[2];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewTrains.Items.Add(lvi);
                }
                reader.Close();
            } else reader.Close();
            SqlCommand vagonFill = new SqlCommand("SELECT id, Name FROM Vagon;", sqlConnection);
            reader=vagonFill.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string list = reader.GetInt32(0).ToString()+" "+reader.GetString(1);
                    comboBoxVagons.Items.Add(list);
                }
                reader.Close();
            }
            else reader.Close();
        }

        private void labelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listViewSched_ItemActivate(object sender, EventArgs e)
        {
            comboBoxCity.Items.Clear();
            comboBoxLine.Items.Clear();
            comboBoxTrain.Items.Clear();
            dateTimePickerDepart.Value =Convert.ToDateTime(listViewSched.FocusedItem.SubItems[4].Text);
            dateTimePickerArriv.Value = Convert.ToDateTime(listViewSched.FocusedItem.SubItems[5].Text);
            idSched.Text = listViewSched.FocusedItem.SubItems[0].Text;
            idSched.Visible = true;
            labelTripName.Text = listViewSched.FocusedItem.SubItems[1].Text;
            labelTripName.Visible = true;
            SqlCommand city = new SqlCommand($"SELECT C.cityName FROM City C;",sqlConnection);
            SqlDataReader reader = city.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxCity.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
            comboBoxCity.SelectedItem = listViewSched.FocusedItem.SubItems[2].Text;
            comboBoxLine.Items.Add(1.ToString());
            comboBoxLine.Items.Add(2.ToString());
            comboBoxLine.Items.Add(3.ToString());
            comboBoxLine.Items.Add(4.ToString());
            comboBoxLine.SelectedItem = listViewSched.FocusedItem.SubItems[3].Text;
            SqlCommand train = new SqlCommand($"SELECT MT.trainName FROM ModelTrain MT;", sqlConnection);
            reader = train.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxTrain.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
            comboBoxTrain.SelectedItem = listViewSched.FocusedItem.SubItems[6].Text;
            comboBoxCity.Enabled = true;
            comboBoxLine.Enabled = true;
            comboBoxTrain.Enabled = true;
            dateTimePickerDepart.Enabled = true;
            dateTimePickerArriv.Enabled = true;
            buttonChange.Enabled = true;
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dateTimePickerDepart.Value >= dateTimePickerArriv.Value)
            {
                MessageBox.Show("Arrival must be after Departure");
            }
            else
            {
                SqlParameter idSchedule = new SqlParameter
                {
                    ParameterName = "@IdSched",
                    Value = Convert.ToInt32(idSched.Text)
                };
                SqlParameter cityName = new SqlParameter
                {
                    ParameterName = "@CityName",
                    Value = comboBoxCity.SelectedItem.ToString()
                };
                SqlParameter line = new SqlParameter
                {
                    ParameterName = "@Line",
                    Value = Convert.ToInt32(comboBoxLine.SelectedItem.ToString())
                };
                SqlParameter trainN = new SqlParameter
                {
                    ParameterName = "@Train",
                    Value = comboBoxTrain.SelectedItem.ToString()
                };
                SqlParameter depart = new SqlParameter
                {
                    ParameterName = "@Depart",
                    Value = dateTimePickerDepart.Value
                };
                SqlParameter arriv = new SqlParameter
                {
                    ParameterName = "@Arriv",
                    Value = dateTimePickerArriv.Value
                };
                SqlCommand schUpdate = new SqlCommand("SchedUpdate", sqlConnection);
                schUpdate.CommandType = System.Data.CommandType.StoredProcedure;
                schUpdate.Parameters.Add(idSchedule);
                schUpdate.Parameters.Add(cityName);
                schUpdate.Parameters.Add(line);
                schUpdate.Parameters.Add(trainN);
                schUpdate.Parameters.Add(depart);
                schUpdate.Parameters.Add(arriv);
                try
                {
                    schUpdate.ExecuteNonQuery();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                listViewSched.Items.Clear();
                SqlCommand schedFill = new SqlCommand($"SELECT Sch.Id, T.Name, C.cityName, T.Line, Sch.Departure, Sch.Arrival, MT.trainName FROM Schedule Sch JOIN Trip T on T.Id=Sch.IdTrip JOIN City C on C.id = T.IdDestinationCity JOIN ModelTrain MT on MT.id=T.IdTrain WHERE Sch.IdModerator = {IdModer.Text};", sqlConnection);
                SqlDataReader reader = schedFill.ExecuteReader();
                if (reader.HasRows)
                {
                    listViewSched.Items.Clear();
                    while (reader.Read())
                    {
                        string[] list = new string[7];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        list[2] = reader.GetString(2);
                        list[3] = reader.GetInt32(3).ToString();
                        list[4] = reader.GetDateTime(4).ToString();
                        list[5] = reader.GetDateTime(5).ToString();
                        list[6] = reader.GetString(6);
                        ListViewItem lvi = new ListViewItem(list);
                        listViewSched.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
                comboBoxCity.Enabled = false;
                comboBoxLine.Enabled = false;
                comboBoxTrain.Enabled = false;
                dateTimePickerDepart.Enabled = false;
                dateTimePickerArriv.Enabled = false;
                buttonChange.Enabled = false;
                idSched.Text = "None";
                labelTripName.Visible = false;
            }
        }

        private void listViewTrains_ItemActivate(object sender, EventArgs e)
        {
            listViewVagons.Items.Clear();
            SqlCommand getVagons = new SqlCommand($"SELECT Vagons.id, Vagon.Name FROM Vagons JOIN Vagon on Vagon.id = Vagons.idVagon WHERE Vagons.idTrain={listViewTrains.FocusedItem.SubItems[0].Text};",sqlConnection);
            SqlDataReader reader = getVagons.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[2];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewVagons.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
            comboBoxVagons.Enabled = true;
            buttonAddVagon.Enabled = true;
            TrainId.Text=listViewTrains.FocusedItem.SubItems[0].Text;
        }

        private void listViewVagons_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Vagon?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteVagon = new SqlCommand("deleteVagon",sqlConnection);
                deleteVagon.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter vagId = new SqlParameter
                {
                    ParameterName = "@IdVagons",
                    Value =Convert.ToInt32(listViewVagons.FocusedItem.SubItems[0].Text)
                };
                deleteVagon.Parameters.Add(vagId);
                try { deleteVagon.ExecuteNonQuery(); } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
                
                listViewVagons.Items.Clear();
                SqlCommand getVagons = new SqlCommand($"SELECT Vagons.id, Vagon.Name FROM Vagons JOIN Vagon on Vagon.id = Vagons.idVagon WHERE Vagons.idTrain={listViewTrains.FocusedItem.SubItems[0].Text};",sqlConnection);
                SqlDataReader reader = getVagons.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[2];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetString(1);
                        ListViewItem lvi = new ListViewItem(list);
                        listViewVagons.Items.Add(lvi);
                    }
                    reader.Close();
                }
                else reader.Close();
            }
        }

        private void buttonAddVagon_Click(object sender, EventArgs e)
        {
            if (listViewVagons.Items.Count > 4)
            {
                MessageBox.Show("Only 5 Vagons can be carried"); 
            }
            else if (comboBoxVagons.SelectedIndex == -1)
            {
                MessageBox.Show("Please, choose the Vagon");
            } else
            {
                string[] IdVagon = comboBoxVagons.SelectedItem.ToString().Split(' ');
                SqlCommand addVagon = new SqlCommand($"INSERT INTO Vagons (idVagon, idTrain) VALUES ({IdVagon[0]},{TrainId.Text});", sqlConnection);
                addVagon.ExecuteNonQuery();
            }
            listViewVagons.Items.Clear();
            SqlCommand getVagons = new SqlCommand($"SELECT Vagons.id, Vagon.Name FROM Vagons JOIN Vagon on Vagon.id = Vagons.idVagon WHERE Vagons.idTrain={listViewTrains.FocusedItem.SubItems[0].Text};", sqlConnection);
            SqlDataReader reader = getVagons.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[2];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetString(1);
                    ListViewItem lvi = new ListViewItem(list);
                    listViewVagons.Items.Add(lvi);
                }
                reader.Close();
            }
            else reader.Close();
        }
    }
}
