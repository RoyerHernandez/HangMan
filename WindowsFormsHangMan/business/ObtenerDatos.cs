using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace business
{
    public class ObtenerDatos
    {
        public void obtenerInformación(string txt1,string txt2 ,string txt3 ,string txt4 , string txt5 , string txt6 , string txt7 , string txt8 , string txt9 , string txt10)
        {
            string palabra;
            string palabraEscrita;
            string compara;

            string[] dato1 = new string[1];

            palabraEscrita = txt1 + txt2 + txt3 + txt4 + txt5 + txt6 + txt7 + txt8 + txt9 + txt10;


            ObtenerDatos obtener = new ObtenerDatos();

            Console.WriteLine(separarPalabra(palabraEscrita, 10));




        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min,max);
        }
        public string obtenerPalabras(int ini, int fin)
        {
            string palabra = string.Empty;
            int palabras = RandomNumber(ini, fin);
            palabra = tipoPalab[palabras];
            return palabra;
        }

        Dictionary<int, String> tipoPalab = new Dictionary<int, string>
        {
            {1, "Liderazgo" },
            {2, "Comunicacion" },
            {3, "Sociedad" }
        };

        public string[] separarPalabra(string palabra, int count)
        {

            var letras = palabra.ToArray();

            string[] arregloPalabra = new string[count];

            for (int i = 0; i < palabra.Length; i++)
            {
                arregloPalabra[i] = Convert.ToString(letras[i]);
            }

            return arregloPalabra;
        }

    }
}
