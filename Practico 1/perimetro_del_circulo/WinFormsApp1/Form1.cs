namespace WinFormsApp1
{
    public partial class fPerimetro : Form
    {
        public fPerimetro()
        {
            InitializeComponent();
        }

        private void lClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void bCalcularPerimetro_Click(object sender, EventArgs e)
        {
            string unidadMedida = tUnidad.Text;
            double radio = Convert.ToDouble(tRadio.Text);

            //Calcular el per�metro del c�rculo
            const double pi = 3.141592;
            double perimetro = pi * radio * 2;
            string valorFormateado = perimetro.ToString("0.00");

            //Muestra el resultado
            MessageBox.Show($"El per�metro del c�rculo es: {valorFormateado} {unidadMedida}");
        }

        private void bCalcularArea_Click(object sender, EventArgs e)
        {
            string unidadMedida = tUnidad.Text;
            double radio = Convert.ToDouble(tRadio.Text);

            //Calcular el per�metro del c�rculo
            const double pi = 3.141592;
            double area = pi * Math.Pow(radio, 2);

            //Muestra el resultado
            MessageBox.Show($"El area del c�rculo es: {area} {unidadMedida}");
        }

    }
}