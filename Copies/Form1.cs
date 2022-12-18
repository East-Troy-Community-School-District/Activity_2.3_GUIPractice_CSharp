/*
 * Copies
 * 12/18/2022
 * C#.NET I
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

namespace Copies
{
    public partial class CopiesForm : Form
    {
        public CopiesForm()
        {
            InitializeComponent();
        }

        private void calculateCostButton_Click(object sender, EventArgs e)
        {
            int numberOfCopies;
            double totalCost;
            numberOfCopies = Convert.ToInt32(copiesTextBox.Text);
            totalCost = numberOfCopies * 0.01 + 5.0;
            totalCostLabel.Text = "That will cost $" + totalCost + ".";
        }
    }
}
