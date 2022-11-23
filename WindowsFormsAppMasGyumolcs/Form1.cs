using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMasGyumolcs
{
    public partial class Form1 : Form
    {
        AdatKapcsolat AdatKapcsolat;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Gyumolcsokbetoltese();
        }

        private void Gyumolcsokbetoltese()
        {
            listBoxGyumolcsok.Items.Clear();
            var adatKapcsolat = new AdatKapcsolat();
            foreach (Gyumolcs item in adatKapcsolat.getAllGyumolcs())
            {
                listBoxGyumolcsok.Items.Add(item);
            }
        }
    }
}
