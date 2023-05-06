﻿using System;
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
                { Stat.Str, new int[] { (int)numStr.Value, chkStrAdv.Checked ? 1 : 0 } },
                { Stat.Dex, new int[] { (int)numDex.Value, chkDexAdv.Checked ? 1 : 0 } },
                { Stat.Con, new int[] { (int)numCon.Value, chkConAdv.Checked ? 1 : 0 } },
                { Stat.Int, new int[] { (int)numInt.Value, chkIntAdv.Checked ? 1 : 0 } },
                { Stat.Wis, new int[] { (int)numWis.Value, chkWisAdv.Checked ? 1 : 0 } },
                { Stat.Cha, new int[] { (int)numCha.Value, chkChaAdv.Checked ? 1 : 0 } }
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
