using System.Runtime.InteropServices;

namespace CantPersonasEnSala
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

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tCupoTotal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tCupoTotal.Width, tCupoTotal.Height, 10, 10));
            tCantidadActual.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tCantidadActual.Width, tCantidadActual.Height, 10, 10));
        }

        private void bCalcularP_Click(object sender, EventArgs e)
        {
            double CupoTotal = Convert.ToDouble(tCupoTotal.Text);
            double cantidadActual = Convert.ToDouble(tCantidadActual.Text);
            double porcentaje = cantidadActual / CupoTotal * 100;

            MessageBox.Show($"El porcentaje es de: {porcentaje}%", "Total de personas en la sala");
        }

        private void bIngreso_Click(object sender, EventArgs e)
        {
            double CupoTotal = Convert.ToDouble(tCupoTotal.Text);
            double cantidadActual = Convert.ToDouble(tCantidadActual.Text);
            if (cantidadActual < CupoTotal)
            {
                cantidadActual++;
                tCantidadActual.Text = cantidadActual.ToString();
            }
            else
            {
                MessageBox.Show("La sala está llena.", "Error");
            }
        }

        private void bDecremento_Click(object sender, EventArgs e)
        {
            double CupoTotal = Convert.ToDouble(tCupoTotal.Text);
            double cantidadActual = Convert.ToDouble(tCantidadActual.Text);
            if (cantidadActual > 0)
            {
                cantidadActual--;
                tCantidadActual.Text = cantidadActual.ToString();
            }
            else
            {
                MessageBox.Show("La sala está vacía.", "Error");
            }
        }

        //código sin condicional, con función Math.Max()
        /*
         private void bDecremento_Click(object sender, EventArgs e)
        {
            double cantidadActual = Convert.ToDouble(tCantidadActual.Text);
            cantidadActual = Math.Max(0, cantidadActual - 1);
            tCantidadActual.Text = cantidadActual.ToString();
        }   */
    }
}