using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ConsoleApp1.Clases;

namespace ConsoleApp1.Librerias
{
    class Pokedex
    {

        /*static void Main (string[] args)
        {
            StreamReader sr = new StreamReader(@"F:\POKEMON\pokemon.xml");
            Pokemon pikachu = new Pokemon("pikachu", "a", "a", "a");
            Dictionary<int, Pokemon> a;
            pikachu.showName();

            
                Dictionary<int, Dictionary<string, string>> pokedex;
            string entrada;
            int val;
            pokedex = ObtenirDadesPokedex(sr, "pokedex", "pokemon");
            

            do
            {
                Console.Write("Numero del Pokemon: ");
                entrada = Console.ReadLine().Trim();

                if (entrada.Length > 0)
                {
                    if (int.TryParse(entrada, out val))
                    {
                        ReadVals(val, pokedex);
                    }
                }
            } while (entrada.Length > 0);
        }*/

        public static Dictionary<string, int> GetPokedexNameNum (List<Pokemon> pokedex)
        {
            Dictionary<string, int> pokedexPK = new Dictionary<string, int>();

            foreach (Pokemon reg in pokedex)
            {
                string name = reg.name;
                int index = pokedex.IndexOf(reg);
                if (pokedexPK.ContainsKey(name))
                {
                    name += "♀";
                    index++;
                }
                pokedexPK.Add(name, index + 1);
                
            }

            return pokedexPK;
        }

        /*static void ReadVals (int val, Dictionary<int, Dictionary<string, string>> pokedex)
        {
            Dictionary<string, string> pokemon;
            if (pokedex.TryGetValue(val, out pokemon))
            {
                Console.WriteLine("Pokemon nº " + val);
                foreach (KeyValuePair<string, string> reg in pokemon)
                {
                    Console.WriteLine(reg.Key + ": " + reg.Value);
                }
            } else
            {
                Console.WriteLine("ESTE POKEMON NO EXISTE");
            }
            Console.WriteLine("---------------------");
        }*/

        public static List<Pokemon> ObtenirDadesPokedex (StreamReader sr, string tagini, string tagele)
        {
            List<Pokemon> pokedex = new List<Pokemon>();
            Dictionary<string, string> info = new Dictionary<string,string>();
            Dictionary<string, int> stats = new Dictionary<string,int>();
            List<string> types = new List<string>();
            List<ushort> evos = new List<ushort>();

            string tag, val, linia;
            int id = 0;
            bool valid;

            string[] validTags =
            {
                "name",
                "ability",
                "species",
                "description"
            };

            string[] unvalidTags =
            {
                "moves"
            };

            string[] specialTags =
            {
                "evolutions",
                "stats",
                "type"
            };



            MyXML.Avanzar(sr, tagini);

            do
            {
                linia = sr.ReadLine().Trim();
                tag = MyXML.ObtenirTagXML(linia);
                valid = MyXML.SiLiniaValida(linia);

                if (tag.Equals(tagele))
                {
                    info = new Dictionary<string, string>();
                    stats = new Dictionary<string, int>();
                    types = new List<string>();
                    evos = new List<ushort>();

                    id = ushort.Parse(MyXML.ObtenirValorAtribut(linia, "id"));
                    info.Add("id", id.ToString());
                }
                else if (Contains(unvalidTags, tag))
                {
                    MyXML.Avanzar(sr, "/" + tag);
                } 
                else if (Contains(validTags, tag) && valid)
                {
                    
                    val = MyXML.ObtenirElementXML(linia);
                        
                    info.Add(tag, val);

                }
                else if ( Contains(specialTags, tag) )
                {
                    if (valid && tag == "type")
                    {
                        types.Add(MyXML.ObtenirElementXML(linia));
                    }
                    else if (tag == "evolutions")
                    {
                        while (MyXML.ObtenirTagXML(linia) != "/evolutions")
                        {
                            linia = sr.ReadLine().Trim();
                            if (MyXML.ObtenirTagXML(linia) == "evolution")
                            {
                                evos.Add(ushort.Parse(MyXML.ObtenirValorAtribut(linia, "id")));
                            }
                        }
                    }
                    else if (tag == "stats")
                    {
                        while (MyXML.ObtenirTagXML(linia) != "/stats") {
                            linia = sr.ReadLine().Trim();
                            if (MyXML.SiLiniaValida(linia)) stats.Add(MyXML.ObtenirTagXML(linia), int.Parse(MyXML.ObtenirElementXML(linia)));
                        }

                    }
                }
                else if (tag.Equals('/' + tagele))
                {
                    /*Console.WriteLine("-------------------");
                    foreach (var item in info)
                    {
                        Console.WriteLine(item.Key + " -- " + item.Value);
                    }
                    foreach (var item in stats)
                    {
                        Console.WriteLine(item.Key + " -- " + item.Value);
                    }
                    foreach (var item in types)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (var item in evos)
                    {
                        Console.WriteLine(item);
                    }*/
                    pokedex.Add(new Pokemon(info, stats, types, evos));
                }

            } while (!tag.Equals('/' + tagini));

            return pokedex;
        }

        private static bool Contains(string[] vec, string val)
        {
            bool contains = false;
            for (int i = 0; i < vec.Length && !contains; i++)
            {
                if (vec[i].Equals(val)) contains = true;
            }
            return contains;
        }

    }
    
}
