using System.Runtime.InteropServices;

namespace sumatoriaCifras
{
    public partial class fSumatoria : Form
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

        public fSumatoria()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tNumero.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tNumero.Width, tNumero.Height, 10, 10));
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(tNumero.Text);

            if (numero >= 10 && numero <= 99)
            {
                int digito1 = numero / 10;
                int digito2 = numero % 10;

                int suma = digito1 + digito2;

                MessageBox.Show($"La suma de los dígitos es: {suma}.", "Resultado");
            }
            else
            {
                MessageBox.Show("Ingrese un número de dos cifras.", "Error");
            }
        }
    }
}