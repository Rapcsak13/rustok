using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rust2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i =1;
        int wblv = 1;
        int szorzo = 1;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int counter2 = 0;
        private void pont_Click(object sender, EventArgs e)
        {
            if (szorzo == 1)
            {
                számláló.Text = i + "";
                i++;
            }
            if (szorzo == 2)
            {
                for (counter2 = 1; counter2 <= 2; counter2++)
                {
                    számláló.Text = i + "";
                    i++;
                }
            }
            if (szorzo == 3)
            {
                for (counter2 = 1; counter2 <= 4; counter2++)
                {
                    számláló.Text = i + "";
                    i++;
                }
            }
            if (szorzo == 4)
            {
                for (counter2 = 1; counter2 <= 8; counter2++)
                {
                    számláló.Text = i + "";
                    i++;
                }
            }
            if (szorzo == 5)
            {
                for (counter2 = 1; counter2 <= 16; counter2++)
                {
                    számláló.Text = i + "";
                    i++;
                }
            }
            if (szorzo == 6)
            {
                for (counter2 = 1; counter2 <= 32; counter2++)
                {
                    számláló.Text = i + "";
                    i++;
                }
            }
            if (szorzo == 7)
            {
                for (counter2 = 1; counter2 <= 100; counter2++)
                {
                    számláló.Text = i + "";
                    i++;
                }
            }

            if (i > 20 && szorzo == 1)
            { 
                    pont.BackgroundImage = rust2.Properties.Resources.rust_spear_removebg_preview;
                    szorzo++;
            }
            if (i > 100 && szorzo == 2)
            {
                pont.BackgroundImage = rust2.Properties.Resources.rust_crossbow;
                szorzo++;
            }
            if (i > 300 && szorzo == 3 && wblv == 2)
            {
                pont.BackgroundImage = rust2.Properties.Resources.rust_semi_pistol;
                szorzo++;   
            }
            if (i > 500 && szorzo == 4 && wblv == 2)
            {
                pont.BackgroundImage = rust2.Properties.Resources.rust_semi;
                szorzo++;
            }
            if (i > 2000 && szorzo == 5 && wblv == 3)
            {
                pont.BackgroundImage = rust2.Properties.Resources.rust_lr;
                szorzo++;
            }
            if (i > 3000 && szorzo == 6 && wblv == 3)
            {
                pont.BackgroundImage = rust2.Properties.Resources.rust_ak;
                szorzo++;
            }



        }
        
        int counter = 0;
        private void upgrade1_Click(object sender, EventArgs e)
        {
            while (timer1.Enabled == false)
            {
                if(i > 50)
                {
                    timer1.Enabled = Enabled;
                    for (counter = 1; counter <= 50;)
                    {
                        counter++;
                        i--;
                    }
                    label2.Text = "MAX";
                }
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

           számláló.Text = i + "";
           i++;
         
        }

        private void upgrade2_Click(object sender, EventArgs e)
        {
            while (timer2.Enabled == false)
            {
                if (i > 100)
                {
                    timer2.Enabled = Enabled;
                    for (counter = 1; counter <= 100;)
                    {
                        counter++;
                        i--;
                    }
                    label3.Text = "MAX";
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            számláló.Text = i + "";
            i++;
        }

        private void upgrade3_Click(object sender, EventArgs e)
        {
            while (timer3.Enabled == false)
            {
                if (i > 500)
                {
                    timer3.Enabled = Enabled;
                    for (counter = 1; counter <= 500;)
                    {
                        counter++;
                        i--;
                    }
                    label4.Text = "MAX";
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            számláló.Text = i + "";
            i++;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            számláló.Text = i + "";
            i++;
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            számláló.Text = i + "";
            i++;
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            számláló.Text = i + "";
            i++;
        }

        private void upgrade4_Click(object sender, EventArgs e)
        {
            while (timer4.Enabled == false)
            {
                if (i > 1000)
                {
                    timer4.Enabled = Enabled;
                    for (counter = 1; counter <= 1000;)
                    {
                        counter++;
                        i--;
                    }
                    label5.Text = "MAX";
                }
            }
        }

        private void upgrade5_Click(object sender, EventArgs e)
        {
            while (timer5.Enabled == false)
            {
                if (i > 2000)
                {
                    timer5.Enabled = Enabled;
                    for (counter = 1; counter <= 2000;)
                    {
                        counter++;
                        i--;
                    }
                    label6.Text = "MAX";
                }
            }
        }

        private void upgrade6_Click(object sender, EventArgs e)
        {
            while (timer6.Enabled == false)
            {
                if (i > 5000)
                {
                    timer6.Enabled = Enabled;   
                    for (counter = 1; counter <= 5000;)
                    {
                        counter++;
                        i--;
                    }
                    label7.Text = "MAX";
                }
            }
        }

        private void wb_Click(object sender, EventArgs e)
        {
            if (i > 300)
            {
                wb.BackgroundImage = rust2.Properties.Resources.rust_wb2;
                if (wblv < 2)
                {
                    wblv++;
                    label1.Text = wblv + "" + " NEXT: 1000 pont";
                }
                
            }
            if (i > 1000)
            {
                wb.BackgroundImage = rust2.Properties.Resources.rust_wb3_removebg_preview;
                if (wblv < 3)
                {
                    wblv++;
                    label1.Text = "MAX";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
