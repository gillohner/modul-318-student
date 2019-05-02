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
            this.lbl_Fahrplan = new System.Windows.Forms.Label();
            this.lbl_Von = new System.Windows.Forms.Label();
            this.lbl_Nach = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listbox_Von = new System.Windows.Forms.ListBox();
            this.listbox_Nach = new System.Windows.Forms.ListBox();
            this.txt_Von = new System.Windows.Forms.TextBox();
            this.txt_Nach = new System.Windows.Forms.TextBox();
            this.btn_Suchen = new System.Windows.Forms.Button();
            this.listview_Ausgabe = new System.Windows.Forms.ListView();
            this.columnAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGleisVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGleisNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_Abfahrtstafel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Fahrplan
            // 
            this.lbl_Fahrplan.AutoSize = true;
            this.lbl_Fahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fahrplan.Location = new System.Drawing.Point(322, 36);
            this.lbl_Fahrplan.Name = "lbl_Fahrplan";
            this.lbl_Fahrplan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Fahrplan.Size = new System.Drawing.Size(166, 42);
            this.lbl_Fahrplan.TabIndex = 1;
            this.lbl_Fahrplan.Text = "Fahrplan";
            // 
            // lbl_Von
            // 
            this.lbl_Von.AutoSize = true;
            this.lbl_Von.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Von.Location = new System.Drawing.Point(100, 99);
            this.lbl_Von.Name = "lbl_Von";
            this.lbl_Von.Size = new System.Drawing.Size(45, 24);
            this.lbl_Von.TabIndex = 2;
            this.lbl_Von.Text = "Von";
            // 
            // lbl_Nach
            // 
            this.lbl_Nach.AutoSize = true;
            this.lbl_Nach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nach.Location = new System.Drawing.Point(481, 99);
            this.lbl_Nach.Name = "lbl_Nach";
            this.lbl_Nach.Size = new System.Drawing.Size(55, 24);
            this.lbl_Nach.TabIndex = 3;
            this.lbl_Nach.Text = "Nach";
            // 
            // listbox_Von
            // 
            this.listbox_Von.FormattingEnabled = true;
            this.listbox_Von.Location = new System.Drawing.Point(96, 149);
            this.listbox_Von.Name = "listbox_Von";
            this.listbox_Von.Size = new System.Drawing.Size(258, 121);
            this.listbox_Von.TabIndex = 9;
            this.listbox_Von.TabStop = false;
            this.listbox_Von.DoubleClick += new System.EventHandler(this.listbox_Von_DoubleClick);
            // 
            // listbox_Nach
            // 
            this.listbox_Nach.FormattingEnabled = true;
            this.listbox_Nach.Location = new System.Drawing.Point(478, 149);
            this.listbox_Nach.Name = "listbox_Nach";
            this.listbox_Nach.Size = new System.Drawing.Size(258, 121);
            this.listbox_Nach.TabIndex = 10;
            this.listbox_Nach.TabStop = false;
            this.listbox_Nach.DoubleClick += new System.EventHandler(this.listbox_Nach_DoubleClick);
            // 
            // txt_Von
            // 
            this.txt_Von.Location = new System.Drawing.Point(97, 127);
            this.txt_Von.Name = "txt_Von";
            this.txt_Von.Size = new System.Drawing.Size(258, 20);
            this.txt_Von.TabIndex = 0;
            this.txt_Von.TextChanged += new System.EventHandler(this.txt_Von_TextChanged);
            // 
            // txt_Nach
            // 
            this.txt_Nach.Location = new System.Drawing.Point(478, 127);
            this.txt_Nach.Name = "txt_Nach";
            this.txt_Nach.Size = new System.Drawing.Size(258, 20);
            this.txt_Nach.TabIndex = 1;
            this.txt_Nach.TextChanged += new System.EventHandler(this.txt_Nach_TextChanged);
            // 
            // btn_Suchen
            // 
            this.btn_Suchen.BackColor = System.Drawing.Color.Red;
            this.btn_Suchen.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Suchen.ForeColor = System.Drawing.Color.Snow;
            this.btn_Suchen.Location = new System.Drawing.Point(535, 301);
            this.btn_Suchen.Name = "btn_Suchen";
            this.btn_Suchen.Size = new System.Drawing.Size(201, 56);
            this.btn_Suchen.TabIndex = 2;
            this.btn_Suchen.Text = "SUCHEN";
            this.btn_Suchen.UseVisualStyleBackColor = false;
            this.btn_Suchen.Click += new System.EventHandler(this.btn_Suchen_Click);
            // 
            // listview_Ausgabe
            // 
            this.listview_Ausgabe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAbfahrt,
            this.columnAnkunft,
            this.columnVon,
            this.columnGleisVon,
            this.columnNach,
            this.columnGleisNach,
            this.columnDauer});
            this.listview_Ausgabe.Location = new System.Drawing.Point(97, 386);
            this.listview_Ausgabe.Name = "listview_Ausgabe";
            this.listview_Ausgabe.Size = new System.Drawing.Size(640, 261);
            this.listview_Ausgabe.TabIndex = 11;
            this.listview_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listview_Ausgabe.View = System.Windows.Forms.View.Details;
            // 
            // columnAbfahrt
            // 
            this.columnAbfahrt.Text = "Abfahrt";
            this.columnAbfahrt.Width = 90;
            // 
            // columnAnkunft
            // 
            this.columnAnkunft.Text = "Ankunft";
            this.columnAnkunft.Width = 90;
            // 
            // columnVon
            // 
            this.columnVon.Text = "Von";
            this.columnVon.Width = 242;
            // 
            // columnGleisVon
            // 
            this.columnGleisVon.Text = "Gleis";
            this.columnGleisVon.Width = 68;
            // 
            // columnNach
            // 
            this.columnNach.Text = "Nach";
            this.columnNach.Width = 228;
            // 
            // columnGleisNach
            // 
            this.columnGleisNach.Text = "Gleis";
            this.columnGleisNach.Width = 68;
            // 
            // columnDauer
            // 
            this.columnDauer.Text = "Dauer";
            this.columnDauer.Width = 98;
            // 
            // btn_Abfahrtstafel
            // 
            this.btn_Abfahrtstafel.BackColor = System.Drawing.Color.Red;
            this.btn_Abfahrtstafel.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Abfahrtstafel.ForeColor = System.Drawing.Color.Snow;
            this.btn_Abfahrtstafel.Location = new System.Drawing.Point(96, 671);
            this.btn_Abfahrtstafel.Name = "btn_Abfahrtstafel";
            this.btn_Abfahrtstafel.Size = new System.Drawing.Size(201, 56);
            this.btn_Abfahrtstafel.TabIndex = 12;
            this.btn_Abfahrtstafel.Text = "Abfahrtstafel";
            this.btn_Abfahrtstafel.UseVisualStyleBackColor = false;
            this.btn_Abfahrtstafel.Click += new System.EventHandler(this.btn_Abfahrtstafel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 729);
            this.Controls.Add(this.btn_Abfahrtstafel);
            this.Controls.Add(this.listview_Ausgabe);
            this.Controls.Add(this.btn_Suchen);
            this.Controls.Add(this.txt_Nach);
            this.Controls.Add(this.txt_Von);
            this.Controls.Add(this.listbox_Nach);
            this.Controls.Add(this.listbox_Von);
            this.Controls.Add(this.lbl_Nach);
            this.Controls.Add(this.lbl_Von);
            this.Controls.Add(this.lbl_Fahrplan);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fahrplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Fahrplan;
        private System.Windows.Forms.Label lbl_Von;
        private System.Windows.Forms.Label lbl_Nach;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listbox_Von;
        private System.Windows.Forms.ListBox listbox_Nach;
        private System.Windows.Forms.TextBox txt_Von;
        private System.Windows.Forms.TextBox txt_Nach;
        private System.Windows.Forms.Button btn_Suchen;
        private System.Windows.Forms.ListView listview_Ausgabe;
        private System.Windows.Forms.ColumnHeader columnAbfahrt;
        private System.Windows.Forms.ColumnHeader columnAnkunft;
        private System.Windows.Forms.Button btn_Abfahrtstafel;
        private System.Windows.Forms.ColumnHeader columnVon;
        private System.Windows.Forms.ColumnHeader columnNach;
        private System.Windows.Forms.ColumnHeader columnDauer;
        private System.Windows.Forms.ColumnHeader columnGleisVon;
        private System.Windows.Forms.ColumnHeader columnGleisNach;
    }
}

