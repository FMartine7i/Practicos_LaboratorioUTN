namespace CalcularVuelto
{
    partial class fCalcularVuelto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCalcularVuelto));
            lNombre = new Label();
            lValorCompra = new Label();
            lMonto = new Label();
            tNombre = new TextBox();
            tValor = new TextBox();
            tMonto = new TextBox();
            lsimbolo1 = new Label();
            lSimbolo2 = new Label();
            bCalcular = new CustomControls.Controls.CustomButton();
            customButton2 = new CustomControls.Controls.CustomButton();
            SuspendLayout();
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.BackColor = Color.Transparent;
            lNombre.ForeColor = Color.Thistle;
            lNombre.Location = new Point(43, 60);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(220, 23);
            lNombre.TabIndex = 0;
            lNombre.Text = "Nombre del vendedor:";
            // 
            // lValorCompra
            // 
            lValorCompra.AutoSize = true;
            lValorCompra.BackColor = Color.Transparent;
            lValorCompra.ForeColor = Color.Gainsboro;
            lValorCompra.Location = new Point(64, 124);
            lValorCompra.Name = "lValorCompra";
            lValorCompra.Size = new Size(199, 23);
            lValorCompra.TabIndex = 1;
            lValorCompra.Text = "Valor de la Compra:";
            // 
            // lMonto
            // 
            lMonto.AutoSize = true;
            lMonto.BackColor = Color.Transparent;
            lMonto.Location = new Point(108, 189);
            lMonto.Name = "lMonto";
            lMonto.Size = new Size(155, 23);
            lMonto.TabIndex = 2;
            lMonto.Text = "Monto pagado:";
            // 
            // tNombre
            // 
            tNombre.BackColor = Color.FromArgb(109, 87, 109);
            tNombre.BorderStyle = BorderStyle.None;
            tNombre.ForeColor = Color.FloralWhite;
            tNombre.Location = new Point(279, 60);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(194, 24);
            tNombre.TabIndex = 3;
            // 
            // tValor
            // 
            tValor.BackColor = Color.FromArgb(109, 87, 109);
            tValor.BorderStyle = BorderStyle.None;
            tValor.ForeColor = Color.Gainsboro;
            tValor.Location = new Point(279, 123);
            tValor.Name = "tValor";
            tValor.Size = new Size(159, 24);
            tValor.TabIndex = 4;
            // 
            // tMonto
            // 
            tMonto.BackColor = Color.FromArgb(109, 87, 109);
            tMonto.BorderStyle = BorderStyle.None;
            tMonto.ForeColor = Color.Gainsboro;
            tMonto.Location = new Point(279, 188);
            tMonto.Name = "tMonto";
            tMonto.Size = new Size(159, 24);
            tMonto.TabIndex = 5;
            // 
            // lsimbolo1
            // 
            lsimbolo1.AutoSize = true;
            lsimbolo1.BackColor = Color.Transparent;
            lsimbolo1.Location = new Point(444, 123);
            lsimbolo1.Name = "lsimbolo1";
            lsimbolo1.Size = new Size(21, 23);
            lsimbolo1.TabIndex = 6;
            lsimbolo1.Text = "$";
            // 
            // lSimbolo2
            // 
            lSimbolo2.AutoSize = true;
            lSimbolo2.BackColor = Color.Transparent;
            lSimbolo2.Location = new Point(444, 188);
            lSimbolo2.Name = "lSimbolo2";
            lSimbolo2.Size = new Size(21, 23);
            lSimbolo2.TabIndex = 7;
            lSimbolo2.Text = "$";
            // 
            // bCalcular
            // 
            bCalcular.BackColor = Color.DarkViolet;
            bCalcular.BackgroundColor = Color.DarkViolet;
            bCalcular.BorderColor = Color.MediumSlateBlue;
            bCalcular.BorderRadius = 20;
            bCalcular.BorderSize = 2;
            bCalcular.FlatAppearance.BorderSize = 0;
            bCalcular.FlatStyle = FlatStyle.Flat;
            bCalcular.ForeColor = Color.Plum;
            bCalcular.Location = new Point(233, 270);
            bCalcular.Name = "bCalcular";
            bCalcular.Size = new Size(150, 40);
            bCalcular.TabIndex = 8;
            bCalcular.Text = "Calcular";
            bCalcular.TextColor = Color.Plum;
            bCalcular.UseVisualStyleBackColor = false;
            bCalcular.Click += bCalcular_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.DarkTurquoise;
            customButton2.BackgroundColor = Color.DarkTurquoise;
            customButton2.BorderColor = Color.DarkMagenta;
            customButton2.BorderRadius = 1;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(547, 12);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(42, 38);
            customButton2.TabIndex = 9;
            customButton2.Text = "X";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += customButton2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 41, 50);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(612, 386);
            Controls.Add(customButton2);
            Controls.Add(bCalcular);
            Controls.Add(lSimbolo2);
            Controls.Add(lsimbolo1);
            Controls.Add(tMonto);
            Controls.Add(tValor);
            Controls.Add(tNombre);
            Controls.Add(lMonto);
            Controls.Add(lValorCompra);
            Controls.Add(lNombre);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(226, 198, 226);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNombre;
        private Label lValorCompra;
        private Label lMonto;
        private TextBox tNombre;
        private TextBox tValor;
        private TextBox tMonto;
        private Label lsimbolo1;
        private Label lSimbolo2;
        private CustomControls.Controls.CustomButton bCalcular;
        private CustomControls.Controls.CustomButton customButton2;
    }
}