using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp30._2
{
    internal class UurWerker : Werknemer
    {
        private double _uren;

        public double Uren
        {
            get => _uren;
            set => _uren = value;
        }

        public UurWerker(string naam, string voornaam, decimal loon, int aantalUren) : base(naam, voornaam, loon)
        {
            Uren = aantalUren;
        }

        public override decimal Verdiensten()
        {
            return Loon * (decimal)Uren;
        }

        public override string ToString()
        {
            return $"Werknemer: {Naam} {Voornaam} {Verdiensten():€0.00} - UurWerker";
        }
    }
}