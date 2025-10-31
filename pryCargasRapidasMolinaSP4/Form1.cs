using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCargasRapidasMolinaSP4
{
    public partial class EstadisticaConsumoLogistico : Form
    {
        public EstadisticaConsumoLogistico()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clase_bd clase_Bd = new Clase_bd();
            clase_Bd.ConectarBD(lblverificacionEstado);
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnKMporCamion_Click(object sender, EventArgs e)
        {
            chtCamiones.Series.Clear();
            Clase_bd clase_Bd = new Clase_bd();
            clase_Bd.cargarChart(chtCamiones);
        }

        private void btnGastosCamion_Click(object sender, EventArgs e)
        {
            chtCamiones.Series.Clear();
            Clase_bd clase_Bd = new Clase_bd();
            clase_Bd.cargarChartGastos(chtCamiones);
        }

        private void btnKilog_Click(object sender, EventArgs e)
        {
            chtCamiones.Series.Clear();
            Clase_bd clase_Bd = new Clase_bd();
            clase_Bd.cargarChartKilog(chtCamiones);
        }
    }
}
