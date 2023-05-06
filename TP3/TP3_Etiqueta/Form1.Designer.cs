namespace TP3_Etiqueta
{
    partial class FEtiqueta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEtiqueta));
            lEtiqueta = new Label();
            lTexto = new Label();
            llabel = new Label();
            NUDLetra = new NumericUpDown();
            bColor = new Button();
            bTamanioMenos = new Button();
            bTamanioMas = new Button();
            bSalir = new Button();
            TTexto = new TextBox();
            LLetra = new Label();
            ((System.ComponentModel.ISupportInitialize)NUDLetra).BeginInit();
            SuspendLayout();
            // 
            // lEtiqueta
            // 
            lEtiqueta.Anchor = AnchorStyles.Top;
            lEtiqueta.AutoSize = true;
            lEtiqueta.BackColor = Color.Transparent;
            lEtiqueta.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lEtiqueta.ForeColor = Color.Black;
            lEtiqueta.Location = new Point(123, 75);
            lEtiqueta.Name = "lEtiqueta";
            lEtiqueta.Size = new Size(95, 22);
            lEtiqueta.TabIndex = 0;
            lEtiqueta.Text = "ETIQUETA";
            // 
            // lTexto
            // 
            lTexto.AutoSize = true;
            lTexto.BackColor = Color.Transparent;
            lTexto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lTexto.ForeColor = Color.Silver;
            lTexto.Location = new Point(72, 156);
            lTexto.Name = "lTexto";
            lTexto.Size = new Size(45, 17);
            lTexto.TabIndex = 1;
            lTexto.Text = "Texto:";
            // 
            // llabel
            // 
            llabel.AutoSize = true;
            llabel.BackColor = Color.Transparent;
            llabel.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            llabel.ForeColor = Color.Silver;
            llabel.Location = new Point(72, 196);
            llabel.Name = "llabel";
            llabel.Size = new Size(44, 17);
            llabel.TabIndex = 2;
            llabel.Text = "Letra:";
            // 
            // NUDLetra
            // 
            NUDLetra.BackColor = Color.FromArgb(66, 60, 69);
            NUDLetra.BorderStyle = BorderStyle.FixedSingle;
            NUDLetra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            NUDLetra.ForeColor = SystemColors.AppWorkspace;
            NUDLetra.Location = new Point(123, 194);
            NUDLetra.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            NUDLetra.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NUDLetra.Name = "NUDLetra";
            NUDLetra.Size = new Size(33, 23);
            NUDLetra.TabIndex = 3;
            NUDLetra.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NUDLetra.ValueChanged += NUDLetra_ValueChanged;
            // 
            // bColor
            // 
            bColor.BackColor = Color.DarkOrchid;
            bColor.FlatStyle = FlatStyle.Flat;
            bColor.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bColor.ForeColor = Color.DeepSkyBlue;
            bColor.Location = new Point(72, 232);
            bColor.Name = "bColor";
            bColor.Size = new Size(196, 49);
            bColor.TabIndex = 4;
            bColor.Text = "Cambio de &Color";
            bColor.UseVisualStyleBackColor = false;
            bColor.Click += bColor_Click;
            // 
            // bTamanioMenos
            // 
            bTamanioMenos.BackColor = Color.DarkOrchid;
            bTamanioMenos.FlatStyle = FlatStyle.Flat;
            bTamanioMenos.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bTamanioMenos.ForeColor = Color.DeepSkyBlue;
            bTamanioMenos.Location = new Point(72, 287);
            bTamanioMenos.Name = "bTamanioMenos";
            bTamanioMenos.Size = new Size(83, 30);
            bTamanioMenos.TabIndex = 5;
            bTamanioMenos.Text = "&< Tamaño";
            bTamanioMenos.UseVisualStyleBackColor = false;
            bTamanioMenos.Click += bTamanioMenos_Click;
            // 
            // bTamanioMas
            // 
            bTamanioMas.BackColor = Color.DarkOrchid;
            bTamanioMas.FlatStyle = FlatStyle.Flat;
            bTamanioMas.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            bTamanioMas.ForeColor = Color.DeepSkyBlue;
            bTamanioMas.Location = new Point(182, 287);
            bTamanioMas.Name = "bTamanioMas";
            bTamanioMas.Size = new Size(86, 30);
            bTamanioMas.TabIndex = 6;
            bTamanioMas.Text = "&> Tamaño";
            bTamanioMas.UseVisualStyleBackColor = false;
            bTamanioMas.Click += bTamanioMas_Click;
            // 
            // bSalir
            // 
            bSalir.BackColor = Color.FromArgb(95, 178, 49, 216);
            bSalir.Dock = DockStyle.Bottom;
            bSalir.FlatStyle = FlatStyle.Flat;
            bSalir.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            bSalir.ForeColor = Color.DeepSkyBlue;
            bSalir.Location = new Point(0, 413);
            bSalir.Name = "bSalir";
            bSalir.Size = new Size(344, 36);
            bSalir.TabIndex = 7;
            bSalir.Text = "&Salir";
            bSalir.UseVisualStyleBackColor = false;
            bSalir.Click += bSalir_Click;
            // 
            // TTexto
            // 
            TTexto.BackColor = Color.FromArgb(66, 60, 69);
            TTexto.BorderStyle = BorderStyle.FixedSingle;
            TTexto.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            TTexto.ForeColor = Color.MediumOrchid;
            TTexto.Location = new Point(123, 153);
            TTexto.MaxLength = 10;
            TTexto.Name = "TTexto";
            TTexto.Size = new Size(145, 23);
            TTexto.TabIndex = 8;
            TTexto.TextChanged += TTexto_TextChanged;
            // 
            // LLetra
            // 
            LLetra.AutoSize = true;
            LLetra.BackColor = Color.Transparent;
            LLetra.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LLetra.ForeColor = Color.Silver;
            LLetra.Location = new Point(162, 196);
            LLetra.Name = "LLetra";
            LLetra.Size = new Size(106, 17);
            LLetra.TabIndex = 9;
            LLetra.Text = "Century Gothic";
            // 
            // FEtiqueta
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = bSalir;
            ClientSize = new Size(344, 449);
            Controls.Add(LLetra);
            Controls.Add(TTexto);
            Controls.Add(bSalir);
            Controls.Add(bTamanioMas);
            Controls.Add(bTamanioMenos);
            Controls.Add(bColor);
            Controls.Add(NUDLetra);
            Controls.Add(llabel);
            Controls.Add(lTexto);
            Controls.Add(lEtiqueta);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "FEtiqueta";
            Text = "Etiqueta";
            Load += FEtiqueta_Load;
            ((System.ComponentModel.ISupportInitialize)NUDLetra).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lEtiqueta;
        private Label lTexto;
        private Label llabel;
        private NumericUpDown NUDLetra;
        private Button bColor;
        private Button bTamanioMenos;
        private Button bTamanioMas;
        private Button bSalir;
        private TextBox TTexto;
        private Label LLetra;
    }
}