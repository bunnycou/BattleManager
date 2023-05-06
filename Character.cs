using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private Dictionary<Stat, int[]> defaultSaves()
        {
            return new Dictionary<Stat, int[]>()
            {
                { Stat.Str, new int[] { 0, 0} },
                { Stat.Dex, new int[] { 0, 0} },
                { Stat.Con, new int[] { 0, 0} },
                { Stat.Wis, new int[] { 0, 0} },
                { Stat.Cha, new int[] { 0, 0} },
                { Stat.Int, new int[] { 0, 0} }
            };
        }

        private Dictionary<DmgType, ResType> defaultRes()
        {
            return new Dictionary<DmgType, ResType>()
            {
                { DmgType.Acid, ResType.None },
                { DmgType.Cold, ResType.None },
                { DmgType.Fire, ResType.None },
                { DmgType.Force, ResType.None },
                { DmgType.Lightning, ResType.None },
                { DmgType.Necrotic, ResType.None },
                { DmgType.Poison, ResType.None },
                { DmgType.Psychic, ResType.None },
                { DmgType.Radiant, ResType.None },
                { DmgType.Thunder, ResType.None },
                { DmgType.Bludgeoning, ResType.None },
                { DmgType.Piercing, ResType.None },
                { DmgType.Slashing, ResType.None }
            };
        }

        public Character()
        {
            // Empty constructor
            name = "blank";
            init = 10;
            health = 10;
            AC = 10;
            savingThrows = defaultSaves();
            resistances = defaultRes();
        }

        public Character(string name, int init, int health, int AC) // Construct with init for permanent use
        {
            this.name = name;
            this.init = init;
            this.health = health;
            this.AC = AC;
            savingThrows = defaultSaves();
            resistances = defaultRes();
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
