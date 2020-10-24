using FoxClubApplication.Models.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace FoxClubApplication.Models.Services
{
    public class FoxServices : IFoxServices
    {
        public List<Fox> Foxes { get; set; }
        public Fox CurrentFox { get; set; }

        public FoxServices()
        {
            Foxes = new List<Fox>();
        }
        public void AddFox(Fox fox)
        {
            Foxes.Add(fox);
        }

        public Fox GetCurrentFox(string name)
        {
            var CurrentFox = Foxes.FirstOrDefault(i => i.FoxName == name);
            return CurrentFox;
        }
        public void ChangeNutrition(string food, string drink)
        {
            CurrentFox.FoxFood = food;
            CurrentFox.FoxDrink = drink;
        }
    }
}
