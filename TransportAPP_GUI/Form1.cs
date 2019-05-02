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
                    ListBoxName.Items.Add(station.Name);
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

            Connections Verbindungen = t.GetConnections(txt_Von.Text, txt_Nach.Text);

            foreach (Connection connection in Verbindungen.ConnectionList)
            {
                DateTime Departure = DateTime.Parse(connection.From.Departure);
                DateTime Arrival = DateTime.Parse(connection.To.Arrival);
                try
                {
                    ListViewItem connection1 = new ListViewItem();
                    connection1.Text = Departure.ToShortTimeString();
                    connection1.SubItems.Add(Arrival.ToShortTimeString());

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
    }
}
