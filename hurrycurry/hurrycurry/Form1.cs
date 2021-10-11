using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hurrycurry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void friescb_CheckedChanged(object sender, EventArgs e)
        {
            if(friescb.Checked == true)
            {
                friestxt.Enabled = true;
            }
            if(friescb.Checked == false)
            {
                friestxt.Enabled = false;
                friestxt.Text = "0";
            }
        }

        private void burgercb_CheckedChanged(object sender, EventArgs e)
        {
            if (burgercb.Checked == true)
            {
                burgertxt.Enabled = true;
            }
            if (burgercb.Checked == false)
            {
                burgertxt.Enabled = false;
                burgertxt.Text = "0";
            }

        }

        private void saladcb_CheckedChanged(object sender, EventArgs e)
        {
            if (saladcb.Checked == true)
            {
                saladtxt.Enabled = true;
            }
            if (saladcb.Checked == false)
            {
                saladtxt.Enabled = false;
                saladtxt.Text = "0";
            }
        }

        private void sandwichcb_CheckedChanged(object sender, EventArgs e)
        {
            if (sandwichcb.Checked == true)
            {
                sandwichtxt.Enabled = true;
            }
            if (sandwichcb.Checked == false)
            {
                sandwichtxt.Enabled = false;
                sandwichtxt.Text = "0";
            }
        }

        private void chickencb_CheckedChanged(object sender, EventArgs e)
        {
            if (chickencb.Checked == true)
            {
                chickentxt.Enabled = true;
            }
            if (chickencb.Checked == false)
            {
                chickentxt.Enabled = false;
                chickentxt.Text = "0";
            }
        }

        private void cheesecb_CheckedChanged(object sender, EventArgs e)
        {
            if (cheesecb.Checked == true)
            {
                cheesetxt.Enabled = true;
            }
            if (cheesecb.Checked == false)
            {
                cheesetxt.Enabled = false;
                cheesetxt.Text = "0";
            }
        }

        private void teacb_CheckedChanged(object sender, EventArgs e)
        {
            if (teacb.Checked == true)
            {
                teatxt.Enabled = true;
            }
            if (teacb.Checked == false)
            {
                teatxt.Enabled = false;
                teatxt.Text = "0";
            }
        }

        private void colacb_CheckedChanged(object sender, EventArgs e)
        {
            if (colacb.Checked == true)
            {
                colatxt.Enabled = true;
            }
            if (colacb.Checked == false)
            {
                colatxt.Enabled = false;
                colatxt.Text = "0";
            }
        }

        private void watercb_CheckedChanged(object sender, EventArgs e)
        {
            if (watercb.Checked == true)
            {
                watertxt.Enabled = true;
            }
            if (watercb.Checked == false)
            {
                watertxt.Enabled = false;
                watertxt.Text = "0";
            }
        }

        private void chocolatecb_CheckedChanged(object sender, EventArgs e)
        {
            if (chocolatecb.Checked == true)
            {
                chocolatetxt.Enabled = true;
            }
            if (chocolatecb.Checked == false)
            {
                chocolatetxt.Enabled = false;
                chocolatetxt.Text = "0";
            }
        }

        private void pancakescb_CheckedChanged(object sender, EventArgs e)
        {
            if (pancakescb.Checked == true)
            {
                pancakestxt.Enabled = true;
            }
            if (pancakescb.Checked == false)
            {
                pancakestxt.Enabled = false;
                pancakestxt.Text = "0";
            }
        }

        private void beerscb_CheckedChanged(object sender, EventArgs e)
        {
            if (beerscb.Checked == true)
            {
                beerstxt.Enabled = true;
            }
            if (beerscb.Checked == false)
            {
                beerstxt.Enabled = false;
                beerstxt.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    
        //declare unit price of different meals and drinks
          double friesup = 100, burgerup = 80, saladup = 50, sandwichup = 60, chickenup = 120, cheeseup = 50;
          double teaup = 30, colaup = 50, waterup = 30, chocolateup = 25, pancakesup = 70, beersup = 180;
        //declare variable to hold price for each drinks and meals
          double friestp, burgertp, saladtp, sandwichtp, chickentp, cheesetp, teatp, colatp, watertp, chocolatetp, pancakestp, beerstp;
          double Subtotal = 0, tax, grdtotal;
        private void button2_Click(object sender, EventArgs e)
        {
            friestp = friesup * Convert.ToDouble(friestxt.Text);
            burgertp = burgerup * Convert.ToDouble(burgertxt.Text);
            saladtp = saladup * Convert.ToDouble(saladtxt.Text);
            sandwichtp = sandwichup * Convert.ToDouble(sandwichtxt.Text);
            chickentp = chickenup * Convert.ToDouble(chickentxt.Text);
            cheesetp = cheeseup * Convert.ToDouble(cheesetxt.Text);
            teatp = teaup * Convert.ToDouble(teatxt.Text);
            colatp = colaup * Convert.ToDouble(colatxt.Text);
            watertp = waterup * Convert.ToDouble(watertxt.Text);
            chocolatetp = chocolateup * Convert.ToDouble(chocolatetxt.Text);
            pancakestp = pancakesup * Convert.ToDouble(pancakestxt.Text);
            beerstp = beersup * Convert.ToDouble(beerstxt.Text);
            richtxt.Clear();
            Subtotal = 0;
            richtxt.AppendText(Environment.NewLine);
            richtxt.AppendText("\t\t\tFRESH GO"+Environment.NewLine);
            if(friescb.Checked == true)
                {
                    richtxt.AppendText("\tfries:\t"+friestp+"Rs"+Environment.NewLine);
                    Subtotal = Subtotal + friestp;
                    subtotallbl.Text = "" + Subtotal;
                }
            if (burgercb.Checked == true)
            {
                richtxt.AppendText("\tburger:\t" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (saladcb.Checked == true)
            {
                richtxt.AppendText("\tsalad:\t" + saladtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + saladtp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (sandwichcb.Checked == true)
            {
                richtxt.AppendText("\tsandwich:\t" + sandwichtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (chickencb.Checked == true)
            {
                richtxt.AppendText("\tchicken:\t" + chickentp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + chickentp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (cheesecb.Checked == true)
            {
                richtxt.AppendText("\tcheese:\t" + cheesetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + cheesetp;
                subtotallbl.Text = "" + Subtotal;
            }
            if (teacb.Checked == true)
            {
                richtxt.AppendText("\ttea:\t" + teatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                subtotallbl.Text = "" + Subtotal;
            }
             if(colacb.Checked == true)
                {
                    richtxt.AppendText("\tcola:\t"+colatp+"Rs"+Environment.NewLine);
                    Subtotal = Subtotal + colatp;
                    subtotallbl.Text = "" + Subtotal;
                }
            
             if (watercb.Checked == true)
             {
                 richtxt.AppendText("\twater:\t" + watertp + "Rs" + Environment.NewLine);
                 Subtotal = Subtotal + watertp;
                 subtotallbl.Text = "" + Subtotal;
             }
             if (chocolatecb.Checked == true)
             {
                 richtxt.AppendText("\tchocolate:\t" + chocolatetp + "Rs" + Environment.NewLine);
                 Subtotal = Subtotal + chocolatetp;
                 subtotallbl.Text = "" + Subtotal;
             }
             if (pancakescb.Checked == true)
             {
                 richtxt.AppendText("\tpancakes:\t" + pancakestp + "Rs" + Environment.NewLine);
                 Subtotal = Subtotal + pancakestp;
                 subtotallbl.Text = "" + Subtotal;
             }
             if (beerscb.Checked == true)
             {
                 richtxt.AppendText("\tbeers:\t" + beerstp + "Rs" + Environment.NewLine);
                 Subtotal = Subtotal + beerstp;
                 subtotallbl.Text = "" + Subtotal;
             }
             tax = Subtotal * 0.16;//tax is 16%
             grdtotal = Subtotal + tax;
             taxlbl.Text = "Rs" + tax;
             Grdtotallbl.Text = "Rs" + grdtotal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            friescb.Checked = false;
            burgercb.Checked = false;
            saladcb.Checked = false;
            sandwichcb.Checked = false;
            chickencb.Checked = false;
            cheesecb.Checked = false;
            teacb.Checked = false;
            colacb.Checked = false;
            watercb.Checked = false;
            chocolatecb.Checked = false;
            pancakescb.Checked = false;
            beerscb.Checked = false;
            richtxt.Clear();
            subtotallbl.Text = "Rs/--";
            taxlbl.Text = "Rs/--";
            Grdtotallbl.Text = "Rs/--";
        }


        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richtxt.Text + " Subtotal" + subtotallbl.Text + "Tax:" +taxlbl.Text+ "Grand Total" +Grdtotallbl.Text,new Font("Century Gothic",12,FontStyle.Regular),Brushes.Blue,new Point(130));
        }

        private void printbtn_Click(object sender, EventArgs e)
        {
           if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        } 
    }
}


