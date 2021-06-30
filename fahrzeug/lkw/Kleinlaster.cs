using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    public abstract class Kleinlaster : Fahrzeug
    {

        // default Konstruktor
        public Kleinlaster() : this(0, "default", "default", "default", 0, 0, 0)
        {
        }

        public Kleinlaster(int ps, string farbe, string kennzeichen, string marke, double kilometerstand, double preisProKm, int miettage)
            : base(ps, farbe, kennzeichen, marke, kilometerstand, preisProKm, miettage)
        {
        }


        public override string fahrzeugTyp()
        {
            return "Kleinlaster";
        }
    }
}
