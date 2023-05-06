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
            return new Dictionary<Stat, int[]>() // [stat, mod, prof]
            {
                { Stat.Str, new int[] { 10, 0, 0} },
                { Stat.Dex, new int[] { 10, 0, 0} },
                { Stat.Con, new int[] { 10, 0, 0} },
                { Stat.Wis, new int[] { 10, 0, 0} },
                { Stat.Cha, new int[] { 10, 0, 0} },
                { Stat.Int, new int[] { 10, 0, 0} }
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

        public Character Clone()
        {
            return new Character
                (
                name: this.name, 
                init: this.init, 
                initOrder: this.initOrder, 
                health: this.health, 
                AC: this.AC, 
                level: this.level, 
                stats: this.stats, 
                resistances: this.resistances
                );
        }

        public Character
            (
            string name = "blank", 
            int init = 10, 
            int initOrder = -1, 
            int health = 20, 
            int AC = 10, 
            int level = 1, 
            Dictionary<Stat, int[]> stats = null, 
            Dictionary<DmgType, ResType> resistances = null
            )
        {
            this.name = name;
            this.init = init;
            this.initOrder = initOrder;
            this.health = health;
            this.AC = AC;
            this.level = level;
            this.stats = stats ?? defaultSaves();
            this.resistances = resistances ?? defaultRes();
        }

        public Dictionary<string, string> actions { get; set; }
        public Dictionary<Stat, int[]> stats { get; set; }
        public Dictionary<DmgType, ResType> resistances { get; set; }
        public string name { get; set; }
        public int init { get; set; }
        public int health { get; set; }
        public int AC { get; set; }
        public int level { get; set; }
        public int initOrder { get; set; }
    }
}
