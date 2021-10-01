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
    public partial class FrmDirectorio : MetroFramework.Forms.MetroForm
    {
        List<Cliente> listaClientes;



        public FrmDirectorio()
        {
            InitializeComponent();
        }

        public FrmDirectorio(List<Cliente> listaClientes) : this()
        {
            this.listaClientes = listaClientes;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
