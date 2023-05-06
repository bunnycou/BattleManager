using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BattleManager.Character;

namespace BattleManager.Forms
{
    public partial class CharOptions : Form
    {
        public CharOptions(string Name, Character C)
        {
            InitializeComponent();
            Text = Name;
            character = C;
        }

        public Character character;

        private void CharOptions_Load(object sender, EventArgs e)
        {
            numStr.Value = character.stats[Stat.Str][0];
            numDex.Value = character.stats[Stat.Dex][0];
            numCon.Value = character.stats[Stat.Con][0];
            numInt.Value = character.stats[Stat.Int][0];
            numWis.Value = character.stats[Stat.Wis][0];
            numCha.Value = character.stats[Stat.Cha][0];
            chkStrAdv.Checked = character.stats[Stat.Str][2] == 1;
            chkDexAdv.Checked = character.stats[Stat.Dex][2] == 1;
            chkConAdv.Checked = character.stats[Stat.Con][2] == 1;
            chkIntAdv.Checked = character.stats[Stat.Int][2] == 1;
            chkWisAdv.Checked = character.stats[Stat.Wis][2] == 1;
            chkChaAdv.Checked = character.stats[Stat.Cha][2] == 1;
            numLevel.Value = character.level;
            numStrMod.Value = character.stats[Stat.Str][1];
            numDexMod.Value = character.stats[Stat.Dex][1];
            numConMod.Value = character.stats[Stat.Con][1];
            numIntMod.Value = character.stats[Stat.Int][1];
            numWisMod.Value = character.stats[Stat.Wis][1];
            numChaMod.Value = character.stats[Stat.Cha][1];

            switch (character.resistances[DmgType.Acid])
            {
                case ResType.Resistant: rdbAcidR.Checked = true; break;
                case ResType.Vulnerable: rdbAcidV.Checked = true; break;
                case ResType.Immune: rdbAcidI.Checked = true; break;
                case ResType.None: rdbAcidN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Cold])
            {
                case ResType.Resistant: rdbColdR.Checked = true; break;
                case ResType.Vulnerable: rdbColdV.Checked = true; break;
                case ResType.Immune: rdbColdI.Checked = true; break;
                case ResType.None: rdbColdN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Fire])
            {
                case ResType.Resistant: rdbFireR.Checked = true; break;
                case ResType.Vulnerable: rdbFireV.Checked = true; break;
                case ResType.Immune: rdbFireI.Checked = true; break;
                case ResType.None: rdbFireN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Force])
            {
                case ResType.Resistant: rdbForceR.Checked = true; break;
                case ResType.Vulnerable: rdbForceV.Checked = true; break;
                case ResType.Immune: rdbForceI.Checked = true; break;
                case ResType.None: rdbForceN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Lightning])
            {
                case ResType.Resistant: rdbLightningR.Checked = true; break;
                case ResType.Vulnerable: rdbLightningV.Checked = true; break;
                case ResType.Immune: rdbLightningI.Checked = true; break;
                case ResType.None: rdbLightningN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Necrotic])
            {
                case ResType.Resistant: rdbNecroticR.Checked = true; break;
                case ResType.Vulnerable: rdbNecroticV.Checked = true; break;
                case ResType.Immune: rdbNecroticI.Checked = true; break;
                case ResType.None: rdbNecroticN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Poison])
            {
                case ResType.Resistant: rdbPoisonR.Checked = true; break;
                case ResType.Vulnerable: rdbPoisonV.Checked = true; break;
                case ResType.Immune: rdbPoisonI.Checked = true; break;
                case ResType.None: rdbPoisonN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Psychic])
            {
                case ResType.Resistant: rdbPsychicR.Checked = true; break;
                case ResType.Vulnerable: rdbPsychicV.Checked = true; break;
                case ResType.Immune: rdbPsychicI.Checked = true; break;
                case ResType.None: rdbPsychicN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Radiant])
            {
                case ResType.Resistant: rdbRadiantR.Checked = true; break;
                case ResType.Vulnerable: rdbRadiantV.Checked = true; break;
                case ResType.Immune: rdbRadiantI.Checked = true; break;
                case ResType.None: rdbRadiantN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Thunder])
            {
                case ResType.Resistant: rdbThunderR.Checked = true; break;
                case ResType.Vulnerable: rdbThunderV.Checked = true; break;
                case ResType.Immune: rdbThunderI.Checked = true; break;
                case ResType.None: rdbThunderN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Bludgeoning])
            {
                case ResType.Resistant: rdbBludgeoningR.Checked = true; break;
                case ResType.Vulnerable: rdbBludgeoningV.Checked = true; break;
                case ResType.Immune: rdbBludgeoningI.Checked = true; break;
                case ResType.None: rdbBludgeoningN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Piercing])
            {
                case ResType.Resistant: rdbPiercingR.Checked = true; break;
                case ResType.Vulnerable: rdbPiercingV.Checked = true; break;
                case ResType.Immune: rdbPiercingI.Checked = true; break;
                case ResType.None: rdbPiercingN.Checked = true; break;
            }
            switch (character.resistances[DmgType.Slashing])
            {
                case ResType.Resistant: rdbSlashingR.Checked = true; break;
                case ResType.Vulnerable: rdbSlashingV.Checked = true; break;
                case ResType.Immune: rdbSlashingI.Checked = true; break;
                case ResType.None: rdbSlashingN.Checked = true; break;
            }
        }

        private void CharOptions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDone_Click(sender, e);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            character.resistances = getResDict();
            character.stats = getStatDict();
            Close();
        }

        private Dictionary<Stat, int[]> getStatDict()
        {
            return new Dictionary<Stat, int[]>()
            {
                { Stat.Str, new int[] { (int)numStr.Value, (int)numStrMod.Value, chkStrAdv.Checked ? 1 : 0 } },
                { Stat.Dex, new int[] { (int)numDex.Value, (int)numDexMod.Value, chkDexAdv.Checked ? 1 : 0 } },
                { Stat.Con, new int[] { (int)numCon.Value, (int)numConMod.Value, chkConAdv.Checked ? 1 : 0 } },
                { Stat.Int, new int[] { (int)numInt.Value, (int)numIntMod.Value, chkIntAdv.Checked ? 1 : 0 } },
                { Stat.Wis, new int[] { (int)numWis.Value, (int)numWisMod.Value, chkWisAdv.Checked ? 1 : 0 } },
                { Stat.Cha, new int[] { (int)numCha.Value, (int)numChaMod.Value, chkChaAdv.Checked ? 1 : 0 } }
            };
        }

        private Dictionary<DmgType, ResType> getResDict()
        {
            return new Dictionary<DmgType, ResType>()
            {
                // Acid
                { DmgType.Acid, rdbAcidR.Checked ? ResType.Resistant : rdbAcidV.Checked ? ResType.Vulnerable : rdbAcidI.Checked ? ResType.Immune : ResType.None },
                // Cold
                { DmgType.Cold, rdbColdR.Checked ? ResType.Resistant : rdbColdV.Checked ? ResType.Vulnerable : rdbColdI.Checked ? ResType.Immune : ResType.None },
                // Fire
                { DmgType.Fire, rdbFireR.Checked ? ResType.Resistant : rdbFireV.Checked ? ResType.Vulnerable : rdbFireI.Checked ? ResType.Immune : ResType.None },
                // Force
                { DmgType.Force, rdbForceR.Checked ? ResType.Resistant : rdbForceV.Checked ? ResType.Vulnerable : rdbForceI.Checked ? ResType.Immune : ResType.None },
                // Lightning
                { DmgType.Lightning, rdbLightningR.Checked ? ResType.Resistant : rdbLightningV.Checked ? ResType.Vulnerable : rdbLightningI.Checked ? ResType.Immune : ResType.None },
                // Necrotic
                { DmgType.Necrotic, rdbNecroticR.Checked ? ResType.Resistant : rdbNecroticV.Checked ? ResType.Vulnerable : rdbNecroticI.Checked ? ResType.Immune : ResType.None },
                // Poison
                { DmgType.Poison, rdbPoisonR.Checked ? ResType.Resistant : rdbPoisonV.Checked ? ResType.Vulnerable : rdbPoisonI.Checked ? ResType.Immune : ResType.None },
                // Psychic
                { DmgType.Psychic, rdbPsychicR.Checked ? ResType.Resistant : rdbPsychicV.Checked ? ResType.Vulnerable : rdbPsychicI.Checked ? ResType.Immune : ResType.None },
                // Radiant
                { DmgType.Radiant, rdbRadiantR.Checked ? ResType.Resistant : rdbRadiantV.Checked ? ResType.Vulnerable : rdbRadiantI.Checked ? ResType.Immune : ResType.None },
                // Thunder
                { DmgType.Thunder, rdbThunderR.Checked ? ResType.Resistant : rdbThunderV.Checked ? ResType.Vulnerable : rdbThunderI.Checked ? ResType.Immune : ResType.None },
                // Bludgeoning
                { DmgType.Bludgeoning, rdbBludgeoningR.Checked ? ResType.Resistant : rdbBludgeoningV.Checked ? ResType.Vulnerable : rdbBludgeoningI.Checked ? ResType.Immune : ResType.None },
                // Piercing
                { DmgType.Piercing, rdbPiercingR.Checked ? ResType.Resistant : rdbPiercingV.Checked ? ResType.Vulnerable : rdbPiercingI.Checked ? ResType.Immune : ResType.None },
                // Slashing
                { DmgType.Slashing, rdbSlashingR.Checked ? ResType.Resistant : rdbSlashingV.Checked ? ResType.Vulnerable : rdbSlashingI.Checked ? ResType.Immune : ResType.None },
            };

        }

        private void numStr_ValueChanged(object sender, EventArgs e)
        {
            numStrMod.Value = Utility.getMod((int)numStr.Value, (int)numLevel.Value, chkStrAdv.Checked);
        }

        private void numDex_ValueChanged(object sender, EventArgs e)
        {
            numDexMod.Value = Utility.getMod((int)numDex.Value, (int)numLevel.Value, chkDexAdv.Checked);
        }

        private void numCon_ValueChanged(object sender, EventArgs e)
        {
            numConMod.Value = Utility.getMod((int)numCon.Value, (int)numLevel.Value, chkConAdv.Checked);
        }

        private void numInt_ValueChanged(object sender, EventArgs e)
        {
            numIntMod.Value = Utility.getMod((int)numInt.Value, (int)numLevel.Value, chkIntAdv.Checked);
        }

        private void numWis_ValueChanged(object sender, EventArgs e)
        {
            numWisMod.Value = Utility.getMod((int)numWis.Value, (int)numLevel.Value, chkWisAdv.Checked);
        }

        private void numCha_ValueChanged(object sender, EventArgs e)
        {
            numChaMod.Value = Utility.getMod((int)numCha.Value, (int)numLevel.Value, chkChaAdv.Checked);
        }

        private void numLevel_ValueChanged(object sender, EventArgs e)
        {
            numStr_ValueChanged(sender, e);
            numDex_ValueChanged(sender, e);
            numCon_ValueChanged(sender, e);
            numInt_ValueChanged(sender, e);
            numWis_ValueChanged(sender, e);
            numCha_ValueChanged(sender, e);
        }
    }
}
