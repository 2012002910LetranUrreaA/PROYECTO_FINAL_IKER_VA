namespace PROYECTO_FINAL_IKER_VA
{
    public partial class SegundoGradoForm : Form
    {
        public SegundoGradoForm()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResolver_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);

                if (a == 0)
                {
                    label5.Text = "El coeficiente 'a' no puede ser 0.";
                    return;
                }

                double discriminante = b * b - 4 * a * c;

                if (discriminante > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                    label5.Text = $"x1 = {x1:F4}, x2 = {x2:F4}";
                }
                else if (discriminante == 0)
                {
                    double x = -b / (2 * a);
                    label5.Text = $"x = {x:F4}";
                }
                else
                {
                    label5.Text = "No existen soluciones reales.";
                }
            }
            catch (FormatException)
            {
                label5.Text = "Ingrese valores numéricos válidos.";
            }
        }
    }
}
