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
    public class FechaConindice
    {
        public DateTime Fecha { get; set; }
        public int Indice { get; set; }
        public FechaConindice(DateTime Fecha, int Indice)
        {
            this.Fecha = Fecha;
            this.Indice = Indice;
        }
        public string toString()
        {
            return "Id" + Indice.ToString() + " - " + Fecha.ToShortDateString();
        }
    }
    public partial class Form1 : Form
    {
        List<FechaConindice> listaFeriados;
        List<DateTime> listaDias;
        public Form1()
        {
            InitializeComponent();
            listaFeriados = new List<FechaConindice>();
            listaDias = new List<DateTime>();
            //dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 1, 1);
            //dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 12, 31);

            //INTERVALO DE CLASES
            dtpFechaDesde.Value = new DateTime(DateTime.Now.Year, 3, 4);
            dtpFechaHasta.Value = new DateTime(DateTime.Now.Year, 5, 6);

            //INTERVALO DE VACACIONES
            dtpVacacionesInicio.Value = new DateTime(DateTime.Now.Year, 7, 8);
            dtpVacacionesFin.Value = new DateTime(DateTime.Now.Year, 7, 19);

            //FERIADOS DEL AÑO
            FechaConindice feriados = new FechaConindice(new DateTime(DateTime.Now.Year, 3, 28), 1);
            listaFeriados.Add(feriados);
            feriados = new FechaConindice(new DateTime(DateTime.Now.Year, 3, 29), 1);
            listaFeriados.Add(feriados);
            feriados = new FechaConindice(new DateTime(DateTime.Now.Year, 4, 1), 3);
            listaFeriados.Add(feriados);
            feriados = new FechaConindice(new DateTime(DateTime.Now.Year, 4, 2), 4);
            listaFeriados.Add(feriados);
            feriados = new FechaConindice(new DateTime(DateTime.Now.Year, 4, 2), 5);
            listaFeriados.Add(feriados);
            feriados = new FechaConindice(new DateTime(DateTime.Now.Year, 5, 1), 6);
            listaFeriados.Add(feriados);
            feriados = new FechaConindice(new DateTime(DateTime.Now.Year, 6, 20), 7);
            listaFeriados.Add(feriados);
            feriados = new FechaConindice(new DateTime(DateTime.Now.Year, 7, 9), 8);
            listaFeriados.Add(feriados);
            listaFeriados.Sort();

            AgregarFeriados(listaFeriados);
            if (lbListaFeriados.Items.Count > 0)
            {
                lbListaFeriados.Enabled = true;
            }
        }
        private void btnGenerarFechas_Click(object sender, EventArgs e)
        {
            bool state = false;
            List<int> diasElegidos = new List<int>();
            rtbFechasFinales.Clear();
            listaDias.Clear();

            //CALCULA QUE DÍAS A LA SEMANA SE SELECCIONÓ
            for (int i = 0; i < clbDíasSemana.Items.Count; i++)
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
                /*foreach (DateTime dt in listaFeriados)
                {
                    if(listaDias.IndexOf(dt) != -1)
                    {
                        listaDias.RemoveAt(listaDias.IndexOf(dt));
                    }
                }*/
                foreach (DateTime dt in listaDias)
                {
                    rtbFechasFinales.Text += dt.ToString() + "\n";
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
                listaFeriados.Add(VentanaNuevoFeriado.dtpFechaFeriado.Value);
            }
            VentanaNuevoFeriado.Dispose();
        }

        private void btnQuitarFeriado_Click(object sender, EventArgs e)
        {
            lbListaFeriados.SelectedIndex
            listaFeriados.RemoveAt(lbListaFeriados.SelectedIndex);
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
