namespace PROYECTO_FINAL_IKER_VA
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
            lblTitulo = new Label();
            lblInstruccion = new Label();
            btnPrimerGrado = new Button();
            btnSegundoGrado = new Button();
            btnTercerGrado = new Button();
            btnElipse = new Button();
            btnSalir = new Button();
            btnHiperbola = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(147, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(316, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONVERSIÓN DE UNIDADES - SOLUCIÓN DE ECUACIONES";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.Location = new Point(174, 45);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(269, 15);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Por favor seleccione el tipo de ecuación a resolver";
            // 
            // btnPrimerGrado
            // 
            btnPrimerGrado.Location = new Point(79, 102);
            btnPrimerGrado.Name = "btnPrimerGrado";
            btnPrimerGrado.Size = new Size(75, 39);
            btnPrimerGrado.TabIndex = 2;
            btnPrimerGrado.Text = "Primer Grado";
            btnPrimerGrado.UseVisualStyleBackColor = true;
            btnPrimerGrado.Click += btnPrimerGrado_Click_1;
            // 
            // btnSegundoGrado
            // 
            btnSegundoGrado.Location = new Point(246, 102);
            btnSegundoGrado.Name = "btnSegundoGrado";
            btnSegundoGrado.Size = new Size(75, 39);
            btnSegundoGrado.TabIndex = 3;
            btnSegundoGrado.Text = "Segundo Grado";
            btnSegundoGrado.UseVisualStyleBackColor = true;
            btnSegundoGrado.Click += btnSegundoGrado_Click_1;
            // 
            // btnTercerGrado
            // 
            btnTercerGrado.Location = new Point(418, 102);
            btnTercerGrado.Name = "btnTercerGrado";
            btnTercerGrado.Size = new Size(75, 39);
            btnTercerGrado.TabIndex = 4;
            btnTercerGrado.Text = "Tercer Grado";
            btnTercerGrado.UseVisualStyleBackColor = true;
            btnTercerGrado.Click += btnTercerGrado_Click_1;
            // 
            // btnElipse
            // 
            btnElipse.Location = new Point(79, 205);
            btnElipse.Name = "btnElipse";
            btnElipse.Size = new Size(75, 23);
            btnElipse.TabIndex = 5;
            btnElipse.Text = "Elipse";
            btnElipse.UseVisualStyleBackColor = true;
            btnElipse.Click += btnElipse_Click_1;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(418, 205);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnHiperbola
            // 
            btnHiperbola.Location = new Point(246, 205);
            btnHiperbola.Name = "btnHiperbola";
            btnHiperbola.Size = new Size(75, 23);
            btnHiperbola.TabIndex = 8;
            btnHiperbola.Text = "Hiperbola";
            btnHiperbola.UseVisualStyleBackColor = true;
            btnHiperbola.Click += btnHiperbola_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 261);
            Controls.Add(btnHiperbola);
            Controls.Add(btnSalir);
            Controls.Add(btnElipse);
            Controls.Add(btnTercerGrado);
            Controls.Add(btnSegundoGrado);
            Controls.Add(btnPrimerGrado);
            Controls.Add(lblInstruccion);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "VENTANA 1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblInstruccion;
        private Button btnPrimerGrado;
        private Button btnSegundoGrado;
        private Button btnTercerGrado;
        private Button btnElipse;
        private Button btnSalir;
        private Button btnHiperbola;
    }
}
