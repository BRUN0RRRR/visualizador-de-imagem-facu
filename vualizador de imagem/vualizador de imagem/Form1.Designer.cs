namespace vualizador_de_imagem
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
            btncarregar = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            limpar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btncarregar
            // 
            btncarregar.Location = new Point(66, 199);
            btncarregar.Name = "btncarregar";
            btncarregar.Size = new Size(75, 23);
            btncarregar.TabIndex = 0;
            btncarregar.Text = "Carregar";
            btncarregar.UseVisualStyleBackColor = true;
            btncarregar.Click += btncarregar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 181);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 181);
            panel1.TabIndex = 2;
            // 
            // limpar
            // 
            limpar.Location = new Point(147, 199);
            limpar.Name = "limpar";
            limpar.Size = new Size(75, 23);
            limpar.TabIndex = 3;
            limpar.Text = "Limpar";
            limpar.UseVisualStyleBackColor = true;
            limpar.Click += limpar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 241);
            Controls.Add(limpar);
            Controls.Add(panel1);
            Controls.Add(btncarregar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btncarregar;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button limpar;
    }
}
