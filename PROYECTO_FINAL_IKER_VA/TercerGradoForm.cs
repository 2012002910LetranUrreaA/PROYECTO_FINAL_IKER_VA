namespace PROYECTO_FINAL_IKER_VA
{
    public partial class TercerGradoForm : Form
    {
        public TercerGradoForm()
        {
            InitializeComponent();
        }
        private void txtA_TextChanged(object sender, EventArgs e)
        {
            // Lógica opcional
        }
        private void txtB_TextChanged(object sender, EventArgs e)
        {
            // Lógica opcional
        }
        private void txtC_TextChanged(object sender, EventArgs e)
        {
            // Lógica opcional
        }

        private void txtD_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                double d = double.Parse(txtD.Text);

                if (a == 0)
                {
                    label6.Text = "El coeficiente 'a' no puede ser 0.";
                    return;
                }

                // Normalización
                double p = (3 * a * c - b * b) / (3 * a * a);
                double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);

                double discriminante = Math.Pow(q / 2, 2) + Math.Pow(p / 3, 3);

                if (discriminante > 0)
                {
                    // Una raíz real
                    double sqrtDisc = Math.Sqrt(discriminante);
                    double u = Math.Cbrt(-q / 2 + sqrtDisc);
                    double v = Math.Cbrt(-q / 2 - sqrtDisc);
                    double x1 = u + v - b / (3 * a);
                    label6.Text = $"Una raíz real: x = {x1:F4}";
                }
                else if (discriminante == 0)
                {
                    // Todas las raíces reales, al menos dos iguales
                    double u = Math.Cbrt(-q / 2);
                    double x1 = 2 * u - b / (3 * a);
                    double x2 = -u - b / (3 * a);
                    label6.Text = $"Raíces reales: x1 = {x1:F4}, x2 = {x2:F4}";
                }
                else
                {
                    // Tres raíces reales distintas
                    double r = Math.Sqrt(-Math.Pow(p / 3, 3));
                    double phi = Math.Acos(-q / (2 * Math.Sqrt(-Math.Pow(p / 3, 3))));
                    double x1 = 2 * Math.Sqrt(-p / 3) * Math.Cos(phi / 3) - b / (3 * a);
                    double x2 = 2 * Math.Sqrt(-p / 3) * Math.Cos((phi + 2 * Math.PI) / 3) - b / (3 * a);
                    double x3 = 2 * Math.Sqrt(-p / 3) * Math.Cos((phi + 4 * Math.PI) / 3) - b / (3 * a);
                    label6.Text = $"Raíces reales:\nx1 = {x1:F4}\nx2 = {x2:F4}\nx3 = {x3:F4}";
                }
            }
            catch (FormatException)
            {
                label6.Text = "Ingrese valores numéricos válidos.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
