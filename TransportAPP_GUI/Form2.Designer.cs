namespace TransportAPP_GUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listview_Ausgabe = new System.Windows.Forms.ListView();
            this.columnAbfahrt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAnkunft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGleisVon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGleisNach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDauer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Bahnhof = new System.Windows.Forms.TextBox();
            this.listbox_Bahnhof = new System.Windows.Forms.ListBox();
            this.lbl_Bahnhof = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.listview_Ausgabe.Location = new System.Drawing.Point(126, 465);
            this.listview_Ausgabe.Margin = new System.Windows.Forms.Padding(6);
            this.listview_Ausgabe.Name = "listview_Ausgabe";
            this.listview_Ausgabe.Size = new System.Drawing.Size(1276, 498);
            this.listview_Ausgabe.TabIndex = 12;
            this.listview_Ausgabe.UseCompatibleStateImageBehavior = false;
            this.listview_Ausgabe.View = System.Windows.Forms.View.Details;
            // 
            // columnAbfahrt
            // 
            this.columnAbfahrt.Text = "Abfahrt";
            this.columnAbfahrt.Width = 70;
            // 
            // columnAnkunft
            // 
            this.columnAnkunft.Text = "Ankunft";
            this.columnAnkunft.Width = 62;
            // 
            // columnVon
            // 
            this.columnVon.Text = "Von";
            this.columnVon.Width = 196;
            // 
            // columnGleisVon
            // 
            this.columnGleisVon.Text = "Gleis";
            this.columnGleisVon.Width = 50;
            // 
            // columnNach
            // 
            this.columnNach.Text = "Nach";
            this.columnNach.Width = 186;
            // 
            // columnGleisNach
            // 
            this.columnGleisNach.Text = "Gleis";
            this.columnGleisNach.Width = 46;
            // 
            // columnDauer
            // 
            this.columnDauer.Text = "Dauer";
            this.columnDauer.Width = 72;
            // 
            // txt_Bahnhof
            // 
            this.txt_Bahnhof.Location = new System.Drawing.Point(127, 133);
            this.txt_Bahnhof.Margin = new System.Windows.Forms.Padding(6);
            this.txt_Bahnhof.Name = "txt_Bahnhof";
            this.txt_Bahnhof.Size = new System.Drawing.Size(512, 31);
            this.txt_Bahnhof.TabIndex = 13;
            this.txt_Bahnhof.TextChanged += new System.EventHandler(this.txt_Bahnhof_TextChanged);
            // 
            // listbox_Bahnhof
            // 
            this.listbox_Bahnhof.FormattingEnabled = true;
            this.listbox_Bahnhof.ItemHeight = 25;
            this.listbox_Bahnhof.Location = new System.Drawing.Point(126, 176);
            this.listbox_Bahnhof.Margin = new System.Windows.Forms.Padding(6);
            this.listbox_Bahnhof.Name = "listbox_Bahnhof";
            this.listbox_Bahnhof.Size = new System.Drawing.Size(512, 229);
            this.listbox_Bahnhof.TabIndex = 15;
            this.listbox_Bahnhof.TabStop = false;
            // 
            // lbl_Bahnhof
            // 
            this.lbl_Bahnhof.AutoSize = true;
            this.lbl_Bahnhof.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bahnhof.Location = new System.Drawing.Point(134, 79);
            this.lbl_Bahnhof.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Bahnhof.Name = "lbl_Bahnhof";
            this.lbl_Bahnhof.Size = new System.Drawing.Size(161, 44);
            this.lbl_Bahnhof.TabIndex = 14;
            this.lbl_Bahnhof.Text = "Bahnhof";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 1120);
            this.Controls.Add(this.txt_Bahnhof);
            this.Controls.Add(this.listbox_Bahnhof);
            this.Controls.Add(this.lbl_Bahnhof);
            this.Controls.Add(this.listview_Ausgabe);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listview_Ausgabe;
        private System.Windows.Forms.ColumnHeader columnAbfahrt;
        private System.Windows.Forms.ColumnHeader columnAnkunft;
        private System.Windows.Forms.ColumnHeader columnVon;
        private System.Windows.Forms.ColumnHeader columnGleisVon;
        private System.Windows.Forms.ColumnHeader columnNach;
        private System.Windows.Forms.ColumnHeader columnGleisNach;
        private System.Windows.Forms.ColumnHeader columnDauer;
        private System.Windows.Forms.TextBox txt_Bahnhof;
        private System.Windows.Forms.ListBox listbox_Bahnhof;
        private System.Windows.Forms.Label lbl_Bahnhof;
    }
}