namespace PROYECTO_FINAL_IKER_VA
{
    public partial class PrimerGradoForm : Form
    {
        public PrimerGradoForm()
        {
            InitializeComponent();
        }

        private void btnVolv_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResolv_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);

                if (a == 0)
                {
                    lblResultado.Text = "El coeficiente 'a' no puede ser 0.";
                }
                else
                {
                    double x = -b / a;
                    lblResultado.Text = $"La solución es: x = {x}";
                }
            }
            catch (FormatException)
            {
                lblResultado.Text = "Por favor, ingrese valores numéricos válidos.";
            }
        }
    }
}
