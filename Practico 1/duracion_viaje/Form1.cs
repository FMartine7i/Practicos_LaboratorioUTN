namespace duracion_viaje
{

    public partial class fDuracionViaje : Form
    {

        public fDuracionViaje()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void lClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bTiempo_Click(object sender, EventArgs e)
        {
            // toma datos de ingreso
            string destino = tLugarDestino.Text;
            double distancia = Convert.ToDouble(tDistancia.Text);
            double velocidad = Convert.ToDouble(tVelocidad.Text);

            // calcula el tiempo de llegada
            double tiempo = distancia / velocidad;

            // resultado
            MessageBox.Show($"El tiempo hasta {destino} será de {tiempo} horas");
        }
    }
}