using System.Runtime.InteropServices;

namespace arena_necesaria
{
    public partial class fCantidadArena : Form
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

        public fCantidadArena()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double ancho = Convert.ToDouble(tAncho.Text);
            double alto = Convert.ToDouble(tAlto.Text);
            double cantRevoque = Convert.ToDouble(tRevoque.Text);

            // Calcula el área de la pared
            double area = ancho * alto;

            // Calcula la cantidad de arena que se usará en total
            double ArenaTotal = area * cantRevoque;

            MessageBox.Show($"Se necesitarán {ArenaTotal} m^3 para una pared de área de {area} m^2", "Cálculo");
        }
    }
}