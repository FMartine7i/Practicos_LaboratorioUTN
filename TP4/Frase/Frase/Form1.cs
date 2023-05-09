namespace Frase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BEliminarEspacios_Click(object sender, EventArgs e)
        {
            string frase = TFrase.Text;

            if (frase == "")
            {

                MessageBox.Show("El campo está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TFrase.Text = frase.Trim();
            }
        }

        private void BPasarOracion_Click(object sender, EventArgs e)
        {
            string frase = TFrase.Text;

            if (frase == "")
            {
                MessageBox.Show("El campo está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                char primeraLetra = frase[0];
                string letra = primeraLetra.ToString();
                string mayus = letra.ToUpper();

                string resto = frase.Substring(1);
                string minus = resto.ToLower();

                TFrase.Text = mayus + minus;
            }
        }

        private void BReemplazar_Click(object sender, EventArgs e)
        {
            string letra = TReemplazaLetra.Text;
            string nuevaLetra = TReemplazaPor.Text;
            string frase = TFrase.Text;

            if (letra == "" || nuevaLetra == "" || frase == "")
            {
                MessageBox.Show("El campo está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                char caracterBuscado = nuevaLetra[0];
                char caracterReemplazado = letra[0];

                for (int i = 0; i < frase.Length; i++)
                {
                    if (frase[i] == caracterReemplazado)
                        frase = frase.Substring(0, i) + caracterBuscado + frase.Substring(i + 1);
                }
            }
            TFrase.Text = frase;
        }

        private void BVocales_Click(object sender, EventArgs e)
        {
            string frase = TFrase.Text;
            if (frase == "")
            {
                MessageBox.Show("El campo está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int contadorVocales = 0;

                for (int i = 0; i < frase.Length; i++)
                {
                    char caracter = frase[i];
                    caracter = char.ToLower(caracter);

                    switch (caracter)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            contadorVocales++;
                            break;
                    }
                }
                LVocales.Text = "Cantidad de vocales: " + contadorVocales;
            }
        }

        private void BPalabras_Click(object sender, EventArgs e)
        {
            string frase = TFrase.Text;
            frase = frase.Trim();

            if (frase == "")
            {
                MessageBox.Show("El campo está vacío", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int contadorPalabras = 0;

                for (int i = 0; i < frase.Length; i++)
                {
                    char caracter = frase[i];
                    string espacio = caracter.ToString();

                    if (espacio == " ")
                        contadorPalabras++;
                }
                int cantidadPalabras = contadorPalabras + 1;
                LPalabras.Text = "Cantidad de palabras: " + cantidadPalabras;
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