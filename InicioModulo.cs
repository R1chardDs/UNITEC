using System;
using System.Windows.Forms;
using Calculadora_de_Salarios.Utils;


namespace Calculadora_de_Salarios
{
    public partial class Frm_InicioModuloNomina : Form
    {
        public Frm_InicioModuloNomina()
        {
            InitializeComponent();
        }

        private void Btn_CalcularLiquidacion_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Titulo_Modulo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Btn_MantenimientoDeEmpleados_Click(object sender, EventArgs e)
        {
            Mensajes.Mostrar(TipoMensaje.EnDesarrollo);
        }

        private void Titulo_Procesos_TextChanged(object sender, EventArgs e)
        {

        }

        private void Titulo_Reportes_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_HistoricoNomina_Click(object sender, EventArgs e)
        {
            Mensajes.Mostrar(TipoMensaje.EnReparacion);
        }

        private void Btn_CrearPuesto_Click(object sender, EventArgs e)
        {
            Mensajes.Mostrar(TipoMensaje.EnDesarrollo);
        }

        private void Btn_CalcularSalarioNeto_Click(object sender, EventArgs e)
        {
            Frm_CalculoSalarioNeto frm = new Frm_CalculoSalarioNeto();
            frm.ShowDialog();
        }

        private void Titulo_CalculosPersonalizados_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_ConceptosNomina_Click(object sender, EventArgs e)
        {
            Mensajes.Mostrar(TipoMensaje.EnDesarrollo);
        }

        private void Btn_LiquidarEmpleado_Click(object sender, EventArgs e)
        {
            Mensajes.Mostrar(TipoMensaje.EnDesarrollo);
        }

        private void Btn_ContabilizarPlanilla_Click(object sender, EventArgs e)
        {
            Mensajes.Mostrar(TipoMensaje.EnDesarrollo);
        }

        private void Btn_GenerarPlanilla_Click(object sender, EventArgs e)
        {
            Mensajes.Mostrar(TipoMensaje.EnDesarrollo);
        }
    }
}
