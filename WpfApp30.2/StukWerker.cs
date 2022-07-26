﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp30._2
{
    internal class StukWerker : Werknemer
    {
        private int _aantal;

        public int Aantal
        {
            get => _aantal;
            set => _aantal = value;
        }

        public StukWerker(string naam, string voornaam, decimal loon, int aantal) : base(naam, voornaam, loon)
        {
            Aantal = aantal;
        }

        public override decimal Verdiensten()
        {
            return Loon * Aantal;
        }

        public override string ToString()
        {
            return $"Werknemer: {Naam} {Voornaam} {Verdiensten():€0.00} - Stukwerker";
        }
    }
}