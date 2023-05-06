namespace Trabajo3_Categoria
{
    partial class FCategoria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bIngresar = new Button();
            bCancelar = new Button();
            lNombre = new Label();
            lApellido = new Label();
            lFecha = new Label();
            tNombre = new TextBox();
            tApellido = new TextBox();
            numDia = new NumericUpDown();
            numMes = new NumericUpDown();
            numAnio = new NumericUpDown();
            lCategorias = new Label();
            lCantBenjamin = new Label();
            lCantQuerubin = new Label();
            lCantInfantil = new Label();
            lCantCadete = new Label();
            lCantJuvenil = new Label();
            lCantAmateur = new Label();
            lCantVeteranos = new Label();
            ((System.ComponentModel.ISupportInitialize)numDia).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAnio).BeginInit();
            SuspendLayout();
            // 
            // bIngresar
            // 
            bIngresar.BackColor = Color.FromArgb(90, 93, 16, 129);
            bIngresar.FlatStyle = FlatStyle.Flat;
            bIngresar.ForeColor = Color.Aqua;
            bIngresar.Location = new Point(179, 235);
            bIngresar.Name = "bIngresar";
            bIngresar.Size = new Size(172, 38);
            bIngresar.TabIndex = 0;
            bIngresar.Text = "&Ingresar";
            bIngresar.UseVisualStyleBackColor = false;
            bIngresar.Click += bIngresar_Click;
            // 
            // bCancelar
            // 
            bCancelar.AutoSize = true;
            bCancelar.BackColor = Color.FromArgb(109, 40, 129);
            bCancelar.Dock = DockStyle.Bottom;
            bCancelar.FlatStyle = FlatStyle.Flat;
            bCancelar.ForeColor = Color.Aqua;
            bCancelar.Location = new Point(0, 322);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(762, 42);
            bCancelar.TabIndex = 1;
            bCancelar.Text = "&Cancelar";
            bCancelar.UseVisualStyleBackColor = false;
            bCancelar.Click += bCancelar_Click;
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.BackColor = Color.Transparent;
            lNombre.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lNombre.ForeColor = Color.White;
            lNombre.Location = new Point(85, 91);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(77, 21);
            lNombre.TabIndex = 2;
            lNombre.Text = "Nombre:";
            // 
            // lApellido
            // 
            lApellido.AutoSize = true;
            lApellido.BackColor = Color.Transparent;
            lApellido.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lApellido.ForeColor = Color.White;
            lApellido.Location = new Point(84, 138);
            lApellido.Name = "lApellido";
            lApellido.Size = new Size(78, 21);
            lApellido.TabIndex = 3;
            lApellido.Text = "Apellido:";
            // 
            // lFecha
            // 
            lFecha.AutoSize = true;
            lFecha.BackColor = Color.Transparent;
            lFecha.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lFecha.ForeColor = Color.White;
            lFecha.Location = new Point(15, 185);
            lFecha.Name = "lFecha";
            lFecha.Size = new Size(147, 21);
            lFecha.TabIndex = 4;
            lFecha.Text = "Fecha de Nacim.:";
            // 
            // tNombre
            // 
            tNombre.BackColor = Color.FromArgb(112, 0, 76);
            tNombre.BorderStyle = BorderStyle.FixedSingle;
            tNombre.ForeColor = SystemColors.Window;
            tNombre.Location = new Point(179, 92);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(172, 23);
            tNombre.TabIndex = 5;
            // 
            // tApellido
            // 
            tApellido.BackColor = Color.FromArgb(112, 0, 76);
            tApellido.BorderStyle = BorderStyle.FixedSingle;
            tApellido.ForeColor = SystemColors.Window;
            tApellido.Location = new Point(179, 136);
            tApellido.Name = "tApellido";
            tApellido.Size = new Size(172, 23);
            tApellido.TabIndex = 6;
            // 
            // numDia
            // 
            numDia.BackColor = Color.FromArgb(112, 0, 76);
            numDia.BorderStyle = BorderStyle.FixedSingle;
            numDia.ForeColor = SystemColors.Window;
            numDia.Location = new Point(179, 187);
            numDia.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numDia.Name = "numDia";
            numDia.Size = new Size(38, 23);
            numDia.TabIndex = 7;
            numDia.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numMes
            // 
            numMes.BackColor = Color.FromArgb(112, 0, 76);
            numMes.BorderStyle = BorderStyle.FixedSingle;
            numMes.ForeColor = SystemColors.Window;
            numMes.Location = new Point(234, 187);
            numMes.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numMes.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMes.Name = "numMes";
            numMes.Size = new Size(38, 23);
            numMes.TabIndex = 8;
            numMes.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numAnio
            // 
            numAnio.BackColor = Color.FromArgb(112, 0, 76);
            numAnio.BorderStyle = BorderStyle.FixedSingle;
            numAnio.ForeColor = SystemColors.Window;
            numAnio.Location = new Point(289, 187);
            numAnio.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numAnio.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            numAnio.Name = "numAnio";
            numAnio.Size = new Size(62, 23);
            numAnio.TabIndex = 9;
            numAnio.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // lCategorias
            // 
            lCategorias.AutoSize = true;
            lCategorias.BackColor = Color.Transparent;
            lCategorias.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lCategorias.ForeColor = Color.White;
            lCategorias.Location = new Point(391, 93);
            lCategorias.Name = "lCategorias";
            lCategorias.Size = new Size(97, 19);
            lCategorias.TabIndex = 10;
            lCategorias.Text = "Categorias:";
            // 
            // lCantBenjamin
            // 
            lCantBenjamin.AutoSize = true;
            lCantBenjamin.BackColor = Color.Transparent;
            lCantBenjamin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lCantBenjamin.ForeColor = Color.White;
            lCantBenjamin.Location = new Point(391, 174);
            lCantBenjamin.Name = "lCantBenjamin";
            lCantBenjamin.Size = new Size(102, 21);
            lCantBenjamin.TabIndex = 11;
            lCantBenjamin.Text = "Benjamín: 0.";
            // 
            // lCantQuerubin
            // 
            lCantQuerubin.AutoSize = true;
            lCantQuerubin.BackColor = Color.Transparent;
            lCantQuerubin.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lCantQuerubin.ForeColor = Color.White;
            lCantQuerubin.Location = new Point(389, 134);
            lCantQuerubin.Name = "lCantQuerubin";
            lCantQuerubin.Size = new Size(104, 21);
            lCantQuerubin.TabIndex = 12;
            lCantQuerubin.Text = "Querubín: 0.";
            // 
            // lCantInfantil
            // 
            lCantInfantil.AutoSize = true;
            lCantInfantil.BackColor = Color.Transparent;
            lCantInfantil.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lCantInfantil.ForeColor = Color.White;
            lCantInfantil.Location = new Point(391, 213);
            lCantInfantil.Name = "lCantInfantil";
            lCantInfantil.Size = new Size(85, 21);
            lCantInfantil.TabIndex = 13;
            lCantInfantil.Text = "Infantil: 0.";
            // 
            // lCantCadete
            // 
            lCantCadete.AutoSize = true;
            lCantCadete.BackColor = Color.Transparent;
            lCantCadete.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lCantCadete.ForeColor = Color.White;
            lCantCadete.Location = new Point(391, 251);
            lCantCadete.Name = "lCantCadete";
            lCantCadete.Size = new Size(93, 21);
            lCantCadete.TabIndex = 14;
            lCantCadete.Text = "Cadete: 0.";
            // 
            // lCantJuvenil
            // 
            lCantJuvenil.AutoSize = true;
            lCantJuvenil.BackColor = Color.Transparent;
            lCantJuvenil.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lCantJuvenil.ForeColor = Color.White;
            lCantJuvenil.Location = new Point(517, 136);
            lCantJuvenil.Name = "lCantJuvenil";
            lCantJuvenil.Size = new Size(85, 21);
            lCantJuvenil.TabIndex = 15;
            lCantJuvenil.Text = "Juvenil: 0.";
            // 
            // lCantAmateur
            // 
            lCantAmateur.AutoSize = true;
            lCantAmateur.BackColor = Color.Transparent;
            lCantAmateur.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lCantAmateur.ForeColor = Color.White;
            lCantAmateur.Location = new Point(517, 174);
            lCantAmateur.Name = "lCantAmateur";
            lCantAmateur.Size = new Size(102, 21);
            lCantAmateur.TabIndex = 16;
            lCantAmateur.Text = "Amateur: 0.";
            // 
            // lCantVeteranos
            // 
            lCantVeteranos.AutoSize = true;
            lCantVeteranos.BackColor = Color.Transparent;
            lCantVeteranos.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lCantVeteranos.ForeColor = Color.White;
            lCantVeteranos.Location = new Point(517, 212);
            lCantVeteranos.Name = "lCantVeteranos";
            lCantVeteranos.Size = new Size(111, 21);
            lCantVeteranos.TabIndex = 17;
            lCantVeteranos.Text = "Veteranos: 0.";
            // 
            // FCategoria
            // 
            AcceptButton = bIngresar;
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BasketAppBackG;
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bCancelar;
            ClientSize = new Size(762, 364);
            Controls.Add(lCantVeteranos);
            Controls.Add(lCantAmateur);
            Controls.Add(lCantJuvenil);
            Controls.Add(lCantCadete);
            Controls.Add(lCantInfantil);
            Controls.Add(lCantQuerubin);
            Controls.Add(lCantBenjamin);
            Controls.Add(lCategorias);
            Controls.Add(numAnio);
            Controls.Add(numMes);
            Controls.Add(numDia);
            Controls.Add(tApellido);
            Controls.Add(tNombre);
            Controls.Add(lFecha);
            Controls.Add(lApellido);
            Controls.Add(lNombre);
            Controls.Add(bCancelar);
            Controls.Add(bIngresar);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FCategoria";
            Text = "Categorias";
            Load += FCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)numDia).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMes).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bIngresar;
        private Button bCancelar;
        private Label lNombre;
        private Label lApellido;
        private Label lFecha;
        private TextBox tNombre;
        private TextBox tApellido;
        private NumericUpDown numDia;
        private NumericUpDown numMes;
        private NumericUpDown numAnio;
        private Label lCategorias;
        private Label lCantBenjamin;
        private Label lCantQuerubin;
        private Label lCantInfantil;
        private Label lCantCadete;
        private Label lCantJuvenil;
        private Label lCantAmateur;
        private Label lCantVeteranos;
    }
}