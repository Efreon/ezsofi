using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AirCraftCarrier
{
    public class Aircraft
    {
        protected int maxAmmo;
        protected int ammoLevel;
        protected int baseDamage;
        protected int allDamage;
        protected string aircraftType;
        protected bool isPriorityAmmo;

        public virtual int MaxAmmo { get; protected set; }
        public virtual int AmmoLevel { get; set; }
        public virtual int BaseDamage { get; protected set; }
        public virtual int AllDamage { get; protected set; }
        public virtual string AircraftType { get; protected set; }
        public virtual bool IsPriorityAmmo { get; protected set; }

        public Aircraft()
        {
            AmmoLevel = 0;
        }
        public void EmptyAmmo()
        {
            AmmoLevel = 0;
        }
        public int Fight()
        {
            AllDamage += BaseDamage * AmmoLevel;
            EmptyAmmo();
            return (BaseDamage * AmmoLevel);
        }
        public int Refill(int amount)
        {
            if (amount - (MaxAmmo - AmmoLevel) > 0)
            {
                AmmoLevel += (MaxAmmo - AmmoLevel);
            }
            else
            {
                AmmoLevel += amount;
            }
            return (amount - (MaxAmmo - AmmoLevel));
        }
        public string GetType()
        {
            return AircraftType;
        }

        public string GetStatus()
        {
            return $"Type {AircraftType}, Ammo: {AmmoLevel}, Base Damage: {BaseDamage}, All Damage: {AllDamage}";
        }

        public bool IsPriority()
        {
            return isPriorityAmmo;
        }
    }
}
