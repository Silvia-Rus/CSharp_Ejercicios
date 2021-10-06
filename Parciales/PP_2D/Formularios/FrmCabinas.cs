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
using Entidades;


namespace Formularios
{
    public partial class FrmCabinas : MetroFramework.Forms.MetroForm
    {
        Procesador procesador;
        List<Puesto> listaPuestos;
        
        private FrmCabinas()
        {
            InitializeComponent();
            
        }

        public FrmCabinas(Procesador procesador) : this()
        {
            this.procesador = procesador;

            listaPuestos = new List<Puesto>();
            listaPuestos = Puesto.FiltroPuestosPorEstado(procesador.Puestos, Enumerados.EstadoPuesto.Libre);
            this.grdCabinasLibres.DataSource = null;
            this.grdCabinasLibres.DataSource = listaPuestos;



        }

        private void FrmCabinas_Load(object sender, EventArgs e)
        {
           
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

    }
}
