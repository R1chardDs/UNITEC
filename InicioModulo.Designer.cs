namespace Calculadora_de_Salarios
{
    partial class Frm_InicioModuloNomina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_InicioModuloNomina));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_CalcularSalarioNeto = new System.Windows.Forms.Button();
            this.Btn_CalcularLiquidacion = new System.Windows.Forms.Button();
            this.Titulo_Modulo = new System.Windows.Forms.TextBox();
            this.Titulo_CalculosPersonalizados = new System.Windows.Forms.TextBox();
            this.Titulo_Procesos = new System.Windows.Forms.TextBox();
            this.Btn_MantenimientoDeEmpleados = new System.Windows.Forms.Button();
            this.Btn_CrearPuesto = new System.Windows.Forms.Button();
            this.Btn_ConceptosNomina = new System.Windows.Forms.Button();
            this.Btn_GenerarPlanilla = new System.Windows.Forms.Button();
            this.Btn_ContabilizarPlanilla = new System.Windows.Forms.Button();
            this.Titulo_Reportes = new System.Windows.Forms.TextBox();
            this.Btn_HistoricoNomina = new System.Windows.Forms.Button();
            this.Btn_LiquidarEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_CalcularSalarioNeto
            // 
            this.Btn_CalcularSalarioNeto.Location = new System.Drawing.Point(12, 137);
            this.Btn_CalcularSalarioNeto.Name = "Btn_CalcularSalarioNeto";
            this.Btn_CalcularSalarioNeto.Size = new System.Drawing.Size(184, 38);
            this.Btn_CalcularSalarioNeto.TabIndex = 1;
            this.Btn_CalcularSalarioNeto.Text = "Calcular Salario Neto";
            this.Btn_CalcularSalarioNeto.UseVisualStyleBackColor = true;
            this.Btn_CalcularSalarioNeto.Click += new System.EventHandler(this.Btn_CalcularSalarioNeto_Click);
            // 
            // Btn_CalcularLiquidacion
            // 
            this.Btn_CalcularLiquidacion.Location = new System.Drawing.Point(214, 137);
            this.Btn_CalcularLiquidacion.Name = "Btn_CalcularLiquidacion";
            this.Btn_CalcularLiquidacion.Size = new System.Drawing.Size(184, 38);
            this.Btn_CalcularLiquidacion.TabIndex = 2;
            this.Btn_CalcularLiquidacion.Text = "Calcular Liquidación";
            this.Btn_CalcularLiquidacion.UseVisualStyleBackColor = true;
            this.Btn_CalcularLiquidacion.Click += new System.EventHandler(this.Btn_CalcularLiquidacion_Click);
            // 
            // Titulo_Modulo
            // 
            this.Titulo_Modulo.BackColor = System.Drawing.SystemColors.Window;
            this.Titulo_Modulo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Titulo_Modulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Titulo_Modulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Modulo.Location = new System.Drawing.Point(78, 33);
            this.Titulo_Modulo.Name = "Titulo_Modulo";
            this.Titulo_Modulo.ReadOnly = true;
            this.Titulo_Modulo.Size = new System.Drawing.Size(295, 19);
            this.Titulo_Modulo.TabIndex = 3;
            this.Titulo_Modulo.TabStop = false;
            this.Titulo_Modulo.Text = "Control de Nomina";
            this.Titulo_Modulo.TextChanged += new System.EventHandler(this.Titulo_Modulo_TextChanged);
            // 
            // Titulo_CalculosPersonalizados
            // 
            this.Titulo_CalculosPersonalizados.BackColor = System.Drawing.SystemColors.Window;
            this.Titulo_CalculosPersonalizados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Titulo_CalculosPersonalizados.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Titulo_CalculosPersonalizados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_CalculosPersonalizados.Location = new System.Drawing.Point(12, 106);
            this.Titulo_CalculosPersonalizados.Name = "Titulo_CalculosPersonalizados";
            this.Titulo_CalculosPersonalizados.ReadOnly = true;
            this.Titulo_CalculosPersonalizados.Size = new System.Drawing.Size(295, 14);
            this.Titulo_CalculosPersonalizados.TabIndex = 4;
            this.Titulo_CalculosPersonalizados.TabStop = false;
            this.Titulo_CalculosPersonalizados.Text = "Calculos personalizados";
            this.Titulo_CalculosPersonalizados.TextChanged += new System.EventHandler(this.Titulo_CalculosPersonalizados_TextChanged);
            // 
            // Titulo_Procesos
            // 
            this.Titulo_Procesos.BackColor = System.Drawing.SystemColors.Window;
            this.Titulo_Procesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Titulo_Procesos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Titulo_Procesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Procesos.Location = new System.Drawing.Point(12, 211);
            this.Titulo_Procesos.Name = "Titulo_Procesos";
            this.Titulo_Procesos.ReadOnly = true;
            this.Titulo_Procesos.Size = new System.Drawing.Size(295, 14);
            this.Titulo_Procesos.TabIndex = 5;
            this.Titulo_Procesos.TabStop = false;
            this.Titulo_Procesos.Text = "Procesos y parametrizaciones";
            this.Titulo_Procesos.TextChanged += new System.EventHandler(this.Titulo_Procesos_TextChanged);
            // 
            // Btn_MantenimientoDeEmpleados
            // 
            this.Btn_MantenimientoDeEmpleados.Location = new System.Drawing.Point(12, 246);
            this.Btn_MantenimientoDeEmpleados.Name = "Btn_MantenimientoDeEmpleados";
            this.Btn_MantenimientoDeEmpleados.Size = new System.Drawing.Size(184, 38);
            this.Btn_MantenimientoDeEmpleados.TabIndex = 6;
            this.Btn_MantenimientoDeEmpleados.Text = "Mantenimiento de empleados";
            this.Btn_MantenimientoDeEmpleados.UseVisualStyleBackColor = true;
            this.Btn_MantenimientoDeEmpleados.Click += new System.EventHandler(this.Btn_MantenimientoDeEmpleados_Click);
            // 
            // Btn_CrearPuesto
            // 
            this.Btn_CrearPuesto.Location = new System.Drawing.Point(214, 246);
            this.Btn_CrearPuesto.Name = "Btn_CrearPuesto";
            this.Btn_CrearPuesto.Size = new System.Drawing.Size(184, 38);
            this.Btn_CrearPuesto.TabIndex = 7;
            this.Btn_CrearPuesto.Text = "Crear nuevo puesto";
            this.Btn_CrearPuesto.UseVisualStyleBackColor = true;
            this.Btn_CrearPuesto.Click += new System.EventHandler(this.Btn_CrearPuesto_Click);
            // 
            // Btn_ConceptosNomina
            // 
            this.Btn_ConceptosNomina.Location = new System.Drawing.Point(415, 246);
            this.Btn_ConceptosNomina.Name = "Btn_ConceptosNomina";
            this.Btn_ConceptosNomina.Size = new System.Drawing.Size(184, 38);
            this.Btn_ConceptosNomina.TabIndex = 8;
            this.Btn_ConceptosNomina.Text = "Conceptos de nomina";
            this.Btn_ConceptosNomina.UseVisualStyleBackColor = true;
            this.Btn_ConceptosNomina.Click += new System.EventHandler(this.Btn_ConceptosNomina_Click);
            // 
            // Btn_GenerarPlanilla
            // 
            this.Btn_GenerarPlanilla.Location = new System.Drawing.Point(12, 303);
            this.Btn_GenerarPlanilla.Name = "Btn_GenerarPlanilla";
            this.Btn_GenerarPlanilla.Size = new System.Drawing.Size(184, 38);
            this.Btn_GenerarPlanilla.TabIndex = 9;
            this.Btn_GenerarPlanilla.Text = "Generar planilla";
            this.Btn_GenerarPlanilla.UseVisualStyleBackColor = true;
            this.Btn_GenerarPlanilla.Click += new System.EventHandler(this.Btn_GenerarPlanilla_Click);
            // 
            // Btn_ContabilizarPlanilla
            // 
            this.Btn_ContabilizarPlanilla.Location = new System.Drawing.Point(214, 303);
            this.Btn_ContabilizarPlanilla.Name = "Btn_ContabilizarPlanilla";
            this.Btn_ContabilizarPlanilla.Size = new System.Drawing.Size(184, 38);
            this.Btn_ContabilizarPlanilla.TabIndex = 10;
            this.Btn_ContabilizarPlanilla.Text = "Contabilizar planilla";
            this.Btn_ContabilizarPlanilla.UseVisualStyleBackColor = true;
            this.Btn_ContabilizarPlanilla.Click += new System.EventHandler(this.Btn_ContabilizarPlanilla_Click);
            // 
            // Titulo_Reportes
            // 
            this.Titulo_Reportes.BackColor = System.Drawing.SystemColors.Window;
            this.Titulo_Reportes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Titulo_Reportes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Titulo_Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo_Reportes.Location = new System.Drawing.Point(12, 370);
            this.Titulo_Reportes.Name = "Titulo_Reportes";
            this.Titulo_Reportes.ReadOnly = true;
            this.Titulo_Reportes.Size = new System.Drawing.Size(295, 14);
            this.Titulo_Reportes.TabIndex = 11;
            this.Titulo_Reportes.TabStop = false;
            this.Titulo_Reportes.Text = "Reportes";
            this.Titulo_Reportes.TextChanged += new System.EventHandler(this.Titulo_Reportes_TextChanged);
            // 
            // Btn_HistoricoNomina
            // 
            this.Btn_HistoricoNomina.Location = new System.Drawing.Point(12, 399);
            this.Btn_HistoricoNomina.Name = "Btn_HistoricoNomina";
            this.Btn_HistoricoNomina.Size = new System.Drawing.Size(184, 38);
            this.Btn_HistoricoNomina.TabIndex = 12;
            this.Btn_HistoricoNomina.Text = "Hisotorico de Nomina";
            this.Btn_HistoricoNomina.UseVisualStyleBackColor = true;
            this.Btn_HistoricoNomina.Click += new System.EventHandler(this.Btn_HistoricoNomina_Click);
            // 
            // Btn_LiquidarEmpleado
            // 
            this.Btn_LiquidarEmpleado.Location = new System.Drawing.Point(415, 303);
            this.Btn_LiquidarEmpleado.Name = "Btn_LiquidarEmpleado";
            this.Btn_LiquidarEmpleado.Size = new System.Drawing.Size(184, 38);
            this.Btn_LiquidarEmpleado.TabIndex = 13;
            this.Btn_LiquidarEmpleado.Text = "Liquidar Empleado";
            this.Btn_LiquidarEmpleado.UseVisualStyleBackColor = true;
            this.Btn_LiquidarEmpleado.Click += new System.EventHandler(this.Btn_LiquidarEmpleado_Click);
            // 
            // Frm_InicioModuloNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 467);
            this.Controls.Add(this.Btn_LiquidarEmpleado);
            this.Controls.Add(this.Btn_HistoricoNomina);
            this.Controls.Add(this.Titulo_Reportes);
            this.Controls.Add(this.Btn_ContabilizarPlanilla);
            this.Controls.Add(this.Btn_GenerarPlanilla);
            this.Controls.Add(this.Btn_ConceptosNomina);
            this.Controls.Add(this.Btn_CrearPuesto);
            this.Controls.Add(this.Btn_MantenimientoDeEmpleados);
            this.Controls.Add(this.Titulo_Procesos);
            this.Controls.Add(this.Titulo_CalculosPersonalizados);
            this.Controls.Add(this.Titulo_Modulo);
            this.Controls.Add(this.Btn_CalcularLiquidacion);
            this.Controls.Add(this.Btn_CalcularSalarioNeto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Frm_InicioModuloNomina";
            this.Text = "Modulo Control de Nomina";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Btn_CalcularSalarioNeto;
        private System.Windows.Forms.Button Btn_CalcularLiquidacion;
        private System.Windows.Forms.TextBox Titulo_Modulo;
        private System.Windows.Forms.TextBox Titulo_CalculosPersonalizados;
        private System.Windows.Forms.TextBox Titulo_Procesos;
        private System.Windows.Forms.Button Btn_MantenimientoDeEmpleados;
        private System.Windows.Forms.Button Btn_CrearPuesto;
        private System.Windows.Forms.Button Btn_ConceptosNomina;
        private System.Windows.Forms.Button Btn_GenerarPlanilla;
        private System.Windows.Forms.Button Btn_ContabilizarPlanilla;
        private System.Windows.Forms.TextBox Titulo_Reportes;
        private System.Windows.Forms.Button Btn_HistoricoNomina;
        private System.Windows.Forms.Button Btn_LiquidarEmpleado;
    }
}

