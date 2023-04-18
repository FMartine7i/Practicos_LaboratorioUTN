namespace IntercambDatos
{
    public partial class fIntercambiarDatos : Form
    {
        public fIntercambiarDatos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void bIntercambio_Click(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(tvalorA.Text);
            double B = Convert.ToDouble(tvalorB.Text);

            double intercambio = A;
            A = B;
            B = intercambio;


            MessageBox.Show($"El Valor de A es {A}.");
            MessageBox.Show($"El Valor de B es {B}.");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}