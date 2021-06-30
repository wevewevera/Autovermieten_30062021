using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    class Kompaktklasse : PKW
    {

        public Kompaktklasse() : this(0, "default", "default", "default", 0, 0, 0)
        {
        }

        public Kompaktklasse(int ps, string farbe, string kennzeichen, string marke, double kilometerstand, double preisProTag, int miettage)
            : base(ps, farbe, kennzeichen, marke, kilometerstand, preisProTag, miettage)
        {
        }

        public override string fahrzeugKlasse()
        {
            return "Kompaktklasse";
        }
    }
}