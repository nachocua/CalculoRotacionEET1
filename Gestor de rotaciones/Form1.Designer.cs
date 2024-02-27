namespace Gestor_de_rotaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nupCantidadRotaciones = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lbListaFeriados = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnQuitarFeriado = new System.Windows.Forms.Button();
            this.btnAgregarFeriado = new System.Windows.Forms.Button();
            this.btnGenerarFechas = new System.Windows.Forms.Button();
            this.rtbFechasFinales = new System.Windows.Forms.RichTextBox();
            this.clbDíasSemana = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadRotaciones)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "";
            this.dtpFechaDesde.Location = new System.Drawing.Point(16, 62);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(317, 62);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de Finalización";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFechaDesde);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpFechaHasta);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalo de clases";
            // 
            // nupCantidadRotaciones
            // 
            this.nupCantidadRotaciones.Location = new System.Drawing.Point(317, 69);
            this.nupCantidadRotaciones.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nupCantidadRotaciones.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupCantidadRotaciones.Name = "nupCantidadRotaciones";
            this.nupCantidadRotaciones.Size = new System.Drawing.Size(66, 20);
            this.nupCantidadRotaciones.TabIndex = 9;
            this.nupCantidadRotaciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Días";
            // 
            // lbListaFeriados
            // 
            this.lbListaFeriados.Enabled = false;
            this.lbListaFeriados.FormattingEnabled = true;
            this.lbListaFeriados.Location = new System.Drawing.Point(59, 19);
            this.lbListaFeriados.Name = "lbListaFeriados";
            this.lbListaFeriados.Size = new System.Drawing.Size(157, 121);
            this.lbListaFeriados.TabIndex = 11;
            this.lbListaFeriados.SelectedIndexChanged += new System.EventHandler(this.lbListaFeriados_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnQuitarFeriado);
            this.groupBox3.Controls.Add(this.btnAgregarFeriado);
            this.groupBox3.Controls.Add(this.lbListaFeriados);
            this.groupBox3.Location = new System.Drawing.Point(11, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(533, 150);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feriados";
            // 
            // btnQuitarFeriado
            // 
            this.btnQuitarFeriado.Enabled = false;
            this.btnQuitarFeriado.Location = new System.Drawing.Point(317, 89);
            this.btnQuitarFeriado.Name = "btnQuitarFeriado";
            this.btnQuitarFeriado.Size = new System.Drawing.Size(154, 23);
            this.btnQuitarFeriado.TabIndex = 13;
            this.btnQuitarFeriado.Text = "Quitar Feriado";
            this.btnQuitarFeriado.UseVisualStyleBackColor = true;
            this.btnQuitarFeriado.Click += new System.EventHandler(this.btnQuitarFeriado_Click);
            // 
            // btnAgregarFeriado
            // 
            this.btnAgregarFeriado.Location = new System.Drawing.Point(317, 36);
            this.btnAgregarFeriado.Name = "btnAgregarFeriado";
            this.btnAgregarFeriado.Size = new System.Drawing.Size(154, 23);
            this.btnAgregarFeriado.TabIndex = 12;
            this.btnAgregarFeriado.Text = "Agregar Feriado";
            this.btnAgregarFeriado.UseVisualStyleBackColor = true;
            this.btnAgregarFeriado.Click += new System.EventHandler(this.btnAgregarFeriado_Click);
            // 
            // btnGenerarFechas
            // 
            this.btnGenerarFechas.Location = new System.Drawing.Point(76, 473);
            this.btnGenerarFechas.Name = "btnGenerarFechas";
            this.btnGenerarFechas.Size = new System.Drawing.Size(154, 23);
            this.btnGenerarFechas.TabIndex = 13;
            this.btnGenerarFechas.Text = "Generar fechas";
            this.btnGenerarFechas.UseVisualStyleBackColor = true;
            this.btnGenerarFechas.Click += new System.EventHandler(this.btnGenerarFechas_Click);
            // 
            // rtbFechasFinales
            // 
            this.rtbFechasFinales.Location = new System.Drawing.Point(331, 419);
            this.rtbFechasFinales.Name = "rtbFechasFinales";
            this.rtbFechasFinales.Size = new System.Drawing.Size(154, 141);
            this.rtbFechasFinales.TabIndex = 14;
            this.rtbFechasFinales.Text = "";
            // 
            // clbDíasSemana
            // 
            this.clbDíasSemana.FormattingEnabled = true;
            this.clbDíasSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes"});
            this.clbDíasSemana.Location = new System.Drawing.Point(59, 26);
            this.clbDíasSemana.Name = "clbDíasSemana";
            this.clbDíasSemana.Size = new System.Drawing.Size(89, 94);
            this.clbDíasSemana.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.clbDíasSemana);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.nupCantidadRotaciones);
            this.groupBox4.Location = new System.Drawing.Point(12, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(532, 137);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rotación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rotaciones en el año";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 571);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.rtbFechasFinales);
            this.Controls.Add(this.btnGenerarFechas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadRotaciones)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nupCantidadRotaciones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbListaFeriados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuitarFeriado;
        private System.Windows.Forms.Button btnAgregarFeriado;
        private System.Windows.Forms.Button btnGenerarFechas;
        private System.Windows.Forms.RichTextBox rtbFechasFinales;
        private System.Windows.Forms.CheckedListBox clbDíasSemana;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
    }
}

