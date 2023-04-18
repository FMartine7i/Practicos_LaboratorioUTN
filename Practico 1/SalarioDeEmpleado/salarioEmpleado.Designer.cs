namespace SalarioDeEmpleado
{
    partial class fSalarioEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSalarioEmpleado));
            bCalcular = new CustomControls.Controls.CustomButton();
            bClose = new CustomControls.Controls.CustomButton();
            lNombre = new Label();
            lIngreso = new Label();
            lTarifa = new Label();
            lHorasTrabajadas = new Label();
            lDiasTrabajados = new Label();
            tNombre = new TextBox();
            tIngreso = new TextBox();
            tTarifa = new TextBox();
            tHorasTrabajadas = new TextBox();
            tDiasTrabajados = new TextBox();
            SuspendLayout();
            // 
            // bCalcular
            // 
            bCalcular.BackColor = Color.BlueViolet;
            bCalcular.BackgroundColor = Color.BlueViolet;
            bCalcular.BorderColor = Color.DarkTurquoise;
            bCalcular.BorderRadius = 30;
            bCalcular.BorderSize = 2;
            bCalcular.FlatAppearance.BorderSize = 0;
            bCalcular.FlatStyle = FlatStyle.Flat;
            bCalcular.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            bCalcular.ForeColor = Color.Plum;
            bCalcular.Location = new Point(413, 449);
            bCalcular.Margin = new Padding(5);
            bCalcular.Name = "bCalcular";
            bCalcular.Size = new Size(175, 60);
            bCalcular.TabIndex = 0;
            bCalcular.Text = "calcular";
            bCalcular.TextColor = Color.Plum;
            bCalcular.UseVisualStyleBackColor = false;
            bCalcular.Click += bCalcular_Click;
            // 
            // bClose
            // 
            bClose.BackColor = Color.MediumSlateBlue;
            bClose.BackgroundColor = Color.MediumSlateBlue;
            bClose.BorderColor = Color.HotPink;
            bClose.BorderRadius = 10;
            bClose.BorderSize = 2;
            bClose.FlatAppearance.BorderSize = 0;
            bClose.FlatStyle = FlatStyle.Flat;
            bClose.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            bClose.ForeColor = Color.White;
            bClose.Location = new Point(919, 14);
            bClose.Margin = new Padding(5);
            bClose.Name = "bClose";
            bClose.Size = new Size(40, 43);
            bClose.TabIndex = 1;
            bClose.Text = "X";
            bClose.TextColor = Color.White;
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // lNombre
            // 
            lNombre.AutoSize = true;
            lNombre.BackColor = Color.Transparent;
            lNombre.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lNombre.ForeColor = Color.FromArgb(63, 49, 92);
            lNombre.Location = new Point(175, 122);
            lNombre.Name = "lNombre";
            lNombre.Size = new Size(114, 28);
            lNombre.TabIndex = 2;
            lNombre.Text = "Nombre:";
            // 
            // lIngreso
            // 
            lIngreso.AutoSize = true;
            lIngreso.BackColor = Color.Transparent;
            lIngreso.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lIngreso.ForeColor = Color.FromArgb(63, 49, 92);
            lIngreso.Location = new Point(93, 219);
            lIngreso.Name = "lIngreso";
            lIngreso.Size = new Size(196, 28);
            lIngreso.TabIndex = 3;
            lIngreso.Text = "Año de ingreso:";
            // 
            // lTarifa
            // 
            lTarifa.AutoSize = true;
            lTarifa.BackColor = Color.Transparent;
            lTarifa.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lTarifa.ForeColor = Color.FromArgb(63, 49, 92);
            lTarifa.Location = new Point(117, 323);
            lTarifa.Name = "lTarifa";
            lTarifa.Size = new Size(172, 28);
            lTarifa.TabIndex = 4;
            lTarifa.Text = "Tarifa horaria:";
            // 
            // lHorasTrabajadas
            // 
            lHorasTrabajadas.AutoSize = true;
            lHorasTrabajadas.BackColor = Color.Transparent;
            lHorasTrabajadas.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lHorasTrabajadas.ForeColor = Color.FromArgb(63, 49, 92);
            lHorasTrabajadas.Location = new Point(497, 161);
            lHorasTrabajadas.Name = "lHorasTrabajadas";
            lHorasTrabajadas.Size = new Size(269, 28);
            lHorasTrabajadas.TabIndex = 5;
            lHorasTrabajadas.Text = "Horas trabajadas/día:";
            // 
            // lDiasTrabajados
            // 
            lDiasTrabajados.AutoSize = true;
            lDiasTrabajados.BackColor = Color.Transparent;
            lDiasTrabajados.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lDiasTrabajados.ForeColor = Color.FromArgb(63, 49, 92);
            lDiasTrabajados.Location = new Point(503, 262);
            lDiasTrabajados.Name = "lDiasTrabajados";
            lDiasTrabajados.Size = new Size(263, 28);
            lDiasTrabajados.TabIndex = 6;
            lDiasTrabajados.Text = "Días trabajados/mes:";
            // 
            // tNombre
            // 
            tNombre.BorderStyle = BorderStyle.None;
            tNombre.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tNombre.ForeColor = Color.DarkOrchid;
            tNombre.Location = new Point(295, 119);
            tNombre.Name = "tNombre";
            tNombre.Size = new Size(176, 30);
            tNombre.TabIndex = 7;
            // 
            // tIngreso
            // 
            tIngreso.BorderStyle = BorderStyle.None;
            tIngreso.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tIngreso.ForeColor = Color.DarkOrchid;
            tIngreso.Location = new Point(295, 217);
            tIngreso.Name = "tIngreso";
            tIngreso.Size = new Size(121, 30);
            tIngreso.TabIndex = 8;
            // 
            // tTarifa
            // 
            tTarifa.BorderStyle = BorderStyle.None;
            tTarifa.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tTarifa.ForeColor = Color.DarkOrchid;
            tTarifa.Location = new Point(295, 323);
            tTarifa.Name = "tTarifa";
            tTarifa.Size = new Size(121, 30);
            tTarifa.TabIndex = 9;
            // 
            // tHorasTrabajadas
            // 
            tHorasTrabajadas.BorderStyle = BorderStyle.None;
            tHorasTrabajadas.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tHorasTrabajadas.ForeColor = Color.DarkOrchid;
            tHorasTrabajadas.Location = new Point(772, 159);
            tHorasTrabajadas.Name = "tHorasTrabajadas";
            tHorasTrabajadas.Size = new Size(88, 30);
            tHorasTrabajadas.TabIndex = 10;
            // 
            // tDiasTrabajados
            // 
            tDiasTrabajados.BorderStyle = BorderStyle.None;
            tDiasTrabajados.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tDiasTrabajados.ForeColor = Color.DarkOrchid;
            tDiasTrabajados.Location = new Point(772, 262);
            tDiasTrabajados.Name = "tDiasTrabajados";
            tDiasTrabajados.Size = new Size(88, 30);
            tDiasTrabajados.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(973, 563);
            Controls.Add(tDiasTrabajados);
            Controls.Add(tHorasTrabajadas);
            Controls.Add(tTarifa);
            Controls.Add(tIngreso);
            Controls.Add(tNombre);
            Controls.Add(lDiasTrabajados);
            Controls.Add(lHorasTrabajadas);
            Controls.Add(lTarifa);
            Controls.Add(lIngreso);
            Controls.Add(lNombre);
            Controls.Add(bClose);
            Controls.Add(bCalcular);
            Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.FloralWhite;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomControls.Controls.CustomButton bCalcular;
        private CustomControls.Controls.CustomButton bClose;
        private Label lNombre;
        private Label lIngreso;
        private Label lTarifa;
        private Label lHorasTrabajadas;
        private Label lDiasTrabajados;
        private TextBox tNombre;
        private TextBox tIngreso;
        private TextBox tTarifa;
        private TextBox tHorasTrabajadas;
        private TextBox tDiasTrabajados;
    }
}