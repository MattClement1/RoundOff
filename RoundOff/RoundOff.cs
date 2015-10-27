/*
*Created by: Matthew Clement
*Created on: 27-Oct-2015
*Created for: Unit #4-02
*This program rounds a numbert to two decimal places
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundOff
{
    public partial class frmRoundOff : Form
    {
        private void RoundNumber(ref Label answer, double number)
        {
            answer.Text = Convert.ToString(Math.Round(number, 1));
        }

        public frmRoundOff()
        {
            InitializeComponent();
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            double numberInput;

            numberInput = Convert.ToDouble(this.txtNumberInput.Text);

            RoundNumber(ref this.lblAnswer, numberInput);
        }
    }
}
