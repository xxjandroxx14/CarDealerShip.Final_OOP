using CarDealerShip.Final_OOP.Honda.Racing;
using CarDealerShip.Final_OOP.Honda.Sedan;
using CarDealerShip.Final_OOP.Honda.SUV;
using CarDealerShip.Final_OOP.Hyundai.Pick_Ups;
using CarDealerShip.Final_OOP.Hyundai.Sedan;
using CarDealerShip.Final_OOP.Hyundai.SUV;
using CarDealerShip.Final_OOP.Mtisubishi.Pick_Ups;
using CarDealerShip.Final_OOP.Mtisubishi.Racing;
using CarDealerShip.Final_OOP.Mtisubishi.Sedan;
using CarDealerShip.Final_OOP.Mtisubishi.SUV;
using CarDealerShip.Final_OOP.Nissan.Pick_Ups;
using CarDealerShip.Final_OOP.Nissan.Racing;
using CarDealerShip.Final_OOP.Nissan.Sedan;
using CarDealerShip.Final_OOP.Nissan.SUV;
using CarDealerShip.Final_OOP.Toyota.Racing;
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

        private void gRSUPRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GR_SUPRA gr_supra = new GR_SUPRA();
            gr_supra.Show();
        }

        private void gR86ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GR86 gr86 = new GR86();
            gr86.Show();
        }

        private void tUNDRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TUNDRA tundra = new TUNDRA();
            tundra.Show();
        }

        private void hILUXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HILUX hilux = new HILUX();
            hilux.Show();
        }

        private void tACOMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TACOMA tacoma = new TACOMA();
            tacoma.Show();
        }

        private void gRYARISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GR_YARIS gr_yaris = new GR_YARIS();
            gr_yaris.Show();
        }

        private void cIVICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CIVIC civic = new CIVIC();
            civic.Show();
        }

        private void cITYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CITY city = new CITY();
            city.Show();
        }

        private void hONDACIVICTYPERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CIVICTYPER civictyper = new CIVICTYPER();
            civictyper.Show();
        }

        private void nSXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NSX nsx = new NSX();
            nsx.Show();
        }

        private void aCCORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACCORD accord = new ACCORD();
            accord.Show();
        }

        private void bRVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BRV brv = new BRV();
            brv.Show();
        }

        private void cRVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRV crv = new CRV();
            crv.Show();
        }


        private void aLMERAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ALMERA almera = new ALMERA();
            almera.Show();
        }

        private void sYLPHYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SYLPHY sylphy = new SYLPHY();
            sylphy.Show();
        }

        private void tERRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TERRA terra = new TERRA();
            terra.Show();
        }

        private void pATROLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PATROL patrol = new PATROL();
            patrol.Show();
        }

        private void nAVARRAPROToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NAVARRA_PRO navarra_pro = new NAVARRA_PRO();
            navarra_pro.Show();
        }

        private void nISSANZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NISSAN_Z nissan_Z = new NISSAN_Z();
            nissan_Z.Show();
        }

        private void gTRR35ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GTR_R35 gtr_R35 = new GTR_R35();
            gtr_R35.Show();
        }

        private void eLANTRAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ELANTRA elantra = new ELANTRA();
            elantra.Show();

        }

        private void aCCENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ACCENT accent = new ACCENT();
            accent.Show();
        }

        private void tUCSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TUCSON tUCSON = new TUCSON();
            tUCSON.Show();
        }

        private void cRETAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRETA creta = new CRETA();
            creta.Show();
        }

        private void sANTAFEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SANTA_FE sANTA_FE = new SANTA_FE();
            sANTA_FE.Show();
        }

        private void h100ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            H_100 h_100 = new H_100();
            h_100.Show();
        }

        private void eLANTRANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ELANTRA elanta = new ELANTRA();
            elanta.Show();
        }

        private void mIRRAGEG4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MIRAGE_G4 mirrage_G4 = new MIRAGE_G4();
            mirrage_G4.Show();
        }

        private void mONTEROSPORTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MONTERO_SPORT montero_SPORT = new MONTERO_SPORT();
            montero_SPORT.Show();
        }

        private void xFOCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X_FORCE x_FORCE = new X_FORCE();
            x_FORCE.Show();
        }

        private void oUTLANDERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OUTLANDER outlander = new OUTLANDER();
            outlander.Show();
        }

        private void tRITONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TRITON triton = new TRITON();
            triton.Show();
        }

        private void lANCEREVOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LANCER_EVO lANCER_EVO = new LANCER_EVO();
            lANCER_EVO.Show();
        }
    }
}
