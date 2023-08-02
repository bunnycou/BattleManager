using System.Collections.Generic;

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

        private static Dictionary<Stat, int[]> DefaultSaves()
        {
            return new Dictionary<Stat, int[]>() // [stat, mod, prof(1/0)]
            {
                { Stat.Str, new int[] { 10, 0, 0} },
                { Stat.Dex, new int[] { 10, 0, 0} },
                { Stat.Con, new int[] { 10, 0, 0} },
                { Stat.Wis, new int[] { 10, 0, 0} },
                { Stat.Cha, new int[] { 10, 0, 0} },
                { Stat.Int, new int[] { 10, 0, 0} }
            };
        }

        private static Dictionary<DmgType, ResType> DefaultRes()
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
            /*return new Character
                (
                name: this.Name, 
                init: this.Init, 
                initOrder: this.InitOrder, 
                health: this.Health, 
                AC: this.AC, 
                level: this.Level, 
                stats: this.Stats, 
                resistances: this.Resistances,
                actions: this.Actions
                );*/
            return new Character(this);
        }

        public Character
            (
            string name = "blank",
            int init = 10,
            int initOrder = -1,
            int health = 20,
            int AC = 10,
            int level = 1,
            bool creature = false,
            Dictionary<Stat, int[]> stats = null,
            Dictionary<DmgType, ResType> resistances = null,
            Dictionary<string, string> actions = null,
            Dictionary<string, string> traits = null
            )
        {
            this.Name = name;
            this.Init = init;
            this.InitOrder = initOrder;
            this.Health = health;
            this.AC = AC;
            this.Level = level;
            this.Creature = creature;
            this.Stats = stats ?? DefaultSaves();
            this.Resistances = resistances ?? DefaultRes();
            this.Actions = actions ?? new();
            this.Traits = traits ?? new();
        }

        public Character (Character character)
        {
            this.Name = character.Name;
            this.Init = character.Init;
            this.InitOrder = character.InitOrder;
            this.Health = character.Health;
            this.AC = character.AC;
            this.Level = character.Level;
            this.Creature = character.Creature;
            this.Stats = character.Stats;
            this.Resistances = character.Resistances;
            this.Actions = character.Actions;
            this.Traits = character.Traits;
        }

        public Dictionary<string, string> Actions { get; set; }
        public Dictionary<string, string> Traits { get; set; }
        public Dictionary<Stat, int[]> Stats { get; set; }
        public Dictionary<DmgType, ResType> Resistances { get; set; }
        public bool Creature { get; set; }
        public string Name { get; set; }
        public int Init { get; set; }
        public int Health { get; set; }
        public int AC { get; set; }
        public int Level { get; set; }
        public int InitOrder { get; set; }
    }
}
