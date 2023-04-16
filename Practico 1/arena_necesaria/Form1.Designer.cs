namespace arena_necesaria
{
    partial class fCantidadArena
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
            lAncho = new Label();
            lAlto = new Label();
            tAncho = new TextBox();
            tAlto = new TextBox();
            lmetros1 = new Label();
            label1 = new Label();
            lRevoque = new Label();
            tRevoque = new TextBox();
            lmCubicos = new Label();
            lClose = new Label();
            bCalcular = new CustomControls.Controls.CustomButton();
            customButton1 = new CustomControls.Controls.CustomButton();
            SuspendLayout();
            // 
            // lAncho
            // 
            lAncho.AutoSize = true;
            lAncho.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lAncho.Location = new Point(210, 115);
            lAncho.Name = "lAncho";
            lAncho.Size = new Size(78, 22);
            lAncho.TabIndex = 0;
            lAncho.Text = "Ancho:";
            // 
            // lAlto
            // 
            lAlto.AutoSize = true;
            lAlto.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lAlto.Location = new Point(236, 180);
            lAlto.Name = "lAlto";
            lAlto.Size = new Size(52, 22);
            lAlto.TabIndex = 1;
            lAlto.Text = "Alto:";
            // 
            // tAncho
            // 
            tAncho.BackColor = Color.LightGray;
            tAncho.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tAncho.Location = new Point(305, 110);
            tAncho.Name = "tAncho";
            tAncho.Size = new Size(172, 31);
            tAncho.TabIndex = 2;
            // 
            // tAlto
            // 
            tAlto.BackColor = Color.LightGray;
            tAlto.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tAlto.Location = new Point(305, 171);
            tAlto.Name = "tAlto";
            tAlto.Size = new Size(172, 31);
            tAlto.TabIndex = 3;
            // 
            // lmetros1
            // 
            lmetros1.AutoSize = true;
            lmetros1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lmetros1.Location = new Point(500, 115);
            lmetros1.Name = "lmetros1";
            lmetros1.Size = new Size(71, 22);
            lmetros1.TabIndex = 4;
            lmetros1.Text = "metros";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(500, 180);
            label1.Name = "label1";
            label1.Size = new Size(71, 22);
            label1.TabIndex = 5;
            label1.Text = "metros";
            // 
            // lRevoque
            // 
            lRevoque.AutoSize = true;
            lRevoque.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lRevoque.Location = new Point(31, 241);
            lRevoque.Name = "lRevoque";
            lRevoque.Size = new Size(268, 22);
            lRevoque.TabIndex = 6;
            lRevoque.Text = "Cantidad de revoque/m^2:";
            // 
            // tRevoque
            // 
            tRevoque.BackColor = Color.LightGray;
            tRevoque.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tRevoque.Location = new Point(305, 232);
            tRevoque.Name = "tRevoque";
            tRevoque.Size = new Size(172, 31);
            tRevoque.TabIndex = 7;
            // 
            // lmCubicos
            // 
            lmCubicos.AutoSize = true;
            lmCubicos.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lmCubicos.Location = new Point(500, 241);
            lmCubicos.Name = "lmCubicos";
            lmCubicos.Size = new Size(147, 22);
            lmCubicos.TabIndex = 8;
            lmCubicos.Text = "metros cúbicos";
            // 
            // lClose
            // 
            lClose.Location = new Point(0, 0);
            lClose.Name = "lClose";
            lClose.Size = new Size(100, 23);
            lClose.TabIndex = 12;
            // 
            // bCalcular
            // 
            bCalcular.BackColor = Color.FromArgb(138, 55, 175);
            bCalcular.BackgroundColor = Color.FromArgb(138, 55, 175);
            bCalcular.BorderColor = Color.FromArgb(0, 192, 192);
            bCalcular.BorderRadius = 20;
            bCalcular.BorderSize = 1;
            bCalcular.FlatAppearance.BorderSize = 0;
            bCalcular.FlatStyle = FlatStyle.Flat;
            bCalcular.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bCalcular.ForeColor = Color.Plum;
            bCalcular.Location = new Point(210, 328);
            bCalcular.Name = "bCalcular";
            bCalcular.Size = new Size(150, 40);
            bCalcular.TabIndex = 10;
            bCalcular.Text = "Calcular";
            bCalcular.TextColor = Color.Plum;
            bCalcular.UseVisualStyleBackColor = false;
            bCalcular.Click += bCalcular_Click;
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(138, 55, 175);
            customButton1.BackgroundColor = Color.FromArgb(138, 55, 175);
            customButton1.BorderColor = Color.FromArgb(0, 192, 192);
            customButton1.BorderRadius = 20;
            customButton1.BorderSize = 1;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            customButton1.ForeColor = Color.Plum;
            customButton1.Location = new Point(421, 328);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 40);
            customButton1.TabIndex = 11;
            customButton1.Text = "Cerrar";
            customButton1.TextColor = Color.Plum;
            customButton1.UseVisualStyleBackColor = false;
            customButton1.Click += customButton1_Click;
            // 
            // fCantidadArena
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 41, 50);
            ClientSize = new Size(801, 421);
            Controls.Add(customButton1);
            Controls.Add(bCalcular);
            Controls.Add(lClose);
            Controls.Add(lmCubicos);
            Controls.Add(tRevoque);
            Controls.Add(lRevoque);
            Controls.Add(label1);
            Controls.Add(lmetros1);
            Controls.Add(tAlto);
            Controls.Add(tAncho);
            Controls.Add(lAlto);
            Controls.Add(lAncho);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(4);
            Name = "fCantidadArena";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lAncho;
        private Label lAlto;
        private TextBox tAncho;
        private TextBox tAlto;
        private Label lmetros1;
        private Label label1;
        private Label lRevoque;
        private TextBox tRevoque;
        private Label lmCubicos;
        private Label lClose;
        private CustomControls.Controls.CustomButton bCalcular;
        private CustomControls.Controls.CustomButton customButton1;
    }
}