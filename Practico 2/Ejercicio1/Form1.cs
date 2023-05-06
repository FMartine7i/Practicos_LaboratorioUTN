namespace Ejercicio1
{
    public partial class FCondicionalTernario : Form
    {
        public FCondicionalTernario()
        {
            InitializeComponent();
        }

        private void bCalcularAbs_Click(object sender, EventArgs e)
        {
            int num = int.Parse(tNum.Text);

            int valorAbs = num < 0 ? -num : num;

            MessageBox.Show($"El valor absoluto de {num} es {valorAbs}.");
        }

        private void bRedondear_Click(object sender, EventArgs e)
        {
            double num = Convert.ToDouble(tNum.Text);
            int entero = (int)num;
            double parteDecimal = num - entero;

            int round = parteDecimal >= 0.5 ? entero + 1 : entero;

            MessageBox.Show($"{num} redondeado es {round}.");
        }
    }
}