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
    public partial class Admin : Form
    {
        public Admin(string Login, int Id)
        {
            InitializeComponent();
            if (Login != null)
            {
                labelLogin.Text = Login;
            }
            else labelLogin.Text = "Error";
            IdAdmin.Text = Id.ToString();
        }
         
        private void IdAdmin_Click(object sender, EventArgs e)
        {

        }

        private SqlConnection sqlConnection = null;
        private void Admin_Load(object sender, EventArgs e)
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

            SqlCommand tripInfo = new SqlCommand("SELECT T.Id, MT.id, MT.trainName, C.id, C.cityName, T.Name, T.Line FROM Trip T JOIN ModelTrain MT on MT.id=T.IdTrain JOIN City C on C.id=T.IdDestinationCity;", sqlConnection);
            SqlDataReader reader = tripInfo.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[7];
                    list[0] = reader.GetInt32(0).ToString();
                    list[1] = reader.GetInt32(1).ToString();
                    list[2] = reader.GetString(2);
                    list[3] = reader.GetInt32(3).ToString();
                    list[4] = reader.GetString(4);
                    list[5] = reader.GetString(5);
                    list[6] = reader.GetInt32(6).ToString();
                    ListViewItem tinf = new ListViewItem(list);
                    listViewTrips.Items.Add(tinf);
                } reader.Close();
            } else reader.Close();

            SqlCommand schedInfo = new SqlCommand("SELECT Sch.Id, Sch.IdTrip, T.Name, Sch.Departure, Sch.Arrival, Sch.Duration, Sch.IdModerator, M.First FROM Schedule Sch JOIN Moderator M on M.Id=Sch.IdModerator JOIN Trip T on T.Id=Sch.IdTrip;", sqlConnection);
            SqlDataReader readers = schedInfo.ExecuteReader();
            if (readers.HasRows)
            {
                while (readers.Read())
                {
                    string[] list = new string[8];
                    list[0] = readers.GetInt32(0).ToString();
                    list[1] = readers.GetInt32(1).ToString();
                    list[2] = readers.GetString(2);
                    list[3] = readers.GetDateTime(3).ToString();
                    list[4] = readers.GetDateTime(4).ToString();
                    list[5] = readers.GetInt32(5).ToString();
                    list[6] = readers.GetInt32(6).ToString();
                    list[7] = readers.GetString(7);
                    ListViewItem tinf = new ListViewItem(list);
                    listViewSched.Items.Add(tinf);
                }
                readers.Close();
            }
            else readers.Close();
            SqlCommand TrainList = new SqlCommand("SELECT MT.trainName FROM ModelTrain MT;", sqlConnection);
            SqlDataReader Train = TrainList.ExecuteReader();
            if (Train.HasRows)
            {
                while(Train.Read())
                {
                    comboBoxTrain.Items.Add(Train.GetString(0));
                } Train.Close();
            } else Train.Close();
            SqlCommand CityList = new SqlCommand("SELECT C.cityName FROM City C;", sqlConnection);
            SqlDataReader City = CityList.ExecuteReader();
            if (City.HasRows)
            {
                while (City.Read())
                {
                    comboBoxCity.Items.Add(City.GetString(0));
                } City.Close();
            } else City.Close();
            comboBoxLine.Items.Add(1);
            comboBoxLine.Items.Add(2);
            comboBoxLine.Items.Add(3);
            comboBoxLine.Items.Add(4);
            SqlCommand tripNamelist = new SqlCommand("SELECT Name FROM Trip;", sqlConnection);
            SqlDataReader tripNameReader = tripNamelist.ExecuteReader();
            if (tripNameReader.HasRows)
            {
                while (tripNameReader.Read())
                {
                    comboBoxTrip.Items.Add(tripNameReader.GetString(0));
                }
                tripNameReader.Close();
            }
            else tripNameReader.Close();

            SqlCommand moderNamelist = new SqlCommand("SELECT Id, First, Second FROM Moderator;", sqlConnection);
            SqlDataReader moderNameReader = moderNamelist.ExecuteReader();
            if (moderNameReader.HasRows)
            {
                while (moderNameReader.Read())
                {
                    comboBoxModer.Items.Add(moderNameReader.GetInt32(0)+" "+moderNameReader.GetString(1)+" "+ moderNameReader.GetString(2));
                }
                moderNameReader.Close();
            }
            else moderNameReader.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int flag = 0;
            for (int i = 0; i < listViewTrips.Items.Count; i++)
            {
                if (String.Equals(listViewTrips.Items[i].SubItems[5].Text.ToString().ToLower().Trim(), textBoxName.Text.ToLower()))
                {
                    flag = 1;
                }
            }
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Please, write Trip's name");
            }
            else if (flag == 1)
            {
                MessageBox.Show("This Trip name already exist");
            }
            else if (comboBoxTrain.SelectedIndex != -1 && comboBoxCity.SelectedIndex!= -1 && comboBoxLine.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Ура");
                try
                {
                    SqlParameter trainName = new SqlParameter
                    {
                        ParameterName = "@TrainName",
                        Value = comboBoxTrain.SelectedItem.ToString()
                    };
                    SqlParameter cityName = new SqlParameter
                    {
                        ParameterName = "@CityName",
                        Value = comboBoxCity.SelectedItem.ToString()
                    };
                    SqlParameter tripName = new SqlParameter
                    {
                        ParameterName = "@TripName",
                        Value = textBoxName.Text
                    };
                    SqlParameter line = new SqlParameter
                    {
                        ParameterName = "@Line",
                        Value = Convert.ToInt32(comboBoxLine.SelectedItem.ToString())

                    };
                    SqlCommand addTrip = new SqlCommand("AddTrip", sqlConnection);
                    addTrip.CommandType = System.Data.CommandType.StoredProcedure;
                    addTrip.Parameters.Add(trainName);
                    addTrip.Parameters.Add(cityName);
                    addTrip.Parameters.Add(tripName);
                    addTrip.Parameters.Add(line);
                    addTrip.ExecuteNonQuery();
                } catch(Exception ex)
                { 
                    MessageBox.Show(ex.ToString());
                }
                listViewTrips.Items.Clear();
                SqlCommand tripInfo = new SqlCommand("SELECT T.Id, MT.id, MT.trainName, C.id, C.cityName, T.Name, T.Line FROM Trip T JOIN ModelTrain MT on MT.id=T.IdTrain JOIN City C on C.id=T.IdDestinationCity;", sqlConnection);
                SqlDataReader reader = tripInfo.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[7];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetInt32(1).ToString();
                        list[2] = reader.GetString(2);
                        list[3] = reader.GetInt32(3).ToString();
                        list[4] = reader.GetString(4);
                        list[5] = reader.GetString(5);
                        list[6] = reader.GetInt32(6).ToString();
                        ListViewItem tinf = new ListViewItem(list);
                        listViewTrips.Items.Add(tinf);
                    }
                    reader.Close();
                }
                else reader.Close();
                comboBoxTrip.Items.Clear();
                comboBoxModer.Items.Clear();
                SqlCommand tripNamelist = new SqlCommand("SELECT Name FROM Trip;", sqlConnection);
                SqlDataReader tripNameReader = tripNamelist.ExecuteReader();
                if (tripNameReader.HasRows)
                {
                    while (tripNameReader.Read())
                    {
                        comboBoxTrip.Items.Add(tripNameReader.GetString(0));
                    }
                    tripNameReader.Close();
                }
                else tripNameReader.Close();

                SqlCommand moderNamelist = new SqlCommand("SELECT Id, First, Second FROM Moderator;", sqlConnection);
                SqlDataReader moderNameReader = moderNamelist.ExecuteReader();
                if (moderNameReader.HasRows)
                {
                    while (moderNameReader.Read())
                    {
                        comboBoxModer.Items.Add(moderNameReader.GetInt32(0) + " " + moderNameReader.GetString(1) + " " + moderNameReader.GetString(2));
                    }
                    moderNameReader.Close();
                }
                else moderNameReader.Close();
            } else MessageBox.Show("Please, Fill everything");
        }

        private void labelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void listViewTrips_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Trip?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteTrip = new SqlCommand("DeleteTrip",sqlConnection);
                deleteTrip.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter tripId = new SqlParameter
                {
                    ParameterName = "@IdTrip",
                    Value = listViewTrips.FocusedItem.SubItems[0].Text
                };
                deleteTrip.Parameters.Add(tripId);
                try
                {
                    deleteTrip.ExecuteNonQuery();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                listViewTrips.Items.Clear();
                SqlCommand tripInfo = new SqlCommand("SELECT T.Id, MT.id, MT.trainName, C.id, C.cityName, T.Name, T.Line FROM Trip T JOIN ModelTrain MT on MT.id=T.IdTrain JOIN City C on C.id=T.IdDestinationCity;", sqlConnection);
                SqlDataReader reader = tripInfo.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] list = new string[7];
                        list[0] = reader.GetInt32(0).ToString();
                        list[1] = reader.GetInt32(1).ToString();
                        list[2] = reader.GetString(2);
                        list[3] = reader.GetInt32(3).ToString();
                        list[4] = reader.GetString(4);
                        list[5] = reader.GetString(5);
                        list[6] = reader.GetInt32(6).ToString();
                        ListViewItem tinf = new ListViewItem(list);
                        listViewTrips.Items.Add(tinf);
                    }
                    reader.Close();
                }
                else reader.Close();
                listViewSched.Items.Clear();
                SqlCommand schedInfo = new SqlCommand("SELECT Sch.Id, Sch.IdTrip, T.Name, Sch.Departure, Sch.Arrival, Sch.Duration, Sch.IdModerator, M.First FROM Schedule Sch JOIN Moderator M on M.Id=Sch.IdModerator JOIN Trip T on T.Id=Sch.IdTrip;", sqlConnection);
                SqlDataReader readers = schedInfo.ExecuteReader();
                if (readers.HasRows)
                {
                    while (readers.Read())
                    {
                        string[] list = new string[8];
                        list[0] = readers.GetInt32(0).ToString();
                        list[1] = readers.GetInt32(1).ToString();
                        list[2] = readers.GetString(2);
                        list[3] = readers.GetDateTime(3).ToString();
                        list[4] = readers.GetDateTime(4).ToString();
                        list[5] = readers.GetInt32(5).ToString();
                        list[6] = readers.GetInt32(6).ToString();
                        list[7] = readers.GetString(7);
                        ListViewItem tinf = new ListViewItem(list);
                        listViewSched.Items.Add(tinf);
                    }
                    readers.Close();
                }
                else readers.Close();
                comboBoxModer.Items.Clear();
                SqlCommand moderNamelist = new SqlCommand("SELECT Id, First, Second FROM Moderator;", sqlConnection);
                SqlDataReader moderNameReader = moderNamelist.ExecuteReader();
                if (moderNameReader.HasRows)
                {
                    while (moderNameReader.Read())
                    {
                        comboBoxModer.Items.Add(moderNameReader.GetInt32(0) + " " + moderNameReader.GetString(1) + " " + moderNameReader.GetString(2));
                    }
                    moderNameReader.Close();
                }
                else moderNameReader.Close();
                comboBoxTrip.Items.Clear();
                SqlCommand tripNamelist = new SqlCommand("SELECT Name FROM Trip;", sqlConnection);
                SqlDataReader tripNameReader = tripNamelist.ExecuteReader();
                if (tripNameReader.HasRows)
                {
                    while (tripNameReader.Read())
                    {
                        comboBoxTrip.Items.Add(tripNameReader.GetString(0));
                    }
                    tripNameReader.Close();
                }
                else tripNameReader.Close();
            }
        }

        private void buttonSched_Click(object sender, EventArgs e)
        {
            if (comboBoxTrip.SelectedIndex == -1 || comboBoxModer.SelectedIndex == -1)
            {
                MessageBox.Show("Please, select everything");
            }
            else if (dateTimePickerDepart.Value >= dateTimePickerArriv.Value)
            {
                MessageBox.Show("Arrival time can't be before Departure");
            }
            else
            {
                try
                {
                    
                    SqlCommand addSch = new SqlCommand("AddSched", sqlConnection);
                    addSch.CommandType = System.Data.CommandType.StoredProcedure;
                    string[] moderInfo = comboBoxModer.SelectedItem.ToString().Split(' ');
                    SqlParameter modId = new SqlParameter
                    {
                        ParameterName = "@IdModer",
                        Value = int.Parse(moderInfo[0])
                    };

                    SqlParameter tripName = new SqlParameter
                    {
                        ParameterName = "@TripName",
                        Value = comboBoxTrip.SelectedItem.ToString()
                    };
                    SqlParameter departure = new SqlParameter
                    {
                        ParameterName = "@Departure",
                        Value = dateTimePickerDepart.Value
                    };
                    SqlParameter arrival = new SqlParameter
                    {
                        ParameterName = "@Arrival",
                        Value = dateTimePickerArriv.Value
                    };
                    addSch.Parameters.Add(modId);
                    addSch.Parameters.Add(tripName);
                    addSch.Parameters.Add(departure);
                    addSch.Parameters.Add(arrival);
                    addSch.ExecuteNonQuery();
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            listViewSched.Items.Clear();
            SqlCommand schedInfo = new SqlCommand("SELECT Sch.Id, Sch.IdTrip, T.Name, Sch.Departure, Sch.Arrival, Sch.Duration, Sch.IdModerator, M.First FROM Schedule Sch JOIN Moderator M on M.Id=Sch.IdModerator JOIN Trip T on T.Id=Sch.IdTrip;", sqlConnection);
            SqlDataReader readers = schedInfo.ExecuteReader();
            if (readers.HasRows)
            {
                while (readers.Read())
                {
                    string[] list = new string[8];
                    list[0] = readers.GetInt32(0).ToString();
                    list[1] = readers.GetInt32(1).ToString();
                    list[2] = readers.GetString(2);
                    list[3] = readers.GetDateTime(3).ToString();
                    list[4] = readers.GetDateTime(4).ToString();
                    list[5] = readers.GetInt32(5).ToString();
                    list[6] = readers.GetInt32(6).ToString();
                    list[7] = readers.GetString(7);
                    ListViewItem tinf = new ListViewItem(list);
                    listViewSched.Items.Add(tinf);
                }
                readers.Close();
            } else readers.Close();
        }

        private void listViewSched_ItemActivate(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this Schedule?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand deleteSched = new SqlCommand("deleteSched", sqlConnection);
                deleteSched.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter schedId = new SqlParameter
                {
                    ParameterName = "@IdSched",
                    Value = listViewSched.FocusedItem.SubItems[0].Text
                };
                deleteSched.Parameters.Add(schedId);
                try
                {
                    deleteSched.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                listViewSched.Items.Clear();
                SqlCommand schedInfo = new SqlCommand("SELECT Sch.Id, Sch.IdTrip, T.Name, Sch.Departure, Sch.Arrival, Sch.Duration, Sch.IdModerator, M.First FROM Schedule Sch JOIN Moderator M on M.Id=Sch.IdModerator JOIN Trip T on T.Id=Sch.IdTrip;", sqlConnection);
                SqlDataReader readers = schedInfo.ExecuteReader();
                if (readers.HasRows)
                {
                    while (readers.Read())
                    {
                        string[] list = new string[8];
                        list[0] = readers.GetInt32(0).ToString();
                        list[1] = readers.GetInt32(1).ToString();
                        list[2] = readers.GetString(2);
                        list[3] = readers.GetDateTime(3).ToString();
                        list[4] = readers.GetDateTime(4).ToString();
                        list[5] = readers.GetInt32(5).ToString();
                        list[6] = readers.GetInt32(6).ToString();
                        list[7] = readers.GetString(7);
                        ListViewItem tinf = new ListViewItem(list);
                        listViewSched.Items.Add(tinf);
                    }
                    readers.Close();
                }
                else readers.Close();
            }
        }
    }
}
