using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcialElectiva
{
    internal class Alcancia
    {
        Dictionary<int, int> monedas = new Dictionary<int, int>();
        List<int> monedasValidas = new List<int>() { 50, 100, 200, 500, 1000 };
        public Alcancia()
        {
            monedas.Add(50, 0);
            monedas.Add(100, 0);
            monedas.Add(200, 0);
            monedas.Add(500, 0);
            monedas.Add(1000, 0);
        }
        public int solicitarMonedaValida()
        {
            Console.WriteLine("\nIngrese un valor de moneda: ");
            int moneda = Convert.ToInt32(Console.ReadLine());
            int coincidencias = monedasValidas.Where(x => x == moneda).Count();
            if (coincidencias <= 0) return 0;
            return moneda;
        }
        public bool InsertarDinero()
        {
            int monedaElegida = solicitarMonedaValida();

            if (monedaElegida == 0)
            {
                Console.WriteLine("El valor de moneda ingresado no es valido");
                return false;
            }

            Console.WriteLine("\nIngrese la cantidad de monedas.");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            monedas[monedaElegida] += cantidad;
            Console.WriteLine("\nDinero ingresado con éxito.");
            return true;
        }

        public void ImprimirCantidadPorMoneda()
        {
            int monedaElegida = solicitarMonedaValida();

            Console.WriteLine("\nDinero ingresado con éxito.");
            Console.WriteLine("Hay " + this.monedas[monedaElegida] + " monedas de " + monedaElegida);
        }

        public void ImprimirTotalPorMoneda()
        {
            int monedaElegida = solicitarMonedaValida();

            if (monedaElegida == 0)
            {
                Console.WriteLine("Moneda no valida");
                return;
            }

            Console.WriteLine("Esta moneda suma un total de $" + monedaElegida * monedas[monedaElegida]);
        }

        public void VerCantidadTotalDeMonedas()
        {
            int contador = 0;
            foreach (int moneda in monedasValidas)
            {
                contador += monedas[moneda];
            }

            Console.WriteLine("\nLa cantiad total es de " + contador + " monedas.");
        }

        public void VerTotalDeDinero()
        {
            int dineroTotal = 0;
            foreach (int moneda in monedasValidas)
            {
                dineroTotal += moneda * monedas[moneda];
            }

            Console.WriteLine("\nLa cantidad total de dinero es de $" + dineroTotal);
        }
    }
}
