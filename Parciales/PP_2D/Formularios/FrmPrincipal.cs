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
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        private Procesador procesador;
        
        
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            procesador = Procesador.CargaDatosAutomatica(procesador);
            this.lblHoraNombre.Text = $"Operador: {procesador.Operador} -- {procesador.Fecha.ToString("dd/MM/yyyy")}";
        }

        private void btnCabinas_Click(object sender, EventArgs e)
        {
            FrmCabinas frmCabinas = new FrmCabinas(procesador);
            if (frmCabinas.ShowDialog() == DialogResult.OK)
            {
                this.procesador = frmCabinas.ObtenerProcesador;
            }
        }

        private void btnComputadoras_Click(object sender, EventArgs e)
        {
            FrmComputadoras frmComputadoras = new FrmComputadoras(procesador);
            frmComputadoras.ShowDialog();
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            FrmDirectorio frmDirectorio = new FrmDirectorio(procesador.Clientes);
            frmDirectorio.ShowDialog();



        }

        private void btnEstadistica_Click(object sender, EventArgs e)
        {
            FrmEstadisticas frmEstadisticas = new FrmEstadisticas();
            frmEstadisticas.ShowDialog();

        }
        public static void FormatoGeneralGrid(DataGridView dataGrid)
        {
            if(!(dataGrid is null))
            {
                //oculta la primera columna
                dataGrid.RowHeadersVisible = false;
                //ajusta al contenido
                dataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                //quita las scrollbars
                dataGrid.ScrollBars = ScrollBars.None;
                
            }

        }


        public static void FiltrarGridPuestosPorEstado(DataGridView aux, List<Puesto> listaPuestos, Enumerados.EstadoPuesto estadoPuesto)
        {

            if(listaPuestos.Count > 0 && !(aux is null))
            {
                for (int i = 0; i < aux.RowCount; i++)
                {
                    if (listaPuestos[i].Estado != estadoPuesto)
                    {
                        aux.CurrentCell = null;
                        aux.Rows[i].Visible = false;
                    }
                }
            }
           
        }

        public static void FiltrarGridClientesPorEstado(DataGridView aux, List<Cliente> listaClientes, Enumerados.EstadoCliente estadoCliente)
        {
            if(listaClientes.Count > 0 && (!(aux is null)))
            {
                for (int i = 0; i < aux.RowCount; i++)
                {
                    if (listaClientes[i].Estado != estadoCliente)
                    {
                        aux.CurrentCell = null;
                        aux.Rows[i].Visible = false;
                    }
                }
            }
        }

        public static void CargaGridClientesPorEstado(DataGridView dataGrid, List<Cliente> listaClientes, Enumerados.EstadoCliente estadoCliente)
        {
            if (!(dataGrid is null))
            {
                dataGrid.DataSource = null;
                dataGrid.DataSource = listaClientes;
                FrmPrincipal.FormatoGeneralGrid(dataGrid);
                FrmPrincipal.FiltrarGridClientesPorEstado(dataGrid, listaClientes, estadoCliente);
            }

        }
    }
}
