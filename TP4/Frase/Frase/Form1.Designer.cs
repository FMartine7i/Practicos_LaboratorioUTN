namespace Frase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            TFrase = new TextBox();
            BEliminarEspacios = new Button();
            BPasarOracion = new Button();
            label2 = new Label();
            TReemplazaLetra = new TextBox();
            label3 = new Label();
            TReemplazaPor = new TextBox();
            BReemplazar = new Button();
            BVocales = new Button();
            BPalabras = new Button();
            BCerrar = new Button();
            LVocales = new Label();
            LPalabras = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(213, 95);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "Frase:";
            // 
            // TFrase
            // 
            TFrase.BackColor = Color.FromArgb(108, 41, 227);
            TFrase.BorderStyle = BorderStyle.FixedSingle;
            TFrase.ForeColor = Color.Thistle;
            TFrase.Location = new Point(270, 92);
            TFrase.Name = "TFrase";
            TFrase.Size = new Size(361, 26);
            TFrase.TabIndex = 1;
            // 
            // BEliminarEspacios
            // 
            BEliminarEspacios.BackColor = Color.FromArgb(92, 80, 255);
            BEliminarEspacios.FlatStyle = FlatStyle.Flat;
            BEliminarEspacios.ForeColor = Color.DarkTurquoise;
            BEliminarEspacios.Location = new Point(270, 135);
            BEliminarEspacios.Name = "BEliminarEspacios";
            BEliminarEspacios.Size = new Size(164, 32);
            BEliminarEspacios.TabIndex = 2;
            BEliminarEspacios.Text = "&Eliminar espacios";
            BEliminarEspacios.UseVisualStyleBackColor = false;
            BEliminarEspacios.Click += BEliminarEspacios_Click;
            // 
            // BPasarOracion
            // 
            BPasarOracion.BackColor = Color.FromArgb(92, 80, 255);
            BPasarOracion.FlatStyle = FlatStyle.Flat;
            BPasarOracion.ForeColor = Color.DarkTurquoise;
            BPasarOracion.Location = new Point(450, 135);
            BPasarOracion.Name = "BPasarOracion";
            BPasarOracion.Size = new Size(181, 32);
            BPasarOracion.TabIndex = 3;
            BPasarOracion.Text = "&Pasar a tipo oración";
            BPasarOracion.UseVisualStyleBackColor = false;
            BPasarOracion.Click += BPasarOracion_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(213, 213);
            label2.Name = "label2";
            label2.Size = new Size(99, 20);
            label2.TabIndex = 4;
            label2.Text = "Reemplazar:";
            // 
            // TReemplazaLetra
            // 
            TReemplazaLetra.BackColor = Color.BlueViolet;
            TReemplazaLetra.BorderStyle = BorderStyle.FixedSingle;
            TReemplazaLetra.ForeColor = Color.Lavender;
            TReemplazaLetra.Location = new Point(310, 210);
            TReemplazaLetra.MaxLength = 1;
            TReemplazaLetra.Name = "TReemplazaLetra";
            TReemplazaLetra.Size = new Size(37, 26);
            TReemplazaLetra.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(353, 213);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 6;
            label3.Text = "por";
            // 
            // TReemplazaPor
            // 
            TReemplazaPor.BackColor = Color.BlueViolet;
            TReemplazaPor.BorderStyle = BorderStyle.FixedSingle;
            TReemplazaPor.ForeColor = Color.Lavender;
            TReemplazaPor.Location = new Point(393, 210);
            TReemplazaPor.MaxLength = 1;
            TReemplazaPor.Name = "TReemplazaPor";
            TReemplazaPor.Size = new Size(41, 26);
            TReemplazaPor.TabIndex = 7;
            // 
            // BReemplazar
            // 
            BReemplazar.BackColor = Color.FromArgb(92, 80, 255);
            BReemplazar.FlatStyle = FlatStyle.Flat;
            BReemplazar.ForeColor = Color.DarkTurquoise;
            BReemplazar.Location = new Point(450, 207);
            BReemplazar.Name = "BReemplazar";
            BReemplazar.Size = new Size(181, 32);
            BReemplazar.TabIndex = 8;
            BReemplazar.Text = "&Reemplazar";
            BReemplazar.UseVisualStyleBackColor = false;
            BReemplazar.Click += BReemplazar_Click;
            // 
            // BVocales
            // 
            BVocales.BackColor = Color.FromArgb(92, 80, 255);
            BVocales.FlatStyle = FlatStyle.Flat;
            BVocales.ForeColor = Color.DarkTurquoise;
            BVocales.Location = new Point(270, 277);
            BVocales.Name = "BVocales";
            BVocales.Size = new Size(164, 52);
            BVocales.TabIndex = 9;
            BVocales.Text = "Cantidad de &vocales";
            BVocales.UseVisualStyleBackColor = false;
            BVocales.Click += BVocales_Click;
            // 
            // BPalabras
            // 
            BPalabras.BackColor = Color.FromArgb(92, 80, 255);
            BPalabras.FlatStyle = FlatStyle.Flat;
            BPalabras.ForeColor = Color.DarkTurquoise;
            BPalabras.Location = new Point(270, 347);
            BPalabras.Name = "BPalabras";
            BPalabras.Size = new Size(164, 52);
            BPalabras.TabIndex = 10;
            BPalabras.Text = "Cantidad de &palabras";
            BPalabras.UseVisualStyleBackColor = false;
            BPalabras.Click += BPalabras_Click;
            // 
            // BCerrar
            // 
            BCerrar.BackColor = Color.FromArgb(56, 17, 124);
            BCerrar.Dock = DockStyle.Bottom;
            BCerrar.FlatStyle = FlatStyle.Flat;
            BCerrar.ForeColor = Color.MediumOrchid;
            BCerrar.Location = new Point(0, 460);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(784, 39);
            BCerrar.TabIndex = 11;
            BCerrar.Text = "&Cancelar";
            BCerrar.UseVisualStyleBackColor = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // LVocales
            // 
            LVocales.AutoSize = true;
            LVocales.BackColor = Color.Transparent;
            LVocales.ForeColor = SystemColors.ControlLightLight;
            LVocales.Location = new Point(450, 293);
            LVocales.Name = "LVocales";
            LVocales.Size = new Size(181, 20);
            LVocales.TabIndex = 12;
            LVocales.Text = "Cantidad de vocales: 0";
            // 
            // LPalabras
            // 
            LPalabras.AutoSize = true;
            LPalabras.BackColor = Color.Transparent;
            LPalabras.ForeColor = SystemColors.ControlLightLight;
            LPalabras.Location = new Point(450, 363);
            LPalabras.Name = "LPalabras";
            LPalabras.Size = new Size(186, 20);
            LPalabras.TabIndex = 13;
            LPalabras.Text = "Cantidad de palabras: 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 499);
            Controls.Add(LPalabras);
            Controls.Add(LVocales);
            Controls.Add(BCerrar);
            Controls.Add(BPalabras);
            Controls.Add(BVocales);
            Controls.Add(BReemplazar);
            Controls.Add(TReemplazaPor);
            Controls.Add(label3);
            Controls.Add(TReemplazaLetra);
            Controls.Add(label2);
            Controls.Add(BPasarOracion);
            Controls.Add(BEliminarEspacios);
            Controls.Add(TFrase);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "FFrase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TFrase;
        private Button BEliminarEspacios;
        private Button BPasarOracion;
        private Label label2;
        private TextBox TReemplazaLetra;
        private Label label3;
        private TextBox TReemplazaPor;
        private Button BReemplazar;
        private Button BVocales;
        private Button BPalabras;
        private Button BCerrar;
        private Label LVocales;
        private Label LPalabras;
    }
}