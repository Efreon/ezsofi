using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirCraftCarrier
{
    class Aircraft
    {
        protected int maxAmmo;
        protected int currAmmo;
        protected int baseDamage;
        protected int allDamage;
        protected string aircraftType;
        protected bool isPriorityAmmo;

        public int MaxAmmo {get; set;}
        public int CurrAmmo { get; set; }
        public int BaseDamage { get; set; }
        public int AllDamage { get; set; }
        public string AircraftType { get; set; }
        public bool IsPriorityAmmo { get; set; }

        public Aircraft()
        {
            MaxAmmo = 0;
            CurrAmmo = 0;
            BaseDamage = 0;
            AllDamage = 0;
            AircraftType = "";
            IsPriorityAmmo = false;
        }
        public int Fight()
        {
            BaseDamage += BaseDamage * CurrAmmo;
            return (BaseDamage * CurrAmmo);
            CurrAmmo = 0;
        }
        public int Refill(int amount)
        {
            if (amount - (MaxAmmo - CurrAmmo) > 0)
            {
                CurrAmmo += (MaxAmmo - CurrAmmo);
            }
            else
            {
                CurrAmmo += amount;
            }
            return (amount - (MaxAmmo - CurrAmmo));
        }
        public string GetType()
        {
            return AircraftType;
        }

        public string GetStatus()
        {
            return $"Type {AircraftType}, Ammo: {CurrAmmo}, Base Damage: {BaseDamage}, All Damage: {AllDamage}";
        }

        public bool IsPriority()
        {
            return isPriorityAmmo;
        }
    }
}
