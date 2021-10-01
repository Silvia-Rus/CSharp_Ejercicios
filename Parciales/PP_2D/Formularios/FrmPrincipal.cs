using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnCabinas_Click(object sender, EventArgs e)
        {
            FrmCabinas frmCabinas = new FrmCabinas();
            frmCabinas.ShowDialog();
        }

        private void btnComputadoras_Click(object sender, EventArgs e)
        {
            FrmComputadoras frmComputadoras = new FrmComputadoras();
            frmComputadoras.ShowDialog();
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            FrmDirectorio frmDirectorio = new FrmDirectorio();
            frmDirectorio.ShowDialog();
        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.ShowDialog();

        }
    }
}
