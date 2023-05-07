namespace Trabajo3_Categoria
{
    public partial class FCategoria : Form
    {
        public FCategoria()
        {
            InitializeComponent();
        }

        private void bIngresar_Click(object sender, EventArgs e)
        {
            string nombre = tNombre.Text;
            string categoria = "";
            string apellido = tApellido.Text;
            int dia = (int)numDia.Value;
            int mes = (int)numMes.Value;
            int anio = (int)numAnio.Value;
            bool esBisiesto = (anio % 4 == 0 && anio % 100 != 0);
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - anio;

            if (nombre.Length == 0)
            {
                MessageBox.Show("El nombre est� vac�o.", "Error");
                tNombre.Focus();
                return;
            }
            else if (apellido.Length == 0)
            {
                MessageBox.Show("El apellido est� vac�o.", "Error");
                tApellido.Focus();
                return;
            }

            switch (mes)
            {
                case 2:
                    if (mes == 2 && dia > 29)
                    {
                        MessageBox.Show("El d�a ingresado es inv�lido para febrero", "ERROR");
                        numDia.Focus();
                    }
                    else if (mes == 2 && dia == 29 && !esBisiesto)
                    {
                        MessageBox.Show("El a�o ingresado no es bisiesto: febrero no tiene 29 d�as", "ERROR");
                        numDia.Focus();
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (dia > 30)
                    {
                        MessageBox.Show("Fecha inv�lida", "Error");
                    }
                    break;
            }

            if (fechaActual.Month > mes || (fechaActual.Month == mes && fechaActual.Day < dia))
                edad--;

            if (edad >= 3 && edad <= 5)
            {
                string querubin = lCantQuerubin.Text;
                string valorActual = querubin.Substring(10); // 11 es la posici�n de la primera cifra
                int cantQuerubin;

                if (valorActual.Length == 1)
                {
                    cantQuerubin = int.Parse(valorActual);
                    cantQuerubin++;
                    lCantQuerubin.Text = "Querub�n: " + cantQuerubin.ToString();
                }
                else if (valorActual.Length == 2)
                {
                    cantQuerubin = int.Parse(valorActual);
                    cantQuerubin++;
                    lCantQuerubin.Text = "Querub�n: " + cantQuerubin.ToString("D2");
                }

                categoria = "Querub�n";
            }
            else if (edad >= 6 && edad <= 8)
            {
                string benjamin = lCantBenjamin.Text;
                string valorActual = benjamin.Substring(10);
                int cantBenjamin;

                if (valorActual.Length == 1)
                {
                    cantBenjamin = int.Parse(valorActual);
                    cantBenjamin++;
                    lCantBenjamin.Text = "Benjam�n: " + cantBenjamin.ToString();
                }
                else if (valorActual.Length == 2)
                {
                    cantBenjamin = int.Parse(valorActual);
                    cantBenjamin++;
                    lCantBenjamin.Text = "Benjam�n: " + cantBenjamin.ToString("D2");
                }

                categoria = "Benjam�n";
            }
            else if (edad >= 9 && edad <= 12)
            {
                categoria = "Infantil";

                string infantil = lCantInfantil.Text;
                string valorActual = infantil.Substring(10);
                int cantInfantil;

                if (valorActual.Length == 1)
                {
                    cantInfantil = int.Parse(valorActual);
                    cantInfantil++;
                    lCantInfantil.Text = "Infantil: " + cantInfantil.ToString();
                }
                else if (valorActual.Length == 2)
                {
                    cantInfantil = int.Parse(valorActual);
                    cantInfantil++;
                    lCantInfantil.Text = "Infantil: " + cantInfantil.ToString("D2");
                }
            }
            else if (edad >= 13 && edad <= 15)
            {
                categoria = "Cadete";

                string cadete = lCantCadete.Text;
                string valorActual = cadete.Substring(8);
                int cantCadete;

                if (valorActual.Length == 1)
                {
                    cantCadete = int.Parse(valorActual);
                    cantCadete++;
                    lCantCadete.Text = "Cadete: " + cantCadete.ToString();
                }
                else if (valorActual.Length == 2)
                {
                    cantCadete = int.Parse(valorActual);
                    cantCadete++;
                    lCantCadete.Text = "Cadete: " + cantCadete.ToString("D2");
                }
            }
            else if (edad >= 16 && edad <= 18)
            {
                categoria = "Juvenil";

                string juvenil = lCantJuvenil.Text;
                string valorActual = juvenil.Substring(9);
                int cantJuvenil;

                if (valorActual.Length == 1)
                {
                    cantJuvenil = int.Parse(valorActual);
                    cantJuvenil++;
                    lCantJuvenil.Text = "Juvenil: " + cantJuvenil.ToString();
                }
                else if (valorActual.Length == 2)
                {
                    cantJuvenil = int.Parse(valorActual);
                    cantJuvenil++;
                    lCantJuvenil.Text = "Juvenil: " + cantJuvenil.ToString("D2");
                }
            }
            else if (edad >= 19 && edad <= 30)
            {
                categoria = "Amateur";

                string amateur = lCantAmateur.Text;
                string valorActual = amateur.Substring(9);
                int cantAmateur;

                if (valorActual.Length == 1)
                {
                    cantAmateur = int.Parse(valorActual);
                    cantAmateur++;
                    lCantAmateur.Text = "Amateur: " + cantAmateur.ToString();
                }
                else if (valorActual.Length == 2)
                {
                    cantAmateur = int.Parse(valorActual);
                    cantAmateur++;
                    lCantAmateur.Text = "Amateur: " + cantAmateur.ToString("D2");
                }
            }
            else if (edad > 30)
            {
                categoria = "Veteranos";

                string veterano = lCantVeteranos.Text;
                string valorActual = veterano.Substring(11);
                int cantVeterano;

                if (valorActual.Length == 1)
                {
                    cantVeterano = int.Parse(valorActual);
                    cantVeterano++;
                    lCantVeteranos.Text = "Veteranos: " + cantVeterano.ToString();
                }
                else if (valorActual.Length == 2)
                {
                    cantVeterano = int.Parse(valorActual);
                    cantVeterano++;
                    lCantVeteranos.Text = "Veteranos: " + cantVeterano.ToString("D2");
                }
            }
            else
            {
                MessageBox.Show("No se puede ingresar: menor de edad", "ERROR");
                return;
            }

            MessageBox.Show($"Ingreso Exitoso:\n-{apellido}, {nombre}\n-Edad: {edad} a�os\n-Categor�a: {categoria}");
            tNombre.Clear();
            tNombre.Focus();
            tApellido.Clear();
            numDia.Value = 1;
            numMes.Value = 1;
            numAnio.Value = 2000;
        }

        private void FCategoria_Load(object sender, EventArgs e)
        {
            int maxValue = DateTime.Today.Year - 2;

            numAnio.Maximum = maxValue;
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Font originalFont;

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            originalFont = label1.Font; // guarda la fuente original del Label
            label1.Font = new Font(originalFont.FontFamily, originalFont.Size + 2);
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.Font = originalFont;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            originalFont = label2.Font;
            label2.Font = new Font(originalFont.FontFamily, originalFont.Size + 2);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.Font = originalFont;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            originalFont = label4.Font;
            label4.Font = new Font(originalFont.FontFamily, originalFont.Size + 2);
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.Font = originalFont;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            originalFont = label3.Font;
            label3.Font = new Font(originalFont.FontFamily, originalFont.Size + 2);
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.Font = originalFont;
        }
    }
}