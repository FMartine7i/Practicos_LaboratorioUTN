namespace Movedizo
{
    public partial class FMovedizo : Form
    {
        public FMovedizo()
        {
            InitializeComponent();
        }

        private void FMovedizo_Click(object sender, EventArgs e)
        {
            switch(this.BackColor.Name)
            {
                case "Gray":
                case "Green":
                    this.BackColor = Color.Red;
                    this.Text = "Rojo";
                    this.Left += 10;
                    this.Top += 10;
                    this.Width -= 15;
                    this.Height += 10;
                    break;
                case "Red":
                    this.BackColor = Color.Blue;
                    this.Text = "Azul";
                    this.Left -= 15;
                    this.Width += 20;
                    this.Height += 5;
                    break;
                case "Blue":
                    this.BackColor = Color.Green;
                    this.Text = "Verde";
                    this.Left -= 5;
                    this.Top -= 15;
                    this.Width -= 5;
                    this.Height -= 15;
                    break;
            }
        }
    }
}