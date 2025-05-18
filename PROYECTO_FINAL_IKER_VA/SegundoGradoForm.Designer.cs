namespace PROYECTO_FINAL_IKER_VA
{
    partial class SegundoGradoForm
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
            txtA = new TextBox();
            txtB = new TextBox();
            txtC = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnResolver = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(143, 66);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(143, 131);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 1;
            // 
            // txtC
            // 
            txtC.Location = new Point(143, 205);
            txtC.Name = "txtC";
            txtC.Size = new Size(100, 23);
            txtC.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(354, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese los coeficientes de la ecuación x = (-b ± √(b^2 - 4ac)) / 2a";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Coeficiente a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 134);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 5;
            label3.Text = "Coeficiente b:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 208);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 6;
            label4.Text = "Coeficiente c:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(377, 69);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 7;
            label5.Text = "(Resultado)";
            // 
            // btnResolver
            // 
            btnResolver.Location = new Point(274, 65);
            btnResolver.Name = "btnResolver";
            btnResolver.Size = new Size(75, 23);
            btnResolver.TabIndex = 8;
            btnResolver.Text = "Resolver";
            btnResolver.UseVisualStyleBackColor = true;
            btnResolver.Click += btnResolver_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(274, 130);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(170, 23);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "Volver al Menú Principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // SegundoGradoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 259);
            Controls.Add(btnVolver);
            Controls.Add(btnResolver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtC);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "SegundoGradoForm";
            Text = "SegundoGradoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private TextBox txtC;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnResolver;
        private Button btnVolver;
    }
}