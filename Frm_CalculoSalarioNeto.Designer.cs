namespace Calculadora_de_Salarios
{
    partial class Frm_CalculoSalarioNeto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_TotalDevengado = new System.Windows.Forms.Label();
            this.txt_TotalDevengado = new System.Windows.Forms.TextBox();
            this.Btn_CalcularSalarioNeto = new System.Windows.Forms.Button();
            this.GroupBox_ResultadosCalculoSalario = new System.Windows.Forms.GroupBox();
            this.Lbl_TituloResultados = new System.Windows.Forms.Label();
            this.lblINATEC = new System.Windows.Forms.Label();
            this.lblInssPatronal = new System.Windows.Forms.Label();
            this.lblSalarioNeto = new System.Windows.Forms.Label();
            this.lblIR = new System.Windows.Forms.Label();
            this.lblExpectativaAnual = new System.Windows.Forms.Label();
            this.lblBaseImponible = new System.Windows.Forms.Label();
            this.lblInssLaboral = new System.Windows.Forms.Label();
            this.GroupBox_ResultadosCalculoSalario.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_TotalDevengado
            // 
            this.Label_TotalDevengado.AutoSize = true;
            this.Label_TotalDevengado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TotalDevengado.Location = new System.Drawing.Point(61, 61);
            this.Label_TotalDevengado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label_TotalDevengado.Name = "Label_TotalDevengado";
            this.Label_TotalDevengado.Size = new System.Drawing.Size(140, 18);
            this.Label_TotalDevengado.TabIndex = 0;
            this.Label_TotalDevengado.Text = "Total Devengado:";
            this.Label_TotalDevengado.Click += new System.EventHandler(this.Label_TotalDevengado_Click);
            // 
            // txt_TotalDevengado
            // 
            this.txt_TotalDevengado.Location = new System.Drawing.Point(236, 58);
            this.txt_TotalDevengado.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TotalDevengado.Name = "txt_TotalDevengado";
            this.txt_TotalDevengado.Size = new System.Drawing.Size(158, 22);
            this.txt_TotalDevengado.TabIndex = 1;
            this.txt_TotalDevengado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_TotalDevengado.TextChanged += new System.EventHandler(this.txt_TotalDevengado_TextChanged);
            // 
            // Btn_CalcularSalarioNeto
            // 
            this.Btn_CalcularSalarioNeto.Location = new System.Drawing.Point(412, 57);
            this.Btn_CalcularSalarioNeto.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_CalcularSalarioNeto.Name = "Btn_CalcularSalarioNeto";
            this.Btn_CalcularSalarioNeto.Size = new System.Drawing.Size(128, 28);
            this.Btn_CalcularSalarioNeto.TabIndex = 2;
            this.Btn_CalcularSalarioNeto.Text = "Calcular";
            this.Btn_CalcularSalarioNeto.UseVisualStyleBackColor = true;
            this.Btn_CalcularSalarioNeto.Click += new System.EventHandler(this.Btn_CalcularSalarioNeto_Click);
            // 
            // GroupBox_ResultadosCalculoSalario
            // 
            this.GroupBox_ResultadosCalculoSalario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GroupBox_ResultadosCalculoSalario.BackColor = System.Drawing.SystemColors.Window;
            this.GroupBox_ResultadosCalculoSalario.Controls.Add(this.Lbl_TituloResultados);
            this.GroupBox_ResultadosCalculoSalario.Controls.Add(this.lblINATEC);
            this.GroupBox_ResultadosCalculoSalario.Controls.Add(this.lblInssPatronal);
            this.GroupBox_ResultadosCalculoSalario.Controls.Add(this.lblSalarioNeto);
            this.GroupBox_ResultadosCalculoSalario.Controls.Add(this.lblIR);
            this.GroupBox_ResultadosCalculoSalario.Controls.Add(this.lblExpectativaAnual);
            this.GroupBox_ResultadosCalculoSalario.Controls.Add(this.lblBaseImponible);
            this.GroupBox_ResultadosCalculoSalario.Controls.Add(this.lblInssLaboral);
            this.GroupBox_ResultadosCalculoSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_ResultadosCalculoSalario.Location = new System.Drawing.Point(78, 112);
            this.GroupBox_ResultadosCalculoSalario.Name = "GroupBox_ResultadosCalculoSalario";
            this.GroupBox_ResultadosCalculoSalario.Padding = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.GroupBox_ResultadosCalculoSalario.Size = new System.Drawing.Size(471, 403);
            this.GroupBox_ResultadosCalculoSalario.TabIndex = 3;
            this.GroupBox_ResultadosCalculoSalario.TabStop = false;
            // 
            // Lbl_TituloResultados
            // 
            this.Lbl_TituloResultados.AutoSize = true;
            this.Lbl_TituloResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TituloResultados.Location = new System.Drawing.Point(35, 25);
            this.Lbl_TituloResultados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_TituloResultados.Name = "Lbl_TituloResultados";
            this.Lbl_TituloResultados.Size = new System.Drawing.Size(93, 18);
            this.Lbl_TituloResultados.TabIndex = 4;
            this.Lbl_TituloResultados.Text = "Resultados";
            // 
            // lblINATEC
            // 
            this.lblINATEC.AutoSize = true;
            this.lblINATEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINATEC.Location = new System.Drawing.Point(35, 357);
            this.lblINATEC.Name = "lblINATEC";
            this.lblINATEC.Size = new System.Drawing.Size(112, 18);
            this.lblINATEC.TabIndex = 6;
            this.lblINATEC.Text = "Aporte INATEC:";
            this.lblINATEC.Click += new System.EventHandler(this.lblINATEC_Click);
            // 
            // lblInssPatronal
            // 
            this.lblInssPatronal.AutoSize = true;
            this.lblInssPatronal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInssPatronal.Location = new System.Drawing.Point(35, 309);
            this.lblInssPatronal.Name = "lblInssPatronal";
            this.lblInssPatronal.Size = new System.Drawing.Size(98, 18);
            this.lblInssPatronal.TabIndex = 5;
            this.lblInssPatronal.Text = "Inss Patronal:";
            this.lblInssPatronal.Click += new System.EventHandler(this.lblInssPatronal_Click);
            // 
            // lblSalarioNeto
            // 
            this.lblSalarioNeto.AutoSize = true;
            this.lblSalarioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioNeto.Location = new System.Drawing.Point(35, 261);
            this.lblSalarioNeto.Name = "lblSalarioNeto";
            this.lblSalarioNeto.Size = new System.Drawing.Size(94, 18);
            this.lblSalarioNeto.TabIndex = 4;
            this.lblSalarioNeto.Text = "Salario Neto:";
            this.lblSalarioNeto.Click += new System.EventHandler(this.lblSalarioNeto_Click);
            // 
            // lblIR
            // 
            this.lblIR.AutoSize = true;
            this.lblIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIR.Location = new System.Drawing.Point(35, 213);
            this.lblIR.Name = "lblIR";
            this.lblIR.Size = new System.Drawing.Size(163, 18);
            this.lblIR.TabIndex = 3;
            this.lblIR.Text = "Impuesto sobre la renta";
            this.lblIR.Click += new System.EventHandler(this.lblIR_Click);
            // 
            // lblExpectativaAnual
            // 
            this.lblExpectativaAnual.AutoSize = true;
            this.lblExpectativaAnual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpectativaAnual.Location = new System.Drawing.Point(35, 165);
            this.lblExpectativaAnual.Name = "lblExpectativaAnual";
            this.lblExpectativaAnual.Size = new System.Drawing.Size(127, 18);
            this.lblExpectativaAnual.TabIndex = 2;
            this.lblExpectativaAnual.Text = "Expectativa Anual:";
            this.lblExpectativaAnual.Click += new System.EventHandler(this.lblExpectativaAnual_Click);
            // 
            // lblBaseImponible
            // 
            this.lblBaseImponible.AutoSize = true;
            this.lblBaseImponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaseImponible.Location = new System.Drawing.Point(35, 117);
            this.lblBaseImponible.Name = "lblBaseImponible";
            this.lblBaseImponible.Size = new System.Drawing.Size(113, 18);
            this.lblBaseImponible.TabIndex = 1;
            this.lblBaseImponible.Text = "Base Imponible:";
            this.lblBaseImponible.Click += new System.EventHandler(this.lblBaseImponible_Click);
            // 
            // lblInssLaboral
            // 
            this.lblInssLaboral.AutoSize = true;
            this.lblInssLaboral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInssLaboral.Location = new System.Drawing.Point(35, 69);
            this.lblInssLaboral.Name = "lblInssLaboral";
            this.lblInssLaboral.Size = new System.Drawing.Size(127, 18);
            this.lblInssLaboral.TabIndex = 0;
            this.lblInssLaboral.Text = "Inss Laboral (7%):";
            this.lblInssLaboral.Click += new System.EventHandler(this.lblInssLaboral_Click);
            // 
            // Frm_CalculoSalarioNeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(637, 558);
            this.Controls.Add(this.GroupBox_ResultadosCalculoSalario);
            this.Controls.Add(this.Btn_CalcularSalarioNeto);
            this.Controls.Add(this.txt_TotalDevengado);
            this.Controls.Add(this.Label_TotalDevengado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_CalculoSalarioNeto";
            this.Text = "Calcular Salario Neto";
            this.GroupBox_ResultadosCalculoSalario.ResumeLayout(false);
            this.GroupBox_ResultadosCalculoSalario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_TotalDevengado;
        private System.Windows.Forms.TextBox txt_TotalDevengado;
        private System.Windows.Forms.Button Btn_CalcularSalarioNeto;
        private System.Windows.Forms.GroupBox GroupBox_ResultadosCalculoSalario;
        private System.Windows.Forms.Label lblInssLaboral;
        private System.Windows.Forms.Label lblBaseImponible;
        private System.Windows.Forms.Label lblExpectativaAnual;
        private System.Windows.Forms.Label lblSalarioNeto;
        private System.Windows.Forms.Label lblIR;
        private System.Windows.Forms.Label lblINATEC;
        private System.Windows.Forms.Label lblInssPatronal;
        private System.Windows.Forms.Label Lbl_TituloResultados;
    }
}