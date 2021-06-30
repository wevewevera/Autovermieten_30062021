using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    public abstract class Kunde
    {
        private static int currentKundeID;
        // Eigenschaften/Properties
        protected int kID { get; set; }
        public string adresse { get; set; }
        public string iban { get; set; }

        // default Konstruktor
        protected Kunde() : this("default", "default")
        {
        }

        protected Kunde(string adresse, string iban)
        {
            this.kID = GetNextID();
            this.adresse = adresse;
            this.iban = iban;
        }
        
        private static int GetNextID()
        {
            return ++currentKundeID;
        }

        public virtual void ZeigeDetails()
        {
            Console.WriteLine("ID: {0} \nAdresse: {1}, \nIBAN: {2}", this.kID, this.adresse, this.iban);
        }

        public abstract String kundenTyp();

    }



}
