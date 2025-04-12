using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Salarios
{
    public partial class Frm_CalculoSalarioNeto : Form
    {
        public Frm_CalculoSalarioNeto()
        {
            InitializeComponent();
        }

        private void Btn_CalcularSalarioNeto_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_TotalDevengado.Text, out decimal devengado))
            {
                decimal inssLaboral = devengado * 0.07m;
                decimal baseImponible = devengado - inssLaboral;
                decimal expectativaAnual = baseImponible * 12;
                decimal baseParaIR = expectativaAnual;

                decimal ir = 0;
                if (baseParaIR < 100000)
                    ir = 0;
                else if (baseParaIR < 200000)
                    ir = (baseParaIR - 100000) * 0.15m;
                else if (baseParaIR < 350000)
                    ir = (baseParaIR - 200000) * 0.20m + 15000;
                else if (baseParaIR < 500000)
                    ir = (baseParaIR - 350000) * 0.25m + 45000;
                else
                    ir = (baseParaIR - 500000) * 0.30m + 82500;

                decimal irMensual = ir / 12;
                decimal salarioNeto = devengado - inssLaboral - irMensual;

                decimal inssPatronal = devengado * 0.225m;
                decimal inatec = devengado * 0.02m;

                // Mostrando resultados en labels (ajustá los nombres si es necesario)
                lblInssLaboral.Text = $"INSS Laboral (7%): C$ {inssLaboral:N2}";
                lblBaseImponible.Text = $"Base Imponible: C$ {baseImponible:N2}";
                lblExpectativaAnual.Text = $"Expectativa Anual: C$ {expectativaAnual:N2}";
                lblIR.Text = $"Impuesto sobre la Renta: C$ {irMensual:N2}";
                lblSalarioNeto.Text = $"Salario Neto: C$ {salarioNeto:N2}";
                lblInssPatronal.Text = $"INSS Patronal: C$ {inssPatronal:N2}";
                lblINATEC.Text = $"Aporte INATEC: C$ {inatec:N2}";
                Lbl_TituloResultados.Text = $"Total a recibir por C$ {devengado:N2}";
            }
            else
            {
                MessageBox.Show("Ingrese un valor válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblInssLaboral_Click(object sender, EventArgs e)
        {

        }

        private void lblBaseImponible_Click(object sender, EventArgs e)
        {

        }

        private void lblExpectativaAnual_Click(object sender, EventArgs e)
        {

        }

        private void lblIR_Click(object sender, EventArgs e)
        {

        }

        private void lblSalarioNeto_Click(object sender, EventArgs e)
        {

        }

        private void lblInssPatronal_Click(object sender, EventArgs e)
        {

        }

        private void lblINATEC_Click(object sender, EventArgs e)
        {

        }

        private void txt_TotalDevengado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_TotalDevengado_Click(object sender, EventArgs e)
        {

        }
    }
}
