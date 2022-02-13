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
    public partial class Passenger : Form
    {
        
        public Passenger(string Login, int Id)
        {
            
            InitializeComponent();
            if (Login != null)
            {
                labelLogin.Text = Login;
            }
            else labelLogin.Text = "Error";
            IdPassenger.Text = Id.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private SqlConnection sqlConnection = null;
        private void Passenger_Load(object sender, EventArgs e)
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
        }

        
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            comboBoxCity.Items.Clear();
            comboBoxDate.Items.Clear();
            comboBoxModel.Items.Clear();
            comboBoxVagon.Items.Clear();
            listViewItems.Items.Clear();

            
            comboBoxCity.Items.Add(" ");
            comboBoxDate.Items.Add(" ");
            comboBoxModel.Items.Add(" ");
            comboBoxVagon.Items.Add(" ");
            comboBoxDate.SelectedIndex = 0;
            comboBoxCity.SelectedIndex = 0;
            comboBoxModel.SelectedIndex = 0;
            comboBoxVagon.SelectedIndex = 0;
            listView1.Items.Clear();
            buttonReturn.Visible = false;
            labelSelectOrd.Visible = false;
            IdOrderss.Visible = false;
            buttonOrder.Visible = false;
            SqlCommand cmd2 = new SqlCommand("TripInfo", sqlConnection);
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(6) > 0)
                    {
                        string[] list = new string[10];
                        list[0] = reader.GetString(0);
                        list[1] = reader.GetDateTime(1).ToString();
                        list[2] = reader.GetInt32(2).ToString();
                        list[3] = reader.GetString(3);
                        list[4] = reader.GetString(4);
                        list[5] = reader.GetSqlMoney(5).ToString();
                        list[6] = reader.GetInt32(6).ToString();
                        list[7] = reader.GetInt32(7).ToString();
                        list[8] = reader.GetInt32(8).ToString();
                        list[9] = reader.GetInt32(9).ToString();
                        ListViewItem lvi = new ListViewItem(list);

                        listView1.Items.Add(lvi);
                        listView1.Visible = true;
                        labelSchedule.Visible = true;
                        comboBoxCity.Visible = true;
                        comboBoxDate.Visible = true;
                        comboBoxModel.Visible = true;
                        comboBoxVagon.Visible = true;
                        labelFilter.Visible = true;
                        labelSortDestCity.Visible = true;
                        labelSortDate.Visible = true;
                        labelSortTrainModel.Visible = true;
                        labelSortVagon.Visible = true;
                        listViewItemHistory.Visible = false;
                        listViewOrderHistory.Visible = false;
                        buttonOrderHistory.Visible = true;
                    }

                    //reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToString(), reader.GetInt32(4).ToString()
                }
                reader.Close();
            } else reader.Close();
            SqlCommand cmdName = new SqlCommand("TripNameList", sqlConnection);
            cmdName.CommandType = System.Data.CommandType.StoredProcedure;
            reader = cmdName.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxCity.Items.Add(reader.GetString(0));
                }
                reader.Close();
            } else reader.Close();
            SqlCommand cmdDate = new SqlCommand("TripDateList", sqlConnection);
            cmdDate.CommandType = System.Data.CommandType.StoredProcedure;
            reader = cmdDate.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxDate.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand cmdModel = new SqlCommand("TripModelList", sqlConnection);
            cmdModel.CommandType = System.Data.CommandType.StoredProcedure;
            reader = cmdModel.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxModel.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand cmdVagon = new SqlCommand("TripVagonList", sqlConnection);
            cmdVagon.CommandType = System.Data.CommandType.StoredProcedure;
            reader = cmdVagon.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxVagon.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("You choosed Something");
        }
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            string[] list = new string[10];
            System.Int32 i = 0;
            while(i <list.Length) 
            {
                list[i] = listView1.SelectedItems[0].SubItems[i].Text;
                i++;
            }
            
            if (MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                listView1.Visible=false;
                labelSchedule.Visible=false;
                comboBoxCity.Visible = false;
                comboBoxDate.Visible = false;
                comboBoxModel.Visible = false;
                comboBoxVagon.Visible = false;
                labelFilter.Visible = false;
                labelSortDestCity.Visible = false;
                labelSortDate.Visible = false;
                labelSortTrainModel.Visible = false;
                labelSortVagon.Visible = false;
                buttonOrderHistory.Visible = false;
                labelPrice.Text = list[5];
                IdTrip.Text = list[7];
                IdVagons.Text = list[8];
                IdSched.Text = list[9];
                SqlCommand cmdItems = new SqlCommand($"SELECT I.Name, I.Price, I.Storage-(SELECT isNull(SUM(ShopList.counter),0) FROM ShopList JOIN Trip T on T.Id = ShopList.idTrip WHERE ShopList.idItems=I.Id AND ShopList.idTrip={IdTrip.Text}), I.Id FROM Item I;", sqlConnection);
                SqlDataReader readerItems = cmdItems.ExecuteReader();
                if (readerItems != null)
                {
                    string[] listItems = new string[4];
                    while (readerItems.Read())
                    { 
                        listItems[0] = readerItems.GetString(0);
                        listItems[1] = readerItems.GetSqlMoney(1).ToString();
                        listItems[2] = readerItems.GetInt32(2).ToString();
                        listItems[3] = readerItems.GetInt32(3).ToString();
                        ListViewItem lvi = new ListViewItem(listItems);

                        listViewItems.Items.Add(lvi);
                    }
                    readerItems.Close();
                } else readerItems.Close();
                listView3.Items.Clear();
                listViewItems.Visible = true;
                listView3.Visible = true;
                labelPrice.Visible = true;
                labelTotal.Visible = true;
                buttonBuy.Visible = true;
                buttonBack.Visible = true;
            }
        }
        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelSortName_Click(object sender, EventArgs e)
        {

        }

        private void listViewItems_ItemActivate(object sender, EventArgs e)
        {
            if (Convert.ToInt32(listViewItems.FocusedItem.SubItems[2].Text) <= 0)
            {
                MessageBox.Show("This Item is out of Stock");
            }
            else
            {
                int name = 0;
                int j = 0;
                int flag = 0;
                int flag2 = 0;
                int flag3 = 0;
                decimal totalPrice = Convert.ToDecimal(labelPrice.Text);

                if (listView3.Items.Count == 0)
                {
                    string[] list = new string[5];
                    int i = 0;
                    while (i < 2)
                    {
                        list[i] = listViewItems.FocusedItem.SubItems[i].Text;
                        i++;
                    }
                    list[2] = "1";
                    decimal count1 = Convert.ToDecimal(list[1].ToString());
                    decimal count2 = Convert.ToDecimal(list[2].ToString());
                    list[3] = Convert.ToString(count1 * count2);
                    list[4] = listViewItems.FocusedItem.SubItems[3].Text;
                    ListViewItem lvi = new ListViewItem(list);
                    listView3.Items.Add(lvi);
                    listView3.Visible = true;
                    flag3 = 1;
                    totalPrice = totalPrice + count1;
                    listViewItems.FocusedItem.SubItems[2].Text = Convert.ToString(Convert.ToInt32(listViewItems.FocusedItem.SubItems[2].Text) - 1);
                    labelPrice.Text = totalPrice.ToString();
                }
                else if (flag3 == 0)
                {
                    while (j < listView3.Items.Count)
                    {
                        if (listViewItems.FocusedItem.SubItems[name].Text == listView3.Items[j].SubItems[name].Text)
                        {

                            int lol = Convert.ToInt32(listView3.Items[j].SubItems[2].Text);
                            lol++;
                            listView3.Items[j].SubItems[2].Text = lol.ToString();
                            decimal count1 = Convert.ToDecimal(listView3.Items[j].SubItems[1].Text);
                            decimal count2 = Convert.ToDecimal(listView3.Items[j].SubItems[2].Text);
                            decimal count3 = count1 * count2;
                            totalPrice = totalPrice + count1;
                            listView3.Items[j].SubItems[3].Text = count3.ToString();
                            listViewItems.FocusedItem.SubItems[2].Text = Convert.ToString(Convert.ToInt32(listViewItems.FocusedItem.SubItems[2].Text) - 1);
                            flag = 1;
                            labelPrice.Text = totalPrice.ToString();
                        }
                        j++;
                    }
                    if (flag == 0)
                    {
                        flag2 = 1;
                    }
                    if (flag2 == 1)
                    {
                        string[] list = new string[5];
                        int i = 0;
                        while (i < 2)
                        {
                            list[i] = listViewItems.FocusedItem.SubItems[i].Text;
                            i++;
                        }
                        list[2] = "1";
                        decimal count1 = Convert.ToDecimal(list[1].ToString());
                        decimal count2 = Convert.ToDecimal(list[2].ToString());
                        list[3] = Convert.ToString(count1 * count2);
                        list[4] = listViewItems.FocusedItem.SubItems[3].Text;
                        ListViewItem lvi = new ListViewItem(list);
                        listView3.Items.Add(lvi);
                        listView3.Visible = true;
                        totalPrice = totalPrice + count1;
                        listViewItems.FocusedItem.SubItems[2].Text = Convert.ToString(Convert.ToInt32(listViewItems.FocusedItem.SubItems[2].Text) - 1);
                        labelPrice.Text = totalPrice.ToString();
                    }

                }
            }
            
        }
        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBoxVagon.SelectedItem != null && comboBoxCity.SelectedItem != null && comboBoxDate != null && comboBoxModel != null)
            {
                SqlCommand Filter = new SqlCommand($"SELECT C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, SUM(C.cityCost + M.costModel + V.vagonCost)/COUNT(V.vagonCost), SUM (V.Seats)- (SELECT COUNT(O.Id) FROM Orders O WHERE O.IdTrip=T.Id AND O.IdSched= Sch.Id AND O.IdVagons=Vg.id), T.Id, Vg.id, Sch.Id FROM Trip T JOIN City C on C.id=T.IdDestinationCity JOIN ModelTrain MT on MT.id=T.IdTrain JOIN Model M on M.id= MT.idModel JOIN Vagons Vg on Vg.idTrain=MT.id JOIN Vagon V on V.id=Vg.idVagon JOIN Schedule Sch on Sch.IdTrip=T.Id Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, T.Id, Vg.id, Sch.Id;", sqlConnection);
                SqlDataReader reader = Filter.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((reader.GetString(0) == comboBoxCity.SelectedItem.ToString() || comboBoxCity.SelectedItem.ToString() == " ") && (reader.GetDateTime(1).ToString().Contains(comboBoxDate.SelectedItem.ToString()) || comboBoxDate.SelectedItem.ToString() == " ") && (reader.GetString(3) == comboBoxModel.SelectedItem.ToString() || comboBoxModel.SelectedItem.ToString() == " ") && (reader.GetString(4) == comboBoxVagon.SelectedItem.ToString() || comboBoxVagon.SelectedItem.ToString() == " ") && (reader.GetInt32(6) > 0))
                        {
                            string[] list = new string[10];
                            list[0] = reader.GetString(0);
                            list[1] = reader.GetDateTime(1).ToString();
                            list[2] = reader.GetInt32(2).ToString();
                            list[3] = reader.GetString(3);
                            list[4] = reader.GetString(4);
                            list[5] = reader.GetSqlMoney(5).ToString();
                            list[6] = reader.GetInt32(6).ToString();
                            list[7] = reader.GetInt32(7).ToString();
                            list[8] = reader.GetInt32(8).ToString();
                            list[9] = reader.GetInt32(9).ToString();
                            ListViewItem lvi = new ListViewItem(list);
                            listView1.Items.Add(lvi);
                            listView1.Visible = true;
                            labelSchedule.Visible = true;
                        }
                        //reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToString(), reader.GetInt32(4).ToString()
                    }
                    reader.Close();
                }
                else reader.Close();
            }
        }

        private void comboBoxDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBoxVagon.SelectedItem != null && comboBoxCity.SelectedItem != null && comboBoxDate != null && comboBoxModel != null)
            {
                SqlCommand Filter = new SqlCommand($"SELECT C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, SUM(C.cityCost + M.costModel + V.vagonCost)/COUNT(V.vagonCost), SUM (V.Seats)- (SELECT COUNT(O.Id) FROM Orders O WHERE O.IdTrip=T.Id AND O.IdSched= Sch.Id AND O.IdVagons=Vg.id), T.Id, Vg.id, Sch.Id FROM Trip T JOIN City C on C.id=T.IdDestinationCity JOIN ModelTrain MT on MT.id=T.IdTrain JOIN Model M on M.id= MT.idModel JOIN Vagons Vg on Vg.idTrain=MT.id JOIN Vagon V on V.id=Vg.idVagon JOIN Schedule Sch on Sch.IdTrip=T.Id Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, T.Id, Vg.id, Sch.Id;", sqlConnection);
                SqlDataReader reader = Filter.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((reader.GetString(0) == comboBoxCity.SelectedItem.ToString() || comboBoxCity.SelectedItem.ToString() == " ") && (reader.GetDateTime(1).ToString().Contains(comboBoxDate.SelectedItem.ToString()) || comboBoxDate.SelectedItem.ToString() == " ") && (reader.GetString(3) == comboBoxModel.SelectedItem.ToString() || comboBoxModel.SelectedItem.ToString() == " ") && (reader.GetString(4) == comboBoxVagon.SelectedItem.ToString() || comboBoxVagon.SelectedItem.ToString() == " ") && (reader.GetInt32(6) > 0))
                        {
                            string[] list = new string[10];
                            list[0] = reader.GetString(0);
                            list[1] = reader.GetDateTime(1).ToString();
                            list[2] = reader.GetInt32(2).ToString();
                            list[3] = reader.GetString(3);
                            list[4] = reader.GetString(4);
                            list[5] = reader.GetSqlMoney(5).ToString();
                            list[6] = reader.GetInt32(6).ToString();
                            list[7] = reader.GetInt32(7).ToString();
                            list[8] = reader.GetInt32(8).ToString();
                            list[9] = reader.GetInt32(9).ToString();
                            ListViewItem lvi = new ListViewItem(list);
                            listView1.Items.Add(lvi);
                            listView1.Visible = true;
                            labelSchedule.Visible = true;
                        }

                        //reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToString(), reader.GetInt32(4).ToString()
                    }
                    reader.Close();
                }
                else reader.Close();
            }
        }

        private void comboBoxModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBoxVagon.SelectedItem != null && comboBoxCity.SelectedItem != null && comboBoxDate != null && comboBoxModel != null)
            {
                SqlCommand Filter = new SqlCommand($"SELECT C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, SUM(C.cityCost + M.costModel + V.vagonCost)/COUNT(V.vagonCost), SUM (V.Seats)- (SELECT COUNT(O.Id) FROM Orders O WHERE O.IdTrip=T.Id AND O.IdSched= Sch.Id AND O.IdVagons=Vg.id), T.Id, Vg.id, Sch.Id FROM Trip T JOIN City C on C.id=T.IdDestinationCity JOIN ModelTrain MT on MT.id=T.IdTrain JOIN Model M on M.id= MT.idModel JOIN Vagons Vg on Vg.idTrain=MT.id JOIN Vagon V on V.id=Vg.idVagon JOIN Schedule Sch on Sch.IdTrip=T.Id Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, T.Id, Vg.id, Sch.Id;", sqlConnection);
                SqlDataReader reader = Filter.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((reader.GetString(0) == comboBoxCity.SelectedItem.ToString() || comboBoxCity.SelectedItem.ToString() == " ") && (reader.GetDateTime(1).ToString().Contains(comboBoxDate.SelectedItem.ToString()) || comboBoxDate.SelectedItem.ToString() == " ") && (reader.GetString(3) == comboBoxModel.SelectedItem.ToString() || comboBoxModel.SelectedItem.ToString() == " ") && (reader.GetString(4) == comboBoxVagon.SelectedItem.ToString() || comboBoxVagon.SelectedItem.ToString() == " ") && (reader.GetInt32(6) > 0))
                        {
                            string[] list = new string[10];
                            list[0] = reader.GetString(0);
                            list[1] = reader.GetDateTime(1).ToString();
                            list[2] = reader.GetInt32(2).ToString();
                            list[3] = reader.GetString(3);
                            list[4] = reader.GetString(4);
                            list[5] = reader.GetSqlMoney(5).ToString();
                            list[6] = reader.GetInt32(6).ToString();
                            list[7] = reader.GetInt32(7).ToString();
                            list[8] = reader.GetInt32(8).ToString();
                            list[9] = reader.GetInt32(9).ToString();
                            ListViewItem lvi = new ListViewItem(list);
                            listView1.Items.Add(lvi);
                            listView1.Visible = true;
                            labelSchedule.Visible = true;
                        }

                        //reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToString(), reader.GetInt32(4).ToString()
                    }
                    reader.Close();
                }
                else reader.Close();
            }
        }

        private void comboBoxVagon_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBoxVagon.SelectedItem != null && comboBoxCity.SelectedItem != null && comboBoxDate != null && comboBoxModel != null)
            {
                SqlCommand Filter = new SqlCommand($"SELECT C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, SUM(C.cityCost + M.costModel + V.vagonCost)/COUNT(V.vagonCost), SUM (V.Seats)- (SELECT COUNT(O.Id) FROM Orders O WHERE O.IdTrip=T.Id AND O.IdSched= Sch.Id AND O.IdVagons=Vg.id), T.Id, Vg.id, Sch.Id FROM Trip T JOIN City C on C.id=T.IdDestinationCity JOIN ModelTrain MT on MT.id=T.IdTrain JOIN Model M on M.id= MT.idModel JOIN Vagons Vg on Vg.idTrain=MT.id JOIN Vagon V on V.id=Vg.idVagon JOIN Schedule Sch on Sch.IdTrip=T.Id Group by C.cityName, Sch.Departure, Sch.Duration, M.ModelName, V.Name, T.Id, Vg.id, Sch.Id;", sqlConnection);
                SqlDataReader reader = Filter.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if ((reader.GetString(0) == comboBoxCity.SelectedItem.ToString() || comboBoxCity.SelectedItem.ToString() == " ") && (reader.GetDateTime(1).ToString().Contains(comboBoxDate.SelectedItem.ToString()) || comboBoxDate.SelectedItem.ToString() == " ") && (reader.GetString(3) == comboBoxModel.SelectedItem.ToString() || comboBoxModel.SelectedItem.ToString() == " ") && (reader.GetString(4) == comboBoxVagon.SelectedItem.ToString() || comboBoxVagon.SelectedItem.ToString() == " ") && (reader.GetInt32(6) > 0))
                        {
                            string[] list = new string[10];
                            list[0] = reader.GetString(0);
                            list[1] = reader.GetDateTime(1).ToString();
                            list[2] = reader.GetInt32(2).ToString();
                            list[3] = reader.GetString(3);
                            list[4] = reader.GetString(4);
                            list[5] = reader.GetSqlMoney(5).ToString();
                            list[6] = reader.GetInt32(6).ToString();
                            list[7] = reader.GetInt32(7).ToString();
                            list[8] = reader.GetInt32(8).ToString();
                            list[9] = reader.GetInt32(9).ToString();
                            ListViewItem lvi = new ListViewItem(list);
                            listView1.Items.Add(lvi);
                            listView1.Visible = true;
                            labelSchedule.Visible = true;
                        }

                        //reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToString(), reader.GetInt32(4).ToString()
                    }
                    reader.Close();
                }
                else reader.Close();
            }
        }

        private void listView3_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

        }

        private void listView3_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void listView3_ItemActivate(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(listView3.FocusedItem.SubItems[2].Text);
            decimal price = Convert.ToDecimal(listView3.FocusedItem.SubItems[1].Text);
            int id = Convert.ToInt32(listView3.FocusedItem.SubItems[4].Text);
            count--;
            decimal totalPrice = Convert.ToDecimal(labelPrice.Text);
            if (count == 0)
            {
                listView3.FocusedItem.Remove();
                totalPrice = totalPrice - price;
                for (int i = 0; i< Convert.ToInt32(listViewItems.Items.Count); i++)
                {
                    if (Convert.ToInt32(listViewItems.Items[i].SubItems[3].Text) == id)
                    {
                        int stock = Convert.ToInt32(listViewItems.Items[i].SubItems[2].Text);
                        listViewItems.Items[i].SubItems[2].Text = Convert.ToString(stock+1);
                    }
                }
                labelPrice.Text = totalPrice.ToString();
            } else
            {
                listView3.FocusedItem.SubItems[3].Text = Convert.ToString(price*count);
                listView3.FocusedItem.SubItems[2].Text = Convert.ToString(count);
                for (int i = 0; i < Convert.ToInt32(listViewItems.Items.Count); i++)
                {
                    if (Convert.ToInt32(listViewItems.Items[i].SubItems[3].Text) == id)
                    {
                        int stock = Convert.ToInt32(listViewItems.Items[i].SubItems[2].Text);
                        listViewItems.Items[i].SubItems[2].Text = Convert.ToString(stock + 1);
                    }
                }
                totalPrice = totalPrice - price;
                labelPrice.Text = totalPrice.ToString();
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("MakeOrder", sqlConnection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter idTrip = new SqlParameter
                {
                    ParameterName = "@IdTrip",
                    Value = IdTrip.Text
                };
                SqlParameter idPass = new SqlParameter
                {
                    ParameterName = "@IdPass",
                    Value = IdPassenger.Text
                };
                SqlParameter idVagons = new SqlParameter
                {
                    ParameterName = "@IdVagons",
                    Value = IdVagons.Text
                };
                SqlParameter Cost = new SqlParameter
                {
                    ParameterName = "@Cost",
                    Value =Convert.ToDecimal(labelPrice.Text)
                };
                SqlParameter IdSch = new SqlParameter
                {
                    ParameterName = "@IdSched",
                    Value = Convert.ToDecimal(IdSched.Text)
                };

                cmd.Parameters.Add(idTrip);
                cmd.Parameters.Add(idPass);
                cmd.Parameters.Add(idVagons);
                cmd.Parameters.Add(IdSch);
                cmd.Parameters.Add(Cost);
                var resul = cmd.ExecuteScalar();
                cmd.Parameters.Remove(idTrip);
                cmd.Parameters.Remove(idPass);
                SqlParameter IdOrderShop = new SqlParameter
                {
                    ParameterName = "@IdOrder",
                    Value = Convert.ToInt32(resul)
                };
                SqlCommand cmdShop = new SqlCommand("MakeShoplist", sqlConnection);
                cmdShop.CommandType = System.Data.CommandType.StoredProcedure;
                cmdShop.Parameters.Add(idPass);
                cmdShop.Parameters.Add(idTrip);
                cmdShop.Parameters.Add(IdOrderShop);
                if (listView3.Items.Count > 0)
                {
                    int i = 0;
                    while (i < listView3.Items.Count)
                    {
                        SqlParameter IdItem =new SqlParameter
                        {
                            ParameterName = "@IdItem",
                            Value = Convert.ToInt32(listView3.Items[i].SubItems[4].Text)
                        };
                        SqlParameter count = new SqlParameter
                        {
                            ParameterName = "@count",
                            Value = Convert.ToInt32(listView3.Items[i].SubItems[2].Text)
                        };
                        cmdShop.Parameters.Add(IdItem);
                        cmdShop.Parameters.Add(count);
                        cmdShop.ExecuteNonQuery();
                        i++;
                        cmdShop.Parameters.Remove(IdItem);
                        cmdShop.Parameters.Remove(count);
                    }
                }
                
                
                MessageBox.Show("Congrats, You've bought it");
                buttonBuy.Visible = false;
                labelTotal.Visible = false;
                labelPrice.Visible = false;
                listViewItems.Visible = false;
                listView3.Visible = false;
                buttonOrder.Visible = true;
                buttonOrderHistory.Visible = true;
                buttonBack.Visible = false;
            }
        }

        private void buttonOrderHistory_Click(object sender, EventArgs e)
        {
            listViewItemHistory.Items.Clear();
            listViewOrderHistory.Items.Clear();
            
            SqlCommand OrderH = new SqlCommand("OrderInfo", sqlConnection);
            OrderH.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter IdPassanger = new SqlParameter
            {
                ParameterName = "@IdPassenger",
                Value = IdPassenger.Text
            };
            OrderH.Parameters.Add(IdPassanger);
            SqlDataReader reader = OrderH.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[8];
                    list[0] = reader.GetDateTime(0).ToString();
                    list[1] = reader.GetInt32(1).ToString();
                    list[2] = reader.GetString(2);
                    list[3] = reader.GetString(3);
                    list[4] = reader.GetString(4);
                    list[5] = reader.GetSqlMoney(5).ToString();
                    list[6] = reader.GetInt32(6).ToString();
                    list[7] = reader.GetInt32(7).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewOrderHistory.Items.Add(lvi);
                }
                reader.Close();
                listViewOrderHistory.Visible = true;
                listViewItemHistory.Visible = true;
                buttonOrderHistory.Visible = false;
                listView1.Visible = false;
                labelSchedule.Visible = false;
                comboBoxCity.Visible = false;
                comboBoxDate.Visible = false;
                comboBoxModel.Visible = false;
                comboBoxVagon.Visible = false;
                labelFilter.Visible = false;
                labelSortDestCity.Visible = false;
                labelSortDate.Visible = false;
                labelSortTrainModel.Visible = false;
                labelSortVagon.Visible = false;
                buttonOrder.Visible = true;
                buttonReturn.Visible = true;
                labelSelectOrd.Visible = true;
                IdOrderss.Visible = true;
            }
            else
            {
                MessageBox.Show("You don't have any orders yet");
                reader.Close();
            }
        }

        private void listViewOrderHistory_ItemActivate(object sender, EventArgs e)
        {
            listViewItemHistory.Items.Clear();
            buttonReturn.Enabled = true;
            SqlCommand itemslist = new SqlCommand("ItemHistory",sqlConnection);
            itemslist.CommandType = System.Data.CommandType.StoredProcedure;
            IdOrderss.Text = listViewOrderHistory.FocusedItem.SubItems[7].Text;
            SqlParameter IdPassangerr = new SqlParameter
            {
                ParameterName = "@idPass",
                Value = IdPassenger.Text
            };
            SqlParameter IdTrip = new SqlParameter
            {
                ParameterName = "@idTrip",
                Value = listViewOrderHistory.FocusedItem.SubItems[6].Text
            };
            SqlParameter IdOrder = new SqlParameter
            {
                ParameterName = "@idOrder",
                Value = listViewOrderHistory.FocusedItem.SubItems[7].Text
            };
            itemslist.Parameters.Add(IdPassangerr);
            itemslist.Parameters.Add(IdTrip);
            itemslist.Parameters.Add(IdOrder);
            SqlDataReader reader = itemslist.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[3];
                    list[0] = reader.GetString(0);
                    list[1] = reader.GetInt32(1).ToString();
                    list[2] = reader.GetSqlMoney(2).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewItemHistory.Items.Add(lvi);
                }
                reader.Close();

            }
            reader.Close();
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            listViewOrderHistory.Items.Clear();
            listViewItemHistory.Items.Clear();
            SqlParameter IdOrder = new SqlParameter
            {
                ParameterName = "@IdOrder",
                Value =Convert.ToInt32(IdOrderss.Text)
            };
            SqlCommand delOrd = new SqlCommand("deleteOrder",sqlConnection);
            delOrd.CommandType = System.Data.CommandType.StoredProcedure;
            delOrd.Parameters.Add(IdOrder);
            try
            {
                delOrd.ExecuteNonQuery();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            SqlCommand OrderH = new SqlCommand("OrderInfo", sqlConnection);
            OrderH.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter IdPassanger = new SqlParameter
            {
                ParameterName = "@IdPassenger",
                Value = IdPassenger.Text
            };
            OrderH.Parameters.Add(IdPassanger);
            SqlDataReader reader = OrderH.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] list = new string[8];
                    list[0] = reader.GetDateTime(0).ToString();
                    list[1] = reader.GetInt32(1).ToString();
                    list[2] = reader.GetString(2);
                    list[3] = reader.GetString(3);
                    list[4] = reader.GetString(4);
                    list[5] = reader.GetSqlMoney(5).ToString();
                    list[6] = reader.GetInt32(6).ToString();
                    list[7] = reader.GetInt32(7).ToString();
                    ListViewItem lvi = new ListViewItem(list);
                    listViewOrderHistory.Items.Add(lvi);
                }
                reader.Close();
                buttonReturn.Enabled = false;
            } else reader.Close();

        }

        private void IdOrderss_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            buttonBack.Visible = false;
            listView3.Visible = false;
            listViewItems.Visible = false;
            buttonBuy.Visible = false;
            labelTotal.Visible = false;
            labelPrice.Visible = false;
            comboBoxCity.Items.Clear();
            comboBoxDate.Items.Clear();
            comboBoxModel.Items.Clear();
            comboBoxVagon.Items.Clear();
            listViewItems.Items.Clear();


            comboBoxCity.Items.Add(" ");
            comboBoxDate.Items.Add(" ");
            comboBoxModel.Items.Add(" ");
            comboBoxVagon.Items.Add(" ");
            comboBoxDate.SelectedIndex = 0;
            comboBoxCity.SelectedIndex = 0;
            comboBoxModel.SelectedIndex = 0;
            comboBoxVagon.SelectedIndex = 0;
            listView1.Items.Clear();
            buttonReturn.Visible = false;
            labelSelectOrd.Visible = false;
            IdOrderss.Visible = false;
            buttonOrder.Visible = false;
            SqlCommand cmd2 = new SqlCommand("TripInfo", sqlConnection);
            cmd2.CommandType = System.Data.CommandType.StoredProcedure;
            SqlDataReader reader = cmd2.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    if (reader.GetInt32(6) > 0)
                    {
                        string[] list = new string[10];
                        list[0] = reader.GetString(0);
                        list[1] = reader.GetDateTime(1).ToString();
                        list[2] = reader.GetInt32(2).ToString();
                        list[3] = reader.GetString(3);
                        list[4] = reader.GetString(4);
                        list[5] = reader.GetSqlMoney(5).ToString();
                        list[6] = reader.GetInt32(6).ToString();
                        list[7] = reader.GetInt32(7).ToString();
                        list[8] = reader.GetInt32(8).ToString();
                        list[9] = reader.GetInt32(9).ToString();
                        ListViewItem lvi = new ListViewItem(list);

                        listView1.Items.Add(lvi);
                        listView1.Visible = true;
                        labelSchedule.Visible = true;
                        comboBoxCity.Visible = true;
                        comboBoxDate.Visible = true;
                        comboBoxModel.Visible = true;
                        comboBoxVagon.Visible = true;
                        labelFilter.Visible = true;
                        labelSortDestCity.Visible = true;
                        labelSortDate.Visible = true;
                        labelSortTrainModel.Visible = true;
                        labelSortVagon.Visible = true;
                        listViewItemHistory.Visible = false;
                        listViewOrderHistory.Visible = false;
                        buttonOrderHistory.Visible = true;
                    }

                    //reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToString(), reader.GetInt32(4).ToString()
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand cmdName = new SqlCommand("TripNameList", sqlConnection);
            cmdName.CommandType = System.Data.CommandType.StoredProcedure;
            reader = cmdName.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxCity.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand cmdDate = new SqlCommand("TripDateList", sqlConnection);
            cmdDate.CommandType = System.Data.CommandType.StoredProcedure;
            reader = cmdDate.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxDate.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand cmdModel = new SqlCommand("TripModelList", sqlConnection);
            cmdModel.CommandType = System.Data.CommandType.StoredProcedure;
            reader = cmdModel.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxModel.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
            SqlCommand cmdVagon = new SqlCommand("TripVagonList", sqlConnection);
            cmdVagon.CommandType = System.Data.CommandType.StoredProcedure;
            reader = cmdVagon.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    comboBoxVagon.Items.Add(reader.GetString(0));
                }
                reader.Close();
            }
            else reader.Close();
        }

    }
}
