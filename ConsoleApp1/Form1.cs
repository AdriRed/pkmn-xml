using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApp1.Librerias;
using ConsoleApp1.Clases;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {



        List<Pokemon> pokedex;
        Dictionary<string, int> pokedexKeys;
        bool loaded = false;
        string folder;

        public Form1()
        {
            InitializeComponent();
        }



        private void btn_loadXML_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader sr;


            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    folder = fbd.SelectedPath;
                }

            }
            try
            {
                sr = new System.IO.StreamReader(folder + "\\pokemon.xml");

                pokedex = Pokedex.ObtenirDadesPokedex(sr, "pokedex", "pokemon");
                pokedexKeys = Pokedex.GetPokedexNameNum(pokedex);

                /*foreach (KeyValuePair<string, int> reg in pokedexKeys)
                {
                    comboBox1.Items.Add(reg.Key);
                }*/


                if (!loaded)
                {
                    dgv_pkmnStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    dgv_pkmnStats.Columns.Add("stat", "stat");
                    dgv_pkmnStats.Columns.Add("value", "value");
                    dgv_evos.Columns.Add("pokemon", "id");

                    loaded = true;
                }
            }
            catch (System.IO.FileNotFoundException excpt) { }
            

            
            
        }

        private void txb_FindPkmn_TextChanged(object sender, EventArgs e)
        {
            string val;
            int id;
            val = txb_FindPkmn.Text.Trim().ToUpper();

            if (loaded)
            {
                if (pokedexKeys.TryGetValue(val, out id))
                {
                    SetInfoBoxes(pokedex[id - 1]);
                }
                else if (int.TryParse(val, out id))
                {
                    if (id >= 1 && id <= pokedex.Count) SetInfoBoxes(pokedex[id - 1]);
                }
            }
        }

        private void SetInfoBoxes(Pokemon pkmn)
        {
            string types = "";

            txb_pkmnDesc.Text = pkmn.description;
            txb_pkmnName.Text = pkmn.name;
            txb_pkmnNum.Text = pkmn.id.ToString();
            txb_pkmnSpecie.Text = pkmn.species;
            txb_pkmnHab.Text = pkmn.ability;


            for (int i = 0; i < pkmn.types.Count - 1; i++)
            {
                types += pkmn.types[i] + " - ";
            }

            types += pkmn.types[pkmn.types.Count - 1];

            txb_pkmnType.Text = types;
            
            try
            {
                pbx_pkmnSprite.Load(folder + "\\sprites\\" + pkmn.id.ToString() + ".png");
            } catch (System.IO.DirectoryNotFoundException e) { }
            
            SetStats(pkmn.stats);
            SetEvos(pkmn.evolutions);

        }

        private void SetEvos(List<ushort> evolutions)
        {
            dgv_evos.Rows.Clear();

            foreach (var item in evolutions)
            {
                dgv_evos.Rows.Add(item.ToString());
            }

            dgv_evos.Refresh();
        }

        private void SetStats (Dictionary<string, int> pkmn)
        {
            
            dgv_pkmnStats.Rows.Clear();

            foreach (KeyValuePair<string, int> reg in pkmn)
            {
                if (reg.Key.Length <= 3)
                {
                    dgv_pkmnStats.Rows.Add(new string[] { reg.Key, reg.Value.ToString() });
                }
            }

            dgv_pkmnStats.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void Dgv_evos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Btn_selectEvo_Click(object sender, EventArgs e)
        {
            int value = int.Parse(dgv_evos.SelectedCells[0].Value.ToString());

            SetInfoBoxes(pokedex[value - 1]);

        }
    }
}
