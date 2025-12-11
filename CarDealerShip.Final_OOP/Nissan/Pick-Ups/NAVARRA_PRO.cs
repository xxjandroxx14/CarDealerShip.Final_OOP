using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerShip.Final_OOP.Nissan.Pick_Ups
{
    public partial class NAVARRA_PRO : Form
    {
        public NAVARRA_PRO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! We will contact you for further details.",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! We will contact you for further details.",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBK_Click(object sender, EventArgs e)
        {
    Menu menu = new Menu();
            this.Close();
        }
    }
}
