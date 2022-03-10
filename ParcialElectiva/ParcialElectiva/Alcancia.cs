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
        public Alcancia()
        {
            monedas.Add(50, 0);
            monedas.Add(100, 0);
            monedas.Add(200, 0);
            monedas.Add(500, 0);
            monedas.Add(1000, 0);
        }
        

        public bool InsertarDinero()
        {
            int opcion;
            Console.WriteLine("\nIngrese la moneda a insertar" +
                "\n1) 50" +
                "\n2) 100" +
                "\n3) 200" +
                "\n4) 500" +
                "\n5) 1000");
            opcion = Convert.ToInt32(Console.ReadLine());

            int monedaElegida;
            switch(opcion)
            {
                case 1:
                    monedaElegida = 50;
                    break;
                case 2:
                    monedaElegida = 100;
                    break;
                case 3:
                    monedaElegida = 200;
                    break;
                case 4:
                    monedaElegida = 500;
                    break;
                case 5:
                    monedaElegida = 1000;
                    break;
                default:
                    monedaElegida = 0;
                    break;
            }

            if (monedaElegida == 0)
            {
                return false;
            }

            Console.WriteLine("\nIngrese la cantidad de monedas.");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            monedas[monedaElegida] += cantidad;
            Console.WriteLine("\nDinero ingresado con éxito.");
            return true;
        }

        public void ImprimirMoneda()
        {
            int opcion;
            Console.WriteLine("\nIngrese la moneda a consultar" +
                "\n1) 50" +
                "\n2) 100" +
                "\n3) 200" +
                "\n4) 500" +
                "\n5) 1000");
            opcion = Convert.ToInt32(Console.ReadLine());

            int monedaElegida;
            switch (opcion)
            {
                case 1:
                    monedaElegida = 50;
                    break;
                case 2:
                    monedaElegida = 100;
                    break;
                case 3:
                    monedaElegida = 200;
                    break;
                case 4:
                    monedaElegida = 500;
                    break;
                case 5:
                    monedaElegida = 1000;
                    break;
                default:
                    monedaElegida = 0;
                    break;
            }

            Console.WriteLine("\nDinero ingresado con éxito.");
            Console.WriteLine("Hay " + this.monedas[monedaElegida] + " monedas de este tipo");
        }

        public void ImprimirTotalPorMoneda()
        {

        }
    }
}
