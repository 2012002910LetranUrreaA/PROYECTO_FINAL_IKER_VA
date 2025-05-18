namespace PROYECTO_FINAL_IKER_VA
{
    partial class ElipseForm
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
            txtH = new TextBox();
            txtK = new TextBox();
            txtA = new TextBox();
            txtB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // txtH
            // 
            txtH.Location = new Point(140, 84);
            txtH.Name = "txtH";
            txtH.Size = new Size(100, 23);
            txtH.TabIndex = 0;
            // 
            // txtK
            // 
            txtK.Location = new Point(140, 145);
            txtK.Name = "txtK";
            txtK.Size = new Size(100, 23);
            txtK.TabIndex = 1;
            // 
            // txtA
            // 
            txtA.Location = new Point(140, 211);
            txtA.Name = "txtA";
            txtA.Size = new Size(100, 23);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(140, 287);
            txtB.Name = "txtB";
            txtB.Size = new Size(100, 23);
            txtB.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(323, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese los coeficientes de la ecuación (x-h)²/a²+(y-k)²/b²=1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 5;
            label2.Text = "Coordenada h:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 6;
            label3.Text = "Coordenada k:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 214);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 7;
            label4.Text = "Semieje mayor (a):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 290);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 8;
            label5.Text = "Semieje menor (b):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 88);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 9;
            label6.Text = "(Resultado)";
            // 
            // button1
            // 
            button1.Location = new Point(281, 84);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Resolver";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 145);
            button2.Name = "button2";
            button2.Size = new Size(250, 23);
            button2.TabIndex = 11;
            button2.Text = "Volver al Menú Principal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ElipseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 340);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(txtK);
            Controls.Add(txtH);
            Name = "ElipseForm";
            Text = "ElipseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtH;
        private TextBox txtK;
        private TextBox txtA;
        private TextBox txtB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
    }
}