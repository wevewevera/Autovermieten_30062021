using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    public class Privatkunde: Kunde
    {
        public Personalien personalien;

        public Privatkunde() : this("default", "default", "default", "default")
        {
        }

        public Privatkunde(string vorname, string nachname, string adresse, string iban) : base(adresse, iban)
        {
            this.personalien = new Personalien(vorname, nachname);
        }

        public override void ZeigeDetails()
        {
            Console.WriteLine("ID: {0} \nAdresse: {1}, \nIBAN: {2},\nName: {3}", this.kID, this.adresse, this.iban, this.personalien);
        }

        public override string kundenTyp()
        {
            return "Privatkunde";
        }
    }
}
