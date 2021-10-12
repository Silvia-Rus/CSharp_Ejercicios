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
        
        public Procesador ObtenerProcesador { get => this.procesador; }
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
                FrmPrincipal.FiltrarGridPuestosPorEstado(dataGrid, Cabina.ConvertidorCabinaAAux(procesador.Cabinas), estadoPuesto);
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

        private void AbrirSesion(Cliente cliente, Cabina cabina)
        {
            FrmIntroducirNumero frmIntroducirNumero = new FrmIntroducirNumero();
            

            if(DialogResult.OK == frmIntroducirNumero.ShowDialog())
            {
                String numero = frmIntroducirNumero.ObtenerNumero;
                if (!(numero is null) && procesador.AbrirSesion(cabina, cliente, Enumerados.TiposDeSesion.llamada, numero))
                {
                    MessageBox.Show($"Cabina asignada: {cabina.Id}");
                }
            }
        }
        

        private void gridClientesEnEspera_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Cliente auxCliente = this.procesador.Clientes[this.gridClientesEnEspera.CurrentRow.Index];
            Cabina auxCabina = Cabina.SiguienteCabinaLibre(procesador.Cabinas);

            if(Puesto.HayPuestosLibres(Cabina.ConvertidorCabinaAAux(procesador.Cabinas)))
            {
                if(Cliente.EsElSiguienteParaCabinas(procesador.Clientes, auxCliente) == 1)
                {
                    this.AbrirSesion(auxCliente, auxCabina);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("El cliente seleccionado no es el siguiente en la fila.\n¿Desea asignarle una cabina igualmente?", "¡ATENCIÓN!", MessageBoxButtons.YesNo);

                    if(dialogResult == DialogResult.Yes)
                    {
                        this.AbrirSesion(auxCliente, auxCabina);
                    }

                }
            }
            else
            {
                MessageBox.Show("No hay cabinas libres.");
            }

            CargaGrids();
        }

        private void gridLlamadasEnCurso_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Sesion auxSesion = this.procesador.Llamadas[this.gridLlamadasEnCurso.CurrentRow.Index];

            DialogResult dialogResult = MessageBox.Show($"¿Está seguro de que desea cerrar la sesión en la cabina {auxSesion.Puesto.Id}?");

            if (dialogResult == DialogResult.Yes)
            {
                procesador.CerrarSesion(auxSesion);
            }

            CargaGrids();
        }
    }
}
