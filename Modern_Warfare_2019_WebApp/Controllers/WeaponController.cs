using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Modern_Warfare_2019_WebApp.Models;

namespace Modern_Warfare_2019_WebApp.Controllers
{
    public class WeaponController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SoldierLayout(string CodeName)
        {
            switch (CodeName)
            {
                case "Terminator":
                    {
                        //create a terminator object
                        Terminator term = new Terminator();
                        return View(term);

                    }

                case "RunAndGun":
                    {
                        //create a run and un object
                        RunAndGun gunna = new RunAndGun();
                        return View(gunna);
                    }

                case "SkullCrusher":
                    {
                        //create Skull crusher object
                        SkullCrusher crush = new SkullCrusher();
                        return View(crush);
                    }

                case "Surgeon":
                    {
                        //Create surgeon object
                        Surgeon precise = new Surgeon();
                        return View(precise);
                    }
                default:
                    {
                        return View();
                    }
            }
        }
    }
}