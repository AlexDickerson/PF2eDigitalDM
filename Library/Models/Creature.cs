using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Creature
    {
        public string Name { get; set; }
        public string ClassLevel { get; set; }
        public string Alignment { get; set; }
        public string Size { get; set; }
        public List<string> Traits { get; set; }
        public int Perception { get; set; }
        public string Vision { get; set; }
        public List<string> Languages { get; set; }
        public Dictionary<string, int> Skills { get; set; }
        public Dictionary<string, int> Attributes { get; set; }
        public List<string> Items { get; set; }
        public int AC { get; set; }
        public Dictionary<string, int> Saves { get; set; }
        public int HP { get; set; }
        public int Speed { get; set; }
        public List<Weapon> MeleeWeapons { get; set; }
        public List<string> Feats { get; set; }
        public List<string> Specials { get; set; }
    }

    public class Weapon
    {
        public string Name { get; set; }
        public string Traits { get; set; }
        public string Damage { get; set; }
    }
}
