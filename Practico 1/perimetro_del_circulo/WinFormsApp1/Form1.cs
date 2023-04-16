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

            //Calcular el perímetro del círculo
            const double pi = 3.141592;
            double perimetro = pi * radio * 2;
            string valorFormateado = perimetro.ToString("0.00");

            //Muestra el resultado
            MessageBox.Show($"El perímetro del círculo es: {valorFormateado} {unidadMedida}");
        }

        private void bCalcularArea_Click(object sender, EventArgs e)
        {
            string unidadMedida = tUnidad.Text;
            double radio = Convert.ToDouble(tRadio.Text);

            //Calcular el perímetro del círculo
            const double pi = 3.141592;
            double area = pi * Math.Pow(radio, 2);

            //Muestra el resultado
            MessageBox.Show($"El area del círculo es: {area} {unidadMedida}");
        }

    }
}