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
            int cantQuerubin = 0;
            int cantBenjamin = 0;
            int cantInfantil = 0;
            int cantCadete = 0;
            int cantJuvenil = 0;
            int cantAmateur = 0;
            int cantVeteranos = 0;
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
                MessageBox.Show("El nombre está vacío.", "Error");
                tNombre.Focus();
                return;
            }
            else if (apellido.Length == 0)
            {
                MessageBox.Show("El apellido está vacío.", "Error");
                tApellido.Focus();
                return;
            }

            switch (mes)
            {
                case 2:
                    if (mes == 2 && dia > 29)
                    {
                        MessageBox.Show("El día ingresado es inválido para febrero", "ERROR");
                        numDia.Focus();
                    }
                    else if (mes == 2 && dia == 29 && !esBisiesto)
                    {
                        MessageBox.Show("El año ingresado no es bisiesto: febrero no tiene 29 días", "ERROR");
                        numDia.Focus();
                    }
                    break;
                case 3:
                case 6:
                case 9:
                case 11:
                    if (dia > 30)
                    {
                        MessageBox.Show("Fecha inválida", "Error");
                    }
                    break;
            }

            if (fechaActual.Month > mes || (fechaActual.Month == mes && fechaActual.Day < dia))
                edad--;

            if (edad >= 3 && edad <= 5)
            {
                categoria = "Querubín";
                cantQuerubin++;
                lCantQuerubin.Text = $"Querubín: {cantQuerubin}.";
            }
            else if (edad >= 6 && edad <= 8)
            {
                categoria = "Benjamín";
                cantBenjamin++;
                lCantBenjamin.Text = $"Benjamín: {cantBenjamin}.";
            }
            else if (edad >= 9 && edad <= 12)
            {
                categoria = "Infantil";
                cantInfantil++;
                lCantInfantil.Text = $"Infantil: {cantInfantil}.";
            }
            else if (edad >= 13 && edad <= 15)
            {
                categoria = "Cadete";
                cantCadete++;
                lCantCadete.Text = $"Cadete: {cantCadete}.";
            }
            else if (edad >= 16 && edad <= 18)
            {
                categoria = "Juvenil";
                cantJuvenil++;
                lCantJuvenil.Text = $"Juvenil: {cantJuvenil}.";
            }
            else if (edad >= 19 && edad <= 30)
            {
                categoria = "Amateur";
                cantAmateur++;
                lCantAmateur.Text = $"Amateur: {cantAmateur}.";
            }
            else if (edad > 30)
            {
                categoria = "Veteranos";
                cantVeteranos++;
                lCantVeteranos.Text = $"Veteranos: {cantVeteranos}.";
            }
            else
            {
                MessageBox.Show("No se puede ingresar: menor de edad", "ERROR");
                return;
            }

            MessageBox.Show($"Ingreso Exitoso:\n-{apellido}, {nombre}\n-Edad: {edad} años\n-Categoría: {categoria}");
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
    }
}