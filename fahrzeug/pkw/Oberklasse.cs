using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;


namespace Projekt_Autovermieten
{
    class Oberklasse : PKW
    {

        // default Konstruktor
        public Oberklasse() : this(0, "default", "default", "default", 0, 0, 0)
        {
        }

        public Oberklasse(int ps, string farbe, string kennzeichen, string marke, double kilometerstand, double preisProTag, int miettage)
            : base(ps, farbe, kennzeichen, marke, kilometerstand, preisProTag, miettage)
        {
        }

        public override string fahrzeugKlasse()
        {
            return "Oberklasse";
        }
    }
}
