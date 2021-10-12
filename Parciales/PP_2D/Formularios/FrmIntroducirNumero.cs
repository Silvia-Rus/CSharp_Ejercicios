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
    public partial class FrmIntroducirNumero : MetroFramework.Forms.MetroForm
    {
        private string numero;

        public string ObtenerNumero { get => numero;  }
        public FrmIntroducirNumero()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(Cabina.EsNumeroValido(this.txtNumeroIntroducido.Text))
            {
                this.numero = this.txtNumeroIntroducido.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Número no válido.\nDebe tener 12 cifras. Sin símbolos.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
