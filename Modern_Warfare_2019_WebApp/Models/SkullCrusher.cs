using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern_Warfare_2019_WebApp.Models
{
    public class SkullCrusher : Soldier
    {
        public override string CodeName => "Skull Crusher";

        public override string PrimaryWeapon => "AX-50";

        public override List<string> PrimaryAttachments => new List<string>
        { "17 Factory Barrel",
          "Stock: Singuard Arms Assassin",
          "Ammunation: Seven-round Mags",
          "Rear Grip: Stippled Grip Tape"};

        public override string SecondaryWeapon => "None";

        public override List<string> SecondaryAttachments => new List<string> { "None" };

        public override List<string> Perks => new List<string> { "Quick Fix", "Ghost", "Battle Hardened" };

        public override List<string> Eqipment => new List<string> { "Frag Grenade/Stim" };

        public override string Description()
        {
            return "If you like to snipe but don't have a\n " +
                   "ton of patience, this is the class setup\n " +
                   "for you. In both attachments and Perks,\n " +
                   "that this build is all about fast ADS speed\n " +
                   "and having the ability to heal in pressure\n " +
                   "situations. After all, if you're taking risky\n " +
                   "shots, you'll need a way to recover after being\n " +
                   "spotted.";
        }
    }
}
