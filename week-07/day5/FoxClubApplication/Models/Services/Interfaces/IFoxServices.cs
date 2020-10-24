using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxClubApplication.Models.Services.Interfaces
{
    public interface IFoxServices
    {
        void AddFox(Fox fox);
        Fox GetCurrentFox(string name);
        void ChangeNutrition(string food, string drink);
    }
}
