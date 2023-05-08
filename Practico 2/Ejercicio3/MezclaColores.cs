namespace Ejercicio3
{
    public partial class FColores : Form
    {
        public FColores()
        {
            InitializeComponent();
        }

        int contadorAmarillo = 0;
        int contadorAzul = 0;
        int contadorRojo = 0;

        private void bAmarillo_Click(object sender, EventArgs e)
        {
            switch (this.BackColor.Name)
            {
                case "Red": 
                    this.BackColor = Color.Orange; 
                    break;
                case "Blue": 
                    this.BackColor = Color.Green; 
                    break;
                case "Purple": 
                    this.BackColor = Color.Black; 
                    break;
                default: 
                    this.BackColor = Color.Yellow; 
                    break;
            }


            contadorAmarillo++;

            if (contadorAmarillo > 0)
                bCerrar.Visible = true;
        }

        private void bRojo_Click(object sender, EventArgs e)
        {
            switch (this.BackColor.Name)
            {
                case "Yellow":
                    this.BackColor = Color.Orange;
                    break;
                case "Blue":
                    this.BackColor = Color.Purple;
                    break;
                case "Purple":
                    this.BackColor = Color.Red;
                    break;
                default:
                    this.BackColor = Color.Red;
                    break;
            }

            contadorRojo++;

            if (contadorRojo > 0)
                bCerrar.Visible = true;
        }

        private void bAzul_Click(object sender, EventArgs e)
        {
            switch (this.BackColor.Name)
            {
                case "Yellow":
                    this.BackColor = Color.Green;
                    break;
                case "Red":
                    this.BackColor = Color.Purple;
                    break;
                case "Orange":
                    this.BackColor = Color.Black;
                    break;
                default:
                    this.BackColor = Color.Blue;
                    break;
            }

            contadorAzul++;

            if (contadorAzul > 0)
                bCerrar.Visible = true;
        }

        string primero = "";
        string segundo = "";
        string tercero = "";
        int contPrimero, contSegundo, contTercero;
        private void bCerrar_Click(object sender, EventArgs e)
        {
            if (contadorAmarillo > contadorAzul && contadorAmarillo > contadorRojo)
            {
                primero = "Amarillo";
                contPrimero = contadorAmarillo;

                if (contadorAzul > contadorRojo)
                {
                    segundo = "Azul";
                    contSegundo = contadorAzul;

                    tercero = "Rojo";
                    contTercero = contadorRojo;
                }
                else
                {
                    segundo = "Rojo";
                    contSegundo = contadorRojo;

                    tercero = "Azul";
                    contTercero = contadorAzul;
                }
            }
            else if (contadorAzul > contadorAmarillo && contadorAzul > contadorRojo)
            {
                primero = "Azul";
                contPrimero = contadorAzul;

                if (contadorRojo > contadorAmarillo)
                {
                    segundo = "Rojo";
                    contSegundo = contadorRojo;

                    tercero = "Amarillo";
                    contTercero = contadorAmarillo;
                }
                else
                {
                    segundo = "Amarillo";
                    contSegundo = contadorAmarillo;

                    tercero = "Rojo";
                    contTercero = contadorRojo;
                }
            }
            else
            {
                primero = "Rojo";
                contPrimero = contadorRojo;

                if (contadorAzul > contadorAmarillo)
                {
                    segundo = "Azul";
                    contSegundo = contadorAzul;

                    tercero = "Amarillo";
                    contTercero = contadorAmarillo;
                }
                else
                {
                    segundo = "Amarillo";
                    contSegundo = contadorAmarillo;

                    tercero = "Azul";
                    contTercero = contadorAzul;
                }
            }

            string plur1 = "";
            string plur2 = "";
            string plur3 = "";

            if (contPrimero > 1 || contPrimero == 0)
                plur1 = "veces";
            else
                plur1 = "vez";

            if (contSegundo > 1 || contSegundo == 0)
                plur2 = "veces";
            else
                plur2 = "vez";

            if (contTercero > 1 || contTercero == 0)
                plur3 = "veces";
            else
                plur3 = "vez";


            MessageBox.Show($"1°. - \"{primero}\": {contPrimero} {plur1}.\n2°. - \"{segundo}\": {contSegundo} {plur2}.\n3°. - \"{tercero}\": {contTercero} {plur3}.", "Ranking");
            Close();
        }
    }
}