namespace IntercambDatos
{
    partial class fIntercambiarDatos
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
            bIntercambio = new CustomControls.Controls.CustomButton();
            bClose = new CustomControls.Controls.CustomButton();
            lvalorA = new System.Windows.Forms.Label();
            lvalorB = new System.Windows.Forms.Label();
            tvalorA = new System.Windows.Forms.TextBox();
            tvalorB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bIntercambio
            // 
            bIntercambio.BackColor = System.Drawing.Color.DarkOrchid;
            bIntercambio.BackgroundColor = System.Drawing.Color.DarkOrchid;
            bIntercambio.BorderColor = System.Drawing.Color.DeepSkyBlue;
            bIntercambio.BorderRadius = 10;
            bIntercambio.BorderSize = 2;
            bIntercambio.FlatAppearance.BorderSize = 0;
            bIntercambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bIntercambio.ForeColor = System.Drawing.Color.Plum;
            bIntercambio.Location = new System.Drawing.Point(293, 296);
            bIntercambio.Name = "bIntercambio";
            bIntercambio.Size = new System.Drawing.Size(179, 57);
            bIntercambio.TabIndex = 0;
            bIntercambio.Text = "iniciar";
            bIntercambio.TextColor = System.Drawing.Color.Plum;
            bIntercambio.UseVisualStyleBackColor = false;
            bIntercambio.Click += this.bIntercambio_Click;
            // 
            // bClose
            // 
            bClose.BackColor = System.Drawing.Color.DarkOrchid;
            bClose.BackgroundColor = System.Drawing.Color.DarkOrchid;
            bClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            bClose.BorderRadius = 1;
            bClose.BorderSize = 0;
            bClose.FlatAppearance.BorderSize = 0;
            bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bClose.ForeColor = System.Drawing.Color.White;
            bClose.Location = new System.Drawing.Point(702, 12);
            bClose.Name = "bClose";
            bClose.Size = new System.Drawing.Size(36, 40);
            bClose.TabIndex = 1;
            bClose.Text = "X";
            bClose.TextColor = System.Drawing.Color.White;
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += this.bClose_Click;
            // 
            // lvalorA
            // 
            lvalorA.AutoSize = true;
            lvalorA.BackColor = System.Drawing.Color.Transparent;
            lvalorA.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lvalorA.Location = new System.Drawing.Point(197, 68);
            lvalorA.Name = "lvalorA";
            lvalorA.Size = new System.Drawing.Size(204, 28);
            lvalorA.TabIndex = 2;
            lvalorA.Text = "Ingresar valor A:";
            // 
            // lvalorB
            // 
            lvalorB.AutoSize = true;
            lvalorB.BackColor = System.Drawing.Color.Transparent;
            lvalorB.Location = new System.Drawing.Point(221, 139);
            lvalorB.Name = "lvalorB";
            lvalorB.Size = new System.Drawing.Size(176, 25);
            lvalorB.TabIndex = 3;
            lvalorB.Text = "Ingresar valor B:";
            // 
            // tvalorA
            // 
            tvalorA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            tvalorA.BackColor = System.Drawing.Color.DarkOrchid;
            tvalorA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tvalorA.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tvalorA.ForeColor = System.Drawing.Color.Thistle;
            tvalorA.Location = new System.Drawing.Point(452, 63);
            tvalorA.Name = "tvalorA";
            tvalorA.Size = new System.Drawing.Size(100, 30);
            tvalorA.TabIndex = 4;
            // 
            // tvalorB
            // 
            tvalorB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            tvalorB.BackColor = System.Drawing.Color.DarkOrchid;
            tvalorB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            tvalorB.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            tvalorB.ForeColor = System.Drawing.Color.Thistle;
            tvalorB.Location = new System.Drawing.Point(433, 139);
            tvalorB.Name = "tvalorB";
            tvalorB.Size = new System.Drawing.Size(79, 26);
            tvalorB.TabIndex = 5;
            // 
            // fIntercambiarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = IntercambDatos.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 438);
            this.Controls.Add(tvalorB);
            this.Controls.Add(tvalorA);
            this.Controls.Add(lvalorB);
            this.Controls.Add(lvalorA);
            this.Controls.Add(bClose);
            this.Controls.Add(bIntercambio);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fIntercambiarDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private CustomControls.Controls.CustomButton bIntercambio;
        private CustomControls.Controls.CustomButton bClose;
        private Label lvalorA;
        private Label lvalorB;
        private TextBox tvalorA;
        private TextBox tvalorB;
    }
}