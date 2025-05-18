namespace PROYECTO_FINAL_IKER_VA
{
    public partial class ElipseForm : Form
    {
        public ElipseForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double h = double.Parse(txtH.Text);
                double k = double.Parse(txtK.Text);
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);

                if (a <= 0 || b <= 0)
                {
                    label6.Text = "Los semiejes deben ser mayores que 0.";
                    return;
                }

                string ecuacion = $"(x - {h})² / {a * a} + (y - {k})² / {b * b} = 1";
                double excentricidad = Math.Sqrt(1 - (b * b) / (a * a));
                double area = Math.PI * a * b;

                label6.Text = $"Ecuación: {ecuacion}\n" +
                              $"Excentricidad: {excentricidad:F4}\n" +
                              $"Área: {area:F2}";
            }
            catch (FormatException)
            {
                label6.Text = "Ingrese valores numéricos válidos.";
            }
        }
    }
}
