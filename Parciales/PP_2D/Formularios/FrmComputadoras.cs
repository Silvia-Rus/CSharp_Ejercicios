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

        public Procesador ObtenerProcesador { get => procesador; }
        private FrmComputadoras()
        {
            InitializeComponent();
        }

        private void CargaGridCompPorEstado(DataGridView dataGrid, Enumerados.EstadoPuesto estadoPuesto)
        {
            if(!(dataGrid is null))
            {
                dataGrid.DataSource = null;
                dataGrid.DataSource = procesador.Computadoras;
                FrmPrincipal.FormatoGeneralGrid(dataGrid);
                FrmComputadoras.FormatoGridCompus(dataGrid);
                FrmPrincipal.FiltrarGridPuestosPorEstado(dataGrid, ConvertidorComputadoraAux(procesador.Computadoras), estadoPuesto);
            }
        }

        private static void FormatoGridCompus(DataGridView dataGrid)
        {
            if (!(dataGrid is null))
            {
                dataGrid.Columns["MinutosDeUso"].Visible = false;
                dataGrid.Columns["Estado"].Visible = false;
                dataGrid.Columns["Caracteristicas"].Visible = false;
                dataGrid.Columns["ProgramasToString"].HeaderText = "Programas";
                dataGrid.Columns["JuegosToString"].HeaderText = "Juegos";
                dataGrid.Columns["PerifericosToString"].HeaderText = "Periféricos";


            }
        }

        private static void FormatoGridClientes(DataGridView dataGrid)
        {
            if (!(dataGrid is null))
            {
                dataGrid.Columns["Edad"].Visible = false;
                dataGrid.Columns["Estado"].Visible = false;
                dataGrid.Columns["ordenDeLlegadaCabina"].Visible = false;
                dataGrid.Columns["CaracteristicasNecesita"].Visible = false;


                dataGrid.Columns["OrdenDeLlegadaComputadora"].HeaderText = "Orden";
                dataGrid.Columns["JuegosNecesitaToString"].HeaderText = "Juegos";
                dataGrid.Columns["ProgramasNecesitaToString"].HeaderText = "Programas";
                dataGrid.Columns["CaracteristicasNecesitaToString"].HeaderText = "Características";



            }
        }

        private void CargaGridConexiones(DataGridView dataGrid)
        {
            if (!(dataGrid is null))
            {
                dataGrid.DataSource = null;
                dataGrid.DataSource = procesador.Conexiones;
                FrmPrincipal.FormatoGeneralGrid(dataGrid);
               //falta el formato para estas sesiones
            }
        }

        private void CargaGrids()
        {
            this.CargaGridCompPorEstado(this.gridCompLibres, Enumerados.EstadoPuesto.Libre);
            FrmPrincipal.CargaGridClientesPorEstado(this.gridClientesEnEspera, procesador.Clientes, Enumerados.EstadoCliente.esperandoComputadora);
            FrmComputadoras.FormatoGridClientes(this.gridClientesEnEspera);
            this.CargaGridConexiones(this.gridConexionesEnCurso);
        }
        private static List<Puesto> ConvertidorComputadoraAux(List<Computadora> lista)
        {
            List<Puesto> retorno = new List<Puesto>();

            foreach (Computadora item in lista)
            {
                retorno.Add(item);
            }

            return retorno;
        }

        public FrmComputadoras(Procesador procesador) : this()
        {
            this.procesador = procesador;
        }

        private void FrmComputadoras_Load(object sender, EventArgs e)
        {
            this.CargaGrids();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

        }

    }
}
