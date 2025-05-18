namespace PROYECTO_FINAL_IKER_VA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "CONVERSIÓN DE UNIDADES - SOLUCIÓN DE ECUACIONES";
            lblInstruccion.Text = "Por favor seleccione el tipo de ecuación a resolver:";

            // Configurar los botones del menú principal
            btnPrimerGrado.Text = "1. Ecuaciones de primer grado";
            btnSegundoGrado.Text = "2. Ecuaciones de segundo grado";
            btnTercerGrado.Text = "3. Ecuaciones de tercer grado";
            btnElipse.Text = "4. Ecuación de elipse";
            btnHiperbola.Text = "5. Ecuación de hiperbola";
            btnSalir.Text = "6. Salir";
        }


        private void btnPrimerGrado_Click_1(object sender, EventArgs e)
        {
            PrimerGradoForm primerGradoForm = new PrimerGradoForm();
            primerGradoForm.ShowDialog();
        }

        private void btnSegundoGrado_Click_1(object sender, EventArgs e)
        {
            SegundoGradoForm segundoGradoForm = new SegundoGradoForm();
            segundoGradoForm.ShowDialog();
        }

        private void btnTercerGrado_Click_1(object sender, EventArgs e)
        {
            TercerGradoForm tercerGradoForm = new TercerGradoForm();
            tercerGradoForm.ShowDialog();
        }

        private void btnElipse_Click_1(object sender, EventArgs e)
        {
            ElipseForm elipseForm = new ElipseForm();
            elipseForm.ShowDialog();
        }
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHiperbola_Click(object sender, EventArgs e)
        {
            HiperbolaForm hiperbolaForm = new HiperbolaForm();
            hiperbolaForm.ShowDialog();
        }
    }
}

