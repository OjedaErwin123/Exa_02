// See https://aka.ms/new-console-template for more information
using System;
using Calculadora;

class myproyect
{
    static void Main(string[] args)
    {
        var calculadora = new Calculadora();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione la fórmula que desea calcular:");
            Console.WriteLine("1. Calcular Fuerza ");
            Console.WriteLine("2. Calcular Trabajo ");
            Console.WriteLine("3. Calcular Energía Cinética ");
            Console.WriteLine("4. Salir");


            switch (opcion)
            {
                case "1":
                    Console.Write("Ingrese la masa (m): ");
                    double masa = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la aceleración (a): ");
                    double aceleracion = Convert.ToDouble(Console.ReadLine());
                    double fuerza = Calculator.Fuerza(masa, aceleracion);
                    Console.WriteLine($"Fuerza (F) = {fuerza}");
                    break;

                case "2":
                    Console.Write("Ingrese la fuerza (F): ");
                    double fuerzaTrabajo = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la distancia (d): ");
                    double distancia = Convert.ToDouble(Console.ReadLine());
                    double trabajo = Calculator.Trabajo(fuerzaTrabajo, distancia);
                    Console.WriteLine($"Trabajo (W) = {trabajo}");
                    break;

                case "3":
                    Console.Write("Ingrese la masa (m): ");
                    double masaEnergia = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la velocidad (v): ");
                    double velocidad = Convert.ToDouble(Console.ReadLine());
                    double energiaCinetica = Calculator.Energy_Cine(masaEnergia, velocidad);
                    Console.WriteLine($"Energía Cinética (E) = {energiaCinetica}");
                    break;

                case "4":
                    continuar = false;
                    Console.WriteLine("Saliendo del programa.");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, seleccione una opción del 1 al 4.");
                    break;
            }

            if (continuar)
            {
                Console.WriteLine("¿Desea realizar otro cálculo? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                continuar = respuesta == "s";
            }
        }
    }
}

