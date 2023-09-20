using Entidades;

namespace Vista
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Aguacatero aguacatero = new Aguacatero();
			Bulldog bulldog = new Bulldog();

			Perro[] perrera = { aguacatero, bulldog };

			foreach (Perro i in perrera)
			{
				MessageBox.Show(i.Correr());
			}

		}
	}
}
