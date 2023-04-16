using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace duracion_viaje
{

    public partial class fDuracionViaje : Form
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

        public fDuracionViaje()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void fDuracionViaje_Load(object sender, EventArgs e)
        {
            bTiempo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, bTiempo.Width, bTiempo.Height, 30, 30));
            tLugarDestino.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tLugarDestino.Width, tLugarDestino.Height, 10, 10));
            tDistancia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tDistancia.Width, tDistancia.Height, 10, 10));
            tVelocidad.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tVelocidad.Width, tVelocidad.Height, 10, 10));
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