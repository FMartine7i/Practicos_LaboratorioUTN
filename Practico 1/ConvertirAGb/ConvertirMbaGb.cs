using System.Runtime.InteropServices;

namespace ConvertirAGb
{
    public partial class fConvertirMbaGb : Form
    {
        public fConvertirMbaGb()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
        }

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

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string N_Archivo = tNArchivo.Text;
            double tamanoArchivo = Convert.ToDouble(tTamano.Text);
            double megabytes = 1024;

            double gigabytes = tamanoArchivo / megabytes;

            MessageBox.Show($"El tamaño de {N_Archivo} es de {gigabytes} Gb", "Tamaño en Gb");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}