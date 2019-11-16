using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modern_Warfare_2019_WebApp.Models
{
    public abstract class Soldier
    {
        //initialize properties
        #region Properties
        public abstract string CodeName { get; }
        public abstract string PrimaryWeapon { get; }
        public abstract List<string> PrimaryAttachments { get; }
        public abstract string SecondaryWeapon { get; }
        public abstract List<string> SecondaryAttachments { get; }
        public abstract List<string> Perks { get; }
        public abstract List<string> Eqipment { get; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public double KDRatio { get; set; }
        #endregion

        #region Methods
        public Soldier()
        {

        }

        public abstract string Description();

        #endregion
    }

}
