using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebadeParalelo
{
    public partial class Automovil
    {
        public string marca;
        public string placa;
        public string modelo;
        public string color;
        public double capacidaddeltanque;
        public double nivelCombustible =0;
        public double rendimientoCombustible;

        
        public Automovil(string marca, string placa, string modelo, string color, double capacidaddeltanque, double rendimientoCombustible)
        {
            this.marca = marca;
            this.placa = placa;
            this.modelo = modelo;
            this.color = color;
            this.capacidaddeltanque = capacidaddeltanque;
            this.nivelCombustible = 0;
            this.rendimientoCombustible = rendimientoCombustible;
        }

        
        public void Conducir(int distancia)
        {
            
            double consumoCombustible = distancia / rendimientoCombustible;

            
            if (nivelCombustible - consumoCombustible < 0)
            {
                Console.WriteLine($"Error: {marca} {modelo} no tiene suficiente combustible para recorrer {distancia} km. Nivel actual: {nivelCombustible:F2} galones, consumo requerido: {consumoCombustible:F2} galones.");
                return;
            }

            
            nivelCombustible -= consumoCombustible;

            
            Console.WriteLine($"{marca} {modelo} recorriendo {distancia} km. Nivel de combustible restante: {nivelCombustible:F2} galones.");
        }

        public void ReabastecerCombustible(double cantidad)
        {
            
            if (cantidad > capacidaddeltanque)
            {
                Console.WriteLine($"Error: La cantidad de combustible ({cantidad:F2} galones) supera la capacidad del tanque ({capacidaddeltanque:F2} galones).");
                return;
            }

            
            nivelCombustible += cantidad;

            
            Console.WriteLine($"{marca} {modelo} reabastecido con {cantidad:F2} galones. Nivel actual: {nivelCombustible:F2} galones.");
        }

        public bool PuedeConducir(int distancia)
        {
            
            double consumoCombustible = distancia / rendimientoCombustible;

            
            return nivelCombustible - consumoCombustible >= 0;
        }




    }
}
