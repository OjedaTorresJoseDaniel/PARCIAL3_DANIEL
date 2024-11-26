using P_BrawlStars.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_BrawlStars.Formularios
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void primerGadgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrimerGadget x = new frmPrimerGadget();
            x.Show();
        }

        private void segundaGadgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSegundoGadget x = new frmSegundoGadget();
            x.Show();
        }

        private void primerEsteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrimerEstelar x = new frmPrimerEstelar();
            x.Show();
        }

        private void segundaEstelarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSegundaEstelar x = new frmSegundaEstelar(); 
            x.Show();
        }

        private void primerRefuerzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrimerRefuerzo x = new frmPrimerRefuerzo();
            x.Show();
        }

        private void segundoRefuerzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSegundoRefuerzo x = new frmSegundoRefuerzo(); 
            x.Show();
        }

        private void tercerRefuerzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTercerRefuerzo x = new frmTercerRefuerzo();
            x.Show();
        }

        private void cuartoRefuerzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCuartoRefuerzo x = new frmCuartoRefuerzo();
            x.Show();
        }

        private void quintoRefuerzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuintoRefuerzo x = new frmQuintoRefuerzo(); 
            x.Show();
        }

        private void sextoRefuerzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSextoRefuerzo x = new frmSextoRefuerzo();
            x.Show();
        }

        private void septimoRefuerzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSeptimoRefuerzo x = new frmSeptimoRefuerzo();
            x.Show();
        }

        private void calidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalidad x = new frmCalidad();
            x.Show();
        }

        private void copaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCopas x = new frmCopas();
            x.Show();
        }

        private void tsMarca_Click(object sender, EventArgs e)
        {
            frmMarca x = new frmMarca();
            x.Show();
        }

        private void tsHipercarga_Click(object sender, EventArgs e)
        {
            frmHipercarga x = new frmHipercarga();
            x.Show();
        }

        private void tsTipo_Click(object sender, EventArgs e)
        {
           frmTipo x = new frmTipo();
            x.Show();
        }

        private void tsSuper_Click(object sender, EventArgs e)
        {
            frmSuper x = new frmSuper();
            x.Show();
        }

        private void tsSalud_Click(object sender, EventArgs e)
        {
            frmSalud x = new frmSalud();
            x.Show();
        }

        private void tsAtaque_Click(object sender, EventArgs e)
        {
            frmAtaque x = new frmAtaque();
            x.Show();
        }

        private void tsFuerza_Click(object sender, EventArgs e)
        {
            frmFuerza x = new frmFuerza();
            x.Show();
        }

        private void tsEstadisticasDelBrawler_Click(object sender, EventArgs e)
        {
            frmEstadisticasDelBrawler x = new frmEstadisticasDelBrawler();
            x.Show();
        }

        private void tsBrawlers_Click(object sender, EventArgs e)
        {
            frmBrawler x = new frmBrawler();
            x.Show();
        }
    }
}
