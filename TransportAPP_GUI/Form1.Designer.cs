namespace TransportAPP_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Fahrplan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Abfahrtstafel = new System.Windows.Forms.Button();
            this.btn_Stationsfinder = new System.Windows.Forms.Button();
            this.tab_Stationsfinder = new System.Windows.Forms.TabPage();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.txt_Stationsfinder = new System.Windows.Forms.TextBox();
            this.btn_SuchenStationsfinder = new System.Windows.Forms.Button();
            this.listbox_Stationsfinder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Stationsfinder = new System.Windows.Forms.Label();
            this.tab_Abfahrtstafel = new System.Windows.Forms.TabPage();
            this.listView_AbfahrtsTafel = new System.Windows.Forms.ListView();
            this.column_AT_ZugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_AT_Abfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_AT_Richtung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnBetreiber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Bahnhof = new System.Windows.Forms.TextBox();
            this.btn_SuchenAbfahrtstafel = new System.Windows.Forms.Button();
            this.listbox_Bahnhof = new System.Windows.Forms.ListBox();
            this.lbl_Station = new System.Windows.Forms.Label();
            this.lbl_Abfahrtstafel = new System.Windows.Forms.Label();
            this.tab_Fahrplan = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.btn_Mail = new System.Windows.Forms.Button();
            this.btn_Swap = new System.Windows.Forms.Button();
            this.listview_Ausgabe = new System.Windows.Forms.ListView();
            this.columnZugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGleisVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerspaetung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Nach = new System.Windows.Forms.TextBox();
            this.txt_Von = new System.Windows.Forms.TextBox();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.listbox_Nach = new System.Windows.Forms.ListBox();
            this.listbox_Von = new System.Windows.Forms.ListBox();
            this.lbl_Nach = new System.Windows.Forms.Label();
            this.lbl_Von = new System.Windows.Forms.Label();
            this.lbl_Fahrplan = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_Stationsfinder.SuspendLayout();
            this.tab_Abfahrtstafel.SuspendLayout();
            this.tab_Fahrplan.SuspendLayout();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Fahrplan
            // 
            this.btn_Fahrplan.BackColor = System.Drawing.Color.Black;
            this.btn_Fahrplan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Fahrplan.FlatAppearance.BorderSize = 0;
            this.btn_Fahrplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Fahrplan.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fahrplan.ForeColor = System.Drawing.Color.White;
            this.btn_Fahrplan.Location = new System.Drawing.Point(-1, 192);
            this.btn_Fahrplan.Name = "btn_Fahrplan";
            this.btn_Fahrplan.Size = new System.Drawing.Size(229, 74);
            this.btn_Fahrplan.TabIndex = 0;
            this.btn_Fahrplan.Text = "Fahrplan";
            this.btn_Fahrplan.UseVisualStyleBackColor = false;
            this.btn_Fahrplan.Click += new System.EventHandler(this.btn_Fahrplan_Click);
            this.btn_Fahrplan.MouseEnter += new System.EventHandler(this.btn_Fahrplan_MouseEnter);
            this.btn_Fahrplan.MouseLeave += new System.EventHandler(this.btn_Fahrplan_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 33);
            this.panel1.TabIndex = 22;
            // 
            // btn_Abfahrtstafel
            // 
            this.btn_Abfahrtstafel.BackColor = System.Drawing.Color.Black;
            this.btn_Abfahrtstafel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Abfahrtstafel.FlatAppearance.BorderSize = 0;
            this.btn_Abfahrtstafel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Abfahrtstafel.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abfahrtstafel.ForeColor = System.Drawing.Color.White;
            this.btn_Abfahrtstafel.Location = new System.Drawing.Point(-1, 270);
            this.btn_Abfahrtstafel.Name = "btn_Abfahrtstafel";
            this.btn_Abfahrtstafel.Size = new System.Drawing.Size(229, 74);
            this.btn_Abfahrtstafel.TabIndex = 1;
            this.btn_Abfahrtstafel.Text = "Abfahrtstafel";
            this.btn_Abfahrtstafel.UseVisualStyleBackColor = false;
            this.btn_Abfahrtstafel.Click += new System.EventHandler(this.btn_Abfahrtstafel_Click);
            this.btn_Abfahrtstafel.MouseEnter += new System.EventHandler(this.btn_Abfahrtstafel_MouseEnter);
            this.btn_Abfahrtstafel.MouseLeave += new System.EventHandler(this.btn_Abfahrtstafel_MouseLeave);
            // 
            // btn_Stationsfinder
            // 
            this.btn_Stationsfinder.BackColor = System.Drawing.Color.Black;
            this.btn_Stationsfinder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Stationsfinder.FlatAppearance.BorderSize = 0;
            this.btn_Stationsfinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Stationsfinder.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stationsfinder.ForeColor = System.Drawing.Color.White;
            this.btn_Stationsfinder.Location = new System.Drawing.Point(-1, 348);
            this.btn_Stationsfinder.Name = "btn_Stationsfinder";
            this.btn_Stationsfinder.Size = new System.Drawing.Size(229, 74);
            this.btn_Stationsfinder.TabIndex = 2;
            this.btn_Stationsfinder.Text = "Stationsfinder";
            this.btn_Stationsfinder.UseVisualStyleBackColor = false;
            this.btn_Stationsfinder.Click += new System.EventHandler(this.btn_Stationsfinder_Click);
            this.btn_Stationsfinder.MouseEnter += new System.EventHandler(this.btn_Stationsfinder_MouseEnter);
            this.btn_Stationsfinder.MouseLeave += new System.EventHandler(this.btn_Stationsfinder_MouseLeave);
            // 
            // tab_Stationsfinder
            // 
            this.tab_Stationsfinder.Controls.Add(this.webBrowser);
            this.tab_Stationsfinder.Controls.Add(this.txt_Stationsfinder);
            this.tab_Stationsfinder.Controls.Add(this.btn_SuchenStationsfinder);
            this.tab_Stationsfinder.Controls.Add(this.listbox_Stationsfinder);
            this.tab_Stationsfinder.Controls.Add(this.label1);
            this.tab_Stationsfinder.Controls.Add(this.lbl_Stationsfinder);
            this.tab_Stationsfinder.Location = new System.Drawing.Point(4, 22);
            this.tab_Stationsfinder.Name = "tab_Stationsfinder";
            this.tab_Stationsfinder.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Stationsfinder.Size = new System.Drawing.Size(859, 698);
            this.tab_Stationsfinder.TabIndex = 3;
            this.tab_Stationsfinder.Text = "tab_Stationsfinder";
            this.tab_Stationsfinder.UseVisualStyleBackColor = true;
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(85, 321);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(685, 340);
            this.webBrowser.TabIndex = 24;
            this.webBrowser.TabStop = false;
            this.webBrowser.Url = new System.Uri("https://www.google.com/maps/search/transit+station/", System.UriKind.Absolute);
            // 
            // txt_Stationsfinder
            // 
            this.txt_Stationsfinder.Location = new System.Drawing.Point(85, 106);
            this.txt_Stationsfinder.Name = "txt_Stationsfinder";
            this.txt_Stationsfinder.Size = new System.Drawing.Size(259, 20);
            this.txt_Stationsfinder.TabIndex = 0;
            this.txt_Stationsfinder.TextChanged += new System.EventHandler(this.txt_Stationsfinder_TextChanged);
            this.txt_Stationsfinder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Stationsfinder_KeyDown);
            // 
            // btn_SuchenStationsfinder
            // 
            this.btn_SuchenStationsfinder.BackColor = System.Drawing.Color.Red;
            this.btn_SuchenStationsfinder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuchenStationsfinder.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuchenStationsfinder.ForeColor = System.Drawing.Color.Snow;
            this.btn_SuchenStationsfinder.Location = new System.Drawing.Point(569, 175);
            this.btn_SuchenStationsfinder.Name = "btn_SuchenStationsfinder";
            this.btn_SuchenStationsfinder.Size = new System.Drawing.Size(201, 78);
            this.btn_SuchenStationsfinder.TabIndex = 1;
            this.btn_SuchenStationsfinder.Text = "SUCHEN";
            this.btn_SuchenStationsfinder.UseVisualStyleBackColor = false;
            this.btn_SuchenStationsfinder.Click += new System.EventHandler(this.btn_SuchenStationsfinder_Click);
            // 
            // listbox_Stationsfinder
            // 
            this.listbox_Stationsfinder.FormattingEnabled = true;
            this.listbox_Stationsfinder.Location = new System.Drawing.Point(85, 132);
            this.listbox_Stationsfinder.Name = "listbox_Stationsfinder";
            this.listbox_Stationsfinder.Size = new System.Drawing.Size(258, 121);
            this.listbox_Stationsfinder.TabIndex = 22;
            this.listbox_Stationsfinder.TabStop = false;
            this.listbox_Stationsfinder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Stationsfinder_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "Bahnhof";
            // 
            // lbl_Stationsfinder
            // 
            this.lbl_Stationsfinder.AutoSize = true;
            this.lbl_Stationsfinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stationsfinder.Location = new System.Drawing.Point(78, 15);
            this.lbl_Stationsfinder.Name = "lbl_Stationsfinder";
            this.lbl_Stationsfinder.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Stationsfinder.Size = new System.Drawing.Size(246, 42);
            this.lbl_Stationsfinder.TabIndex = 16;
            this.lbl_Stationsfinder.Text = "Stationsfinder";
            // 
            // tab_Abfahrtstafel
            // 
            this.tab_Abfahrtstafel.Controls.Add(this.listView_AbfahrtsTafel);
            this.tab_Abfahrtstafel.Controls.Add(this.txt_Bahnhof);
            this.tab_Abfahrtstafel.Controls.Add(this.btn_SuchenAbfahrtstafel);
            this.tab_Abfahrtstafel.Controls.Add(this.listbox_Bahnhof);
            this.tab_Abfahrtstafel.Controls.Add(this.lbl_Station);
            this.tab_Abfahrtstafel.Controls.Add(this.lbl_Abfahrtstafel);
            this.tab_Abfahrtstafel.Location = new System.Drawing.Point(4, 22);
            this.tab_Abfahrtstafel.Name = "tab_Abfahrtstafel";
            this.tab_Abfahrtstafel.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Abfahrtstafel.Size = new System.Drawing.Size(859, 698);
            this.tab_Abfahrtstafel.TabIndex = 1;
            this.tab_Abfahrtstafel.Text = "tab_Abfahrtstafel";
            this.tab_Abfahrtstafel.UseVisualStyleBackColor = true;
            // 
            // listView_AbfahrtsTafel
            // 
            this.listView_AbfahrtsTafel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_AT_ZugName,
            this.column_AT_Abfahrt,
            this.column_AT_Richtung,
            this.columnBetreiber});
            this.listView_AbfahrtsTafel.Location = new System.Drawing.Point(85, 321);
            this.listView_AbfahrtsTafel.Name = "listView_AbfahrtsTafel";
            this.listView_AbfahrtsTafel.Size = new System.Drawing.Size(685, 261);
            this.listView_AbfahrtsTafel.TabIndex = 24;
            this.listView_AbfahrtsTafel.TabStop = false;
            this.listView_AbfahrtsTafel.UseCompatibleStateImageBehavior = false;
            this.listView_AbfahrtsTafel.View = System.Windows.Forms.View.Details;
            // 
            // column_AT_ZugName
            // 
            this.column_AT_ZugName.Text = "";
            this.column_AT_ZugName.Width = 91;
            // 
            // column_AT_Abfahrt
            // 
            this.column_AT_Abfahrt.Text = "Abfahrt";
            // 
            // column_AT_Richtung
            // 
            this.column_AT_Richtung.Text = "Richtung";
            this.column_AT_Richtung.Width = 200;
            // 
            // columnBetreiber
            // 
            this.columnBetreiber.Text = "Betreiber";
            this.columnBetreiber.Width = 325;
            // 
            // txt_Bahnhof
            // 
            this.txt_Bahnhof.Location = new System.Drawing.Point(85, 106);
            this.txt_Bahnhof.Name = "txt_Bahnhof";
            this.txt_Bahnhof.Size = new System.Drawing.Size(259, 20);
            this.txt_Bahnhof.TabIndex = 0;
            this.txt_Bahnhof.TextChanged += new System.EventHandler(this.txt_Bahnhof_TextChanged);
            this.txt_Bahnhof.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Bahnhof_KeyDown);
            // 
            // btn_SuchenAbfahrtstafel
            // 
            this.btn_SuchenAbfahrtstafel.BackColor = System.Drawing.Color.Red;
            this.btn_SuchenAbfahrtstafel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SuchenAbfahrtstafel.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SuchenAbfahrtstafel.ForeColor = System.Drawing.Color.Snow;
            this.btn_SuchenAbfahrtstafel.Location = new System.Drawing.Point(569, 175);
            this.btn_SuchenAbfahrtstafel.Name = "btn_SuchenAbfahrtstafel";
            this.btn_SuchenAbfahrtstafel.Size = new System.Drawing.Size(201, 78);
            this.btn_SuchenAbfahrtstafel.TabIndex = 1;
            this.btn_SuchenAbfahrtstafel.Text = "SUCHEN";
            this.btn_SuchenAbfahrtstafel.UseVisualStyleBackColor = false;
            this.btn_SuchenAbfahrtstafel.Click += new System.EventHandler(this.btn_SuchenAbfahrtstafel_Click);
            // 
            // listbox_Bahnhof
            // 
            this.listbox_Bahnhof.FormattingEnabled = true;
            this.listbox_Bahnhof.Location = new System.Drawing.Point(85, 132);
            this.listbox_Bahnhof.Name = "listbox_Bahnhof";
            this.listbox_Bahnhof.Size = new System.Drawing.Size(258, 121);
            this.listbox_Bahnhof.TabIndex = 22;
            this.listbox_Bahnhof.TabStop = false;
            this.listbox_Bahnhof.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Bahnhof_MouseDoubleClick);
            // 
            // lbl_Station
            // 
            this.lbl_Station.AutoSize = true;
            this.lbl_Station.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Station.Location = new System.Drawing.Point(88, 79);
            this.lbl_Station.Name = "lbl_Station";
            this.lbl_Station.Size = new System.Drawing.Size(80, 24);
            this.lbl_Station.TabIndex = 21;
            this.lbl_Station.Text = "Bahnhof";
            // 
            // lbl_Abfahrtstafel
            // 
            this.lbl_Abfahrtstafel.AutoSize = true;
            this.lbl_Abfahrtstafel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Abfahrtstafel.Location = new System.Drawing.Point(78, 15);
            this.lbl_Abfahrtstafel.Name = "lbl_Abfahrtstafel";
            this.lbl_Abfahrtstafel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Abfahrtstafel.Size = new System.Drawing.Size(227, 42);
            this.lbl_Abfahrtstafel.TabIndex = 16;
            this.lbl_Abfahrtstafel.Text = "Abfahrtstafel";
            // 
            // tab_Fahrplan
            // 
            this.tab_Fahrplan.Controls.Add(this.label2);
            this.tab_Fahrplan.Controls.Add(this.lbl_Mail);
            this.tab_Fahrplan.Controls.Add(this.txt_Mail);
            this.tab_Fahrplan.Controls.Add(this.btn_Mail);
            this.tab_Fahrplan.Controls.Add(this.btn_Swap);
            this.tab_Fahrplan.Controls.Add(this.listview_Ausgabe);
            this.tab_Fahrplan.Controls.Add(this.txt_Nach);
            this.tab_Fahrplan.Controls.Add(this.txt_Von);
            this.tab_Fahrplan.Controls.Add(this.btn_Suchen);
            this.tab_Fahrplan.Controls.Add(this.listbox_Nach);
            this.tab_Fahrplan.Controls.Add(this.listbox_Von);
            this.tab_Fahrplan.Controls.Add(this.lbl_Nach);
            this.tab_Fahrplan.Controls.Add(this.lbl_Von);
            this.tab_Fahrplan.Controls.Add(this.lbl_Fahrplan);
            this.tab_Fahrplan.Location = new System.Drawing.Point(4, 22);
            this.tab_Fahrplan.Name = "tab_Fahrplan";
            this.tab_Fahrplan.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Fahrplan.Size = new System.Drawing.Size(859, 698);
            this.tab_Fahrplan.TabIndex = 0;
            this.tab_Fahrplan.Text = "tab_Fahrplan";
            this.tab_Fahrplan.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 675);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "*Wenn Sie ihre gefundenen Resultate per E-Mail mit jemandem teilen möchten, geben" +
    " Sie hier demjenigen seine E-Mail adresse ein.";
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mail.Location = new System.Drawing.Point(337, 570);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Mail.Size = new System.Drawing.Size(145, 24);
            this.lbl_Mail.TabIndex = 27;
            this.lbl_Mail.Text = "E-Mail Adresse*";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(334, 597);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(229, 20);
            this.txt_Mail.TabIndex = 26;
            // 
            // btn_Mail
            // 
            this.btn_Mail.BackColor = System.Drawing.Color.Red;
            this.btn_Mail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Mail.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Mail.ForeColor = System.Drawing.Color.Snow;
            this.btn_Mail.Location = new System.Drawing.Point(569, 570);
            this.btn_Mail.Name = "btn_Mail";
            this.btn_Mail.Size = new System.Drawing.Size(201, 47);
            this.btn_Mail.TabIndex = 25;
            this.btn_Mail.Text = "Mail Senden";
            this.btn_Mail.UseVisualStyleBackColor = false;
            this.btn_Mail.Click += new System.EventHandler(this.btn_SendByMail_Click);
            // 
            // btn_Swap
            // 
            this.btn_Swap.BackColor = System.Drawing.Color.White;
            this.btn_Swap.BackgroundImage = global::TransportAPP_GUI.Properties.Resources.arrow_swap_1153356;
            this.btn_Swap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Swap.FlatAppearance.BorderSize = 0;
            this.btn_Swap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Swap.Image = global::TransportAPP_GUI.Properties.Resources.arrow_swap_1153356;
            this.btn_Swap.Location = new System.Drawing.Point(390, 132);
            this.btn_Swap.Name = "btn_Swap";
            this.btn_Swap.Size = new System.Drawing.Size(75, 75);
            this.btn_Swap.TabIndex = 3;
            this.btn_Swap.UseVisualStyleBackColor = false;
            this.btn_Swap.Click += new System.EventHandler(this.btn_Swap_Click);
            // 
            // listview_Ausgabe
            // 
            this.listview_Ausgabe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnZugName,
            this.columnAbfahrt,
            this.columnAnkunft,
            this.columnVon,
            this.columnGleisVon,
            this.columnNach,
            this.columnDauer,
            this.columnVerspaetung});
            this.listview_Ausgabe.Location = new System.Drawing.Point(85, 404);
            this.listview_Ausgabe.Name = "listview_Ausgabe";
            this.listview_Ausgabe.Size = new System.Drawing.Size(685, 100);
            this.listview_Ausgabe.TabIndex = 21;
            this.listview_Ausgabe.TabStop = false;
            this.listview_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listview_Ausgabe.View = System.Windows.Forms.View.Details;
            // 
            // columnZugName
            // 
            this.columnZugName.Text = "";
            this.columnZugName.Width = 59;
            // 
            // columnAbfahrt
            // 
            this.columnAbfahrt.Text = "Abfahrt";
            this.columnAbfahrt.Width = 51;
            // 
            // columnAnkunft
            // 
            this.columnAnkunft.Text = "Ankunft";
            this.columnAnkunft.Width = 56;
            // 
            // columnVon
            // 
            this.columnVon.Text = "Von";
            this.columnVon.Width = 152;
            // 
            // columnGleisVon
            // 
            this.columnGleisVon.Text = "Gleis";
            this.columnGleisVon.Width = 35;
            // 
            // columnNach
            // 
            this.columnNach.Text = "Nach";
            this.columnNach.Width = 147;
            // 
            // columnDauer
            // 
            this.columnDauer.Text = "Dauer";
            this.columnDauer.Width = 43;
            // 
            // columnVerspaetung
            // 
            this.columnVerspaetung.Text = "Verspätung";
            this.columnVerspaetung.Width = 66;
            // 
            // txt_Nach
            // 
            this.txt_Nach.Location = new System.Drawing.Point(512, 110);
            this.txt_Nach.Name = "txt_Nach";
            this.txt_Nach.Size = new System.Drawing.Size(258, 20);
            this.txt_Nach.TabIndex = 1;
            this.txt_Nach.TextChanged += new System.EventHandler(this.txt_Nach_TextChanged);
            this.txt_Nach.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Nach_KeyDown);
            // 
            // txt_Von
            // 
            this.txt_Von.Location = new System.Drawing.Point(85, 106);
            this.txt_Von.Name = "txt_Von";
            this.txt_Von.Size = new System.Drawing.Size(259, 20);
            this.txt_Von.TabIndex = 0;
            this.txt_Von.TextChanged += new System.EventHandler(this.txt_Von_TextChanged);
            this.txt_Von.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Von_KeyDown);
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.BackColor = System.Drawing.Color.Red;
            this.btn_Suchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Suchen.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suchen.ForeColor = System.Drawing.Color.Snow;
            this.btn_Suchen.Location = new System.Drawing.Point(569, 277);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(201, 56);
            this.btn_Suchen.TabIndex = 2;
            this.btn_Suchen.Text = "SUCHEN";
            this.btn_Suchen.UseVisualStyleBackColor = false;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            // 
            // listbox_Nach
            // 
            this.listbox_Nach.FormattingEnabled = true;
            this.listbox_Nach.Location = new System.Drawing.Point(512, 132);
            this.listbox_Nach.Name = "listbox_Nach";
            this.listbox_Nach.Size = new System.Drawing.Size(258, 121);
            this.listbox_Nach.TabIndex = 20;
            this.listbox_Nach.TabStop = false;
            this.listbox_Nach.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Nach_MouseDoubleClick);
            // 
            // listbox_Von
            // 
            this.listbox_Von.FormattingEnabled = true;
            this.listbox_Von.Location = new System.Drawing.Point(85, 132);
            this.listbox_Von.Name = "listbox_Von";
            this.listbox_Von.Size = new System.Drawing.Size(258, 121);
            this.listbox_Von.TabIndex = 19;
            this.listbox_Von.TabStop = false;
            this.listbox_Von.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listbox_Von_MouseDoubleClick);
            // 
            // lbl_Nach
            // 
            this.lbl_Nach.AutoSize = true;
            this.lbl_Nach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nach.Location = new System.Drawing.Point(515, 82);
            this.lbl_Nach.Name = "lbl_Nach";
            this.lbl_Nach.Size = new System.Drawing.Size(55, 24);
            this.lbl_Nach.TabIndex = 18;
            this.lbl_Nach.Text = "Nach";
            // 
            // lbl_Von
            // 
            this.lbl_Von.AutoSize = true;
            this.lbl_Von.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Von.Location = new System.Drawing.Point(89, 82);
            this.lbl_Von.Name = "lbl_Von";
            this.lbl_Von.Size = new System.Drawing.Size(45, 24);
            this.lbl_Von.TabIndex = 17;
            this.lbl_Von.Text = "Von";
            // 
            // lbl_Fahrplan
            // 
            this.lbl_Fahrplan.AutoSize = true;
            this.lbl_Fahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fahrplan.Location = new System.Drawing.Point(78, 15);
            this.lbl_Fahrplan.Name = "lbl_Fahrplan";
            this.lbl_Fahrplan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Fahrplan.Size = new System.Drawing.Size(166, 42);
            this.lbl_Fahrplan.TabIndex = 15;
            this.lbl_Fahrplan.Text = "Fahrplan";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_Fahrplan);
            this.tabControl.Controls.Add(this.tab_Abfahrtstafel);
            this.tabControl.Controls.Add(this.tab_Stationsfinder);
            this.tabControl.Location = new System.Drawing.Point(222, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(867, 724);
            this.tabControl.TabIndex = 0;
            this.tabControl.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TransportAPP_GUI.Properties.Resources.train1;
            this.pictureBox1.Location = new System.Drawing.Point(-67, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 731);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btn_Fahrplan);
            this.Controls.Add(this.btn_Abfahrtstafel);
            this.Controls.Add(this.btn_Stationsfinder);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FahrplanAPP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab_Stationsfinder.ResumeLayout(false);
            this.tab_Stationsfinder.PerformLayout();
            this.tab_Abfahrtstafel.ResumeLayout(false);
            this.tab_Abfahrtstafel.PerformLayout();
            this.tab_Fahrplan.ResumeLayout(false);
            this.tab_Fahrplan.PerformLayout();
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Fahrplan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Abfahrtstafel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Stationsfinder;
        private System.Windows.Forms.TabPage tab_Stationsfinder;
        private System.Windows.Forms.TextBox txt_Stationsfinder;
        private System.Windows.Forms.Button btn_SuchenStationsfinder;
        private System.Windows.Forms.ListBox listbox_Stationsfinder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Stationsfinder;
        private System.Windows.Forms.TabPage tab_Abfahrtstafel;
        private System.Windows.Forms.ListView listView_AbfahrtsTafel;
        private System.Windows.Forms.ColumnHeader column_AT_ZugName;
        private System.Windows.Forms.ColumnHeader column_AT_Abfahrt;
        private System.Windows.Forms.ColumnHeader column_AT_Richtung;
        private System.Windows.Forms.ColumnHeader columnBetreiber;
        private System.Windows.Forms.TextBox txt_Bahnhof;
        private System.Windows.Forms.Button btn_SuchenAbfahrtstafel;
        private System.Windows.Forms.ListBox listbox_Bahnhof;
        private System.Windows.Forms.Label lbl_Station;
        private System.Windows.Forms.Label lbl_Abfahrtstafel;
        private System.Windows.Forms.TabPage tab_Fahrplan;
        private System.Windows.Forms.ListView listview_Ausgabe;
        private System.Windows.Forms.ColumnHeader columnZugName;
        private System.Windows.Forms.ColumnHeader columnAbfahrt;
        private System.Windows.Forms.ColumnHeader columnAnkunft;
        private System.Windows.Forms.ColumnHeader columnVon;
        private System.Windows.Forms.ColumnHeader columnGleisVon;
        private System.Windows.Forms.ColumnHeader columnNach;
        private System.Windows.Forms.ColumnHeader columnDauer;
        private System.Windows.Forms.ColumnHeader columnVerspaetung;
        private System.Windows.Forms.TextBox txt_Nach;
        private System.Windows.Forms.TextBox txt_Von;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.ListBox listbox_Nach;
        private System.Windows.Forms.ListBox listbox_Von;
        private System.Windows.Forms.Label lbl_Nach;
        private System.Windows.Forms.Label lbl_Von;
        private System.Windows.Forms.Label lbl_Fahrplan;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.Button btn_Swap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Button btn_Mail;
    }
}

