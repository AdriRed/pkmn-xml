using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoClase
{
    static void Main (string[] args)
    {
        System.IO.StreamReader sr = new System.IO.StreamReader(@"F:\planets.xml");
        Dictionary<string, List<string>> rutas, planetas;
        string[] dadesPlaneta;
        string[][] dadesRuta;
        string entrada;

        rutas = obtenerDadesXML(sr, "hyperspaceRoutes", "Route", "nameRoute");
        planetas = obtenerDadesXML(sr, "planets", "planet", "name");

        do
        {
            Console.Write("NOMBRE DEL PLANETA: ");
            entrada = Console.ReadLine().Trim();
            if (entrada.Length > 0)
            {
                dadesPlaneta = infoPlaneta(entrada, planetas);
                dadesRuta = infoRutas(entrada, planetas, rutas);

                foreach (string var in dadesPlaneta)
                {
                    Console.WriteLine(var);
                }
                foreach (string[] line in dadesRuta)
                {
                    foreach (string var in line)
                    {
                        Console.Write(var + " -- ");
                    }
                   Console.WriteLine();
                }
            }
        } while (entrada.Length > 0);
    }

    //FUNCIONS QUE RETORNEN LES DADES
    static string[] InformacioPlaneta (string planeta, Dictionary<string, List<string>> planetas)
    {
        string[] info;
        info = planetas[planeta].ToArray();
        return info;
    }


    static string[][] InfoRutas (string planeta, Dictionary<string, List<string>> planetas, Dictionary<string, List<string>> rutas)
    {
        List<string[]> info = new List<string[]>();
        string[] infoRuta;
        string afiliacioStart;

        foreach (KeyValuePair<string, List<string>> reg in rutas)
        {

            if (reg.Value[1].Equals(planeta))
            {

                infoRuta = new string[6];
                infoRuta[0] = reg.Value[0];
                infoRuta[1] = reg.Key;
                infoRuta[2] = reg.Value[1];
                infoRuta[3] = reg.Value[2];
                afiliacioStart = planetas[planeta][1];
                infoRuta[4] = planetas[reg.Value[2]][1];
                infoRuta[5] = infoRuta[4] == afiliacioStart ? "1" : "0";
                info.Add(infoRuta);
            }
        }
        return info.ToArray();
    }

    //FUNCIO QUE FA EL DICCIONARI
    static Dictionary<string, List<string>> ObtenerDadesXML (System.IO.StreamReader sr, string tagini, string tagele, string tagkey)
    {
        Dictionary<string, List<string>> diccionario = new Dictionary<string, List<string>>();
        String linia, element, tag, key = "";
        List<string> lista = new List<string>();

        do
        {
            linia = sr.ReadLine().Trim();
            tag = ObtenirTagXML(linia);
        } while (!tag.Equals(tagini));

        do
        {
            linia = sr.ReadLine().Trim();
            tag = ObtenirTagXML(linia);
            if (SiLiniaValida(linia))
            {

                element = ObtenirElementXML(linia);
                if (tag == tagkey)
                {
                    key = element;
                }
                else
                {
                    lista.Add(element);
                }

            }
            else if (tag.Equals("/" + tagele))
            {

                diccionario.Add(key, lista);

                lista = new List<string>();
            }
        } while (!tag.Equals("/" + tagini));

        return diccionario;
    }
    //FUNCIO PER COMPROVAR SI LA LINIA ES VALIDA
    static bool SiLiniaValida (string linia)
    {
        bool valid;
        valid = linia.Length != linia.IndexOf('>') + 1;
        return valid;
    }
    //FUNCIONS OBTENIR TAG/ELEMENT
    static string ObtenirTagXML (string line)
    {
        string tag;
        int n = line.IndexOf('>');
        tag = line.Substring(1, n - 1);
        return tag;
    }

    static string ObtenirElementXML (string linia)
    {
        string element;
        int n = linia.IndexOf('>') + 1;
        int m = linia.LastIndexOf('<');
        element = linia.Substring(n, m - n);
        return element;
    }
}
