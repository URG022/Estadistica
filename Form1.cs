using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estadistica
{
	public partial class Form1 : Form
	{

		//Variables
		double p, probabilidad;
		int n, k;


		public Form1()
		{
			InitializeComponent();
			Bitmap img = new Bitmap(Application.StartupPath + @"\img\Probabilidad.png");
			this.BackgroundImage = img;
			this.BackgroundImageLayout = ImageLayout.Stretch;
		}


		// Función para calcular el coeficiente binomial (n choose k)
		static int CoeficienteBinomial(int n, int k)
		{
			if (k == 0 || k == n)
				return 1;
			return CoeficienteBinomial(n - 1, k - 1) + CoeficienteBinomial(n - 1, k);
		}

		// Función para calcular la probabilidad binomial
		static double ProbabilidadBinomial(int n, int k, double p)
		{
			return CoeficienteBinomial(n, k) * Math.Pow(p, k) * Math.Pow(1 - p, n - k);
		}

        private void txtP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
		{
			n = Convert.ToInt32(txtN.Text);
			k = Convert.ToInt32(txtK.Text);
			p = Convert.ToDouble(txtP.Text);


			// Calcular la probabilidad utilizando la distribución binomial
			probabilidad = ProbabilidadBinomial(n, k, p);

			string porcentaje = $"{probabilidad:P}";
			MessageBox.Show($"La probabilidad es de: {porcentaje}", "Probabilidad Binomial", MessageBoxButtons.OK, MessageBoxIcon.Information);
			txtK.Clear();
			txtN.Clear();
			txtP.Clear();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}
