using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaPC
{

    
    public partial class BaPC : Form
    {
             struct Part {
        public float price;
        public string name;
        public bool active;
    }
        Part athlon760k = new Part();
        Part fx6300 = new Part();
        Part fx8150 = new Part();
        Part i5 = new Part();
        Part i7 = new Part();
        void Prices() {
            athlon760k.price = 84.99F;
            fx6300.price = 114.99F;
            fx8150.price = 159.99F;
            i5.price = 209.99F;
            i7.price = 309.99F;
        }
        void Names() {
            athlon760k.name = "AMD Athlon X4 760K";
            fx6300.name = "AMD FX-6300";
            fx8150.name = "AMD FX-8150";
            i5.name = "Intel i5-4670K";
            i7.name = "Intel i7-4770K";
        }
        void Activity() {
            athlon760k.active = false;
            fx6300.active = false;
            fx8150.active = false;
            i5.active = false;
            i7.active = false;

        }

        public int priceInt;
        public BaPC()
        {

            InitializeComponent();
        }

        private void blahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void priceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void getbuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                priceInt = Convert.ToInt32(priceTB.Text);
            }
            catch (System.FormatException)
            {
                getbuildLabel.Text = "Error, please only use numbers!";
            } 
            if (priceInt < 200)
            {

            }
            else {
                getbuildLabel.Text = "For $" + Convert.ToString(priceInt) + " you can get these parts:";
            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
