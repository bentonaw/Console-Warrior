using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Warrior
{
    internal class Character
    {
        public int HP { get; set; }
        public int AC { get; set; }

        public int Physical { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Psyche { get; set; }

        public int Lvl { get; set; }
        public int Exp { get; set; }
        public int Age { get; set; }
        public int Race { get; set; }
        public string Gender { get; set; }

        public string Class {  get; set; }

        public double PhysMod { get; set; }
        public double DexMod { get; set; }
        public double IntMod { get; set; }
        public double PsyMod { get; set; }

        public double WeaponMod {  get; set; }
        public double ArmorHeadMod { get; set; }
        public double ArmorTorsoInnerMod { get; set; }
        public double ArmorTorsoOuterMod { get; set; }
        public double ArmorArmMod { get; set; }
        public double ArmorTrouserMod { get; set; }
        public double ArmorShoesMod { get; set; }
        
        //public double AttackHit()
        //{
            
        //}

        //public double AttackDmg() 
        //{ 
        
        //}


    }
}
