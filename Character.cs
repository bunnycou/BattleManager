using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleManager
{
    public class Character
    {
        public enum Stat
        {
            Str,
            Dex,
            Con,
            Int,
            Wis,
            Cha

        }
        public enum ResType
        {
            Resistant,
            Vulnerable,
            Immune,
            None
        }

        public enum DmgType
        {
            Acid,
            Cold,
            Fire,
            Force,
            Lightning,
            Necrotic,
            Poison,
            Psychic,
            Radiant,
            Thunder,
            Bludgeoning,
            Piercing,
            Slashing
        }

        public Character(string name, int health, int AC) // Construct without init for temp use (will likely be deleted)
        {
            this.name = name;
            this.health = health;
            this.AC = AC;
        }

        public Character(string name, int init, int health, int AC) // Construct with init for permanent use
        {
            this.name = name;
            this.init = init;
            this.health = health;
            this.AC = AC;
        }

        public Character(string name, int init, int health, int AC, Dictionary<Stat, int[]> saves, Dictionary<DmgType, ResType> res) // Construct full character
        {
            this.name = name;
            this.init = init;
            this.health = health;
            this.AC = AC;
            this.savingThrows = saves;
            this.resistances = res;
        }

        public Dictionary<Stat, int[]> savingThrows { get; set; }
        public Dictionary<DmgType, ResType> resistances { get; set; }
        public string name { get; set; }
        public int init { get; set; }
        public int health { get; set; }
        public int AC { get; set; }
    }
}
