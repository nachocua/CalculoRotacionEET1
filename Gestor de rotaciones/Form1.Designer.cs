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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvFeriados = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarFeriado = new System.Windows.Forms.Button();
            this.btnAgregarFeriado = new System.Windows.Forms.Button();
            this.btnGenerarFechas = new System.Windows.Forms.Button();
            this.rtbFechasFinales = new System.Windows.Forms.RichTextBox();
            this.clbDíasSemana = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpVacacionesFin = new System.Windows.Forms.DateTimePicker();
            this.dtpVacacionesInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidadRotaciones)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CustomFormat = "";
            this.dtpFechaDesde.Location = new System.Drawing.Point(6, 32);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaDesde.TabIndex = 0;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(6, 69);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHasta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
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
            this.groupBox1.Size = new System.Drawing.Size(218, 102);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Intervalo de clases";
            // 
            // nupCantidadRotaciones
            // 
            this.nupCantidadRotaciones.Location = new System.Drawing.Point(49, 172);
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
            this.nupCantidadRotaciones.Size = new System.Drawing.Size(76, 20);
            this.nupCantidadRotaciones.TabIndex = 9;
            this.nupCantidadRotaciones.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvFeriados);
            this.groupBox3.Controls.Add(this.btnQuitarFeriado);
            this.groupBox3.Controls.Add(this.btnAgregarFeriado);
            this.groupBox3.Location = new System.Drawing.Point(220, 120);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 240);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Feriados";
            // 
            // dgvFeriados
            // 
            this.dgvFeriados.AllowUserToAddRows = false;
            this.dgvFeriados.AllowUserToDeleteRows = false;
            this.dgvFeriados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFeriados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.fecha});
            this.dgvFeriados.Location = new System.Drawing.Point(-31, 18);
            this.dgvFeriados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFeriados.Name = "dgvFeriados";
            this.dgvFeriados.ReadOnly = true;
            this.dgvFeriados.RowHeadersWidth = 30;
            this.dgvFeriados.RowTemplate.Height = 24;
            this.dgvFeriados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvFeriados.Size = new System.Drawing.Size(187, 217);
            this.dgvFeriados.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.MinimumWidth = 6;
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 125;
            // 
            // btnQuitarFeriado
            // 
            this.btnQuitarFeriado.Enabled = false;
            this.btnQuitarFeriado.Location = new System.Drawing.Point(161, 154);
            this.btnQuitarFeriado.Name = "btnQuitarFeriado";
            this.btnQuitarFeriado.Size = new System.Drawing.Size(68, 52);
            this.btnQuitarFeriado.TabIndex = 13;
            this.btnQuitarFeriado.Text = "Quitar Feriado";
            this.btnQuitarFeriado.UseVisualStyleBackColor = true;
            this.btnQuitarFeriado.Click += new System.EventHandler(this.btnQuitarFeriado_Click);
            // 
            // btnAgregarFeriado
            // 
            this.btnAgregarFeriado.Location = new System.Drawing.Point(161, 57);
            this.btnAgregarFeriado.Name = "btnAgregarFeriado";
            this.btnAgregarFeriado.Size = new System.Drawing.Size(68, 52);
            this.btnAgregarFeriado.TabIndex = 12;
            this.btnAgregarFeriado.Text = "Agregar Feriado";
            this.btnAgregarFeriado.UseVisualStyleBackColor = true;
            this.btnAgregarFeriado.Click += new System.EventHandler(this.btnAgregarFeriado_Click);
            // 
            // btnGenerarFechas
            // 
            this.btnGenerarFechas.Location = new System.Drawing.Point(157, 519);
            this.btnGenerarFechas.Name = "btnGenerarFechas";
            this.btnGenerarFechas.Size = new System.Drawing.Size(154, 23);
            this.btnGenerarFechas.TabIndex = 13;
            this.btnGenerarFechas.Text = "Generar fechas";
            this.btnGenerarFechas.UseVisualStyleBackColor = true;
            this.btnGenerarFechas.Click += new System.EventHandler(this.btnGenerarFechas_Click);
            // 
            // rtbFechasFinales
            // 
            this.rtbFechasFinales.Location = new System.Drawing.Point(12, 367);
            this.rtbFechasFinales.Name = "rtbFechasFinales";
            this.rtbFechasFinales.Size = new System.Drawing.Size(447, 136);
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
            this.clbDíasSemana.Location = new System.Drawing.Point(100, 18);
            this.clbDíasSemana.Name = "clbDíasSemana";
            this.clbDíasSemana.Size = new System.Drawing.Size(72, 79);
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
            this.groupBox4.Size = new System.Drawing.Size(202, 240);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rotación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Rotaciones en el año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Días";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpVacacionesFin);
            this.groupBox2.Controls.Add(this.dtpVacacionesInicio);
            this.groupBox2.Location = new System.Drawing.Point(236, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 102);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vacaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha de Finalización";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha Inicio";
            // 
            // dtpVacacionesFin
            // 
            this.dtpVacacionesFin.Location = new System.Drawing.Point(13, 69);
            this.dtpVacacionesFin.Name = "dtpVacacionesFin";
            this.dtpVacacionesFin.Size = new System.Drawing.Size(200, 20);
            this.dtpVacacionesFin.TabIndex = 2;
            // 
            // dtpVacacionesInicio
            // 
            this.dtpVacacionesInicio.CustomFormat = "";
            this.dtpVacacionesInicio.Location = new System.Drawing.Point(13, 32);
            this.dtpVacacionesInicio.Name = "dtpVacacionesInicio";
            this.dtpVacacionesInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpVacacionesInicio.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 554);
            this.Controls.Add(this.groupBox2);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeriados)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nupCantidadRotaciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnQuitarFeriado;
        private System.Windows.Forms.Button btnAgregarFeriado;
        private System.Windows.Forms.Button btnGenerarFechas;
        private System.Windows.Forms.RichTextBox rtbFechasFinales;
        private System.Windows.Forms.CheckedListBox clbDíasSemana;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpVacacionesFin;
        private System.Windows.Forms.DateTimePicker dtpVacacionesInicio;
        private System.Windows.Forms.DataGridView dgvFeriados;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.Label label3;
    }
}

