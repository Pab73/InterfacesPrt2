using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp30._2
{
    internal class CommissieWerker : Werknemer
    {
        private int _aantal;

        public int Aantal
        {
            get => _aantal;
            set => _aantal = value;
        }

        private decimal _commissie;

        public decimal Commissie
        {
            get => _commissie;
            set => _commissie = value;
        }

        public CommissieWerker(string naam, string voornaam, decimal loon, decimal commissie, int aantal) : base(naam, voornaam, loon)
        {
            Aantal = aantal;
            Commissie = commissie;
        }

        public override decimal Verdiensten()
        {
            return Loon + Aantal * Commissie;
        }

        public override string ToString()
        {
            return $"Werknemer: {Naam} {Voornaam} {Verdiensten():€0.00} - CommissieWerker";
        }
    }
}