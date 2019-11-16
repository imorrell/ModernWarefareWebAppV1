using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern_Warfare_2019_WebApp.Models
{
    public class Surgeon : Soldier
    {
        public override string CodeName => "Surgeon";

        public override string PrimaryWeapon => "M13";

        public override List<string> PrimaryAttachments => new List<string>
        { "Barrel: Light Integral",
          "Suppressor Optic: Gi Mini Reflex",
          "Stock: Lightweight",
          "Stock Rear",
          "Grip: Strappled",
          "Perk: Sleight of Hand" };

        public override string SecondaryWeapon => "None";

        public override List<string> SecondaryAttachments => new List<string> { "None" };

        public override List<string> Perks => new List<string> { "Your Choice" };

        public override List<string> Eqipment => new List<string> { "Your choice" };

        public override string Description()
        {
            return "For the M13, the situation should feel\n " +
                "familiar except for tacking on a slightly\n " +
                "more tailored barrel. Beyond that, the usual\n " +
                "suspects show up here. You essentially want a\n " +
                "build that prioritizes accuracy and power above\n " +
                "all else";
        }
    }
}
