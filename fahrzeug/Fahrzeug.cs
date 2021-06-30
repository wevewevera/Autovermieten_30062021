using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    public abstract class Fahrzeug
    {
        private static int currentFahrzeugID;
        // Eigenschaften/Properties
        protected int ID { get; set; }
        public string kennzeichen { get; set; }
        public string marke { get; set; }
        public string farbe { get; set; }
        public double preisProTag { get; set; }
        public double kilometerstand { get; set; }
        public int miettage { get; set; }
        public int ps { get; set; }

        public Kunde zugewiesenerKunde { get; set; }
      
        //// "Hat ein" Beziehung
        //// Objekt Komposition
        //AutoIDInfo autoIDInfo = new AutoIDInfo();
        //public void SetAutoIDInfo(int idNum, string besitzer)
        //{
        //    autoIDInfo.IDNum = idNum;
        //    autoIDInfo.Besitzer = besitzer;
        //}

        //public void GetAutoIDInfo()
        //{
        //    Console.WriteLine("Das Auto hat die ID: {0} und den Besitzer {1}", autoIDInfo.IDNum, autoIDInfo.Besitzer);
        //}

        // default Konstruktor
        protected Fahrzeug() : this(0, "default", "default", "default", 0, 0, 0)
        {
        }

        protected Fahrzeug(int ps, string farbe, string kennzeichen, string marke, double kilometerstand, double preisProTag, int miettage)
        {
            this.ID = GetNextID();
            this.ps = ps;
            this.farbe = farbe;
            this.kennzeichen = kennzeichen;
            this.marke = marke;
            this.kilometerstand = kilometerstand;
            this.preisProTag = preisProTag;
            this.miettage = miettage;
        }

        private int GetNextID()
        {
            return ++currentFahrzeugID;
        }

        public virtual void ZeigeDetails()
        {
            Console.WriteLine("ID: {0} \nFarbe: {1}, \nPS: {2}, \nKennzeichen:{3}, \nMarke:{4}, \nKilometerstand:{5}, \nPreisproKm:{6}, \nMiettage:{7}, \nKlasse:{8}, \nTyp:{9}", this.ID, this.farbe, this.ps, 
                this.kennzeichen, this.marke, this.kilometerstand, this.preisProTag, this.miettage, this.fahrzeugKlasse(), this.fahrzeugTyp());
            Console.WriteLine(Rechnung());
        }

        public virtual Rechnung Rechnung()
        {
            return new Rechnung(this);
        }

        public abstract string fahrzeugTyp();

        public abstract string fahrzeugKlasse();
    }
}
