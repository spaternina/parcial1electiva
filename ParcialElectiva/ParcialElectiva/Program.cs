using System;
namespace ParcialElectiva
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Alcancia alcancia = new Alcancia();
			int respuesta;
			do
			{
				Console.WriteLine("\n -- Menú --" +
					"\n1) Ingresar dinero" +
					"\n2) Ver cantidad por denominación" +
					"\n3) Ver dinero total por denominación" +
					"\n4) Ver cantidad de monedas en total" +
					"\n5) Ver total de dinero" +
					"\n -- Ingrese opcion diferente a las anteriores para salir --");
				respuesta = Convert.ToInt32(Console.ReadLine());

				switch (respuesta)
                {
					case 1:
						bool dineroIngresado = alcancia.InsertarDinero();
						break;
					case 2:
						alcancia.ImprimirMoneda();
						break;
					case 3:
						alcancia.ImprimirTotalPorMoneda();
						break;
					case 4:
						alcancia.ImprimirTotalPorMoneda();
						break;
				}
			} while (respuesta >= 1 && respuesta <= 4);
		}
	}
}
