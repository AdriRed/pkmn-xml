using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Librerias
{
    class MyXML
    {
        public static string ObtenirTagXML(string linia)
        {
            string tag;
            int indexSpace = linia.IndexOf(' '), indexFin = linia.IndexOf('>');
            int n = indexSpace > 0 ? Math.Min(indexSpace, indexFin) : indexFin;
            tag = linia.Substring(1, n - 1);
            return tag;
        }

        public static string ObtenirValorAtribut(string linia, string atribut)
        {
            string val;

            int loc = linia.IndexOf(atribut + "=") + atribut.Length + 1 + 1;
            linia = linia.Substring(loc);
            loc = linia.IndexOf("'");
            val = linia.Substring(0, loc);
            return val;
        }

        public static string ObtenirElementXML(string linia)
        {
            string element;
            int n = linia.IndexOf('>') + 1;
            int m = linia.LastIndexOf('<');
            element = linia.Substring(n, m - n);
            return element;
        }

        public static bool SiLiniaValida(string linia)
        {
            bool valid;
            valid = linia.Length != linia.IndexOf('>') + 1;
            return valid;
        }

        public static void Avanzar (System.IO.StreamReader sr, string tagini)
        {
            string linia, tag;
            do
            {
                linia = sr.ReadLine().Trim();
                tag = MyXML.ObtenirTagXML(linia);
            } while (!tag.Equals(tagini));
        }
    }
}
