using Entidades;

namespace Vista
{
	public partial class CuentasForm : Form
	{
		public CuentasForm()
		{
			InitializeComponent();
		}

		List<TipoMovimiento> tipoMovimientoLista = new List<TipoMovimiento>();
		Cliente cliente;
		Cuenta cuenta;
		Movimiento movimiento;
		List<Movimiento> listaMovimientos = new List<Movimiento>();

		private void CuentasForm_Load(object sender, EventArgs e)
		{
			tipoMovimientoLista.Add(new TipoMovimiento("Depósito"));
			tipoMovimientoLista.Add(new TipoMovimiento("Retiro"));

			TipoMovimientoComboBox.DataSource = tipoMovimientoLista;
			TipoMovimientoComboBox.DisplayMember = "Nombre";
		}

		private void AperturarButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(IdentidadTextBox.Text))
			{
				errorProvider1.SetError(IdentidadTextBox, "Ingrese una identidad");
				IdentidadTextBox.Focus();
				return;
			}
			errorProvider1.Clear();

			if (string.IsNullOrWhiteSpace(NombreTextBox.Text))
			{
				errorProvider1.SetError(NombreTextBox, "Ingrese un nombre");
				NombreTextBox.Focus();
				return;
			}
			errorProvider1.Clear();

			if (string.IsNullOrWhiteSpace(GeneroComboBox.Text))
			{
				errorProvider1.SetError(GeneroComboBox, "Seleccione el genero");
				return;
			}
			errorProvider1.Clear();

			if (string.IsNullOrWhiteSpace(CodigoTextBox.Text))
			{
				errorProvider1.SetError(CodigoTextBox, "Ingrese un código");
				CodigoTextBox.Focus();
				return;
			}
			errorProvider1.Clear();

			cliente = new Cliente();
			cliente.Identidad = IdentidadTextBox.Text;
			cliente.Nombre = NombreTextBox.Text;
			cliente.FechaNacimiento = FechaNaciminetoDateTimePicker.Value;
			cliente.Genero = GeneroComboBox.Text;

			cuenta = new Cuenta(CodigoTextBox.Text, DateTime.Now, 0.00M, cliente, "Activa");
			SaldoTextBox.Text = cuenta.Saldo.ToString();

		}

		private void AgregarMovimientoButton_Click(object sender, EventArgs e)
		{
			if (MontoTextBox.Text == string.Empty)
			{
				errorProvider1.SetError(MontoTextBox, "Ingrese un monto");
				MontoTextBox.Focus();
				return;
			}

			if (TipoMovimientoComboBox.Text == string.Empty)
			{
				errorProvider1.SetError(TipoMovimientoComboBox, "Seleccione el tipo de movimiento");
				return;
			}

			if (cliente == null && cuenta == null)
			{
				errorProvider1.SetError(NombreTextBox, "No se ha aperturado la cuenta");
				return;
			}

			decimal monto = Convert.ToDecimal(MontoTextBox.Text);

			if (TipoMovimientoComboBox.Text == "Depósito")
			{
				cuenta.Depositar(monto);
				movimiento = new Movimiento(cuenta, DateTime.Now, monto, new TipoMovimiento(TipoMovimientoComboBox.SelectedText));

				//listaMovimientos.Add(movimiento);

				MovimientosListBox.Items.Add("Depósito a la cuenta N. " + cuenta.Codigo +
											" por la cantidad de L. " + movimiento.Monto +
											" con fecha: " + movimiento.Fecha.ToShortDateString());

				SaldoTextBox.Text = cuenta.Saldo.ToString();
			}
			else if (TipoMovimientoComboBox.Text == "Retiro")
			{
				bool retiro = cuenta.Retirar(monto);

				if (retiro)
				{
					movimiento = new Movimiento(cuenta, DateTime.Now, monto, new TipoMovimiento(TipoMovimientoComboBox.SelectedText));

					MovimientosListBox.Items.Add("Retiro a la cuenta N. " + cuenta.Codigo +
											" por la cantidad de L. " + movimiento.Monto +
											" con fecha: " + movimiento.Fecha.ToShortDateString());

					SaldoTextBox.Text = cuenta.Saldo.ToString();
				}
				else
				{
					MessageBox.Show($"La cuenta N. {cuenta.Codigo} no tiene suficiente saldo para realizar el retiro");
				}

			}

		}
	}
}
