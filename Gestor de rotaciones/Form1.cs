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
        List<DateTime> listaFeriados;
        List<DateTime> listaDias;
        public Form1()
        {
            InitializeComponent();
            listaFeriados = new List<DateTime>();
            listaDias = new List<DateTime>();

            //INTERVALO DE CLASES
            //dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            //dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);
            //dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 3, 4);
            //dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 5, 6);
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 3, 4);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 11, 18);

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
            feriados = new DateTime(DateTime.Now.Year, 5, 1);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 6, 17);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 6, 20);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 6, 21);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 7, 9);
            listaFeriados.Add(feriados);
            feriados = new DateTime(DateTime.Now.Year, 10, 12);
            listaFeriados.Add(feriados);
            listaFeriados.Sort();

            AgregarFeriados(listaFeriados);
            VerificarBotonQuitar();
        }
        private void AgregarFeriados(List<DateTime> listaFeriados)
        {
            dgvFeriados.Rows.Clear();
            for (int i = 0; i < listaFeriados.Count; i++)
            {
                dgvFeriados.Rows.Add(i, listaFeriados[i].ToShortDateString());
            }
        }

        private void btnGenerarFechas_Click(object sender, EventArgs e)
        {
            bool state = false;
            List<int> diasElegidos = new List<int>();
            int[] diasPorRotacion = new int[(int)nupCantidadRotaciones.Value];
            int i;
            rtbFechasFinales.Clear();
            listaDias.Clear();

            //CALCULA QUE DÍAS A LA SEMANA SE SELECCIONÓ
            for (i = 0; i < clbDíasSemana.Items.Count; i++)
            {
                if (clbDíasSemana.GetItemChecked(i))
                {
                    state = true;
                    diasElegidos.Add(i + 1);
                }
            }

            //CHEQUEA QUE HAYA DÍAS SELECCIONADOS
            if (!state)
            {
                MessageBox.Show("Debes seleccionar al menos 1 día de rotaciones");
            }
            else
            {
                for (DateTime fechaActual = dtpFechaDesde.Value; fechaActual <= dtpFechaHasta.Value; fechaActual = fechaActual.AddDays(1))
                {
                    if (diasElegidos.IndexOf((int)fechaActual.DayOfWeek) != -1)
                    {
                        listaDias.Add(fechaActual);
                    }
                }
                foreach (DateTime dt in listaFeriados)
                {
                    if (listaDias.IndexOf(dt) != -1)
                    {
                        listaDias.RemoveAt(listaDias.IndexOf(dt));
                    }
                }
                for (DateTime dt = dtpVacacionesInicio.Value; dt <= dtpVacacionesFin.Value; dt = dt.AddDays(1))
                {
                    if (listaDias.IndexOf(dt) != -1)
                    {
                        listaDias.RemoveAt(listaDias.IndexOf(dt));
                    }
                }
                for (i = 0; i < diasPorRotacion.Count(); i++)
                {
                    diasPorRotacion[i] = listaDias.Count / diasPorRotacion.Count();
                }
                for (i = 0; i < listaDias.Count % diasPorRotacion.Count(); i++)
                {
                    diasPorRotacion[i]++;
                }
                int diasAcumulados = 0;
                for (i = 1; i <= diasPorRotacion.Count(); i++)
                {
                    rtbFechasFinales.Text += "Rotación " + i + ": "
                        + diasPorRotacion[i-1] + " días de clase. "
                        + listaDias[diasAcumulados].ToShortDateString() + " - "
                        + listaDias[diasAcumulados + diasPorRotacion[i - 1] - 1].ToShortDateString() + "\n";
                    diasAcumulados += diasPorRotacion[i - 1];
                }
            }
        }

        private void btnAgregarFeriado_Click(object sender, EventArgs e)
        {
            Form2 unaVentana = new Form2();
            if (unaVentana.ShowDialog() == DialogResult.OK)
            {
                listaFeriados.Add(unaVentana.dtpFechaFeriado.Value);
                listaFeriados.Sort();
                AgregarFeriados(listaFeriados);
                btnQuitarFeriado.Enabled = true;
            }
            unaVentana.Dispose();
        }

        private void btnQuitarFeriado_Click(object sender, EventArgs e)
        {
            VerificarBotonQuitar();
        }

        private void VerificarBotonQuitar()
        {
            if (dgvFeriados.Rows.Count == 0)
            {
                btnQuitarFeriado.Enabled = false;
            }
            else
            {
                btnQuitarFeriado.Enabled = true;
            }
        }
    }
}
