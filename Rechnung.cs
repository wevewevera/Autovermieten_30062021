using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    public class Rechnung
    {
        public Fahrzeug fahrzeug { get; set; }

        public Rechnung(Fahrzeug fahrzeug)
        {
            this.fahrzeug = fahrzeug;
            double preis = fahrzeug.miettage * fahrzeug.preisProTag;
            Console.WriteLine("preis={0}", preis);
        }

        public double preisBerechnen()
        {
            double ergebnis = fahrzeug.miettage * fahrzeug.preisProTag;
            return ergebnis;
        }

        //PKW pkw1 = new PKW();
        //public void preisBerechnen()
        //{
        //    double ergebnis = pkw1.miettage * pkw1.preisProTag;
        //    Console.WriteLine("{0}", ergebnis);
        //}
        //Fahrzeug.miettage 
    }
}
