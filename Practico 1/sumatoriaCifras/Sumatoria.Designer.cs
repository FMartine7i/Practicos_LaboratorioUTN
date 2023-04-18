namespace sumatoriaCifras
{
    partial class fSumatoria
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
            bCalcular = new CustomControls.Controls.CustomButton();
            bClose = new CustomControls.Controls.CustomButton();
            tNumero = new TextBox();
            lNumero = new Label();
            SuspendLayout();
            // 
            // bCalcular
            // 
            bCalcular.BackColor = Color.DarkViolet;
            bCalcular.BackgroundColor = Color.DarkViolet;
            bCalcular.BorderColor = Color.SlateBlue;
            bCalcular.BorderRadius = 10;
            bCalcular.BorderSize = 3;
            bCalcular.FlatAppearance.BorderSize = 0;
            bCalcular.FlatStyle = FlatStyle.Flat;
            bCalcular.ForeColor = Color.Plum;
            bCalcular.Location = new Point(294, 330);
            bCalcular.Margin = new Padding(6);
            bCalcular.Name = "bCalcular";
            bCalcular.Size = new Size(153, 56);
            bCalcular.TabIndex = 0;
            bCalcular.TabStop = false;
            bCalcular.Text = "calcular";
            bCalcular.TextColor = Color.Plum;
            bCalcular.UseVisualStyleBackColor = false;
            bCalcular.Click += bCalcular_Click;
            // 
            // bClose
            // 
            bClose.BackColor = Color.BlueViolet;
            bClose.BackgroundColor = Color.BlueViolet;
            bClose.BorderColor = Color.PaleVioletRed;
            bClose.BorderRadius = 1;
            bClose.BorderSize = 0;
            bClose.FlatAppearance.BorderSize = 0;
            bClose.FlatStyle = FlatStyle.Flat;
            bClose.ForeColor = Color.White;
            bClose.Location = new Point(677, 15);
            bClose.Margin = new Padding(6);
            bClose.Name = "bClose";
            bClose.Size = new Size(35, 42);
            bClose.TabIndex = 1;
            bClose.Text = "X";
            bClose.TextColor = Color.White;
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // tNumero
            // 
            tNumero.BackColor = Color.Indigo;
            tNumero.BorderStyle = BorderStyle.None;
            tNumero.Font = new Font("Century Gothic", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            tNumero.ForeColor = Color.MediumPurple;
            tNumero.Location = new Point(340, 182);
            tNumero.Name = "tNumero";
            tNumero.Size = new Size(58, 46);
            tNumero.TabIndex = 2;
            // 
            // lNumero
            // 
            lNumero.AutoSize = true;
            lNumero.BackColor = Color.Transparent;
            lNumero.Font = new Font("Century Gothic", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lNumero.ForeColor = Color.Thistle;
            lNumero.Location = new Point(114, 63);
            lNumero.Name = "lNumero";
            lNumero.Size = new Size(528, 41);
            lNumero.TabIndex = 3;
            lNumero.Text = "Ingresar número de dos cifras:";
            // 
            // fSumatoria
            // 
            AutoScaleDimensions = new SizeF(14F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(727, 455);
            Controls.Add(lNumero);
            Controls.Add(tNumero);
            Controls.Add(bClose);
            Controls.Add(bCalcular);
            Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "fSumatoria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.Controls.CustomButton bCalcular;
        private CustomControls.Controls.CustomButton bClose;
        private TextBox tNumero;
        private Label lNumero;
    }
}