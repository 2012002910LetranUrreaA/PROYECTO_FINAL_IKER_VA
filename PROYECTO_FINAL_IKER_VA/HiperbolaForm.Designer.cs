namespace PROYECTO_FINAL_IKER_VA
{
    partial class HiperbolaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rbHorizontal = new RadioButton();
            rbVertical = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnResolver = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // rbHorizontal
            // 
            rbHorizontal.AutoSize = true;
            rbHorizontal.Location = new Point(373, 179);
            rbHorizontal.Name = "rbHorizontal";
            rbHorizontal.Size = new Size(218, 19);
            rbHorizontal.TabIndex = 0;
            rbHorizontal.TabStop = true;
            rbHorizontal.Text = "(x-h)²/a² - (y-k)²/b² = 1 (Horizontal)  ";
            rbHorizontal.UseVisualStyleBackColor = true;
            // 
            // rbVertical
            // 
            rbVertical.AutoSize = true;
            rbVertical.Location = new Point(373, 237);
            rbVertical.Name = "rbVertical";
            rbVertical.Size = new Size(201, 19);
            rbVertical.TabIndex = 1;
            rbVertical.TabStop = true;
            rbVertical.Text = "(y-k)²/a² - (x-h)²/b² = 1 (Vertical)  ";
            rbVertical.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(201, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(201, 120);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(165, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(201, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(165, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(220, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(147, 23);
            textBox4.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(355, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese los coeficientes de la ecuación Ax² + Cy² + Dx + Ey + F = 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 7;
            label2.Text = "Coordenada h:\t";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 8;
            label3.Text = "Coordenada k:\t";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 187);
            label4.Name = "label4";
            label4.Size = new Size(184, 15);
            label4.TabIndex = 9;
            label4.Text = "Parámetro a (distancia a vértices):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 245);
            label5.Name = "label5";
            label5.Size = new Size(203, 15);
            label5.TabIndex = 10;
            label5.Text = "Parámetro b (distancia a co-vértices):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(671, 187);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 11;
            label6.Text = "(Resultado)";
            // 
            // btnResolver
            // 
            btnResolver.Location = new Point(373, 63);
            btnResolver.Name = "btnResolver";
            btnResolver.Size = new Size(75, 23);
            btnResolver.TabIndex = 12;
            btnResolver.Text = "Resolver";
            btnResolver.UseVisualStyleBackColor = true;
            btnResolver.Click += btnResolver_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(373, 120);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(201, 23);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver al Menú Principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // HiperbolaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 358);
            Controls.Add(btnVolver);
            Controls.Add(btnResolver);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(rbVertical);
            Controls.Add(rbHorizontal);
            Name = "HiperbolaForm";
            Text = "HiperbolaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbHorizontal;
        private RadioButton rbVertical;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnResolver;
        private Button btnVolver;
    }
}