using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Windows.Forms;
using SwissTransport;
using System.IO;

namespace TransportAPP_GUI
{
    public partial class Form1 : Form
    {
        //Membervariablen
        Transport t = new Transport();
       string filepath = null;


        //Form
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }


        //FindStation
        private void FindStation(string StationsName, ListBox ListBoxName)
        {
            Stations stations = t.GetStations(StationsName);

            ListBoxName.Items.Clear();

            foreach(Station station in stations.StationList)
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
                    MessageBox.Show("Geben Sie bitte eine gültige Station ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void txt_Von_TextChanged(object sender, EventArgs e)
        {
            FindStation(txt_Von.Text, listbox_Von);
        }

        private void txt_Nach_TextChanged(object sender, EventArgs e)
        {
            FindStation(txt_Nach.Text, listbox_Nach);
        }

        private void txt_Bahnhof_TextChanged(object sender, EventArgs e)
        {
            FindStation(txt_Bahnhof.Text, listbox_Bahnhof);
        }

        private void txt_Stationsfinder_TextChanged(object sender, EventArgs e)
        {
            FindStation(txt_Stationsfinder.Text, listbox_Stationsfinder);
        }


        //MoveToListBox
        private void MoveToListBox(KeyEventArgs e, TextBox TextBoxName, ListBox ListBoxName)
        {
            {
                try
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        ListBoxName.SelectedIndex--;
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        ListBoxName.SelectedIndex++;
                    }
                    else if (e.KeyCode == Keys.Enter)
                    {
                        TextBoxName.Text = ListBoxName.SelectedItems[0].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Die Befüllung der Textbox ist fehlgeschlagen", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void txt_Von_KeyDown(object sender, KeyEventArgs e)
        {
            MoveToListBox(e, txt_Von, listbox_Von);
        }

        private void txt_Nach_KeyDown(object sender, KeyEventArgs e)
        {
            MoveToListBox(e, txt_Nach, listbox_Nach);
        }

        private void txt_Bahnhof_KeyDown(object sender, KeyEventArgs e)
        {
            MoveToListBox(e, txt_Bahnhof, listbox_Bahnhof);
        }

        private void txt_Stationsfinder_KeyDown(object sender, KeyEventArgs e)
        {
            MoveToListBox(e, txt_Stationsfinder, listbox_Stationsfinder);
        }


        //FillTextBox
        private void FillTextBox(TextBox TextBoxName, ListBox ListBoxName)
        {
            if (ListBoxName.SelectedItems != null && ListBoxName.SelectedItems.Count > 0)
            {
                TextBoxName.Text = ListBoxName.SelectedItems[0].ToString();
            }
        }

        private void listbox_Von_MouseDoubleClick(object sender, MouseEventArgs e)
        { 
            FillTextBox(txt_Von, listbox_Von);
        }

        private void listbox_Nach_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FillTextBox(txt_Nach, listbox_Nach);
        }

        private void listbox_Bahnhof_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FillTextBox(txt_Bahnhof, listbox_Bahnhof);
        }

        private void listbox_Stationsfinder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            FillTextBox(txt_Stationsfinder, listbox_Stationsfinder);
        }


        //Connection        
        private void Connection(ListView ListViewName, String Abfahrtstation, String Zielstation)
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
                    connection1.SubItems.Add(connection.Duration.Replace("00d", "").Replace(":00", ""));
                    if (connection.To.Delay != null)
                    {
                        connection1.SubItems.Add(connection.From.Delay.ToString() + " min.");
                    }

                    ListViewName.Items.Add(connection1);
                }
                catch
                {
                    MessageBox.Show("Geben Sie bitte eine gültige Station ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Suchen_Click(object sender, EventArgs e)
        {  
                Connection(listview_Ausgabe, txt_Von.Text, txt_Nach.Text);
        }


        //CreateGoogleMaps
        private void CreateGoogleMaps(string StationName)
        {
            try
            {
                Station stations = t.GetStations(StationName).StationList.First();

                string XCoordinate = stations.Coordinate.XCoordinate.ToString();
                string YCoordinate = stations.Coordinate.YCoordinate.ToString();
                webBrowser.Url = new System.Uri("https://www.google.com/maps?q=" + XCoordinate.Replace(",", ".") + "," + YCoordinate.Replace(",", "."), System.UriKind.Absolute);
            }
            catch
            {
                MessageBox.Show("Geben Sie bitte eine gültige Station ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_SuchenStationsfinder_Click(object sender, EventArgs e)
        {
                CreateGoogleMaps(txt_Stationsfinder.Text);
        }


        //StationBoard
        private void StationBoard(string StationName, ListView ListViewName)
        {
            ListViewName.Items.Clear();
            
            Station station = t.GetStations(StationName).StationList.First();
            StationBoardRoot stationBoardRoot = t.GetStationBoard(StationName, station.Id);

            foreach(StationBoard stationBoard in stationBoardRoot.Entries)
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
                   MessageBox.Show("Die Abfahrtstafel konnte nicht angezeigt werden.", "Caption", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_SuchenAbfahrtstafel_Click(object sender, EventArgs e)
        {
            try
            {
                StationBoard(txt_Bahnhof.Text, listView_AbfahrtsTafel);
            }
            catch
            {
                MessageBox.Show("Geben Sie bitte eine gültige Station ein.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //ChangeTab
        private void ChangeTab(TabPage TabPageName)
        {
            tabControl.SelectTab(TabPageName);
        }

        private void btn_Fahrplan_Click(object sender, EventArgs e)
        {
            ChangeTab(tab_Fahrplan);
        }

        private void btn_Abfahrtstafel_Click(object sender, EventArgs e)
        {
            ChangeTab(tab_Abfahrtstafel);
        }

        private void btn_Stationsfinder_Click(object sender, EventArgs e)
        {
            ChangeTab(tab_Stationsfinder);
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

        private void btn_Stationsfinder_MouseEnter(object sender, EventArgs e)
        {
            ButtonFarbeAendern(btn_Stationsfinder, Color.DarkSlateGray);
        }

        private void btn_Stationsfinder_MouseLeave(object sender, EventArgs e)
        {
            ButtonFarbeAendern(btn_Stationsfinder, Color.Black);
        }


        //SwapStations
        private void SwapStations(TextBox TextBoxVonName, TextBox TextBoxNachName)
        {
            string StationVon = TextBoxVonName.Text;
            string StationNach = TextBoxNachName.Text;

            TextBoxNachName.Clear();
            TextBoxVonName.Clear();

            TextBoxNachName.Text = StationVon;
            TextBoxVonName.Text = StationNach;
        }

        private void btn_Swap_Click(object sender, EventArgs e)
        {
            SwapStations(txt_Von, txt_Nach);
        }

        //SendMail
        private void SendMail(String MailAdresse, ListView ListViewName)
        {
                   string[] headers = ListViewName.Columns
                               .OfType<ColumnHeader>()
                               .Select(header => header.Text.Trim())
                               .ToArray();

                    string[][] items = ListViewName.Items
                                .OfType<ListViewItem>()
                                .Select(lvi => lvi.SubItems
                                    .OfType<ListViewItem.ListViewSubItem>()
                                    .Select(si => si.Text).ToArray()).ToArray();

                    string table = string.Join(",", headers) + Environment.NewLine;
                    foreach (string[] a in items)
                    {
                        table += string.Join(",", a) + Environment.NewLine;
                    }
                    table = table.TrimEnd('\r', '\n');
                    
                    //Gerne hätte ich die Daten als .CSV in einem Ordner abgespeichert und dann in der E-Mail als Anhang gesendet. Leider kann ich die Datei nirgends hinspeichern, da ich keine Rechte habe. Die alten Zeilen habe ich im Code gelassen.
                    //  filepath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    // File.WriteAllText(filepath, table);

              
            try
            {
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("FahrplanAPPGillohner@gmail.com");
                mailMessage.To.Add(new MailAddress(MailAdresse));
                mailMessage.Subject = "FahrplanAPP";
                mailMessage.Body = "Hier ist ein Fahrplan, den ich mit dir teilen wollte: " + table;
                //mailMessage.Attachments.Add(new Attachment(filepath)); 
                mailMessage.IsBodyHtml = true;
                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.Host = "smtp.gmail.com";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("FahrplanAPPGillohner@gmail.com", "spDaq$zgp%Rd1vX0iOgR");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mailMessage);
                MessageBox.Show("Die E-Mail wurde erfolgreich versendet!", "Herzlichen Glückwunsch");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_SendByMail_Click(object sender, EventArgs e)
        {
            SendMail(txt_Mail.Text, listview_Ausgabe);
        }
    }
}
