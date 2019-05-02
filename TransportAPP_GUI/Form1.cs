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

        public Form1()
        {
            InitializeComponent();
        }

        public void StationSuchen(string Stationsname, ListBox ListBoxName)
        {
            Stations Stations = t.GetStations(Stationsname);

            ListBoxName.Items.Clear();

            foreach (Station station in Stations.StationList)
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

        private void TextBoxBefuellung(ListBox ListBoxName, TextBox TextBoxName)
        {
            if (ListBoxName.SelectedIndex > -1)
            {
                TextBoxName.Text = ListBoxName.SelectedItems[0].ToString();
                ListBoxName.Items.Clear();
            }
        }

        private void Verbindung(ListView ListViewName)
        {
            ListViewName.Items.Clear();

            Connections connections = t.GetConnections(txt_Von.Text, txt_Nach.Text);

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
                    connection1.SubItems.Add(connection.From.Delay.ToString() + "min.");

                    ListViewName.Items.Add(connection1);
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

        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            Verbindung(listview_Ausgabe);
        }

        private void listbox_Von_DoubleClick(object sender, EventArgs e)
        {
            TextBoxBefuellung(listbox_Von, txt_Von);
        }

        private void listbox_Nach_DoubleClick(object sender, EventArgs e)
        {
            TextBoxBefuellung(listbox_Nach, txt_Nach);
        }

        private void txt_Bahnhof_TextChanged(object sender, EventArgs e)
        {
            StationSuchen(txt_Bahnhof.Text, listBox_Bahnhof);
        }

        private void listBox_Bahnhof_DoubleClick(object sender, EventArgs e)
        {
            TextBoxBefuellung(listBox_Bahnhof, txt_Bahnhof);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
