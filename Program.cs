using probabildiadCalculadorCarros;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            test.Algo();

            CarrosManager.RellenarListas();
            CarrosManager.SeleccionarCarrosPorDefecto();
            CarrosManager.Ejecutar();
        }
    }
}