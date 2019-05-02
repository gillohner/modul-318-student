using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport;

namespace TransportAPP_GUI
{
    public partial class Form1 : Form
    {

        //Membervariablen
        Transport t = new Transport();


        //Form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }


        //StationSuchen
        private void StationSuchen(string StationsName, ListBox ListBoxName)
        {
            Stations stations = t.GetStations(StationsName);

            ListBoxName.Items.Clear();

            foreach (Station station in stations.StationList)
            {
                try
                {
                    if(station.Id != null)
                    {
                        ListBoxName.Items.Add(station.Name);
                    }
                }
                catch
                {
                }
            }
        }

        private void txt_Von_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txt_Von.Text, listbox_Von);
        }

        private void txt_Nach_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txt_Nach.Text, listbox_Nach);
        }

        private void txt_Bahnhof_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txt_Bahnhof.Text, listBox_Bahnhof);
        }


        //TextBoxBefuellung
        private void TextBoxBefuellung(ListBox ListBoxName, TextBox TextBoxName)
        {
            if (ListBoxName.SelectedIndex > -1)
            {
                TextBoxName.Text = ListBoxName.SelectedItems[0].ToString();
                ListBoxName.Items.Clear();
            }
        }

        private void listbox_Von_DoubleClick(object sender, EventArgs e)
        {
            TextBoxBefuellung(listbox_Von, txt_Von);
        }

        private void listbox_Nach_DoubleClick(object sender, EventArgs e)
        {
            TextBoxBefuellung(listbox_Nach, txt_Nach);
        }

        private void listBox_Bahnhof_DoubleClick(object sender, EventArgs e)
        {
            TextBoxBefuellung(listBox_Bahnhof, txt_Bahnhof);
        }


        //Verbindung        
        private void Verbindung(ListView ListViewName, String Abfahrtstation, String Zielstation)
        {
            ListViewName.Items.Clear();

            Connections connections = t.GetConnections(Abfahrtstation, Zielstation);

            foreach (Connection connection in connections.ConnectionList)
            {
                DateTime Departure = DateTime.Parse(connection.From.Departure);
                DateTime Arrival = DateTime.Parse(connection.To.Arrival);
                try
                {
                    ListViewItem connection1 = new ListViewItem();
                    connection1.Text = null;
                    connection1.SubItems.Add(Departure.ToShortTimeString());
                    connection1.SubItems.Add(Arrival.ToShortTimeString());
                    connection1.SubItems.Add(connection.From.Station.Name);
                    connection1.SubItems.Add(connection.From.Platform);
                    connection1.SubItems.Add(connection.To.Station.Name);
                    connection1.SubItems.Add(connection.To.Platform);
                    connection1.SubItems.Add(connection.Duration);
                    if (connection.To.Delay != null)
                    {
                        connection1.SubItems.Add(connection.From.Delay.ToString() + " min.");
                    }

                    ListViewName.Items.Add(connection1);
                }
                catch
                {

                }
            }
        }

        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            Verbindung(listview_Ausgabe, txt_Von.Text, txt_Nach.Text);
        }


        //StationBoard
        private void StationBoard(string BahnhofName, ListView ListViewName)
        {
            ListViewName.Items.Clear();

            Station station = t.GetStations(BahnhofName).StationList.First();
            StationBoardRoot stationBoardRoot = t.GetStationBoard(BahnhofName, station.Id);

            foreach (StationBoard stationBoard in stationBoardRoot.Entries)
            {
                try
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = stationBoard.Name;
                    listViewItem.SubItems.Add(stationBoard.Stop.Departure.ToShortTimeString());
                    listViewItem.SubItems.Add(stationBoard.To);
                    listViewItem.SubItems.Add(stationBoard.Operator);

                    ListViewName.Items.Add(listViewItem);
                }
                catch
                {
                   // MessageBox.Show("Die Abfahrtstafel konnte nicht angezeigt werden.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_SuchenAbfahrtstafel_Click(object sender, EventArgs e)
        {
            StationBoard(txt_Bahnhof.Text, listView_AbfahrtsTafel);
        }


        //Tab wechseln mit Buttons
        private void TabWechseln(TabPage TabPageName)
        {
            tabControl.SelectTab(TabPageName);
        }

        private void btn_Fahrplan_Click(object sender, EventArgs e)
        {
            TabWechseln(tab_Fahrplan);
        }

        private void btn_Abfahrtstafel_Click(object sender, EventArgs e)
        {
            TabWechseln(tab_Abfahrtstafel);
        }


        //Button Farbe aendern
        private void ButtonFarbeAendern(Button ButtonName, Color ColorName)
        {
            ButtonName.BackColor = ColorName;
        }

        private void btn_Fahrplan_MouseEnter(object sender, EventArgs e)
        {
            ButtonFarbeAendern(btn_Fahrplan, Color.DarkSlateGray);
        }

        private void btn_Fahrplan_MouseLeave(object sender, EventArgs e)
        {
            ButtonFarbeAendern(btn_Fahrplan, Color.Black);
        }

        private void btn_Abfahrtstafel_MouseEnter(object sender, EventArgs e)
        {
            ButtonFarbeAendern(btn_Abfahrtstafel, Color.DarkSlateGray);
        }

        private void btn_Abfahrtstafel_MouseLeave(object sender, EventArgs e)
        {
            ButtonFarbeAendern(btn_Abfahrtstafel, Color.Black);
        }
    }
}
