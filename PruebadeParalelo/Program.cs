using PruebadeParalelo;
using System;
namespace ensamblado
{
    internal class program
    {
        public static void Main(string[] args)
        {
            
            Automovil auto1 = new Automovil("BMW", "M001567", "330i", "Plateado", 70, 30);
            Automovil auto2 = new Automovil(" Chevrolet", "M72933", " Camaro", "Blanco", 30, 20);
            Automovil auto3 = new Automovil("Audi", "Gr00068", "A4", "Negro", 50, 35);

            
            Console.WriteLine("\nSimulación de conduccion de vehículos:");

            
            auto1.nivelCombustible = 70;
            auto1.Conducir(5);
            MostrarEstadoAuto(auto1);

            
            if (auto2.PuedeConducir(14))
            {
                auto2.Conducir(0);
                MostrarEstadoAuto(auto2);
            }
            else
            {
                Console.WriteLine($"Error: {auto2.marca} {auto2.modelo} no tiene suficiente combustible para recorrer 14 km. Nivel actual: {auto2.nivelCombustible:F2} galones.");
            }

           
            if (auto3.PuedeConducir(12))
            {
                auto3.Conducir(20);
                MostrarEstadoAuto(auto3);
            }
            else
            {
              
                double cantidadReabastecida = 30; 
                auto3.ReabastecerCombustible(cantidadReabastecida);

                
                if (auto3.PuedeConducir(12))
                {
                    auto3.Conducir(20);
                    MostrarEstadoAuto(auto3);
                }
                else
                {
                    Console.WriteLine($"Error: {auto3.marca} {auto3.modelo} sigue sin tener suficiente combustible para recorrer 12 km después de reabastecer.");
                }
            }
        }

        public static void MostrarEstadoAuto(Automovil auto)
        {
            Console.WriteLine($"\n{auto.marca} {auto.modelo}:");
            Console.WriteLine($"Nivel de combustible: {auto.nivelCombustible:F2} galones");
        }

      
    }

} 
