using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FrmComputadoras : MetroFramework.Forms.MetroForm
    {
        Procesador procesador;
        private FrmComputadoras()
        {
            InitializeComponent();
        }

        public FrmComputadoras(Procesador procesador) : this()
        {
            this.procesador = procesador;
        }

        private void FrmComputadoras_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

    }
}
