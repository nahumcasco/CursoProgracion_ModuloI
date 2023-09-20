namespace Entidades
{
	public abstract class Perro
	{
		public string Nombre { get; set; } = string.Empty;

		public virtual string Ladrar()
		{
			return "El perro esta ladrando";
		}

		public abstract string Correr();

	}

	public class Aguacatero : Perro
	{
		public override string Correr()
		{
			return "El Aguacatero esta corriendo";
		}

		public override string Ladrar()
		{
			return "El Aguacatero esta Ladrando";
		}
	}

	public class Bulldog : Perro
	{
		public override string Correr()
		{
			return "El bulldog esta corriendo";
		}

		public override string Ladrar()
		{
			return "El Bulldog esta Ladrando";
		}
	}



}
