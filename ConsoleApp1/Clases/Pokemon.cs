using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    class Pokemon
    {
        public ushort id;
        public string name, description, species, ability;
        public Dictionary<string, int> stats;
        public List<string> types;
        public List<ushort> evolutions;
        public Dictionary<string, string> other;

        public Pokemon (ushort id, string name, string desc, string species, string ability, List<string> types, Dictionary<string, int> stats, List<ushort> evos)
        {
            this.id = id;
            this.name = name;
            this.description = desc;
            this.species = species;
            this.ability = ability;
            this.types = types;
            this.stats = stats;
            this.evolutions = evos;

        }

        public Pokemon(Dictionary<string, string> info, Dictionary<string, int> stats, List<string> types ,List<ushort> evos)
        {
            this.stats = stats;
            this.evolutions = evos;
            this.types = types;
            string val;

            if (info.TryGetValue("name", out this.name))
            {
                info.Remove("name");
            } 
            if (info.TryGetValue("description", out this.description) )
            {
                info.Remove("description");
            }
            if (info.TryGetValue("species", out this.species))
            {
                info.Remove("species");
            }
            if (info.TryGetValue("ability", out this.ability))
            {
                info.Remove("ability");
            }
            if (info.TryGetValue("id", out val))
            {
                this.id = ushort.Parse(val);
                info.Remove("id");
            }

            this.other = info;
        }

        /*public void showName ()
        {
            Console.WriteLine(name);
        }
        */
    }
}
