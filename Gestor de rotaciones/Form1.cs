using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace Gestor_de_rotaciones
{
    public partial class Form1 : Form
    {
        List<DateTime> listaFeriados = new List<DateTime>();
        public Form1()
        {
            InitializeComponent();
            //dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            //dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);

            //INTERVALO DE CLASES
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 3, 4);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 5, 6);

            //INTERVALO DE VACACIONES
            dtpVacacionesInicio.Value = new DateTime(DateTime.Now.Year, 7, 8);
            dtpVacacionesFin.Value = new DateTime(DateTime.Now.Year, 7, 19);

            //FERIADOS DEL AÑO
            DateTime feriados = new DateTime(DateTime.Now.Year, 3, 28);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 3, 29);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 4, 1);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 4, 2);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 4, 2);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 5, 1);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 6, 20);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 7, 9);
            listaFeriados.Add(feriados);
            AgregarFeriados(listaFeriados);
        }
        private void btnGenerarFechas_Click(object sender, EventArgs e)
        {
            bool state = false;
            int i = 0;
            int cantidadDias = 0;
            List<int> diasElegidos = new List<int>();
            //DateTime fechaInicio;
            //DateTime fechaFinal;
            //int[] diasPorRotacion = null;
            
            //CALCULA QUE DÍAS A LA SEMANA SE SELECCIONÓ
            do
            {
                if (clbDíasSemana.GetItemChecked(i))
                {
                    state = true;
                    diasElegidos.Add(i + 1);
                }
                i++;
            } while (i < clbDíasSemana.Items.Count);
            
            //CHEQUEA QUE HAYA DÍAS SELECCIONADOS
            if (!state)
            {
                MessageBox.Show("Debes seleccionar al menos 1 día de rotaciones");
            }
            else
            {
                rtbFechasFinales.Clear();
                List<DateTime> listaFeriadosAChequear = new List<DateTime>();
                for (i = 0; i < listaFeriados.Count; i++)
                {
                    if (diasElegidos.IndexOf((int)listaFeriados[i].DayOfWeek) != -1)
                    {
                        listaFeriadosAChequear.Add(listaFeriados[i]);
                    }
                }
                foreach (DateTime dt in listaFeriadosAChequear)
                {
                    rtbFechasFinales.Text = dt.ToString();
                }
                /*
                foreach (DateTime dt in listaFeriados)
                {
                    listaFeriadosAChequear.Add(dt);
                }
                for (i = 0; i < listaFeriadosAChequear.Count; i++)
                {
                    if (diasElegidos.IndexOf((int)listaFeriadosAChequear[i].DayOfWeek) == -1)
                    {
                        listaFeriadosAChequear.RemoveAt(i);
                        i--;
                    }
                }
                */
                cantidadDias -= listaFeriadosAChequear.Count;
                rtbFechasFinales.Text = cantidadDias.ToString();
                /*
                for (DateTime fechaActual = dtpFechaDesde.Value; fechaActual <= dtpFechaHasta.Value; fechaActual = fechaActual.AddDays(1))
                {
                    if (diasElegidos.IndexOf((int)fechaActual.DayOfWeek) != -1)
                    {
                        i = 0;
                        state = false;
                        while (i < listaFeriados.Count && !state)
                        {
                            if (lbListaFeriados.Items.IndexOf(fechaActual.ToShortDateString()) == -1)
                            {
                                cantidadDias++;
                            }
                            i++;
                        }
                    }
                }
                rtbFechasFinales.Text = cantidadDias.ToString();
                */
                /*
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
                fechaInicio = dtpFechaDesde.Value;
                while (diasElegidos.IndexOf((int)fechaInicio.DayOfWeek) != -1)
                {
                    fechaInicio = fechaInicio.AddDays(1);
                }
                fechaFinal = fechaInicio.AddDays(1);
                i = 0;
                while (i < diasPorRotacion[0])
                {
                    if (diasElegidos.IndexOf((int)fechaFinal.DayOfWeek) != -1)
                    {
                        i++;
                    }
                    fechaFinal = fechaFinal.AddDays(1);
                }
                fechaFinal = fechaFinal.AddDays(-1)
                rtbFechasFinales.Text = diasPorRotacion[0] + " - " + fechaInicio.ToShortDateString() + " - " + fechaFinal.ToShortDateString();
                */
                /*
                for (int j = 1; j < diasPorRotacion.Length; j++)
                {
                    fechaInicio = fechaFinal.AddDays(1);
                    while (diasElegidos.IndexOf((int)fechaInicio.DayOfWeek) != -1)
                    {
                        fechaInicio = fechaInicio.AddDays(1);
                    }
                    fechaFinal = fechaInicio.AddDays(1);
                    i = 0;
                    while (i < diasPorRotacion[0])
                    {
                        if (diasElegidos.IndexOf((int)fechaFinal.DayOfWeek) != -1)
                        {
                            i++;
                        }
                        fechaFinal = fechaFinal.AddDays(1);
                    }
                    fechaFinal = fechaFinal.AddDays(-1);
                    rtbFechasFinales.Text += "\n" + diasPorRotacion[j] + " - " + fechaInicio.ToShortDateString() + " - " + fechaFinal.ToShortDateString();
                }
                */
            }
        }

        private void btnAgregarFeriado_Click(object sender, EventArgs e)
        {
            lbListaFeriados.Enabled = true;
            Form2 VentanaNuevoFeriado = new Form2();
            if (VentanaNuevoFeriado.ShowDialog() == DialogResult.OK)
            {
                lbListaFeriados.Items.Add(VentanaNuevoFeriado.dtpFechaFeriado.Value.ToShortDateString());
                listaFeriados.Add(VentanaNuevoFeriado.dtpFechaFeriado.Value);
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

        private void cbOcultarFeriados_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbOcultarFeriados.Checked)
            {
                List<int> diasElegidos = new List<int>();
                int i = 0;
                //CALCULA QUE DÍAS A LA SEMANA SE SELECCIONÓ
                do
                {
                    if (clbDíasSemana.GetItemChecked(i))
                    {
                        diasElegidos.Add(i + 1);
                    }
                    i++;
                } while (i < clbDíasSemana.Items.Count);
                List<DateTime> listaFeriadosAChequear = new List<DateTime>();
                foreach (DateTime dt in listaFeriados)
                {
                    listaFeriadosAChequear.Add(dt);
                }
                for (i = 0; i < listaFeriadosAChequear.Count; i++)
                {
                    if (diasElegidos.IndexOf((int)listaFeriadosAChequear[i].DayOfWeek) == -1)
                    {
                        listaFeriadosAChequear.RemoveAt(i);
                        i--;
                    }
                }
                AgregarFeriados(listaFeriadosAChequear);
            }
            else
            {
                AgregarFeriados(listaFeriados);
            }
        }
        private void AgregarFeriados(List<DateTime> listaFeriados)
        {
            lbListaFeriados.Items.Clear();
            foreach (DateTime dt in listaFeriados)
            {
                lbListaFeriados.Items.Add(dt);
            }
        }
    }
}
