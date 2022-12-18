/*
 * Coins
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

namespace Coins
{
    public partial class CoinsForm : Form
    {
        public CoinsForm()
        {
            InitializeComponent();
        }

        /*
         * This will close the application when the "Exit" button
         * is clicked.
         */
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*
         * This will clear the text boxes and list box.
         */
        private void clearButton_Click(object sender, EventArgs e)
        {
            penniesTextBox.Text = "";
            nickelsTextBox.Text = "";
            dimesTextBox.Text = "";
            quartersTextBox.Text = "";
            moneyListBox.Items.Clear();
        }
    }
}
