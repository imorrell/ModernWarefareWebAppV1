using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern_Warfare_2019_WebApp.Models
{
    public class RunAndGun : Soldier
    {
        public override string CodeName => "Run and Gun";

        public override string PrimaryWeapon => "P90";

        public override List<string> PrimaryAttachments => new List<string>
        {
            "Stock: QCB Comb",
            "Any Laser",
            "Underbarrel: Granulated Grip Tape",
            "Rear Grip: Stippled Grip",
            "Tape Perk: FMJ/Heavy Hitter"
        };
        public override string SecondaryWeapon => "None";

        public override List<string> SecondaryAttachments => new List<string> { "None" };

        public override List<string> Perks => new List<string> { "Double Time", "Ghost", "Battle Hardened" };

        public override List<string> Eqipment => new List<string> { "Claymore", "Molotov" };

        public override string Description()
        {
            return "For those who want to purely run and gun,\n " +
                   "this is one P90 offering that may suit \n " +
                   "taste. SMGs are one of the better weapon classes\n " +
                   "in Modern Warfare right now, and this loadout\n" +
                   "allows you to make use of one of the best ones in the game.";
        }
    }
}
