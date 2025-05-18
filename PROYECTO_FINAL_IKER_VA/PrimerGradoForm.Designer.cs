namespace PROYECTO_FINAL_IKER_VA
{
    partial class PrimerGradoForm
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
            label1 = new Label();
            label2 = new Label();
            lblB = new Label();
            lblResultado = new Label();
            btnResolv = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(151, 107);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(151, 185);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 33);
            label1.Name = "label1";
            label1.Size = new Size(264, 15);
            label1.TabIndex = 2;
            label1.Text = "Ingrese los coeficientes de la ecuación ax + b = 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 110);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Coeficiente a:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(40, 188);
            lblB.Name = "lblB";
            lblB.Size = new Size(80, 15);
            lblB.TabIndex = 4;
            lblB.Text = "Coeficiente b:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(390, 115);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(67, 15);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "(Resultado)";
            // 
            // btnResolv
            // 
            btnResolv.Location = new Point(286, 106);
            btnResolv.Name = "btnResolv";
            btnResolv.Size = new Size(75, 23);
            btnResolv.TabIndex = 6;
            btnResolv.Text = "Resolver";
            btnResolv.UseVisualStyleBackColor = true;
            btnResolv.Click += btnResolv_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(286, 188);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(186, 23);
            btnVolver.TabIndex = 7;
            btnVolver.Text = "Volver al Menú Principal";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolv_Click;
            // 
            // PrimerGradoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 303);
            Controls.Add(btnVolver);
            Controls.Add(btnResolv);
            Controls.Add(lblResultado);
            Controls.Add(lblB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "PrimerGradoForm";
            Text = "PrimerGradoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Label label1;
        private Label label2;
        private Label lblB;
        private Label lblResultado;
        private Button btnResolv;
        private Button btnVolver;
    }
}