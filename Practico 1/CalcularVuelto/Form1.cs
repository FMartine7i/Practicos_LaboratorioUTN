using System.Runtime.InteropServices;

namespace CalcularVuelto
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
                    int nLeftRect,     // x-coordinate of upper-left corner
                    int nTopRect,      // y-coordinate of upper-left corner
                    int nRightRect,    // x-coordinate of lower-right corner
                    int nBottomRect,   // y-coordinate of lower-right corner
                    int nWidthEllipse, // height of ellipse
                    int nHeightEllipse // width of ellipse
            );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tNombre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tNombre.Width, tNombre.Height, 10, 10));
            tValor.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tValor.Width, tValor.Height, 10, 10));
            tMonto.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tMonto.Width, tMonto.Height, 10, 10));
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            double monto = Convert.ToDouble(tMonto.Text);
            double valor = Convert.ToDouble(tValor.Text);

            if (monto > valor)
            {
                double vuelto = monto - valor;
                MessageBox.Show($"El vuelto correspondiente a {nombre} es de {vuelto}$", "Vuelto");
            }
            else
            {
                MessageBox.Show("El monto pagado no puede ser mayor al valor de la compra.", "error");
            }
        }
    }
}