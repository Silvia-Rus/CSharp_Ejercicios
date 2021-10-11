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
        
        public Procesador ObtenerProcesador { get => procesador; }
        private FrmCabinas()
        {
            InitializeComponent();
            
        }

        public FrmCabinas(Procesador procesador) : this()
        {
            this.procesador = procesador;

        }

        private void CargaGrids()
        {
          
            this.CargaGridCabinasPorEstado(this.gridCabinasLibres, Enumerados.EstadoPuesto.Libre);
            this.CargaGridCabinasPorEstado(this.gridCabinasOcupadas, Enumerados.EstadoPuesto.EnUso);
            FrmPrincipal.CargaGridClientesPorEstado(this.gridClientesEnEspera, procesador.Clientes, Enumerados.EstadoCliente.esperandoCabina);
            FormatoGridClientes(this.gridClientesEnEspera);
            this.CargaGridLlamadas(this.gridLlamadasEnCurso);
        }

        private void CargaGridCabinasPorEstado(DataGridView dataGrid, Enumerados.EstadoPuesto estadoPuesto)
        {
            if(!(dataGrid is null))
            {
                dataGrid.DataSource = null;
                dataGrid.DataSource = procesador.Cabinas;
                FrmPrincipal.FormatoGeneralGrid(dataGrid);
                FrmCabinas.FormatoGridCabinas(dataGrid);
                FrmPrincipal.FiltrarGridPuestosPorEstado(dataGrid, ConvertidorCabinaAAux(procesador.Cabinas), estadoPuesto);
            }
           
        }

       
        private void CargaGridLlamadas(DataGridView dataGrid)
        {
            if(!(dataGrid is null))
            {
                dataGrid.DataSource = null;
                dataGrid.DataSource = procesador.Llamadas;
                FrmPrincipal.FormatoGeneralGrid(dataGrid);
                FrmCabinas.FormatoGridLlamadas(dataGrid);
            }
        }

        private static List<Puesto> ConvertidorCabinaAAux(List<Cabina> lista)
        {
            List<Puesto> retorno = new List<Puesto>();

            foreach (Cabina item in lista)
            {
                retorno.Add(item);
            }

            return retorno;
        }

        private void FrmCabinas_Load(object sender, EventArgs e)
        {
          
            this.CargaGrids();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private static void FormatoGridCabinas(DataGridView dataGrid)
        {

           if(!(dataGrid is null))
           {
                dataGrid.Columns["Marca"].Visible = false;
                dataGrid.Columns["Tipo"].Visible = false;
                dataGrid.Columns["MinutosDeUso"].Visible = false;

           }

        }

        private static void FormatoGridClientes(DataGridView dataGrid)
        {
            if (!(dataGrid is null))
            {
                dataGrid.Columns["Edad"].Visible = false;
                dataGrid.Columns["Estado"].Visible = false;
                dataGrid.Columns["OrdenDeLlegadaComputadora"].Visible = false;
                dataGrid.Columns["OrdenDeLlegadaCabina"].HeaderText = "Orden";

                dataGrid.Columns["JuegosNecesitaToString"].Visible = false;
                dataGrid.Columns["ProgramasNecesitaToString"].Visible = false;
                dataGrid.Columns["CaracteristicasNecesitaToString"].Visible = false;
            }
        }

        private static void FormatoGridLlamadas(DataGridView dataGrid)
        {
            if (!(dataGrid is null))
            {
                dataGrid.Columns["Id"].Visible = false;
                dataGrid.Columns["HoraFinal"].Visible = false;
                dataGrid.Columns["Duracion"].Visible = false;
                dataGrid.Columns["Costo"].Visible = false;
            }
        }

    }
}
