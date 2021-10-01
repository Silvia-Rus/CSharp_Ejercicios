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
    public partial class FrmComputadoras : MetroFramework.Forms.MetroForm
    {
        public FrmComputadoras()
        {
            InitializeComponent();
        }

        private void FrmComputadoras_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

        private void btnCabinas_Click(object sender, EventArgs e)
        {

        }
    }
}
