using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using HtmlAgilityPack;
using System.Text.RegularExpressions;


namespace probabildiadCalculadorCarros
{
    internal class test
    {
        public static void Algo()
        {
            // Hacer la petición HTTP a la página
            WebClient client = new WebClient();
            string html = client.DownloadString("https://autos.mercadolibre.com.mx/nissan/march/2023/#applied_filter_id%3DVEHICLE_YEAR%26applied_filter_name%3DA%C3%B1o%26applied_filter_order%3D2%26applied_value_id%3D%5B2023-2023%5D%26applied_value_name%3D2023%26applied_value_order%3D1%26applied_value_results%3D4%26is_custom%3Dfalse");

            // Analizar el HTML con HtmlAgilityPack
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            // Encontrar la línea que tiene el valor 'dimension22'
            HtmlNode node = doc.DocumentNode.SelectSingleNode("//script[contains(text(),'dimension22')]");

            // Buscar el valor numérico en la línea usando regular expressions
            string pattern = @"meli_ga\(""set"",\s*""dimension22"",\s*""(\d+)""\);";
            Match match = Regex.Match(node.InnerHtml, pattern);

            if (match.Success)
            {
                string value = match.Groups[1].Value;
                Console.WriteLine("Valor: " + value);
            }
            else
            {
                Console.WriteLine("No se encontró el valor");
            }


            //// Hacer la petición HTTP a la página
            //WebClient client = new WebClient();
            //string html = client.DownloadString("https://autos.mercadolibre.com.mx/march/#filter");

            //// Analizar el HTML con HtmlAgilityPack
            //HtmlDocument doc = new HtmlDocument();
            //doc.LoadHtml(html);

            //// Encontrar la línea que tiene el valor 'dimension22'
            //HtmlNode node = doc.DocumentNode.SelectSingleNode("//script[contains(text(),'dimension22')]");

            //// Extraer el número de la línea usando regular expressions
            //string value = Regex.Match(node.InnerText, @"\b\d+\b").Value;

            //Console.WriteLine("Valor: " + value);






        }



        //// Hacer la petición HTTP a la página
        //WebClient client = new WebClient();
        //string html = client.DownloadString("https://autos.mercadolibre.com.mx/march/#filter");

        //// Analizar el HTML con HtmlAgilityPack
        //HtmlDocument doc = new HtmlDocument();
        //doc.LoadHtml(html);

        //// Encontrar el número de publicaciones
        //HtmlNode node = doc.DocumentNode.SelectSingleNode("//span[@class='quantity-results']");
        //string result = node.InnerText.Trim().Replace(",", "");

        //int numPublicaciones = Int32.Parse(result);

        //Console.WriteLine("Número de publicaciones: " + numPublicaciones);
    }
}

