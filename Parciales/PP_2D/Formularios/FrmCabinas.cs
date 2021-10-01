using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;


namespace Formularios
{
    public partial class FrmCabinas : MetroFramework.Forms.MetroForm
    {
        public FrmCabinas()
        {
            InitializeComponent();
        }

        private void FrmCabinas_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnComputadoras_Click(object sender, EventArgs e)
        {

        }
    }
}
