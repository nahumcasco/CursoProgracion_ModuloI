namespace Entidades
{
	public class Persona
	{
		//Atributos
		private string nombre;
		//private decimal estatura;
		//private int edad;
		//private string genero;
		//private DateTime fechaNacimiento;



		//Propiedades
		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public decimal Estatura { get; set; }
		public int Edad { get; set; }
		public string Genero { get; set; }
		public DateTime FechaNacimiento { get; set; }

		//Constructores
		public Persona() { }

		public Persona(string nombre, DateTime fechaNacimiento)
		{
			Nombre = nombre;
			FechaNacimiento = fechaNacimiento;
		}

		public Persona(string nombre, decimal estatura, int edad, string genero, DateTime fechaNacimiento)
		{
			Nombre=nombre;
			Estatura=estatura;
			Edad=edad;
			Genero=genero;
			FechaNacimiento=fechaNacimiento;
		}

		//Métodos (Funciones, Acciones)

		public string DevolverDatosDeLaPersona()
		{
			return "Nombre: " + Nombre + ", Edad: " + Edad + ", Género: " + Genero;
		}


	}
}
