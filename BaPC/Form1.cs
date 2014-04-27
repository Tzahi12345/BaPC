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
        //Definitions
        struct Part
        {
            public float price;
            public string name;
        }
        //CPUs
        Part athlon760k = new Part();
        Part fx6300 = new Part();
        Part fx8150 = new Part();
        Part i5 = new Part();
        Part i7 = new Part();
        //CPU Coolers
        Part hyper212plus = new Part();
        //Motherboards
        Part msia55m = new Part();
        Part biostara960d = new Part();
        Part msiz87 = new Part();
        Part asrockz87 = new Part();
        //Memory
        Part kblu = new Part();
        Part gskill = new Part();
        //Storage
        Part tb1 = new Part();
        Part tb3 = new Part();
        //GPUs
        Part n750ti = new Part();
        Part n760 = new Part();
        Part n770 = new Part();
        Part n780 = new Part();
        Part n780ti = new Part();
        Part a270x = new Part();
        Part a290 = new Part();
        Part a290x = new Part();
        //Cases
        Part matxcougar = new Part();
        Part atxfractal = new Part();
        //PSUs
        Part cx430 = new Part();
        Part cx750m = new Part();
        //OSs
        Part windows8 = new Part();
        public void Prices() {
            athlon760k.price = 84.99F;
            fx6300.price = 114.99F;
            fx8150.price = 159.99F;
            i5.price = 209.99F;
            i7.price = 309.99F;
            hyper212plus.price = 29.99F;
            msia55m.price = 44.99F;
            biostara960d.price = 35.99F;
            msiz87.price = 95.99F;
            asrockz87.price = 94.99F;
            kblu.price = 64.99F;
            gskill.price = 126.00F;
            tb1.price = 50.00F;
            tb3.price = 104.99F;
            n750ti.price = 139.99F;
            n760.price = 234.99F;
            n770.price = 310.49F;
            n780.price = 473.99F;
            n780ti.price = 649.99F;
            a270x.price = 199.99F;
            a290.price = 409.99F;
            a290x.price = 527.99F;
            matxcougar.price = 34.99F;
            atxfractal.price = 84.99F;
            cx430.price = 39.99F;
            cx750m.price = 79.99F;
            windows8.price = 89.99F;
        }

        public void Names() {
            athlon760k.name = "AMD Athlon X4 760K";
            fx6300.name = "AMD FX-6300";
            fx8150.name = "AMD FX-8150";
            i5.name = "Intel i5-4670K";
            i7.name = "Intel i7-4770K";
            hyper212plus.name = "Cooler Master Hyper 212 Plus";
            msia55m.name = "MSI A55M-E33";
            biostara960d.name = "Biostar A960D+";
            msiz87.name = "MSI Z87M-G43";
            asrockz87.name = "ASRock Z87 Pro3";
            kblu.name = "Kingston Blu 2x4GB DDR3-1600";
            gskill.name = "G.Skill Ripjaws X Series 2x8GB DDR3-1600";
            tb1.name = "Hitachi 1TB 7200RPM HDD";
            tb3.name = "Seagate 3TB 7200RPM HDD";
            n750ti.name = "Gigabyte GeForce GTX 750 Ti";
            n760.name = "EVGA GeForce GTX 760";
            n770.name = "PNY GeForce GTX 770";
            n780.name = "Zotac GeForce GTX 780";
            n780ti.name = "PNY GeForce GTX 780 Ti";
            a270x.name = "VisionTek Radeon R9 270X";
            a290.name = "Gigabyte Radeon R9 290";
            a290x.name = "PowerColor Radeon R9 290X";
            matxcougar.name = "Cougar Spike";
            atxfractal.name = "Fractal Design Define R4 w/ Window";
            cx430.name = "Corsair CX430 430W";
            cx750m.name = "Corsair CX750M 750W";
            windows8.name = "Microsoft Windows 8.1 64-bit";
        }
        /*Unecessary, to be removed
        public void Activity() {
            athlon760k.active = false;
            fx6300.active = false;
            fx8150.active = false;
            i5.active = false;
            i7.active = false;
            hyper212plus.active = false;

        }
          */
        struct Build
        {
            public bool active;
        }
        Build fourfifty = new Build();
        Build fivesixty = new Build();
        Build sixninety = new Build();
        Build sevenninety = new Build();
        Build ninehundred = new Build();
        Build onethousand = new Build();
        Build elevenhundred = new Build();
        Build twelvethirty = new Build();
        Build thirteenthirty = new Build();
        Build fourteenfifty = new Build();
        public string currentPartsLink;
        public string na = "N/A";
        public int priceInt;
        public BaPC()
        {

            InitializeComponent();
        }
        //Simplified repetitive actions
        public void GenerateParts(int x)
        {
            if ((x > 459) && (x < 560))
            {
                fourfifty.active = true;
                
            } else if ((x >= 560) && (x < 690)) {
                fivesixty.active = true;
            }
            else if ((x >= 690) && (x < 790))
            {
                sixninety.active = true;
            }
            else if ((x >= 790) && (x < 900))
            {
                sevenninety.active = true;
            }
            else if ((x >= 900) && (x < 1000))
            {
                ninehundred.active = true;
            }
            else if ((x >= 1000) && (x < 1100))
            {
                onethousand.active = true;
            }
            else if ((x >= 1100) && (x < 1228))
            {
                elevenhundred.active = true;
            }
            else if ((x >= 1228) && (x < 1328))
            {
                twelvethirty.active = true;
            }
            else if ((x >= 1328) && (x < 1450))
            {
                thirteenthirty.active = true;
            }
            else if (x >= 1450)
            {
                fourteenfifty.active = true;
            }
        }
        public void ClearLabels()
        {
            cpuLabel.Text = "";
            cpuPriceLabel.Text = "";
            cpucoolerLabel.Text = "";
            cpucoolerPriceLabel.Text = "";
            motherboardLabel.Text = "";
            motherboardPriceLabel.Text = "";
            memoryLabel.Text = "";
            memoryPriceLabel.Text = "";
            storageLabel.Text = "";
            storagePriceLabel.Text = "";
            gpuLabel.Text = "";
            gpuPriceLabel.Text = "";
            caseLabel.Text = "";
            casePriceLabel.Text = "";
            psuLabel.Text = "";
            psuPriceLabel.Text = "";
            osLabel.Text = "";
            osPriceLabel.Text = "";
            totalPriceLabel.Text = "";
            partsLink.Text = "";
        }
        public void SupportedPrice(int x)
        {
            if ((priceInt < x))
            {
                getbuildLabel.Text = "We do not currently support prices under $" + x + ".";
            }
            else
            {
                getbuildLabel.Text = "For $" + Convert.ToString(priceInt) + " you can get these parts:";
            }
        }
        void Automatizer(Part cpu, Part motherboard, Part memory, Part storage, Part gpu, Part Case, Part psu)
        {
            cpuLabel.Text = cpu.name;
            cpuPriceLabel.Text = FloatToString(cpu.price);
            motherboardLabel.Text = motherboard.name;
            motherboardPriceLabel.Text = FloatToString(motherboard.price);
            memoryLabel.Text = memory.name;
            memoryPriceLabel.Text = FloatToString(memory.price);
            storageLabel.Text = storage.name;
            storagePriceLabel.Text = FloatToString(storage.price);
            gpuLabel.Text = gpu.name;
            gpuPriceLabel.Text = FloatToString(gpu.price);
            caseLabel.Text = Case.name;
            casePriceLabel.Text = FloatToString(Case.price);
            psuLabel.Text = psu.name;
            psuPriceLabel.Text = FloatToString(psu.price);
        }
        void NoExtras()
        {
            cpucoolerLabel.Text = na;
            cpucoolerPriceLabel.Text = na;
            osLabel.Text = na;
            osPriceLabel.Text = na;
        }
        public string FloatToString(float f)
        {
            string s = f.ToString("0.00");
            return s;
        }
        //Other functions that include buttons, labels, and other visual items
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

            //Calling needed functions for parts
            Names();
            Prices();

            //Try and catch for int
            try
            {
                priceInt = Convert.ToInt32(priceTB.Text);
                SupportedPrice(460);
            }
            catch (Exception ex)
            {
                //Catch if priceTB.Text is not only an integer
                if (ex is FormatException)
                {
                    getbuildLabel.Text = "Error, please only use numbers!";
                }
                //Catch if number is too big for int32
                else if (ex is OverflowException)
                {

                    getbuildLabel.Text = "Wow, I'm surprised you have that much to spend. Try entering a more reasonable amount.";

                }
            }
            //Activates appropriate prices
            GenerateParts(priceInt);
            //Clears current labels
            ClearLabels();

            //If statements for each priceInt
            if (fourfifty.active == true)
            {
                Automatizer(athlon760k, msia55m, kblu, tb1, n750ti, matxcougar, cx430);
                NoExtras();
                float combinedPrice = athlon760k.price + msia55m.price + kblu.price + tb1.price + n750ti.price + matxcougar.price + cx430.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uYR";
                fourfifty.active = false;
            }
            else if (fivesixty.active == true)
            {
                Automatizer(fx6300, biostara960d, kblu, tb1, n760, matxcougar, cx430);
                NoExtras();
                float combinedPrice = fx6300.price + biostara960d.price + kblu.price + tb1.price + n760.price + matxcougar.price + cx430.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uYL";
                fivesixty.active = false;
            }
            else if (sixninety.active == true)
            {
                Automatizer(fx6300, biostara960d, kblu, tb1, n770, matxcougar, cx750m);
                NoExtras();
                float combinedPrice = fx6300.price + biostara960d.price + kblu.price + tb1.price + n770.price + matxcougar.price + cx750m.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uYE";
                sixninety.active = false;
            }
            else if (sevenninety.active == true)
            {
                Automatizer(fx8150, biostara960d, kblu, tb3, n770, matxcougar, cx750m);
                NoExtras();
                float combinedPrice = fx8150.price + biostara960d.price + kblu.price + tb3.price + n770.price + matxcougar.price + cx750m.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uYJ";
                sevenninety.active = false;
            }
            else if (ninehundred.active == true)
            {
                Automatizer(i5, msiz87, kblu, tb3, n770, matxcougar, cx750m);
                NoExtras();
                float combinedPrice = i5.price + msiz87.price + kblu.price + tb3.price + n770.price + matxcougar.price + cx750m.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uXF";
                ninehundred.active = false;
            }
            else if (onethousand.active == true)
            {
                Automatizer(i5, msiz87, kblu, tb3, a290, matxcougar, cx750m);
                NoExtras();
                float combinedPrice = i5.price + msiz87.price + kblu.price + tb3.price + a290.price + matxcougar.price + cx750m.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uXN";
                onethousand.active = false;
            }
            else if (elevenhundred.active == true)
            {
                Automatizer(i5, msiz87, gskill, tb3, a290, atxfractal, cx750m);
                NoExtras();
                float combinedPrice = i5.price + msiz87.price + gskill.price + tb3.price + a290.price + atxfractal.price + cx750m.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uYz";
                elevenhundred.active = false;
            }
            else if (twelvethirty.active == true)
            {
                Automatizer(i5, msiz87, gskill, tb3, a290x, atxfractal, cx750m);
                NoExtras();
                float combinedPrice = i5.price + msiz87.price + gskill.price + tb3.price + a290x.price + atxfractal.price + cx750m.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uY2";
                twelvethirty.active = false;
            }
            else if (thirteenthirty.active == true)
            {
                Automatizer(i7, msiz87, gskill, tb3, a290x, atxfractal, cx750m);
                NoExtras();
                float combinedPrice = i7.price + msiz87.price + gskill.price + tb3.price + a290x.price + atxfractal.price + cx750m.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uYy";
                thirteenthirty.active = false;
            }
            else if (fourteenfifty.active == true)
            {
                Automatizer(i7, msiz87, gskill, tb3, n780ti, atxfractal, cx750m);
                NoExtras();
                float combinedPrice = i7.price + msiz87.price + gskill.price + tb3.price + n780ti.price + atxfractal.price + cx750m.price;
                totalPriceLabel.Text = "Around $" + FloatToString(combinedPrice);
                partsLink.Text = "Link to Parts";
                currentPartsLink = "http://pcpartpicker.com/user/Tzahi12345/saved/4uYj";
                fourteenfifty.active = false;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void partsLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(currentPartsLink);
        }
    }
}
