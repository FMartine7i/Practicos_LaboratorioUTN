namespace Ejercicio1
{
    partial class FCondicionalTernario
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
            tNum = new TextBox();
            bCalcularAbs = new Button();
            bRedondear = new Button();
            SuspendLayout();
            // 
            // tNum
            // 
            tNum.BackColor = Color.Indigo;
            tNum.BorderStyle = BorderStyle.FixedSingle;
            tNum.ForeColor = Color.Plum;
            tNum.Location = new Point(129, 29);
            tNum.Margin = new Padding(4);
            tNum.Name = "tNum";
            tNum.Size = new Size(107, 26);
            tNum.TabIndex = 0;
            // 
            // bCalcularAbs
            // 
            bCalcularAbs.BackColor = Color.FromArgb(98, 136, 29, 190);
            bCalcularAbs.FlatStyle = FlatStyle.Flat;
            bCalcularAbs.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bCalcularAbs.ForeColor = Color.DeepSkyBlue;
            bCalcularAbs.Location = new Point(46, 83);
            bCalcularAbs.Margin = new Padding(4);
            bCalcularAbs.Name = "bCalcularAbs";
            bCalcularAbs.Size = new Size(125, 44);
            bCalcularAbs.TabIndex = 2;
            bCalcularAbs.Text = "Calcular Abs";
            bCalcularAbs.UseVisualStyleBackColor = false;
            bCalcularAbs.Click += bCalcularAbs_Click;
            // 
            // bRedondear
            // 
            bRedondear.BackColor = Color.FromArgb(98, 136, 29, 190);
            bRedondear.FlatStyle = FlatStyle.Flat;
            bRedondear.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            bRedondear.ForeColor = Color.DeepSkyBlue;
            bRedondear.Location = new Point(195, 83);
            bRedondear.Margin = new Padding(4);
            bRedondear.Name = "bRedondear";
            bRedondear.Size = new Size(125, 44);
            bRedondear.TabIndex = 3;
            bRedondear.Text = "Redondear";
            bRedondear.UseVisualStyleBackColor = false;
            bRedondear.Click += bRedondear_Click;
            // 
            // FCondicionalTernario
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(365, 161);
            Controls.Add(bRedondear);
            Controls.Add(bCalcularAbs);
            Controls.Add(tNum);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FCondicionalTernario";
            Text = "Operador Ternario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tNum;
        private Button bCalcularAbs;
        private Button bRedondear;
    }
}