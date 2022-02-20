using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Devon Sihra
namespace ElectricalCurrent
{
    public partial class FrmElectricalCurrent : Form
    {
        
       

        public FrmElectricalCurrent()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double voltage = double.Parse(txtBatteryVoltage.Text);
            double res = double.Parse(txtResistance.Text);
            double cap = double.Parse(txtCapacitance.Text);
            double time = double.Parse(txtTime.Text);
            double exp = -time / (res * cap);
            //processing 
            double current = voltage * Math.Pow(2.718, exp)/res;
            lblCurrent.Text = current.ToString("E2");
        

            
             


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBatteryVoltage.Text = "0";
            txtCapacitance.Text = "0";
            txtResistance.Text = "0";
            txtTime.Text = "0";

            lblCurrent.Text = "0";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
