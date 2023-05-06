using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP3_Etiqueta
{
    public partial class FEtiqueta : Form
    {
        public FEtiqueta()
        {
            InitializeComponent();
        }

        private void FEtiqueta_Load(object sender, EventArgs e)
        {
            lEtiqueta.Top = 75;
            lEtiqueta.Anchor = AnchorStyles.Top | AnchorStyles.Left;
        }

        private void TTexto_TextChanged(object sender, EventArgs e)
        {
            string texto = TTexto.Text;

            texto = TTexto.Text.ToUpper();
            lEtiqueta.Text = texto;
            centrarEtiqueta();
        }


        private void bColor_Click(object sender, EventArgs e)
        {
            switch (lEtiqueta.ForeColor.Name)
               {
               case "Black":
                   lEtiqueta.ForeColor = Color.Purple;
                   break;
               case "Purple":
                   lEtiqueta.ForeColor = Color.DarkCyan;
                   break;
               case "DarkCyan":
                   lEtiqueta.ForeColor = Color.BlueViolet;
                   break;
               case "BlueViolet":
                   lEtiqueta.ForeColor = Color.LimeGreen;
                   break;
               case "LimeGreen":
                   lEtiqueta.ForeColor = Color.Black;
                   break;
               default:
                   lEtiqueta.ForeColor = Color.Black;
                   break; 
               } 
        }

        private void centrarEtiqueta()
        {           
            lEtiqueta.Left = (this.ClientSize.Width - lEtiqueta.Width) / 2;

            int labelTop = -275;
            int formHeight = this.ClientSize.Height;
            int labelHeight = lEtiqueta.Height;
            int newTop = labelTop + (formHeight - labelTop - labelHeight) / 2;

            lEtiqueta.Top = newTop;
        }

        private void bTamanioMas_Click(object sender, EventArgs e)
        {
            float tamanioFuente = lEtiqueta.Font.Size;

            if (tamanioFuente <= 20)
            {
                lEtiqueta.Font = new Font(lEtiqueta.Font.FontFamily, lEtiqueta.Font.Size + 2);
                centrarEtiqueta();               
            }
            else
            {
                MessageBox.Show("El tamaño máximo es 20!", "Error");
                return;
            }
        }

        private void bTamanioMenos_Click(object sender, EventArgs e)
        {
            float tamanioFuente = lEtiqueta.Font.Size;

            if (tamanioFuente >= 10)
            {
                lEtiqueta.Font = new Font(lEtiqueta.Font.FontFamily, lEtiqueta.Font.Size - 2);
                centrarEtiqueta();
            }
            else
            {
                MessageBox.Show("El tamaño mínimo es 10!", "Error");
                return;
            }
        }

        private void NUDLetra_ValueChanged(object sender, EventArgs e)
        {
            switch (NUDLetra.Value)
            {
                case 1:
                    lEtiqueta.Font = new Font("Century Gothic", lEtiqueta.Font.Size);
                    LLetra.Text = "Century Gothic";
                    centrarEtiqueta();
                    break;
                case 2:
                    lEtiqueta.Font = new Font("Impact", lEtiqueta.Font.Size);
                    LLetra.Text = "Impact";
                    centrarEtiqueta();
                    break;
                case 3:
                    lEtiqueta.Font = new Font("Script MT", lEtiqueta.Font.Size);
                    LLetra.Text = "Script MT";
                    centrarEtiqueta();
                    break;
                case 4:
                    lEtiqueta.Font = new Font("Segoe Script", lEtiqueta.Font.Size);
                    LLetra.Text = "Segoe Script";
                    centrarEtiqueta();
                    break;
            }
        }

        private void bSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}