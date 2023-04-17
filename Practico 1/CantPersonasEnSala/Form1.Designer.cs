namespace CantPersonasEnSala
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
            bCalcularP = new CustomControls.Controls.CustomButton();
            bIngreso = new CustomControls.Controls.CustomButton();
            bDecremento = new CustomControls.Controls.CustomButton();
            bClose = new CustomControls.Controls.CustomButton();
            lCupoTotal = new Label();
            tCupoTotal = new TextBox();
            lPersonas = new Label();
            label1 = new Label();
            tCantidadActual = new TextBox();
            SuspendLayout();
            // 
            // bCalcularP
            // 
            bCalcularP.BackColor = Color.DarkViolet;
            bCalcularP.BackgroundColor = Color.DarkViolet;
            bCalcularP.BorderColor = Color.DeepSkyBlue;
            bCalcularP.BorderRadius = 20;
            bCalcularP.BorderSize = 2;
            bCalcularP.FlatAppearance.BorderSize = 0;
            bCalcularP.FlatStyle = FlatStyle.Flat;
            bCalcularP.ForeColor = Color.Plum;
            bCalcularP.Location = new Point(281, 327);
            bCalcularP.Name = "bCalcularP";
            bCalcularP.Size = new Size(150, 58);
            bCalcularP.TabIndex = 0;
            bCalcularP.Text = "Calcular Porcentaje";
            bCalcularP.TextColor = Color.Plum;
            bCalcularP.UseVisualStyleBackColor = false;
            bCalcularP.Click += bCalcularP_Click;
            // 
            // bIngreso
            // 
            bIngreso.BackColor = Color.DarkViolet;
            bIngreso.BackgroundColor = Color.DarkViolet;
            bIngreso.BorderColor = Color.DeepSkyBlue;
            bIngreso.BorderRadius = 20;
            bIngreso.BorderSize = 2;
            bIngreso.FlatAppearance.BorderSize = 0;
            bIngreso.FlatStyle = FlatStyle.Flat;
            bIngreso.ForeColor = Color.Plum;
            bIngreso.Location = new Point(193, 221);
            bIngreso.Name = "bIngreso";
            bIngreso.Size = new Size(150, 58);
            bIngreso.TabIndex = 1;
            bIngreso.Text = "Incrementar cantidad";
            bIngreso.TextColor = Color.Plum;
            bIngreso.UseVisualStyleBackColor = false;
            bIngreso.Click += bIngreso_Click;
            // 
            // bDecremento
            // 
            bDecremento.BackColor = Color.DarkViolet;
            bDecremento.BackgroundColor = Color.DarkViolet;
            bDecremento.BorderColor = Color.DeepSkyBlue;
            bDecremento.BorderRadius = 20;
            bDecremento.BorderSize = 2;
            bDecremento.FlatAppearance.BorderSize = 0;
            bDecremento.FlatStyle = FlatStyle.Flat;
            bDecremento.ForeColor = Color.Plum;
            bDecremento.Location = new Point(381, 221);
            bDecremento.Name = "bDecremento";
            bDecremento.Size = new Size(150, 58);
            bDecremento.TabIndex = 2;
            bDecremento.Text = "Decrementar cantidad";
            bDecremento.TextColor = Color.Plum;
            bDecremento.UseVisualStyleBackColor = false;
            bDecremento.Click += bDecremento_Click;
            // 
            // bClose
            // 
            bClose.BackColor = Color.Aqua;
            bClose.BackgroundColor = Color.Aqua;
            bClose.BorderColor = Color.PaleVioletRed;
            bClose.BorderRadius = 1;
            bClose.BorderSize = 0;
            bClose.FlatAppearance.BorderSize = 0;
            bClose.FlatStyle = FlatStyle.Flat;
            bClose.ForeColor = Color.White;
            bClose.Location = new Point(658, 12);
            bClose.Name = "bClose";
            bClose.Size = new Size(34, 40);
            bClose.TabIndex = 3;
            bClose.Text = "X";
            bClose.TextColor = Color.White;
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // lCupoTotal
            // 
            lCupoTotal.AutoSize = true;
            lCupoTotal.BackColor = Color.Transparent;
            lCupoTotal.ForeColor = Color.WhiteSmoke;
            lCupoTotal.Location = new Point(135, 71);
            lCupoTotal.Name = "lCupoTotal";
            lCupoTotal.Size = new Size(115, 23);
            lCupoTotal.TabIndex = 4;
            lCupoTotal.Text = "Cupo Total:";
            // 
            // tCupoTotal
            // 
            tCupoTotal.BackColor = Color.Plum;
            tCupoTotal.BorderStyle = BorderStyle.None;
            tCupoTotal.ForeColor = Color.BlueViolet;
            tCupoTotal.Location = new Point(256, 70);
            tCupoTotal.Name = "tCupoTotal";
            tCupoTotal.Size = new Size(190, 24);
            tCupoTotal.TabIndex = 5;
            // 
            // lPersonas
            // 
            lPersonas.AutoSize = true;
            lPersonas.BackColor = Color.Transparent;
            lPersonas.ForeColor = Color.WhiteSmoke;
            lPersonas.Location = new Point(469, 70);
            lPersonas.Name = "lPersonas";
            lPersonas.Size = new Size(91, 23);
            lPersonas.TabIndex = 6;
            lPersonas.Text = "Personas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(28, 137);
            label1.Name = "label1";
            label1.Size = new Size(222, 23);
            label1.TabIndex = 7;
            label1.Text = "Cantidad de personas:";
            // 
            // tCantidadActual
            // 
            tCantidadActual.BackColor = Color.Plum;
            tCantidadActual.BorderStyle = BorderStyle.None;
            tCantidadActual.ForeColor = Color.BlueViolet;
            tCantidadActual.Location = new Point(256, 136);
            tCantidadActual.Name = "tCantidadActual";
            tCantidadActual.Size = new Size(190, 24);
            tCantidadActual.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 444);
            Controls.Add(tCantidadActual);
            Controls.Add(label1);
            Controls.Add(lPersonas);
            Controls.Add(tCupoTotal);
            Controls.Add(lCupoTotal);
            Controls.Add(bClose);
            Controls.Add(bDecremento);
            Controls.Add(bIngreso);
            Controls.Add(bCalcularP);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Gainsboro;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.Controls.CustomButton bCalcularP;
        private CustomControls.Controls.CustomButton bIngreso;
        private CustomControls.Controls.CustomButton bDecremento;
        private CustomControls.Controls.CustomButton bClose;
        private Label lCupoTotal;
        private TextBox tCupoTotal;
        private Label lPersonas;
        private Label label1;
        private TextBox tCantidadActual;
    }
}