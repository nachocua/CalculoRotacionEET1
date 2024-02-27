namespace Gestor_de_rotaciones
{
    partial class Form2
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
            this.dtpFechaFeriado = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarFeriado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtpFechaFeriado
            // 
            this.dtpFechaFeriado.CustomFormat = "";
            this.dtpFechaFeriado.Location = new System.Drawing.Point(37, 65);
            this.dtpFechaFeriado.Name = "dtpFechaFeriado";
            this.dtpFechaFeriado.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaFeriado.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha del Feriado";
            // 
            // btnAgregarFeriado
            // 
            this.btnAgregarFeriado.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAgregarFeriado.Location = new System.Drawing.Point(55, 118);
            this.btnAgregarFeriado.Name = "btnAgregarFeriado";
            this.btnAgregarFeriado.Size = new System.Drawing.Size(154, 23);
            this.btnAgregarFeriado.TabIndex = 13;
            this.btnAgregarFeriado.Text = "Agregar Feriado";
            this.btnAgregarFeriado.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 162);
            this.Controls.Add(this.btnAgregarFeriado);
            this.Controls.Add(this.dtpFechaFeriado);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarFeriado;
        public System.Windows.Forms.DateTimePicker dtpFechaFeriado;
    }
}