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

        static List<Carro> carros2012 = new List<Carro>();
        static List<Carro> carros2013 = new List<Carro>();
        static List<Carro> carros2014 = new List<Carro>();
        static List<Carro> carros2015 = new List<Carro>();

        static List<Carro> carros2016 = new List<Carro>();
        static List<Carro> carros2017 = new List<Carro>();
        static List<Carro> carros2018 = new List<Carro>();
        static List<Carro> carros2019 = new List<Carro>();
        static List<Carro> carros2020 = new List<Carro>();
        static List<Carro> carros2021 = new List<Carro>();

        static List<Carro> carros2022 = new List<Carro>();
        static List<Carro> carros2023 = new List<Carro>();



        static List<Carro> carrosSeleccionados = new List<Carro>();

        internal static List<Carro> Carros2012 { get => carros2012; set => carros2012 = value; }
        internal static List<Carro> Carros2013 { get => carros2013; set => carros2013 = value; }
        internal static List<Carro> Carros2014 { get => carros2014; set => carros2014 = value; }
        internal static List<Carro> Carros2015 { get => carros2015; set => carros2015 = value; }
        internal static List<Carro> Carros2016 { get => carros2016; set => carros2016 = value; }
        internal static List<Carro> Carros2017 { get => carros2017; set => carros2017 = value; }
        internal static List<Carro> Carros2018 { get => carros2018; set => carros2018 = value; }
        internal static List<Carro> Carros2019 { get => carros2019; set => carros2019 = value; }
        internal static List<Carro> Carros2020 { get => carros2020; set => carros2020 = value; }
        internal static List<Carro> Carros2021 { get => carros2021; set => carros2021 = value; }
        internal static List<Carro> Carros2022 { get => carros2022; set => carros2022 = value; }
        internal static List<Carro> Carros2023 { get => carros2023; set => carros2023 = value; }

        public static void RellenarListas() //aquí se cambia el número de carros 1/2
        {
            for (int i = 0; i < 5; i++)
            {
                CarrosManager.Carros2012.Add(new Carro(i + 1, "2012"));
            }

            for (int i = 0; i < 6; i++)
            {
                CarrosManager.Carros2013.Add(new Carro(i + 1, "2013"));
            }

            for (int i = 0; i < 8; i++)
            {
                CarrosManager.Carros2014.Add(new Carro(i + 1, "2014"));
            }

            for (int i = 0; i < 22; i++)
            {
                CarrosManager.Carros2015.Add(new Carro(i + 1, "2015"));
            }

            for (int i = 0; i < 40; i++) 
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
            for (int i = 0; i < 26; i++)
            {
                CarrosManager.Carros2022.Add(new Carro(i + 1, "2022"));
            }
            for (int i = 0; i < 3; i++)
            {
                CarrosManager.Carros2023.Add(new Carro(i + 1, "2023"));
            }
        }

        public static void SeleccionarCarrosPorDefecto()
        {
            int a12 = random.Next(0, 6);
            int a13 = random.Next(0, 7);
            int a14 = random.Next(0, 9);
            int a15 = random.Next(0, 23);
            int a16 = random.Next(0, 41); //Aquí se cambia el número de carros 2/2
            int a17 = random.Next(0, 51);
            int a18 = random.Next(0, 136);
            int a19 = random.Next(0, 57);
            int a20 = random.Next(0, 150);
            int a21 = random.Next(0, 44);
            int a22 = random.Next(0, 27);
            int a23 = random.Next(0, 4);

            carrosSeleccionados.Add(Carros2012[a12]);
            carrosSeleccionados.Add(Carros2013[a13]);
            carrosSeleccionados.Add(Carros2014[a14]);
            carrosSeleccionados.Add(Carros2015[a15]);
            carrosSeleccionados.Add(Carros2016[a16]);
            carrosSeleccionados.Add(Carros2017[a17]);
            carrosSeleccionados.Add(Carros2018[a18]);
            carrosSeleccionados.Add(Carros2019[a19]);
            carrosSeleccionados.Add(Carros2020[a20]);
            carrosSeleccionados.Add(Carros2021[a21]);
            carrosSeleccionados.Add(Carros2022[a22]);
            carrosSeleccionados.Add(Carros2023[a23]);

            Carros2012.RemoveAt(a16);
            Carros2013.RemoveAt(a16);
            Carros2014.RemoveAt(a16);
            Carros2015.RemoveAt(a16);
            Carros2016.RemoveAt(a16);
            Carros2017.RemoveAt(a17);
            Carros2018.RemoveAt(a18);
            Carros2019.RemoveAt(a19);
            Carros2020.RemoveAt(a20);
            Carros2021.RemoveAt(a21);
            Carros2022.RemoveAt(a22);
            Carros2023.RemoveAt(a23);
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
            while (carrosSeleccionados.Count != 30)
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
