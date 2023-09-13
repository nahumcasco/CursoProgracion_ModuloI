namespace Vista
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components=new System.ComponentModel.Container();
			NombreLabel=new Label();
			label2=new Label();
			label3=new Label();
			label4=new Label();
			label5=new Label();
			NombreTextBox=new TextBox();
			EstaturaTextBox=new TextBox();
			EdadTextBox=new TextBox();
			GeneroTextBox=new TextBox();
			FechaNacimientoDateTimePicker=new DateTimePicker();
			CrearButton=new Button();
			MostrarButton=new Button();
			PersonasDataGridView=new DataGridView();
			PersonasBindingSource=new BindingSource(components);
			nombreDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
			estaturaDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
			edadDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
			generoDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
			fechaNacimientoDataGridViewTextBoxColumn=new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)PersonasDataGridView).BeginInit();
			((System.ComponentModel.ISupportInitialize)PersonasBindingSource).BeginInit();
			SuspendLayout();
			// 
			// NombreLabel
			// 
			NombreLabel.AutoSize=true;
			NombreLabel.Location=new Point(132, 29);
			NombreLabel.Name="NombreLabel";
			NombreLabel.Size=new Size(54, 15);
			NombreLabel.TabIndex=0;
			NombreLabel.Text="Nombre:";
			// 
			// label2
			// 
			label2.AutoSize=true;
			label2.Location=new Point(134, 67);
			label2.Name="label2";
			label2.Size=new Size(52, 15);
			label2.TabIndex=1;
			label2.Text="Estatura:";
			// 
			// label3
			// 
			label3.AutoSize=true;
			label3.Location=new Point(150, 105);
			label3.Name="label3";
			label3.Size=new Size(36, 15);
			label3.TabIndex=2;
			label3.Text="Edad:";
			// 
			// label4
			// 
			label4.AutoSize=true;
			label4.Location=new Point(138, 145);
			label4.Name="label4";
			label4.Size=new Size(48, 15);
			label4.TabIndex=3;
			label4.Text="Género:";
			// 
			// label5
			// 
			label5.AutoSize=true;
			label5.Location=new Point(80, 177);
			label5.Name="label5";
			label5.Size=new Size(106, 15);
			label5.TabIndex=4;
			label5.Text="Fecha Nacimiento:";
			// 
			// NombreTextBox
			// 
			NombreTextBox.Location=new Point(213, 21);
			NombreTextBox.Name="NombreTextBox";
			NombreTextBox.Size=new Size(270, 23);
			NombreTextBox.TabIndex=5;
			// 
			// EstaturaTextBox
			// 
			EstaturaTextBox.Location=new Point(213, 59);
			EstaturaTextBox.Name="EstaturaTextBox";
			EstaturaTextBox.Size=new Size(270, 23);
			EstaturaTextBox.TabIndex=6;
			// 
			// EdadTextBox
			// 
			EdadTextBox.Location=new Point(213, 97);
			EdadTextBox.Name="EdadTextBox";
			EdadTextBox.ReadOnly=true;
			EdadTextBox.Size=new Size(270, 23);
			EdadTextBox.TabIndex=7;
			// 
			// GeneroTextBox
			// 
			GeneroTextBox.Location=new Point(213, 137);
			GeneroTextBox.Name="GeneroTextBox";
			GeneroTextBox.Size=new Size(270, 23);
			GeneroTextBox.TabIndex=8;
			// 
			// FechaNacimientoDateTimePicker
			// 
			FechaNacimientoDateTimePicker.Format=DateTimePickerFormat.Short;
			FechaNacimientoDateTimePicker.Location=new Point(213, 177);
			FechaNacimientoDateTimePicker.Name="FechaNacimientoDateTimePicker";
			FechaNacimientoDateTimePicker.Size=new Size(270, 23);
			FechaNacimientoDateTimePicker.TabIndex=9;
			// 
			// CrearButton
			// 
			CrearButton.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			CrearButton.Location=new Point(213, 210);
			CrearButton.Name="CrearButton";
			CrearButton.Size=new Size(125, 42);
			CrearButton.TabIndex=10;
			CrearButton.Text="Agregar";
			CrearButton.UseVisualStyleBackColor=true;
			CrearButton.Click+=CrearButton_Click;
			// 
			// MostrarButton
			// 
			MostrarButton.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
			MostrarButton.Location=new Point(374, 206);
			MostrarButton.Name="MostrarButton";
			MostrarButton.Size=new Size(109, 46);
			MostrarButton.TabIndex=11;
			MostrarButton.Text="Mostrar";
			MostrarButton.UseVisualStyleBackColor=true;
			MostrarButton.Click+=MostrarButton_Click;
			// 
			// PersonasDataGridView
			// 
			PersonasDataGridView.AllowUserToAddRows=false;
			PersonasDataGridView.AllowUserToDeleteRows=false;
			PersonasDataGridView.AutoGenerateColumns=false;
			PersonasDataGridView.ColumnHeadersHeightSizeMode=DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			PersonasDataGridView.Columns.AddRange(new DataGridViewColumn[] { nombreDataGridViewTextBoxColumn, estaturaDataGridViewTextBoxColumn, edadDataGridViewTextBoxColumn, generoDataGridViewTextBoxColumn, fechaNacimientoDataGridViewTextBoxColumn });
			PersonasDataGridView.DataSource=PersonasBindingSource;
			PersonasDataGridView.Location=new Point(1, 279);
			PersonasDataGridView.Name="PersonasDataGridView";
			PersonasDataGridView.ReadOnly=true;
			PersonasDataGridView.RowTemplate.Height=25;
			PersonasDataGridView.Size=new Size(793, 240);
			PersonasDataGridView.TabIndex=12;
			// 
			// PersonasBindingSource
			// 
			PersonasBindingSource.DataSource=typeof(Entidades.Persona);
			// 
			// nombreDataGridViewTextBoxColumn
			// 
			nombreDataGridViewTextBoxColumn.DataPropertyName="Nombre";
			nombreDataGridViewTextBoxColumn.HeaderText="Nombre";
			nombreDataGridViewTextBoxColumn.Name="nombreDataGridViewTextBoxColumn";
			nombreDataGridViewTextBoxColumn.ReadOnly=true;
			// 
			// estaturaDataGridViewTextBoxColumn
			// 
			estaturaDataGridViewTextBoxColumn.DataPropertyName="Estatura";
			estaturaDataGridViewTextBoxColumn.HeaderText="Estatura";
			estaturaDataGridViewTextBoxColumn.Name="estaturaDataGridViewTextBoxColumn";
			estaturaDataGridViewTextBoxColumn.ReadOnly=true;
			// 
			// edadDataGridViewTextBoxColumn
			// 
			edadDataGridViewTextBoxColumn.DataPropertyName="Edad";
			edadDataGridViewTextBoxColumn.HeaderText="Edad";
			edadDataGridViewTextBoxColumn.Name="edadDataGridViewTextBoxColumn";
			edadDataGridViewTextBoxColumn.ReadOnly=true;
			// 
			// generoDataGridViewTextBoxColumn
			// 
			generoDataGridViewTextBoxColumn.DataPropertyName="Genero";
			generoDataGridViewTextBoxColumn.HeaderText="Genero";
			generoDataGridViewTextBoxColumn.Name="generoDataGridViewTextBoxColumn";
			generoDataGridViewTextBoxColumn.ReadOnly=true;
			// 
			// fechaNacimientoDataGridViewTextBoxColumn
			// 
			fechaNacimientoDataGridViewTextBoxColumn.DataPropertyName="FechaNacimiento";
			fechaNacimientoDataGridViewTextBoxColumn.HeaderText="Fecha Nacimiento";
			fechaNacimientoDataGridViewTextBoxColumn.Name="fechaNacimientoDataGridViewTextBoxColumn";
			fechaNacimientoDataGridViewTextBoxColumn.ReadOnly=true;
			fechaNacimientoDataGridViewTextBoxColumn.Width=200;
			// 
			// Form1
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(793, 519);
			Controls.Add(PersonasDataGridView);
			Controls.Add(MostrarButton);
			Controls.Add(CrearButton);
			Controls.Add(FechaNacimientoDateTimePicker);
			Controls.Add(GeneroTextBox);
			Controls.Add(EdadTextBox);
			Controls.Add(EstaturaTextBox);
			Controls.Add(NombreTextBox);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(NombreLabel);
			Name="Form1";
			Text="Form1";
			((System.ComponentModel.ISupportInitialize)PersonasDataGridView).EndInit();
			((System.ComponentModel.ISupportInitialize)PersonasBindingSource).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label NombreLabel;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private TextBox NombreTextBox;
		private TextBox EstaturaTextBox;
		private TextBox EdadTextBox;
		private TextBox GeneroTextBox;
		private DateTimePicker FechaNacimientoDateTimePicker;
		private Button CrearButton;
		private Button MostrarButton;
		private DataGridView PersonasDataGridView;
		private BindingSource PersonasBindingSource;
		private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn estaturaDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn edadDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn generoDataGridViewTextBoxColumn;
		private DataGridViewTextBoxColumn fechaNacimientoDataGridViewTextBoxColumn;
	}
}