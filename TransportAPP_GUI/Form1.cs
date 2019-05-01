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
        public Form1()
        {
            InitializeComponent();
        }

        private void AdresseSuchen(string Stationsname, ComboBox ComboBoxName)
        {
            Transport t = new Transport();
            Stations MyStations = t.GetStations(Stationsname);

            foreach (Station station in MyStations.StationList)
            {
                ComboBoxName.Items.Add(station.Name);
            }
        }
        private void comboBox_Von_KeyDown(object sender, KeyEventArgs e)
        {
            comboBox_Von.DroppedDown = true;
            AdresseSuchen(comboBox_Von.Text, comboBox_Von);
        }
    }
}
