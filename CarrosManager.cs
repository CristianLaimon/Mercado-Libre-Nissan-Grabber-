using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probabildiadCalculadorCarros
{
    internal class CarrosManager
    {
        static Random random = new();
        static int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0;

        static List<Carro> carros2016 = new List<Carro>();
        static List<Carro> carros2017 = new List<Carro>();
        static List<Carro> carros2018 = new List<Carro>();
        static List<Carro> carros2019 = new List<Carro>();
        static List<Carro> carros2020 = new List<Carro>();
        static List<Carro> carros2021 = new List<Carro>();


        static List<Carro> carrosSeleccionados = new List<Carro>();

        public static List<Carro> Carros2016 { get => carros2016; set => carros2016 = value; }
        public static List<Carro> Carros2017 { get => carros2017; set => carros2017 = value; }
        public static List<Carro> Carros2018 { get => carros2018; set => carros2018 = value; }
        public static List<Carro> Carros2019 { get => carros2019; set => carros2019 = value; }
        public static List<Carro> Carros2020 { get => carros2020; set => carros2020 = value; }
        public static List<Carro> Carros2021 { get => carros2021; set => carros2021 = value; }

        public static void RellenarListas() //aquí se cambia el número de carros 1/2
        {
            for(int i = 0; i < 40; i++) 
            {
                CarrosManager.Carros2016.Add(new Carro(i+1, "2016"));
            }

            for (int i = 0; i < 51; i++) 
            {
                CarrosManager.Carros2017.Add(new Carro(i + 1, "2017"));
            }

            for (int i = 0; i < 135; i++)
            {
                CarrosManager.Carros2018.Add(new Carro(i + 1, "2018"));
            }

            for (int i = 0; i < 56; i++)
            {
                CarrosManager.Carros2019.Add(new Carro(i + 1, "2019"));
            }

            for (int i = 0; i < 149; i++)
            {
                CarrosManager.Carros2020.Add(new Carro(i + 1, "2020"));
            }

            for (int i = 0; i < 43; i++)
            {
                CarrosManager.Carros2021.Add(new Carro(i + 1, "2021"));
            }
        }

        public static void SeleccionarCarrosPorDefecto()
        {
            int a16 = random.Next(0, 41); //Aquí se cambia el número de carros 2/2
            int a17 = random.Next(0, 51);
            int a18 = random.Next(0, 136);
            int a19 = random.Next(0, 57);
            int a20 = random.Next(0, 150);
            int a21 = random.Next(0, 44);

            carrosSeleccionados.Add(carros2016[a16]);
            carrosSeleccionados.Add(carros2017[a17]);
            carrosSeleccionados.Add(carros2018[a18]);
            carrosSeleccionados.Add(carros2019[a19]);
            carrosSeleccionados.Add(carros2020[a20]);
            carrosSeleccionados.Add(carros2021[a21]);

            Carros2016.RemoveAt(a16);
            Carros2017.RemoveAt(a17);
            Carros2018.RemoveAt(a18);
            Carros2019.RemoveAt(a19);
            Carros2020.RemoveAt(a20);
            Carros2021.RemoveAt(a21);
        }

        public static void SeleccionarCarro()
        {
            
            int candidato = random.Next(1, 7);
            int carroSeleccionado;


            switch (candidato)
            {
                case 1:
                    if (c1 < 1)
                    {
                        carroSeleccionado = random.Next(0, Carros2016.Count); //Se genera el índice del número de carro a selecc.
                        carrosSeleccionados.Add(Carros2016[carroSeleccionado]); //Se añade el índice del carro
                        Carros2016.RemoveAt(carroSeleccionado); //Se borra
                        c1++;
                    }
                    break;
                case 2:
                    if (c2 < 1)
                    {
                        carroSeleccionado = random.Next(0, Carros2017.Count); //Se genera el índice del número de carro a selecc.
                        carrosSeleccionados.Add(Carros2017[carroSeleccionado]); //Se añade el índice del carro
                        Carros2017.RemoveAt(carroSeleccionado); //Se borra
                        c2++;
                    }
                    break;
                case 3:
                    if (c3 < 6)
                    {
                        carroSeleccionado = random.Next(0, Carros2018.Count); //Se genera el índice del número de carro a selecc.
                        carrosSeleccionados.Add(Carros2018[carroSeleccionado]); //Se añade el índice del carro
                        Carros2018.RemoveAt(carroSeleccionado); //Se borra
                        c3++;
                    }
                    break;
                case 4:
                    if (c4 < 2)
                    {
                        carroSeleccionado = random.Next(0, Carros2019.Count); //Se genera el índice del número de carro a selecc.
                        carrosSeleccionados.Add(Carros2019[carroSeleccionado]); //Se añade el índice del carro
                        Carros2019.RemoveAt(carroSeleccionado); //Se borra
                        c4++;
                    }
                    break;
                case 5:
                    if (c5 < 7)
                    {
                        carroSeleccionado = random.Next(0, Carros2020.Count); //Se genera el índice del número de carro a selecc.
                        carrosSeleccionados.Add(Carros2020[carroSeleccionado]); //Se añade el índice del carro
                        Carros2020.RemoveAt(carroSeleccionado); //Se borra
                        c5++;
                    }
                    break;
                case 6:
                    if (c6 < 1)
                    {
                        carroSeleccionado = random.Next(0, Carros2021.Count); //Se genera el índice del número de carro a selecc.
                        carrosSeleccionados.Add(Carros2021[carroSeleccionado]); //Se añade el índice del carro
                        Carros2021.RemoveAt(carroSeleccionado); //Se borra
                        c6++;
                    }
                    break;

            }
        }

        public static void Ejecutar()
        {
            while (carrosSeleccionados.Count != 24)
            {
                SeleccionarCarro();
            }
            foreach(Carro carro in carrosSeleccionados)
            {
                Console.WriteLine(carro.Year + ": " + carro.NumeroCarro.ToString());
            }
        }
    }
}
