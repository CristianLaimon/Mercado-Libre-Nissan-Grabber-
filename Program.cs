using probabildiadCalculadorCarros;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Carros.RellenarListas();
            Carros.SeleccionarCarrosPorDefecto();
            Carros.Ejecutar();
        }
    }
}