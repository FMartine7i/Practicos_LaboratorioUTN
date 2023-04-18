namespace CustomControls
{
    partial class CustomButton
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
            customButton1 = new Controls.CustomButton();
            SuspendLayout();
            // 
            // customButton1
            // 
            customButton1.BackColor = Color.FromArgb(75, 10, 80);
            customButton1.BackgroundColor = Color.FromArgb(75, 10, 80);
            customButton1.BorderColor = Color.PaleVioletRed;
            customButton1.BorderRadius = 30;
            customButton1.BorderSize = 0;
            customButton1.FlatAppearance.BorderSize = 0;
            customButton1.FlatStyle = FlatStyle.Flat;
            customButton1.ForeColor = Color.White;
            customButton1.Location = new Point(338, 303);
            customButton1.Name = "customButton1";
            customButton1.Size = new Size(150, 57);
            customButton1.TabIndex = 0;
            customButton1.Text = "customButton1";
            customButton1.TextColor = Color.White;
            customButton1.UseVisualStyleBackColor = false;
            // 
            // CustomButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(customButton1);
            Name = "CustomButton";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Controls.CustomButton customButton1;
    }
}