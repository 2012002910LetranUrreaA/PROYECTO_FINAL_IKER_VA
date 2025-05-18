namespace PROYECTO_FINAL_IKER_VA
{
    public partial class HiperbolaForm : Form
    {
        public HiperbolaForm()
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
                double h = double.Parse(textBox1.Text);
                double k = double.Parse(textBox2.Text);
                double a = double.Parse(textBox3.Text);
                double b = double.Parse(textBox4.Text);

                if (a <= 0 || b <= 0)
                {
                    label6.Text = "Los parámetros a y b deben ser mayores que 0.";
                    return;
                }

                string ecuacion;
                double c = Math.Sqrt(a * a + b * b); // Distancia del centro a los focos
                double excentricidad = c / a;

                if (rbHorizontal.Checked)
                {
                    ecuacion = $"(x - {h})²/{a * a} - (y - {k})²/{b * b} = 1";
                }
                else if (rbVertical.Checked)
                {
                    ecuacion = $"(y - {k})²/{a * a} - (x - {h})²/{b * b} = 1";
                }
                else
                {
                    label6.Text = "Seleccione la orientación de la hipérbola.";
                    return;
                }

                label6.Text = $"Ecuación: {ecuacion}\n" +
                              $"Excentricidad: {excentricidad:F4}\n" +
                              $"Distancia entre focos: {2 * c:F2}";
            }
            catch (FormatException)
            {
                label6.Text = "Ingrese valores numéricos válidos.";
            }
        }
    }
}
