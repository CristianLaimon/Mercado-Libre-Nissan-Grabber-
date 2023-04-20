using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probabildiadCalculadorCarros
{
    internal class Carro
    {
        int numeroCarro;
        string year;

        public Carro(int numeroCarro, string year)
        {
            this.NumeroCarro = numeroCarro;
            this.Year = year;
        }

        public int NumeroCarro { get => numeroCarro; set => numeroCarro = value; }
        public string Year { get => year; set => year = value; }
    }
}
