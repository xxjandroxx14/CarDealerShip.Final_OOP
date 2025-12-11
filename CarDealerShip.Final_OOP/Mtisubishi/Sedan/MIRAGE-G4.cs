using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerShip.Final_OOP.Mtisubishi.Sedan
{
    public partial class MIRAGE_G4 : Form
    {
        public MIRAGE_G4()
        {
            InitializeComponent();
        }

     

        private void buttonFinnace_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! We will contact you for further details.",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you! We will contact you for further details.",
                        "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonBack_Click_1(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Close();
        }
    }
}
