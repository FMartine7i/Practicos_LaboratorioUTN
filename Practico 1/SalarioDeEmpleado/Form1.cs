using System.Runtime.InteropServices;

namespace SalarioDeEmpleado
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
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            double ingreso = Convert.ToDouble(tIngreso.Text);
            double tarifaHoraria = Convert.ToDouble(tTarifa.Text);
            double HorasPorDia = Convert.ToDouble(tHorasTrabajadas.Text);
            double DiasPorMes = Convert.ToDouble(tDiasTrabajados.Text);
            double antiguedad = 2023 - ingreso;

            double sueldoBruto = tarifaHoraria * HorasPorDia * DiasPorMes;
            double retenciones = sueldoBruto * 0.2;
            double bonifAntiguedad = sueldoBruto * (antiguedad * 0.015);

            double salarioTotal = sueldoBruto - retenciones + bonifAntiguedad;

            MessageBox.Show($"El salario de {nombre} es de: {salarioTotal}$");
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tNombre.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tNombre.Width, tNombre.Height, 10, 10));
            tIngreso.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tIngreso.Width, tIngreso.Height, 10, 10));
            tTarifa.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tTarifa.Width, tTarifa.Height, 10, 10));
            tHorasTrabajadas.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tHorasTrabajadas.Width, tHorasTrabajadas.Height, 10, 10));
            tDiasTrabajados.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tDiasTrabajados.Width, tDiasTrabajados.Height, 10, 10));
        }
    }


}