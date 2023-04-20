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

        static List<int> carros2016 = new List<int>();
        static List<int> carros2017 = new List<int>();
        static List<int> carros2018 = new List<int>();
        static List<int> carros2019 = new List<int>();
        static List<int> carros2020 = new List<int>();
        static List<int> carros2021 = new List<int>();


        static List<int> carrosSeleccionados = new List<int>();


        public static List<int> Carros2016 { get => carros2016; set => carros2016 = value; }
        public static List<int> Carros2017 { get => carros2017; set => carros2017 = value; }
        public static List<int> Carros2018 { get => carros2018; set => carros2018 = value; }
        public static List<int> Carros2019 { get => carros2019; set => carros2019 = value; }
        public static List<int> Carros2020 { get => carros2020; set => carros2020 = value; }
        public static List<int> Carros2021 { get => carros2021; set => carros2021 = value; }

        public static void RellenarListas()
        {
            for(int i = 0; i < 40; i++) 
            {
                CarrosManager.carros2016.Add(i+1);
            }

            for (int i = 0; i < 51; i++) 
            {
                CarrosManager.carros2017.Add(i + 1);
            }

            for (int i = 0; i < 135; i++)
            {
                CarrosManager.carros2018.Add(i + 1);
            }

            for (int i = 0; i < 56; i++)
            {
                CarrosManager.carros2019.Add(i + 1);
            }

            for (int i = 0; i < 149; i++)
            {
                CarrosManager.carros2020.Add(i + 1);
            }

            for (int i = 0; i < 43; i++)
            {
                CarrosManager.carros2021.Add(i + 1);
            }
        }

        public static void SeleccionarCarrosPorDefecto()
        {
            carros2016.Remove(random.Next(1, 41));
            carros2017.Remove(random.Next(1, 52));
            carros2018.Remove(random.Next(1, 136));
            carros2019.Remove(random.Next(1, 57));
            carros2020.Remove(random.Next(1, 150));
            carros2021.Remove(random.Next(1, 44));
        }

        public static string SeleccionarCarro()
        {
            
            int candidato = random.Next(1, 7);
            int carroSeleccionado;

            switch (candidato)
            {
                case 1:
                    carroSeleccionado = random.Next(0, carros2016.Count); //Se genera el índice del número de carro a selecc.
                    carrosSeleccionados.Add(carros2016[carroSeleccionado]); //Se añade el índice del carro
                    carros2016.Remove(carroSeleccionado); //Se borra
                    return "2016" + "    " + carroSeleccionado;

                default:
                    return "no hay nada";
                //case 2:
                //    carroSeleccionado = random.Next(carros2017.Count);
                //    carrosSeleccionados.Add(carros2017[carroSeleccionado]);
                //    carros2017.Remove(carroSeleccionado);
                //    break;
                //case 3:
                //    carroSeleccionado = random.Next(1, carros2018.Count);
                //    carrosSeleccionados.Add(carros2018[carroSeleccionado]);
                //    carros2018.Remove(carroSeleccionado);
                //    break;
                //case 4:
                //    carroSeleccionado = random.Next(1, carros2019.Count);
                //    carrosSeleccionados.Add(carros2019[carroSeleccionado]);
                //    carros2019.Remove(carroSeleccionado);
                //    break;
                //case 5:
                //    carroSeleccionado = random.Next(1, carros2020.Count);
                //    carrosSeleccionados.Add(carros2020[carroSeleccionado]);
                //    carros2020.Remove(carroSeleccionado);
                //    break;
                //case 6:
                //    carroSeleccionado = random.Next(1, carros2021.Count);
                //    carrosSeleccionados.Add(carros2021[carroSeleccionado]);
                //    carros2021.Remove(carroSeleccionado);
                //    break;
            }
        }

        public static void Ejecutar()
        {
            while (carrosSeleccionados.Count != 30)
            {
                SeleccionarCarro();
            }
            foreach(int carro in carrosSeleccionados)
            {
                Console.WriteLine("")
            }
        }
    }
}
