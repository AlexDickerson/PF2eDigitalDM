using Microsoft.AspNetCore.Components;
using Library.Models;

namespace PF2eDigitalDM.Components.Elements
{
    public partial class StatBlock : ComponentBase
    {
        //[Parameter]
        public Creature character { get; set; } = default!;

        protected override void OnInitialized()
        {
            Creature ferox = new Creature
            {
                Name = "Ferox Valkar",
                ClassLevel = "Barbarian 1",
                Alignment = "N",
                Size = "Medium",
                Traits = new List<string> { "Kholo", "Great Kholo", "Humanoid" },
                Perception = 5,
                Vision = "Low-Light Vision",
                Languages = new List<string> { "Common", "Diabolic", "Kholo" },
                Skills = new Dictionary<string, int>
                {
                    { "Acrobatics", 3 }, { "Athletics", 7 }, { "Intimidation", 3 },
                    { "Lore: Gladiatorial", 4 }, { "Performance", 3 }, { "Stealth", 6 },
                    { "Survival", 3 }, { "Thievery", 6 }
                },
                Attributes = new Dictionary<string, int> { { "Str", 4 }, { "Dex", 3 }, { "Con", 1 }, { "Int", 1 }, { "Wis", 0 }, { "Cha", 0 } },
                Items = new List<string> { "Hide", "Predator's Claw" },
                AC = 18,
                Saves = new Dictionary<string, int> { { "Fort", 6 }, { "Ref", 6 }, { "Will", 5 } },
                HP = 23,
                Speed = 25,
                MeleeWeapons = new List<Weapon>
                {
                    new Weapon { Name = "Spirit Thresher", Traits = "Uncommon, Kholo, Sweep, Versatile S, Large", Damage = "1d12+4 B" },
                    new Weapon { Name = "Bo Staff", Traits = "Monk, Parry, Reach, Trip", Damage = "1d8+4 B" }
                },
                        Feats = new List<string>
                {
                    "Great Kholo", "Impressive Performance", "Intimidating Glare",
                    "Kholo Weapon Familiarity", "Raging Intimidation"
                },
                Specials = new List<string> { "Bite (Kholo)", "Instinct (Giant Instinct)" }
            };

            character = ferox;
        }
    }
}
