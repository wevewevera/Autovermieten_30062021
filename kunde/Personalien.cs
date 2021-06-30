using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    public class Personalien
    {
        public string vorname { get; set; }
        public string nachname { get; set; }

        public Personalien(string vorname, string nachname)
        {
            this.vorname = vorname;
            this.nachname = nachname;
        }

        public override string ToString()
        {
            return this.vorname + " " + this.nachname;
        }
    }
}