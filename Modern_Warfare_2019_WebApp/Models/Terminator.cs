using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern_Warfare_2019_WebApp.Models
{
    public class Terminator : Soldier
    {
        public override string CodeName => "Terminator";
        public override string PrimaryWeapon => "Kilo";
        public override List<string> PrimaryAttachments => new List<string>
        {
               "Barrel: Singuard Arms 18.6",
               "Optic: G.I. Mini Reflex/Operator Reflex Sight",
               "Stock: TAC Ultralight: Aim walk movement speed",
               "Foregrip: Commando Foregrip Recon/50-round mag"
        };
        public override string SecondaryWeapon => "AUG";
        public override List<string> SecondaryAttachments => new List<string>
        {
                   "No suppressor",
                   "Any Laser",
                   "Barrel: 407 extended",
                   "Stock: FTAC Ultralight Hollow",
                   "Underbarrel: Commando",
                   "FMJ or Recon"
        };
        public override List<string> Perks => new List<string> { "Overkill", "Restock", "Amped" };
        public override List<string> Eqipment => new List<string> { "Flash Grenade" };

        public override string Description()
        {
            return "This loadout combines two of Modern Warfare's\n " +
                   "best early-game weapons to form a great pairing\n. " +
                   "Pelt opponents from medium range with the Kilo\n " +
                   "and shred from up close with the AUG. This one\n " +
                   "is great for an all-purpose approach that doesn't\n " +
                   "involve sniping";
        }
    }

}
