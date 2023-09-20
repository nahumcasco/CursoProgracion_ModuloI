namespace Entidades
{
	public interface IPerro
	{
		public string Ladrar();
		public string Correr();
	}

	public class Chihuahua : IPerro
	{
		public string Correr()
		{
			return "Chihuahua esta corriendo";
		}

		public string Ladrar()
		{
			return "Chihuahua esta Ladrando";
		}
	}





}
