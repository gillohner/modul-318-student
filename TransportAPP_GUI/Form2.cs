using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransportAPP_GUI
{
    public partial class Form2 : Form
    {
        Form1 mainForm;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            mainForm = parent;
        }

        private void txt_Bahnhof_TextChanged(object sender, EventArgs e)
        {
            mainForm.StationSuchen(txt_Bahnhof.Text, listbox_Bahnhof);

          
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }
    }
}
