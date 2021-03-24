using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp30._2
{
#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()

    internal class Werknemer
#pragma warning restore CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
    {
        public Werknemer()
        {
            Loon = 0;
            Naam = "";
            Voornaam = "";
        }

        public Werknemer(string naam, string voornaam, decimal loon)
        {
            Naam = naam;
            Voornaam = voornaam;
            Loon = loon;
        }

        private decimal _loon;

        public decimal Loon
        {
            get => _loon;
            set => _loon = value;
        }

        private string _naam;

        public string Naam
        {
            get => _naam;
            set => _naam = value;
        }

        private string _voornaam;

        public string Voornaam
        {
            get => _voornaam;
            set => _voornaam = value;
        }

        public override bool Equals(object obj)
        {
            return false;
        }

        public virtual decimal Verdiensten()
        {
            return Loon;
        }

        public override string ToString()
        {
            return $"Werknemer: {Naam} {Voornaam} {Loon:€0.00}";
        }
    }

    class VolledigeNaamComparer : IComparer<Werknemer>
    {
        public int Compare(Werknemer x, Werknemer y)
        {
            return x.Naam.CompareTo(y.Naam);
        }
    }
    class VerdienstenComparer : IComparer<Werknemer>
    {
        public int Compare(Werknemer x, Werknemer y)
        {
            return x.Loon.CompareTo(y.Loon);
        }
    }
}