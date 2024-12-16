using System;
using System.Collections.Generic;

namespace Banquer
{
    class Program
    {
        static void Main(string[] args)
        {
            var banquer = new Banker();

            Console.WriteLine("Introduce el nombre del cliente:");
            var nombre = Console.ReadLine();
            banquer.CreaClient(nombre);

            Console.WriteLine("¿Quieres sacar dinero? (sí/no)");
            var respuestaSacar = Console.ReadLine().ToLower();

            if (respuestaSacar == "sí")
            {
                Console.WriteLine("¿Cuánto diner quieres sacar?");
                var cantidadSacar = Convert.ToInt32(Console.ReadLine());

                var resultadoSacar = banquer.TreureDiners(nombre, cantidadSacar);
                Console.WriteLine(resultadoSacar);
            }

            Console.WriteLine("¿Quieres agregar dinero? (sí/no)");
            var respuestaAgregar = Console.ReadLine().ToLower();

            if (respuestaAgregar == "sí")
            {
                Console.WriteLine("¿Cuánto dinero quieres agregar?");
                var cantidadAgregar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(banquer.PosarDiners(nombre, cantidadAgregar));
            }

            Console.WriteLine($"Operaciones finalizadas para el cliente {nombre}.");
        }
    }
}


