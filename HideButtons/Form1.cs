/*
 * Hide Buttons
 * Pawelski
 * 9/17/2023
 * Developing Desktop Applications
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

namespace HideButtons
{
    public partial class HideButtonsForm : Form
    {
        public HideButtonsForm()
        {
            InitializeComponent();
        }

        private void topLeftButton_Click(object sender, EventArgs e)
        {
            topLeftButton.Visible = false;
            topRightButton.Visible = true;
            bottomLeftButton.Visible = true;
            bottomRightButton.Visible = true;
        }
    }
}
