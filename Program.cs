using probabildiadCalculadorCarros;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            CarrosManager.RellenarListas();
            CarrosManager.SeleccionarCarrosPorDefecto();
            CarrosManager.Ejecutar();
        }
    }
}