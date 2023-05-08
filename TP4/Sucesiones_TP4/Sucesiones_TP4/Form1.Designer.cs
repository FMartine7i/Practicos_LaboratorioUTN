namespace Sucesiones_TP4
{
    partial class FSucesiones
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
            lTabla = new Label();
            LFibonacci = new Label();
            BTablaMultiplicar = new Button();
            BFibonacci = new Button();
            BSerie = new Button();
            BCerrar = new Button();
            LRespuesta = new Label();
            NUDTabla = new NumericUpDown();
            NUDFibonacci = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NUDDesde = new NumericUpDown();
            NUDHasta = new NumericUpDown();
            NUDCada = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)NUDTabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDFibonacci).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDDesde).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDHasta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDCada).BeginInit();
            SuspendLayout();
            // 
            // lTabla
            // 
            lTabla.AutoSize = true;
            lTabla.BackColor = Color.Transparent;
            lTabla.ForeColor = SystemColors.Control;
            lTabla.Location = new Point(122, 135);
            lTabla.Name = "lTabla";
            lTabla.Size = new Size(74, 20);
            lTabla.TabIndex = 0;
            lTabla.Text = "Tabla del";
            // 
            // LFibonacci
            // 
            LFibonacci.AutoSize = true;
            LFibonacci.BackColor = Color.Transparent;
            LFibonacci.ForeColor = SystemColors.Control;
            LFibonacci.Location = new Point(91, 232);
            LFibonacci.Name = "LFibonacci";
            LFibonacci.Size = new Size(105, 20);
            LFibonacci.TabIndex = 1;
            LFibonacci.Text = "Fibonacci de";
            // 
            // BTablaMultiplicar
            // 
            BTablaMultiplicar.BackColor = Color.DarkOrchid;
            BTablaMultiplicar.FlatStyle = FlatStyle.Flat;
            BTablaMultiplicar.ForeColor = Color.CornflowerBlue;
            BTablaMultiplicar.Location = new Point(79, 177);
            BTablaMultiplicar.Name = "BTablaMultiplicar";
            BTablaMultiplicar.Size = new Size(167, 33);
            BTablaMultiplicar.TabIndex = 2;
            BTablaMultiplicar.Text = "Tabla de &Multiplicar";
            BTablaMultiplicar.UseVisualStyleBackColor = false;
            BTablaMultiplicar.Click += BTablaMultiplicar_Click;
            // 
            // BFibonacci
            // 
            BFibonacci.BackColor = Color.DarkOrchid;
            BFibonacci.FlatStyle = FlatStyle.Flat;
            BFibonacci.ForeColor = Color.CornflowerBlue;
            BFibonacci.Location = new Point(79, 276);
            BFibonacci.Name = "BFibonacci";
            BFibonacci.Size = new Size(167, 33);
            BFibonacci.TabIndex = 3;
            BFibonacci.Text = "&Fibonacci";
            BFibonacci.UseVisualStyleBackColor = false;
            BFibonacci.Click += BFibonacci_Click;
            // 
            // BSerie
            // 
            BSerie.BackColor = Color.DarkOrchid;
            BSerie.FlatStyle = FlatStyle.Flat;
            BSerie.ForeColor = Color.CornflowerBlue;
            BSerie.Location = new Point(79, 452);
            BSerie.Name = "BSerie";
            BSerie.Size = new Size(167, 33);
            BSerie.TabIndex = 4;
            BSerie.Text = "&Serie";
            BSerie.UseVisualStyleBackColor = false;
            BSerie.Click += BSerie_Click;
            // 
            // BCerrar
            // 
            BCerrar.BackColor = Color.FromArgb(95, 128, 0, 188);
            BCerrar.Dock = DockStyle.Bottom;
            BCerrar.ForeColor = Color.DarkSlateBlue;
            BCerrar.Location = new Point(0, 579);
            BCerrar.Name = "BCerrar";
            BCerrar.Size = new Size(520, 38);
            BCerrar.TabIndex = 5;
            BCerrar.Text = "&Cerrar";
            BCerrar.UseVisualStyleBackColor = false;
            BCerrar.Click += BCerrar_Click;
            // 
            // LRespuesta
            // 
            LRespuesta.AutoSize = true;
            LRespuesta.BackColor = Color.Transparent;
            LRespuesta.ForeColor = SystemColors.Control;
            LRespuesta.Location = new Point(287, 135);
            LRespuesta.Name = "LRespuesta";
            LRespuesta.Size = new Size(13, 20);
            LRespuesta.TabIndex = 6;
            LRespuesta.Text = " ";
            LRespuesta.Click += LRespuesta_Click;
            // 
            // NUDTabla
            // 
            NUDTabla.BackColor = Color.FromArgb(57, 55, 58);
            NUDTabla.BorderStyle = BorderStyle.FixedSingle;
            NUDTabla.ForeColor = Color.MediumPurple;
            NUDTabla.Location = new Point(202, 133);
            NUDTabla.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            NUDTabla.Name = "NUDTabla";
            NUDTabla.Size = new Size(44, 26);
            NUDTabla.TabIndex = 7;
            // 
            // NUDFibonacci
            // 
            NUDFibonacci.BackColor = Color.FromArgb(57, 55, 58);
            NUDFibonacci.BorderStyle = BorderStyle.FixedSingle;
            NUDFibonacci.ForeColor = Color.MediumPurple;
            NUDFibonacci.Location = new Point(202, 230);
            NUDFibonacci.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUDFibonacci.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            NUDFibonacci.Name = "NUDFibonacci";
            NUDFibonacci.Size = new Size(44, 26);
            NUDFibonacci.TabIndex = 8;
            NUDFibonacci.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(136, 331);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 9;
            label1.Text = "Desde:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(142, 368);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 10;
            label2.Text = "Hasta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(142, 405);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 11;
            label3.Text = "Cada:";
            // 
            // NUDDesde
            // 
            NUDDesde.BackColor = Color.FromArgb(57, 55, 58);
            NUDDesde.BorderStyle = BorderStyle.FixedSingle;
            NUDDesde.ForeColor = Color.MediumPurple;
            NUDDesde.Location = new Point(202, 329);
            NUDDesde.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUDDesde.Name = "NUDDesde";
            NUDDesde.Size = new Size(44, 26);
            NUDDesde.TabIndex = 12;
            // 
            // NUDHasta
            // 
            NUDHasta.BackColor = Color.FromArgb(57, 55, 58);
            NUDHasta.BorderStyle = BorderStyle.FixedSingle;
            NUDHasta.ForeColor = Color.MediumPurple;
            NUDHasta.Location = new Point(202, 366);
            NUDHasta.Name = "NUDHasta";
            NUDHasta.Size = new Size(44, 26);
            NUDHasta.TabIndex = 13;
            // 
            // NUDCada
            // 
            NUDCada.BackColor = Color.FromArgb(57, 55, 58);
            NUDCada.BorderStyle = BorderStyle.FixedSingle;
            NUDCada.ForeColor = Color.MediumPurple;
            NUDCada.Location = new Point(203, 403);
            NUDCada.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
            NUDCada.Name = "NUDCada";
            NUDCada.Size = new Size(43, 26);
            NUDCada.TabIndex = 14;
            // 
            // FSucesiones
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back8;
            CancelButton = BCerrar;
            ClientSize = new Size(520, 617);
            Controls.Add(NUDCada);
            Controls.Add(NUDHasta);
            Controls.Add(NUDDesde);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(NUDFibonacci);
            Controls.Add(NUDTabla);
            Controls.Add(LRespuesta);
            Controls.Add(BCerrar);
            Controls.Add(BSerie);
            Controls.Add(BFibonacci);
            Controls.Add(BTablaMultiplicar);
            Controls.Add(LFibonacci);
            Controls.Add(lTabla);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FSucesiones";
            Text = "Sucesiones";
            ((System.ComponentModel.ISupportInitialize)NUDTabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDFibonacci).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDDesde).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDHasta).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDCada).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lTabla;
        private Label LFibonacci;
        private Button BTablaMultiplicar;
        private Button BFibonacci;
        private Button BSerie;
        private Button BCerrar;
        private Label LRespuesta;
        private NumericUpDown NUDTabla;
        private NumericUpDown NUDFibonacci;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown NUDDesde;
        private NumericUpDown NUDHasta;
        private NumericUpDown NUDCada;
    }
}