using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    public class Bis35 : Kleinlaster
    {

        // default Konstruktor
        public Bis35() : this(0, "default", "default", "default", 0, 0, 0)
        {
        }

        public Bis35(int ps, string farbe, string kennzeichen, string marke, double kilometerstand, double preisProKm, int miettage)
            : base(ps, farbe, kennzeichen, marke, kilometerstand, preisProKm, miettage)
        {
        }

        public override string fahrzeugKlasse()
        {
            return "Unter 3,5t";
        }
    }
}
