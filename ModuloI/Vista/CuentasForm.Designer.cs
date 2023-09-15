namespace Vista
{
	partial class CuentasForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components=new System.ComponentModel.Container();
			groupBox1=new GroupBox();
			label4=new Label();
			FechaNaciminetoDateTimePicker=new DateTimePicker();
			label3=new Label();
			GeneroComboBox=new ComboBox();
			NombreTextBox=new TextBox();
			label2=new Label();
			IdentidadTextBox=new TextBox();
			label1=new Label();
			groupBox2=new GroupBox();
			SaldoTextBox=new TextBox();
			label6=new Label();
			CodigoTextBox=new TextBox();
			label5=new Label();
			groupBox3=new GroupBox();
			TipoMovimientoComboBox=new ComboBox();
			label8=new Label();
			MontoTextBox=new TextBox();
			label7=new Label();
			AperturarButton=new Button();
			AgregarMovimientoButton=new Button();
			MovimientosListBox=new ListBox();
			errorProvider1=new ErrorProvider(components);
			groupBox1.SuspendLayout();
			groupBox2.SuspendLayout();
			groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(FechaNaciminetoDateTimePicker);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(GeneroComboBox);
			groupBox1.Controls.Add(NombreTextBox);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(IdentidadTextBox);
			groupBox1.Controls.Add(label1);
			groupBox1.Location=new Point(12, 12);
			groupBox1.Name="groupBox1";
			groupBox1.Size=new Size(606, 111);
			groupBox1.TabIndex=0;
			groupBox1.TabStop=false;
			groupBox1.Text="Datos del Cliente";
			// 
			// label4
			// 
			label4.AutoSize=true;
			label4.Location=new Point(346, 79);
			label4.Name="label4";
			label4.Size=new Size(87, 21);
			label4.TabIndex=7;
			label4.Text="Fecha Nac.:";
			// 
			// FechaNaciminetoDateTimePicker
			// 
			FechaNaciminetoDateTimePicker.Format=DateTimePickerFormat.Short;
			FechaNaciminetoDateTimePicker.Location=new Point(439, 74);
			FechaNaciminetoDateTimePicker.Name="FechaNaciminetoDateTimePicker";
			FechaNaciminetoDateTimePicker.Size=new Size(158, 29);
			FechaNaciminetoDateTimePicker.TabIndex=6;
			// 
			// label3
			// 
			label3.AutoSize=true;
			label3.Location=new Point(369, 39);
			label3.Name="label3";
			label3.Size=new Size(64, 21);
			label3.TabIndex=5;
			label3.Text="Género:";
			// 
			// GeneroComboBox
			// 
			GeneroComboBox.FormattingEnabled=true;
			GeneroComboBox.Items.AddRange(new object[] { "M", "F" });
			GeneroComboBox.Location=new Point(439, 36);
			GeneroComboBox.Name="GeneroComboBox";
			GeneroComboBox.Size=new Size(158, 29);
			GeneroComboBox.TabIndex=4;
			// 
			// NombreTextBox
			// 
			NombreTextBox.Location=new Point(103, 71);
			NombreTextBox.Name="NombreTextBox";
			NombreTextBox.Size=new Size(219, 29);
			NombreTextBox.TabIndex=3;
			// 
			// label2
			// 
			label2.AutoSize=true;
			label2.Location=new Point(26, 74);
			label2.Name="label2";
			label2.Size=new Size(71, 21);
			label2.TabIndex=2;
			label2.Text="Nombre:";
			// 
			// IdentidadTextBox
			// 
			IdentidadTextBox.Location=new Point(103, 36);
			IdentidadTextBox.Name="IdentidadTextBox";
			IdentidadTextBox.Size=new Size(219, 29);
			IdentidadTextBox.TabIndex=1;
			// 
			// label1
			// 
			label1.AutoSize=true;
			label1.Location=new Point(19, 39);
			label1.Name="label1";
			label1.Size=new Size(78, 21);
			label1.TabIndex=0;
			label1.Text="Identidad:";
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(SaldoTextBox);
			groupBox2.Controls.Add(label6);
			groupBox2.Controls.Add(CodigoTextBox);
			groupBox2.Controls.Add(label5);
			groupBox2.Location=new Point(634, 23);
			groupBox2.Name="groupBox2";
			groupBox2.Size=new Size(347, 100);
			groupBox2.TabIndex=1;
			groupBox2.TabStop=false;
			groupBox2.Text="Datos de la cuenta";
			// 
			// SaldoTextBox
			// 
			SaldoTextBox.Location=new Point(108, 60);
			SaldoTextBox.Name="SaldoTextBox";
			SaldoTextBox.ReadOnly=true;
			SaldoTextBox.Size=new Size(206, 29);
			SaldoTextBox.TabIndex=3;
			// 
			// label6
			// 
			label6.AutoSize=true;
			label6.Location=new Point(41, 65);
			label6.Name="label6";
			label6.Size=new Size(52, 21);
			label6.TabIndex=2;
			label6.Text="Saldo:";
			// 
			// CodigoTextBox
			// 
			CodigoTextBox.Location=new Point(108, 28);
			CodigoTextBox.Name="CodigoTextBox";
			CodigoTextBox.Size=new Size(206, 29);
			CodigoTextBox.TabIndex=1;
			// 
			// label5
			// 
			label5.AutoSize=true;
			label5.Location=new Point(30, 33);
			label5.Name="label5";
			label5.Size=new Size(63, 21);
			label5.TabIndex=0;
			label5.Text="Código:";
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(TipoMovimientoComboBox);
			groupBox3.Controls.Add(label8);
			groupBox3.Controls.Add(MontoTextBox);
			groupBox3.Controls.Add(label7);
			groupBox3.Location=new Point(12, 155);
			groupBox3.Name="groupBox3";
			groupBox3.Size=new Size(969, 107);
			groupBox3.TabIndex=2;
			groupBox3.TabStop=false;
			groupBox3.Text="Movimiento";
			// 
			// TipoMovimientoComboBox
			// 
			TipoMovimientoComboBox.FormattingEnabled=true;
			TipoMovimientoComboBox.Location=new Point(526, 57);
			TipoMovimientoComboBox.Name="TipoMovimientoComboBox";
			TipoMovimientoComboBox.Size=new Size(437, 29);
			TipoMovimientoComboBox.TabIndex=3;
			// 
			// label8
			// 
			label8.AutoSize=true;
			label8.Location=new Point(369, 60);
			label8.Name="label8";
			label8.Size=new Size(131, 21);
			label8.TabIndex=2;
			label8.Text="Tipo Movimiento:";
			// 
			// MontoTextBox
			// 
			MontoTextBox.Location=new Point(103, 52);
			MontoTextBox.Name="MontoTextBox";
			MontoTextBox.Size=new Size(219, 29);
			MontoTextBox.TabIndex=1;
			// 
			// label7
			// 
			label7.AutoSize=true;
			label7.Location=new Point(38, 52);
			label7.Name="label7";
			label7.Size=new Size(59, 21);
			label7.TabIndex=0;
			label7.Text="Monto:";
			// 
			// AperturarButton
			// 
			AperturarButton.Location=new Point(675, 268);
			AperturarButton.Name="AperturarButton";
			AperturarButton.Size=new Size(106, 39);
			AperturarButton.TabIndex=3;
			AperturarButton.Text="Aperturar";
			AperturarButton.UseVisualStyleBackColor=true;
			AperturarButton.Click+=AperturarButton_Click;
			// 
			// AgregarMovimientoButton
			// 
			AgregarMovimientoButton.Location=new Point(805, 268);
			AgregarMovimientoButton.Name="AgregarMovimientoButton";
			AgregarMovimientoButton.Size=new Size(176, 39);
			AgregarMovimientoButton.TabIndex=4;
			AgregarMovimientoButton.Text="Agregar Movimiento";
			AgregarMovimientoButton.UseVisualStyleBackColor=true;
			AgregarMovimientoButton.Click+=AgregarMovimientoButton_Click;
			// 
			// MovimientosListBox
			// 
			MovimientosListBox.FormattingEnabled=true;
			MovimientosListBox.ItemHeight=21;
			MovimientosListBox.Location=new Point(12, 313);
			MovimientosListBox.Name="MovimientosListBox";
			MovimientosListBox.Size=new Size(969, 214);
			MovimientosListBox.TabIndex=5;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl=this;
			// 
			// CuentasForm
			// 
			AutoScaleDimensions=new SizeF(9F, 21F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(993, 546);
			Controls.Add(MovimientosListBox);
			Controls.Add(AgregarMovimientoButton);
			Controls.Add(AperturarButton);
			Controls.Add(groupBox3);
			Controls.Add(groupBox2);
			Controls.Add(groupBox1);
			Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			Margin=new Padding(3, 4, 3, 4);
			Name="CuentasForm";
			Text="CuentasForm";
			Load+=CuentasForm_Load;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox IdentidadTextBox;
		private Label label1;
		private TextBox NombreTextBox;
		private Label label2;
		private Label label3;
		private ComboBox GeneroComboBox;
		private Label label4;
		private DateTimePicker FechaNaciminetoDateTimePicker;
		private GroupBox groupBox2;
		private TextBox CodigoTextBox;
		private Label label5;
		private TextBox SaldoTextBox;
		private Label label6;
		private GroupBox groupBox3;
		private TextBox MontoTextBox;
		private Label label7;
		private ComboBox TipoMovimientoComboBox;
		private Label label8;
		private Button AperturarButton;
		private Button AgregarMovimientoButton;
		private ListBox MovimientosListBox;
		private ErrorProvider errorProvider1;
	}
}