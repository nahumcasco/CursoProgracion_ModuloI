namespace Vista
{
	partial class Form2
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
			SincronoButton=new Button();
			AzincronoButton=new Button();
			SumarButton=new Button();
			SuspendLayout();
			// 
			// SincronoButton
			// 
			SincronoButton.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			SincronoButton.Location=new Point(109, 26);
			SincronoButton.Name="SincronoButton";
			SincronoButton.Size=new Size(152, 72);
			SincronoButton.TabIndex=0;
			SincronoButton.Text="Hornear Pollo";
			SincronoButton.UseVisualStyleBackColor=true;
			SincronoButton.Click+=SincronoButton_Click;
			// 
			// AzincronoButton
			// 
			AzincronoButton.Font=new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
			AzincronoButton.Location=new Point(370, 30);
			AzincronoButton.Name="AzincronoButton";
			AzincronoButton.Size=new Size(171, 68);
			AzincronoButton.TabIndex=1;
			AzincronoButton.Text="Hornear Pollo";
			AzincronoButton.UseVisualStyleBackColor=true;
			AzincronoButton.Click+=AzincronoButton_Click;
			// 
			// SumarButton
			// 
			SumarButton.Location=new Point(242, 177);
			SumarButton.Name="SumarButton";
			SumarButton.Size=new Size(142, 65);
			SumarButton.TabIndex=2;
			SumarButton.Text="Sumar";
			SumarButton.UseVisualStyleBackColor=true;
			SumarButton.Click+=SumarButton_Click;
			// 
			// Form2
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(749, 415);
			Controls.Add(SumarButton);
			Controls.Add(AzincronoButton);
			Controls.Add(SincronoButton);
			Name="Form2";
			Text="Form2";
			ResumeLayout(false);
		}

		#endregion

		private Button SincronoButton;
		private Button AzincronoButton;
		private Button SumarButton;
	}
}