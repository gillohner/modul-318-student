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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listview_Ausgabe = new System.Windows.Forms.ListView();
            this.columnAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGleisVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGleisNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.txt_Nach = new System.Windows.Forms.TextBox();
            this.txt_Von = new System.Windows.Forms.TextBox();
            this.listbox_Nach = new System.Windows.Forms.ListBox();
            this.listbox_Von = new System.Windows.Forms.ListBox();
            this.lbl_Nach = new System.Windows.Forms.Label();
            this.lbl_Von = new System.Windows.Forms.Label();
            this.lbl_Fahrplan = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Bahnhof = new System.Windows.Forms.TextBox();
            this.listBox_Bahnhof = new System.Windows.Forms.ListBox();
            this.lbl_Bahnhof = new System.Windows.Forms.Label();
            this.lbl_Abfahrtstafel = new System.Windows.Forms.Label();
            this.columnZugName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVerspätung = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(222, -2);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(867, 738);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listview_Ausgabe);
            this.tabPage1.Controls.Add(this.btn_Suchen);
            this.tabPage1.Controls.Add(this.txt_Nach);
            this.tabPage1.Controls.Add(this.txt_Von);
            this.tabPage1.Controls.Add(this.listbox_Nach);
            this.tabPage1.Controls.Add(this.listbox_Von);
            this.tabPage1.Controls.Add(this.lbl_Nach);
            this.tabPage1.Controls.Add(this.lbl_Von);
            this.tabPage1.Controls.Add(this.lbl_Fahrplan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(859, 712);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tab_Fahrplan";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.columnGleisNach,
            this.columnDauer,
            this.columnVerspätung});
            this.listview_Ausgabe.Location = new System.Drawing.Point(85, 404);
            this.listview_Ausgabe.Name = "listview_Ausgabe";
            this.listview_Ausgabe.Size = new System.Drawing.Size(685, 261);
            this.listview_Ausgabe.TabIndex = 21;
            this.listview_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listview_Ausgabe.View = System.Windows.Forms.View.Details;
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
            // columnGleisNach
            // 
            this.columnGleisNach.Text = "Gleis";
            this.columnGleisNach.Width = 42;
            // 
            // columnDauer
            // 
            this.columnDauer.Text = "Dauer";
            this.columnDauer.Width = 43;
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.BackColor = System.Drawing.Color.Red;
            this.btn_Suchen.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suchen.ForeColor = System.Drawing.Color.Snow;
            this.btn_Suchen.Location = new System.Drawing.Point(569, 313);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(201, 56);
            this.btn_Suchen.TabIndex = 16;
            this.btn_Suchen.Text = "SUCHEN";
            this.btn_Suchen.UseVisualStyleBackColor = false;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            // 
            // txt_Nach
            // 
            this.txt_Nach.Location = new System.Drawing.Point(512, 110);
            this.txt_Nach.Name = "txt_Nach";
            this.txt_Nach.Size = new System.Drawing.Size(258, 20);
            this.txt_Nach.TabIndex = 14;
            this.txt_Nach.TextChanged += new System.EventHandler(this.txt_Nach_TextChanged);
            // 
            // txt_Von
            // 
            this.txt_Von.Location = new System.Drawing.Point(85, 106);
            this.txt_Von.Name = "txt_Von";
            this.txt_Von.Size = new System.Drawing.Size(259, 20);
            this.txt_Von.TabIndex = 13;
            this.txt_Von.TextChanged += new System.EventHandler(this.txt_Von_TextChanged);
            // 
            // listbox_Nach
            // 
            this.listbox_Nach.FormattingEnabled = true;
            this.listbox_Nach.Location = new System.Drawing.Point(512, 132);
            this.listbox_Nach.Name = "listbox_Nach";
            this.listbox_Nach.Size = new System.Drawing.Size(258, 121);
            this.listbox_Nach.TabIndex = 20;
            this.listbox_Nach.TabStop = false;
            this.listbox_Nach.SelectedIndexChanged += new System.EventHandler(this.listbox_Nach_DoubleClick);
            // 
            // listbox_Von
            // 
            this.listbox_Von.FormattingEnabled = true;
            this.listbox_Von.Location = new System.Drawing.Point(85, 132);
            this.listbox_Von.Name = "listbox_Von";
            this.listbox_Von.Size = new System.Drawing.Size(258, 121);
            this.listbox_Von.TabIndex = 19;
            this.listbox_Von.TabStop = false;
            this.listbox_Von.SelectedIndexChanged += new System.EventHandler(this.listbox_Von_DoubleClick);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txt_Bahnhof);
            this.tabPage2.Controls.Add(this.listBox_Bahnhof);
            this.tabPage2.Controls.Add(this.lbl_Bahnhof);
            this.tabPage2.Controls.Add(this.lbl_Abfahrtstafel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(859, 712);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tab_Abfahrtstafel";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Snow;
            this.button1.Location = new System.Drawing.Point(569, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 78);
            this.button1.TabIndex = 23;
            this.button1.Text = "SUCHEN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Bahnhof
            // 
            this.txt_Bahnhof.Location = new System.Drawing.Point(85, 106);
            this.txt_Bahnhof.Name = "txt_Bahnhof";
            this.txt_Bahnhof.Size = new System.Drawing.Size(259, 20);
            this.txt_Bahnhof.TabIndex = 20;
            this.txt_Bahnhof.TextChanged += new System.EventHandler(this.txt_Bahnhof_TextChanged);
            // 
            // listBox_Bahnhof
            // 
            this.listBox_Bahnhof.FormattingEnabled = true;
            this.listBox_Bahnhof.Location = new System.Drawing.Point(85, 132);
            this.listBox_Bahnhof.Name = "listBox_Bahnhof";
            this.listBox_Bahnhof.Size = new System.Drawing.Size(258, 121);
            this.listBox_Bahnhof.TabIndex = 22;
            this.listBox_Bahnhof.TabStop = false;
            this.listBox_Bahnhof.DoubleClick += new System.EventHandler(this.listBox_Bahnhof_DoubleClick);
            // 
            // lbl_Bahnhof
            // 
            this.lbl_Bahnhof.AutoSize = true;
            this.lbl_Bahnhof.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bahnhof.Location = new System.Drawing.Point(88, 79);
            this.lbl_Bahnhof.Name = "lbl_Bahnhof";
            this.lbl_Bahnhof.Size = new System.Drawing.Size(80, 24);
            this.lbl_Bahnhof.TabIndex = 21;
            this.lbl_Bahnhof.Text = "Bahnhof";
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
            // columnZugName
            // 
            this.columnZugName.Text = "";
            this.columnZugName.Width = 59;
            // 
            // columnVerspätung
            // 
            this.columnVerspätung.Text = "Verspätung";
            this.columnVerspätung.Width = 66;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView1.Location = new System.Drawing.Point(85, 321);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(685, 261);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 59;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Abfahrt";
            this.columnHeader2.Width = 51;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ankunft";
            this.columnHeader3.Width = 56;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Von";
            this.columnHeader4.Width = 152;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gleis";
            this.columnHeader5.Width = 35;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nach";
            this.columnHeader6.Width = 147;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Gleis";
            this.columnHeader7.Width = 42;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Dauer";
            this.columnHeader8.Width = 43;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Verspätung";
            this.columnHeader9.Width = 66;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1084, 731);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fahrplan APP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listview_Ausgabe;
        private System.Windows.Forms.ColumnHeader columnAbfahrt;
        private System.Windows.Forms.ColumnHeader columnAnkunft;
        private System.Windows.Forms.ColumnHeader columnVon;
        private System.Windows.Forms.ColumnHeader columnGleisVon;
        private System.Windows.Forms.ColumnHeader columnNach;
        private System.Windows.Forms.ColumnHeader columnGleisNach;
        private System.Windows.Forms.ColumnHeader columnDauer;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.TextBox txt_Nach;
        private System.Windows.Forms.TextBox txt_Von;
        private System.Windows.Forms.ListBox listbox_Nach;
        private System.Windows.Forms.ListBox listbox_Von;
        private System.Windows.Forms.Label lbl_Nach;
        private System.Windows.Forms.Label lbl_Von;
        private System.Windows.Forms.Label lbl_Fahrplan;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_Abfahrtstafel;
        private System.Windows.Forms.TextBox txt_Bahnhof;
        private System.Windows.Forms.ListBox listBox_Bahnhof;
        private System.Windows.Forms.Label lbl_Bahnhof;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader columnZugName;
        private System.Windows.Forms.ColumnHeader columnVerspätung;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

