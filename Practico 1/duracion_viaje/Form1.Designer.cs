namespace duracion_viaje
{
    partial class fDuracionViaje
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
            lClose = new Label();
            lDestino = new Label();
            lDistancia = new Label();
            lVelocidad = new Label();
            bTiempo = new Button();
            tLugarDestino = new TextBox();
            tDistancia = new TextBox();
            tVelocidad = new TextBox();
            lKilometros = new Label();
            lUnidad = new Label();
            SuspendLayout();
            // 
            // lClose
            // 
            lClose.AutoSize = true;
            lClose.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lClose.ForeColor = SystemColors.ButtonFace;
            lClose.Location = new Point(697, -2);
            lClose.Name = "lClose";
            lClose.Size = new Size(25, 30);
            lClose.TabIndex = 0;
            lClose.Text = "x";
            lClose.Click += lClose_Click;
            // 
            // lDestino
            // 
            lDestino.AutoSize = true;
            lDestino.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lDestino.ForeColor = Color.FromArgb(221, 190, 237);
            lDestino.Location = new Point(151, 68);
            lDestino.Name = "lDestino";
            lDestino.Size = new Size(82, 22);
            lDestino.TabIndex = 1;
            lDestino.Text = "Destino:";
            // 
            // lDistancia
            // 
            lDistancia.AutoSize = true;
            lDistancia.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lDistancia.ForeColor = Color.FromArgb(221, 190, 237);
            lDistancia.Location = new Point(151, 154);
            lDistancia.Name = "lDistancia";
            lDistancia.Size = new Size(104, 22);
            lDistancia.TabIndex = 2;
            lDistancia.Text = "Distancia: ";
            // 
            // lVelocidad
            // 
            lVelocidad.AutoSize = true;
            lVelocidad.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lVelocidad.ForeColor = Color.FromArgb(221, 190, 237);
            lVelocidad.Location = new Point(151, 239);
            lVelocidad.Name = "lVelocidad";
            lVelocidad.Size = new Size(111, 22);
            lVelocidad.TabIndex = 3;
            lVelocidad.Text = "Velocidad:";
            // 
            // bTiempo
            // 
            bTiempo.BackColor = Color.FromArgb(153, 116, 232);
            bTiempo.FlatAppearance.BorderSize = 0;
            bTiempo.FlatStyle = FlatStyle.Flat;
            bTiempo.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bTiempo.ForeColor = Color.WhiteSmoke;
            bTiempo.Location = new Point(300, 337);
            bTiempo.Name = "bTiempo";
            bTiempo.Size = new Size(137, 62);
            bTiempo.TabIndex = 4;
            bTiempo.Text = "Calcular tiempo";
            bTiempo.UseVisualStyleBackColor = false;
            bTiempo.Click += bTiempo_Click;
            // 
            // tLugarDestino
            // 
            tLugarDestino.BackColor = Color.FromArgb(221, 210, 237);
            tLugarDestino.BorderStyle = BorderStyle.None;
            tLugarDestino.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tLugarDestino.Location = new Point(278, 68);
            tLugarDestino.Name = "tLugarDestino";
            tLugarDestino.Size = new Size(195, 23);
            tLugarDestino.TabIndex = 5;
            // 
            // tDistancia
            // 
            tDistancia.BackColor = Color.FromArgb(221, 210, 237);
            tDistancia.BorderStyle = BorderStyle.None;
            tDistancia.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tDistancia.Location = new Point(278, 154);
            tDistancia.Name = "tDistancia";
            tDistancia.Size = new Size(195, 23);
            tDistancia.TabIndex = 6;
            // 
            // tVelocidad
            // 
            tVelocidad.BackColor = Color.FromArgb(221, 210, 237);
            tVelocidad.BorderStyle = BorderStyle.None;
            tVelocidad.Font = new Font("Century Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tVelocidad.Location = new Point(278, 239);
            tVelocidad.Name = "tVelocidad";
            tVelocidad.Size = new Size(195, 23);
            tVelocidad.TabIndex = 7;
            // 
            // lKilometros
            // 
            lKilometros.AutoSize = true;
            lKilometros.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lKilometros.ForeColor = Color.FromArgb(221, 190, 237);
            lKilometros.Location = new Point(491, 154);
            lKilometros.Name = "lKilometros";
            lKilometros.Size = new Size(37, 22);
            lKilometros.TabIndex = 8;
            lKilometros.Text = "km";
            // 
            // lUnidad
            // 
            lUnidad.AutoSize = true;
            lUnidad.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lUnidad.ForeColor = Color.FromArgb(221, 190, 237);
            lUnidad.Location = new Point(491, 239);
            lUnidad.Name = "lUnidad";
            lUnidad.Size = new Size(57, 22);
            lUnidad.TabIndex = 9;
            lUnidad.Text = "km/h";
            // 
            // fDuracionViaje
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 41, 50);
            ClientSize = new Size(734, 461);
            Controls.Add(lUnidad);
            Controls.Add(lKilometros);
            Controls.Add(tVelocidad);
            Controls.Add(tDistancia);
            Controls.Add(tLugarDestino);
            Controls.Add(bTiempo);
            Controls.Add(lVelocidad);
            Controls.Add(lDistancia);
            Controls.Add(lDestino);
            Controls.Add(lClose);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "fDuracionViaje";
            Text = "Duración viaje";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lClose;
        private Label lDestino;
        private Label lDistancia;
        private Label lVelocidad;
        private Button bTiempo;
        private TextBox tLugarDestino;
        private TextBox tDistancia;
        private TextBox tVelocidad;
        private Label lKilometros;
        private Label lUnidad;
    }
}