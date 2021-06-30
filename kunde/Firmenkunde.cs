using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    public class Firmenkunde: Kunde
    {
        public Personalien repraesentant { get; set; }

        // default Konstruktor
        public Firmenkunde() : this("default", "default", "default", "default")
        {
        }

        public Firmenkunde(string vorname, string nachname, string adresse, string iban) : base(adresse, iban)
        {
            this.repraesentant = new Personalien(vorname, nachname);
        }

        public override void ZeigeDetails()
        {
            Console.WriteLine("ID: {0} \nAdresse: {1}, \nIBAN: {2},\nName: {3}", this.kID, this.adresse, this.iban, this.repraesentant);
        }

        public override string kundenTyp()
        {
            return "Firmenkunde";
        }
    }
}



