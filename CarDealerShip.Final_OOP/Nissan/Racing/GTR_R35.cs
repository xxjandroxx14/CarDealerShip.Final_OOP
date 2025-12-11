using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerShip.Final_OOP.Nissan.Racing
{
    public partial class GTR_R35 : Form
    {
        public GTR_R35()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonFn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! We will contact you for further details.",
                          "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCh_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! We will contact you for further details.",
                          "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBk_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
        }
    }
}
