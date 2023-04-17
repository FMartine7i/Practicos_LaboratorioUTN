using Microsoft.VisualBasic.Logging;
using System.Drawing;
using System;

namespace SumatoriaHoras
{
    public partial class Form1 : Form
    {
        public Form1()
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

            int sumaHoras = Hora1 + Hora2;
            int sumaMinutos = Minutos1 + Minutos2;
            int sumaSegundos = Segundos1 + Segundos2;

            if (sumaHoras >= 24)
            {
                MessageBox.Show("No hay más de 24 horas.", "Error");
                return;
            }

            if (sumaMinutos >= 60)
            {
                MessageBox.Show("No puede superar los 60 Minutos.", "Error");
                return;
            }

            if (sumaSegundos >= 60)
            {
                MessageBox.Show("No puede superar los 60 segundos.", "Error");
                return;
            }

            MessageBox.Show($"La suma de los tiempos es: {sumaHoras} horas, {sumaMinutos} minutos, {sumaSegundos} segundos.");
        }


        private void customButton1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}