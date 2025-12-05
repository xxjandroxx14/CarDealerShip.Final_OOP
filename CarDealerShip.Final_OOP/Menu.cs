using CarDealerShip.Final_OOP.Toyota.SUV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarDealerShip.Final_OOP
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void vIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vios vios = new Vios();
            vios.Show();
        }

        private void cORROLAAXIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorrolaAxio corrolla = new CorrolaAxio();
            corrolla.Show();


        }

        private void cAMRYToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Camry camry = new Camry();
            camry.Show();
        }

        private void tOYOTAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vELOZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VELOZ veloz = new VELOZ();
            veloz.Show();
        }
        private void sEQUOIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SEQUOIA sequoia = new SEQUOIA();
            sequoia.Show();
        }
    }
}
