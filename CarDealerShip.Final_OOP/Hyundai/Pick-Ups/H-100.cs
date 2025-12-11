using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerShip.Final_OOP.Hyundai.Pick_Ups
{
    public partial class H_100 : Form
    {
        public H_100()
        {
            InitializeComponent();
        }

        private void buttonFinnace_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! We will contact you for further details.",
                          "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! We will contact you for further details.",
                          "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
        }
    }
}
