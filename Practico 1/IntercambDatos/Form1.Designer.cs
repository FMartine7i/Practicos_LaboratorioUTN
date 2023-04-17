namespace IntercambDatos
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
            bIntercambio = new CustomControls.Controls.CustomButton();
            bClose = new CustomControls.Controls.CustomButton();
            lvalorA = new Label();
            lvalorB = new Label();
            tvalorA = new TextBox();
            tvalorB = new TextBox();
            SuspendLayout();
            // 
            // bIntercambio
            // 
            bIntercambio.BackColor = Color.DarkOrchid;
            bIntercambio.BackgroundColor = Color.DarkOrchid;
            bIntercambio.BorderColor = Color.DeepSkyBlue;
            bIntercambio.BorderRadius = 10;
            bIntercambio.BorderSize = 2;
            bIntercambio.FlatAppearance.BorderSize = 0;
            bIntercambio.FlatStyle = FlatStyle.Flat;
            bIntercambio.ForeColor = Color.Plum;
            bIntercambio.Location = new Point(293, 296);
            bIntercambio.Name = "bIntercambio";
            bIntercambio.Size = new Size(179, 57);
            bIntercambio.TabIndex = 0;
            bIntercambio.Text = "iniciar";
            bIntercambio.TextColor = Color.Plum;
            bIntercambio.UseVisualStyleBackColor = false;
            bIntercambio.Click += bIntercambio_Click;
            // 
            // bClose
            // 
            bClose.BackColor = Color.DarkOrchid;
            bClose.BackgroundColor = Color.DarkOrchid;
            bClose.BorderColor = Color.PaleVioletRed;
            bClose.BorderRadius = 1;
            bClose.BorderSize = 0;
            bClose.FlatAppearance.BorderSize = 0;
            bClose.FlatStyle = FlatStyle.Flat;
            bClose.ForeColor = Color.White;
            bClose.Location = new Point(702, 12);
            bClose.Name = "bClose";
            bClose.Size = new Size(36, 40);
            bClose.TabIndex = 1;
            bClose.Text = "X";
            bClose.TextColor = Color.White;
            bClose.UseVisualStyleBackColor = false;
            bClose.Click += bClose_Click;
            // 
            // lvalorA
            // 
            lvalorA.AutoSize = true;
            lvalorA.BackColor = Color.Transparent;
            lvalorA.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lvalorA.Location = new Point(197, 68);
            lvalorA.Name = "lvalorA";
            lvalorA.Size = new Size(204, 28);
            lvalorA.TabIndex = 2;
            lvalorA.Text = "Ingresar valor A:";
            // 
            // lvalorB
            // 
            lvalorB.AutoSize = true;
            lvalorB.BackColor = Color.Transparent;
            lvalorB.Location = new Point(221, 139);
            lvalorB.Name = "lvalorB";
            lvalorB.Size = new Size(180, 25);
            lvalorB.TabIndex = 3;
            lvalorB.Text = "Ingresar valor A:";
            // 
            // tvalorA
            // 
            tvalorA.AutoCompleteSource = AutoCompleteSource.FileSystem;
            tvalorA.BackColor = Color.DarkOrchid;
            tvalorA.BorderStyle = BorderStyle.None;
            tvalorA.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            tvalorA.ForeColor = Color.Thistle;
            tvalorA.Location = new Point(452, 63);
            tvalorA.Name = "tvalorA";
            tvalorA.Size = new Size(100, 30);
            tvalorA.TabIndex = 4;
            // 
            // tvalorB
            // 
            tvalorB.AutoCompleteSource = AutoCompleteSource.FileSystem;
            tvalorB.BackColor = Color.DarkOrchid;
            tvalorB.BorderStyle = BorderStyle.None;
            tvalorB.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            tvalorB.ForeColor = Color.Thistle;
            tvalorB.Location = new Point(433, 139);
            tvalorB.Name = "tvalorB";
            tvalorB.Size = new Size(79, 26);
            tvalorB.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(750, 438);
            Controls.Add(tvalorB);
            Controls.Add(tvalorA);
            Controls.Add(lvalorB);
            Controls.Add(lvalorA);
            Controls.Add(bClose);
            Controls.Add(bIntercambio);
            Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.WhiteSmoke;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
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