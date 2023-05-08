using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sucesiones_TP4
{
    public partial class FSucesiones : Form
    {
        public FSucesiones()
        {
            InitializeComponent();
        }

        private void BTablaMultiplicar_Click(object sender, EventArgs e)
        {
            int num = (int)NUDTabla.Value;
            string resultadoTabla = "";
            int i = 0;

            while (i <= 10)
            {
                int resultado = i * num;
                resultadoTabla += $"{i} * {num} = {resultado}\n";
                i++;
            }
            LRespuesta.Text = $"Tabla del {num}\n\n" + resultadoTabla;
        }

        private void BFibonacci_Click(object sender, EventArgs e)
        {
            int num1 = 1, num2 = 2, num3;
            int valor = (int)NUDFibonacci.Value;
            int i = 2;
            string resultadoFibonacci = "1, 1, ";

            do
            {
                num3 = num1 + num2;
                resultadoFibonacci += num3 + ", ";
                num1 = num2;
                num2 = num3;
                i++;
            } while (i <= valor);
            resultadoFibonacci.TrimEnd(',', ' ');
            LRespuesta.Text = $"Sucesión de Fibonacci\n{resultadoFibonacci}";
        }

        private void BSerie_Click(object sender, EventArgs e)
        {
            int desde = (int)NUDDesde.Value;
            int cada = (int)NUDCada.Value;
            int hasta = (int)NUDHasta.Value;
            string resultado = "";

            if (desde < hasta)
            {
                for (int i = desde; i <= hasta; i += cada)
                {
                    resultado += i.ToString() + ", ";
                }

                resultado.TrimEnd(',', ' ');
                LRespuesta.Text = $"Serie\n{resultado}";
            }
            else
            {
                MessageBox.Show("El número desde debe ser menor que el número hasta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LRespuesta_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea eliminar el label LRespuesta?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (respuesta == DialogResult.OK)
            {
                LRespuesta.Text = "";
            }
        }

        private void BCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("¿Desea cerrar el programa?", "icono", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}