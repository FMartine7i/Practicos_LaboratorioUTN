namespace WinFormsApp1
{
    partial class fPerimetro
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
            bCalcularPerimetro = new Button();
            lClose = new Label();
            lRadio = new Label();
            tRadio = new TextBox();
            tUnidad = new TextBox();
            bCalcularArea = new Button();
            lIndicacion = new Label();
            SuspendLayout();
            // 
            // bCalcularPerimetro
            // 
            bCalcularPerimetro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bCalcularPerimetro.Location = new Point(158, 217);
            bCalcularPerimetro.Name = "bCalcularPerimetro";
            bCalcularPerimetro.Size = new Size(112, 53);
            bCalcularPerimetro.TabIndex = 0;
            bCalcularPerimetro.Text = "Calcular Perímetro";
            bCalcularPerimetro.UseVisualStyleBackColor = true;
            bCalcularPerimetro.Click += bCalcularPerimetro_Click;
            // 
            // lClose
            // 
            lClose.AutoSize = true;
            lClose.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lClose.Location = new Point(621, 0);
            lClose.Name = "lClose";
            lClose.Size = new Size(26, 30);
            lClose.TabIndex = 1;
            lClose.Text = "X";
            lClose.Click += lClose_Click;
            // 
            // lRadio
            // 
            lRadio.AutoSize = true;
            lRadio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lRadio.Location = new Point(158, 100);
            lRadio.Name = "lRadio";
            lRadio.Size = new Size(79, 32);
            lRadio.TabIndex = 2;
            lRadio.Text = "Radio:";
            // 
            // tRadio
            // 
            tRadio.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tRadio.Location = new Point(243, 97);
            tRadio.Name = "tRadio";
            tRadio.Size = new Size(150, 39);
            tRadio.TabIndex = 3;
            // 
            // tUnidad
            // 
            tUnidad.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            tUnidad.Location = new Point(411, 97);
            tUnidad.Name = "tUnidad";
            tUnidad.Size = new Size(56, 39);
            tUnidad.TabIndex = 4;
            // 
            // bCalcularArea
            // 
            bCalcularArea.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            bCalcularArea.Location = new Point(355, 217);
            bCalcularArea.Name = "bCalcularArea";
            bCalcularArea.Size = new Size(112, 53);
            bCalcularArea.TabIndex = 5;
            bCalcularArea.Text = "Calcular Área";
            bCalcularArea.UseVisualStyleBackColor = true;
            bCalcularArea.Click += bCalcularArea_Click;
            // 
            // lIndicacion
            // 
            lIndicacion.AutoSize = true;
            lIndicacion.Location = new Point(473, 114);
            lIndicacion.Name = "lIndicacion";
            lIndicacion.Size = new Size(159, 15);
            lIndicacion.TabIndex = 6;
            lIndicacion.Text = "← Indique unidad de medida";
            // 
            // fPerimetro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 332);
            Controls.Add(lIndicacion);
            Controls.Add(bCalcularArea);
            Controls.Add(tUnidad);
            Controls.Add(tRadio);
            Controls.Add(lRadio);
            Controls.Add(lClose);
            Controls.Add(bCalcularPerimetro);
            FormBorderStyle = FormBorderStyle.None;
            Name = "fPerimetro";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bCalcularPerimetro;
        private Label lClose;
        private Label lRadio;
        private TextBox tRadio;
        private TextBox tUnidad;
        private Button bCalcularArea;
        private Label lIndicacion;
    }
}