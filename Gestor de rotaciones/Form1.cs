using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_de_rotaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            //dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 3, 4);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 11, 18);
        }
        private void btnGenerarFechas_Click(object sender, EventArgs e)
        {
            bool state = false;
            int i = 0;
            List<int> diasElegidos = new List<int>();
            int[] diasPorRotacion = null;
            do
            {
                if (clbDíasSemana.GetItemChecked(i))
                {
                    state = true;
                    diasElegidos.Add(i + 1);
                }
                i++;
            } while (i < clbDíasSemana.Items.Count);
            if (!state)
            {
                MessageBox.Show("Debes seleccionar al menos 1 día de rotaciones");
            }
            else
            {
                int cantidadDias = 0;
                for (DateTime fechaActual = dtpFechaDesde.Value; fechaActual <= dtpFechaHasta.Value; fechaActual = fechaActual.AddDays(1))
                {
                    if (diasElegidos.IndexOf((int)fechaActual.DayOfWeek) != -1)
                    {
                        if (lbListaFeriados.Items.IndexOf(fechaActual.ToShortDateString()) == -1)
                        {
                            cantidadDias++;
                        }
                    }
                }
                diasPorRotacion = new int[Convert.ToInt32(nupCantidadRotaciones.Value)];
                for (i = 0; i < diasPorRotacion.Length; i++)
                {
                    diasPorRotacion[i] = cantidadDias / (int)nupCantidadRotaciones.Value;
                }
                for (i = 0; i < cantidadDias - (diasPorRotacion[0] * diasPorRotacion.Length); i++)
                {
                    diasPorRotacion[i % diasPorRotacion.Length]++;
                }
                rtbFechasFinales.Clear();
                DateTime fechaInicio = dtpFechaDesde.Value;
                while (diasElegidos.IndexOf((int)fechaInicio.DayOfWeek) != -1)
                {
                    fechaInicio = fechaInicio.AddDays(1);
                }
                DateTime fechaFinal = fechaInicio.AddDays(1);
                rtbFechasFinales.Text = fechaInicio.ToShortDateString() + " - " + fechaFinal.ToShortDateString();
                for (i = 0; i < (int)nupCantidadRotaciones.Value - 1; i++)
                {
                    fechaInicio = fechaFinal.AddDays(1);
                }
            }
        }

        private void btnAgregarFeriado_Click(object sender, EventArgs e)
        {
            lbListaFeriados.Enabled = true;
            Form2 VentanaNuevoFeriado = new Form2();
            if (VentanaNuevoFeriado.ShowDialog() == DialogResult.OK)
            {
                lbListaFeriados.Items.Add(VentanaNuevoFeriado.dtpFechaFeriado.Value.ToShortDateString());
            }
            VentanaNuevoFeriado.Dispose();
        }

        private void btnQuitarFeriado_Click(object sender, EventArgs e)
        {
            lbListaFeriados.Items.RemoveAt(lbListaFeriados.SelectedIndex);
            lbListaFeriados.SelectedItem = null;
            if (lbListaFeriados.Items.Count == 0)
            {
                lbListaFeriados.Enabled = false;
                btnQuitarFeriado.Enabled = false;
            }
        }

        private void lbListaFeriados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbListaFeriados.SelectedIndex != -1)
            {
                btnQuitarFeriado.Enabled = true;
            }
        }
    }
}
