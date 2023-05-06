namespace Ejercicio3
{
    partial class FColores
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
            bAmarillo = new Button();
            bRojo = new Button();
            bAzul = new Button();
            bCerrar = new Button();
            SuspendLayout();
            // 
            // bAmarillo
            // 
            bAmarillo.BackColor = Color.FromArgb(95, 255, 255, 0);
            bAmarillo.FlatStyle = FlatStyle.Flat;
            bAmarillo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bAmarillo.ForeColor = Color.DarkGoldenrod;
            bAmarillo.Location = new Point(25, 38);
            bAmarillo.Name = "bAmarillo";
            bAmarillo.Size = new Size(75, 27);
            bAmarillo.TabIndex = 0;
            bAmarillo.Text = "&Amarillo";
            bAmarillo.UseVisualStyleBackColor = false;
            bAmarillo.Click += bAmarillo_Click;
            // 
            // bRojo
            // 
            bRojo.BackColor = Color.FromArgb(95, 255, 0, 75);
            bRojo.FlatStyle = FlatStyle.Flat;
            bRojo.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bRojo.ForeColor = Color.LightCoral;
            bRojo.Location = new Point(131, 38);
            bRojo.Name = "bRojo";
            bRojo.Size = new Size(75, 27);
            bRojo.TabIndex = 1;
            bRojo.Text = "&Rojo";
            bRojo.UseVisualStyleBackColor = false;
            bRojo.Click += bRojo_Click;
            // 
            // bAzul
            // 
            bAzul.BackColor = Color.FromArgb(95, 0, 133, 185);
            bAzul.FlatStyle = FlatStyle.Flat;
            bAzul.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bAzul.ForeColor = Color.DeepSkyBlue;
            bAzul.Location = new Point(237, 38);
            bAzul.Name = "bAzul";
            bAzul.Size = new Size(75, 27);
            bAzul.TabIndex = 2;
            bAzul.Text = "&Azul";
            bAzul.UseVisualStyleBackColor = false;
            bAzul.Click += bAzul_Click;
            // 
            // bCerrar
            // 
            bCerrar.BackColor = Color.FromArgb(49, 49, 49);
            bCerrar.FlatStyle = FlatStyle.Flat;
            bCerrar.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            bCerrar.ForeColor = SystemColors.Control;
            bCerrar.Location = new Point(237, 126);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(75, 33);
            bCerrar.TabIndex = 3;
            bCerrar.Text = "&Cerrar";
            bCerrar.UseVisualStyleBackColor = false;
            bCerrar.Visible = false;
            bCerrar.Click += bCerrar_Click;
            // 
            // FColores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            CancelButton = bCerrar;
            ClientSize = new Size(334, 171);
            Controls.Add(bCerrar);
            Controls.Add(bAzul);
            Controls.Add(bRojo);
            Controls.Add(bAmarillo);
            Name = "FColores";
            Text = "Mezcla de colores";
            ResumeLayout(false);
        }

        #endregion

        private Button bAmarillo;
        private Button bRojo;
        private Button bAzul;
        private Button bCerrar;
    }
}