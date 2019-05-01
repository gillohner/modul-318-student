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
            this.comboBox_Von = new System.Windows.Forms.ComboBox();
            this.lbl_Fahrplan = new System.Windows.Forms.Label();
            this.lbl_Von = new System.Windows.Forms.Label();
            this.lbl_Nach = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // comboBox_Von
            // 
            this.comboBox_Von.AllowDrop = true;
            this.comboBox_Von.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Von.FormattingEnabled = true;
            this.comboBox_Von.Location = new System.Drawing.Point(90, 178);
            this.comboBox_Von.Name = "comboBox_Von";
            this.comboBox_Von.Size = new System.Drawing.Size(258, 21);
            this.comboBox_Von.TabIndex = 0;
            this.comboBox_Von.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox_Von_KeyDown);
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
            this.lbl_Von.Location = new System.Drawing.Point(93, 151);
            this.lbl_Von.Name = "lbl_Von";
            this.lbl_Von.Size = new System.Drawing.Size(45, 24);
            this.lbl_Von.TabIndex = 2;
            this.lbl_Von.Text = "Von";
            // 
            // lbl_Nach
            // 
            this.lbl_Nach.AutoSize = true;
            this.lbl_Nach.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nach.Location = new System.Drawing.Point(482, 151);
            this.lbl_Nach.Name = "lbl_Nach";
            this.lbl_Nach.Size = new System.Drawing.Size(55, 24);
            this.lbl_Nach.TabIndex = 3;
            this.lbl_Nach.Text = "Nach";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(479, 178);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(258, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 805);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lbl_Nach);
            this.Controls.Add(this.lbl_Von);
            this.Controls.Add(this.lbl_Fahrplan);
            this.Controls.Add(this.comboBox_Von);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Von;
        private System.Windows.Forms.Label lbl_Fahrplan;
        private System.Windows.Forms.Label lbl_Von;
        private System.Windows.Forms.Label lbl_Nach;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

