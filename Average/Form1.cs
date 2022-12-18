/*
 * Average
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

namespace Average
{
    public partial class AverageForm : Form
    {
        public AverageForm()
        {
            InitializeComponent();
        }

        private void calculateAverageButton_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, total, average;
            num1 = Convert.ToDouble(number1TextBox.Text);
            num2 = Convert.ToDouble(number2TextBox.Text);
            num3 = Convert.ToDouble(number3TextBox.Text);
            total = num1 + num2 + num3;
            average = total / 3.0;
            averagesListBox.Items.Add(average);
        }
    }
}
