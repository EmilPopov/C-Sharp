﻿
namespace WarMachines.Models
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine , IMachine,IFighter
    {
        private const double initialHealthPoints = 200;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints,initialHealthPoints)
        {
            this.StealthMode = stealthMode;
        }
        public bool StealthMode { get; private set; }
       

        public void ToggleStealthMode()
        {
            this.StealthMode = !this.StealthMode;
        }
        public override string ToString()
        {
            var baseString = base.ToString();
            var result = new StringBuilder();
            result.Append(baseString);
            result.Append(string.Format(" *Stealth: {0}", this.StealthMode ? "ON" : "OFF"));
            return result.ToString();
        }
    }
}
