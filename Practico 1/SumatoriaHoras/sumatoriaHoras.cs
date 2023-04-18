using Microsoft.VisualBasic.Logging;
using System.Drawing;
using System;

namespace SumatoriaHoras
{
    public partial class fSumaHoras : Form
    {
        public fSumaHoras()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int Hora1 = int.Parse(tHoras1.Text);
            int Hora2 = int.Parse(tHoras2.Text);
            int Minutos1 = int.Parse(tMinutos1.Text);
            int Minutos2 = int.Parse(tMinutos2.Text);
            int Segundos1 = int.Parse(tSegundos1.Text);
            int Segundos2 = int.Parse(tSegundos2.Text);

            int total = Segundos1 + Segundos2 + (Minutos1 * 60) + (Minutos2 * 60) + (Hora1 * 3600) + (Hora2 * 3600);

            int HorasEnTotal = total / 3600;
            int MinutosEnTotal = (total % 3600) / 60;
            int SegundosEnTotal = (total % 3600) % 60;

            MessageBox.Show($"La suma de los tiempos es: {HorasEnTotal} horas, {MinutosEnTotal} minutos, {SegundosEnTotal} segundos.");
        }


        private void customButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}