using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppOrarend
{
    public partial class FormOrarend : Form
    {
        string mod = null;
        FormOrarend kivalasztottOra = null;
        public FormOrarend(string mod)
        {
            InitializeComponent();
            this.mod = mod;
        }

        public FormOrarend()
        {
        }

        private void FormOrarend_Load(object sender, EventArgs e)
        {
            if (Program.formOrarend.listBox_orarend.SelectedIndex >= 0)
            {
                kivalasztottOra = (FormOrarend)Program.formOrarend.listBox_orarend.SelectedItem;
            }
            switch (this.mod)
            {
                case "új":
                        this.Text = "Új tantárgy felvitele";
                        újTantárgyToolStripMenuItem_ujtantargy.Text = "Új tantárgy felvitele";
                    break;
            }
        }
    
    }
}
