namespace ConvertirAGb
{
    partial class Form1
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
            lNArchivo = new Label();
            bCalcular = new CustomControls.Controls.CustomButton();
            tNArchivo = new TextBox();
            label1 = new Label();
            tTamano = new TextBox();
            lUnidad = new Label();
            bClose = new CustomControls.Controls.CustomButton();
            SuspendLayout();
            // 
            // lNArchivo
            // 
            lNArchivo.AutoSize = true;
            lNArchivo.ForeColor = Color.FromArgb(210, 183, 200);
            lNArchivo.Location = new Point(47, 110);
            lNArchivo.Name = "lNArchivo";
            lNArchivo.Size = new Size(200, 23);
            lNArchivo.TabIndex = 0;
            lNArchivo.Text = "Nombre del archivo:";
            // 
            // bCalcular
            // 
            bCalcular.BackColor = Color.DarkOrchid;
            bCalcular.BackgroundColor = Color.DarkOrchid;
            bCalcular.BorderColor = Color.PaleVioletRed;
            bCalcular.BorderRadius = 20;
            bCalcular.BorderSize = 0;
            bCalcular.FlatAppearance.BorderSize = 0;
            bCalcular.FlatStyle = FlatStyle.Flat;
            bCalcular.ForeColor = Color.Plum;
            bCalcular.Location = new Point(138, 302);
            bCalcular.Name = "bCalcular";
            bCalcular.Size = new Size(130, 49);
            bCalcular.TabIndex = 1;
            bCalcular.Text = "Calcular";
            bCalcular.TextColor = Color.Plum;
            bCalcular.UseVisualStyleBackColor = false;
            bCalcular.Click += bCalcular_Click;
            // 
            // tNArchivo
            // 
            tNArchivo.BackColor = Color.FromArgb(90, 76, 90);
            tNArchivo.BorderStyle = BorderStyle.None;
            tNArchivo.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tNArchivo.ForeColor = Color.Gainsboro;
            tNArchivo.Location = new Point(253, 109);
            tNArchivo.Name = "tNArchivo";
            tNArchivo.Size = new Size(229, 24);
            tNArchivo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(210, 183, 200);
            label1.Location = new Point(157, 176);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 3;
            label1.Text = "Tamaño:";
            // 
            // tTamano
            // 
            tTamano.BackColor = Color.FromArgb(90, 76, 90);
            tTamano.BorderStyle = BorderStyle.None;
            tTamano.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            tTamano.ForeColor = Color.Gainsboro;
            tTamano.Location = new Point(253, 176);
            tTamano.Name = "tTamano";
            tTamano.Size = new Size(167, 24);
            tTamano.TabIndex = 4;
            // 
            // lUnidad
            // 
            lUnidad.AutoSize = true;
            lUnidad.ForeColor = Color.FromArgb(210, 183, 200);
            lUnidad.Location = new Point(442, 177);
            lUnidad.Name = "lUnidad";
            lUnidad.Size = new Size(40, 23);
            lUnidad.TabIndex = 5;
            lUnidad.Text = "Mb";
            // 
            // bClose
            // 
            bClose.BackColor = Color.DarkOrchid;
            bClose.BackgroundColor = Color.DarkOrchid;
            bClose.BorderColor = Color.PaleVioletRed;
            bClose.BorderRadius = 20;
            bClose.BorderSize = 0;
            bClose.FlatAppearance.BorderSize = 0;
            bClose.FlatStyle = FlatStyle.Flat;
            bClose.ForeColor = Color.Plum;
            bClose.Location = new Point(374, 302);
            bClose.Name = "bClose";
            bClose.Size = new Size(130, 49);
            bClose.TabIndex = 6;
            bClose.Text = "Cerrar";
            bClose.TextColor = Color.Plum;
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 41, 50);
            ClientSize = new Size(648, 424);
            Controls.Add(bClose);
            Controls.Add(lUnidad);
            Controls.Add(tTamano);
            Controls.Add(label1);
            Controls.Add(tNArchivo);
            Controls.Add(bCalcular);
            Controls.Add(lNArchivo);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FromArgb(200, 173, 198);
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Convertir Mb a Gb";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lNArchivo;
        private CustomControls.Controls.CustomButton bCalcular;
        private TextBox tNArchivo;
        private Label label1;
        private TextBox tTamano;
        private Label lUnidad;
        private CustomControls.Controls.CustomButton bClose;
    }
}