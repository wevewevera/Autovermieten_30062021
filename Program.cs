using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten
{
    class Program
    {
        static void Main(string[] args)
        {
            var kunden = new List<Kunde>();
            var fahrzeuge = new List<Fahrzeug>();

            while (true)
            {
                for (int i = 0; i < 3; i++) Console.WriteLine();
                Console.WriteLine("Was möchten Sie tun?");
                Console.WriteLine("[1] Kunde anlegen");
                Console.WriteLine("[2] Fahrzeug anlegen");
                Console.WriteLine("[3] Kunden anzeigen");
                Console.WriteLine("[4] Fahrzeug anzeigen");

                Console.Write("> ");
                string eingabe = Console.ReadLine();
                int option;

                try
                {
                    option = Int32.Parse(eingabe);
                }
                catch (Exception)
                {
                    Console.WriteLine("Die Option {0} ist nicht bekannt!", eingabe);
                    continue;
                }

                if (option == 1) erstelleKunde(kunden);
                else if (option == 2) erstelleFahrzeug(fahrzeuge);
                else if (option == 3) kundenAnzeigen(kunden);
                else if (option == 4) fahrzeugeAnzeigen(fahrzeuge);
                else Console.WriteLine("Die Option {0} ist nicht bekannt!", option);
            }

            
        }

        private static void kundenAnzeigen(List<Kunde> kunden)
        {
            foreach (var kunde in kunden)
            {
                Console.WriteLine();
                kunde.ZeigeDetails();
            }
        }


        private static void erstelleFahrzeug(List<Fahrzeug> fahrzeuge)
        {
            Console.Write("Soll das Auto ein PKW sein? (y/n) ");
            bool pkw = Console.ReadLine().ToLower().Equals("y"); 

            Fahrzeug fahrzeug = null;
            if (pkw) 
            {
                Console.Write("Gehört das PKW zu der Ober-/ Mittel-/ Kompaktklasse? (1 - Ober, 2 - Mittel, 3 - Kompakt) ");
                int pkwklasse = int.Parse(Console.ReadLine());
                switch (pkwklasse)
                {
                    case 1:
                    fahrzeug = ErstelleOberklasseBefehl.erstelleOberklasse();
                        break;
                    case 2:
                        fahrzeug = ErstelleMittelklasseBefehl.erstelleMittelklasse();
                        break;
                    case 3:
                        fahrzeug = ErstelleKompaktklasseBefehl.erstelleKompaktklasse();
                        break;
                    default:
                        Console.WriteLine("Die Daten können nicht gespeichert werden, da die Klasse vom Auto nicht stimmt");
                        break;
                }

                //fahrzeug = ErstelleUeber35Befehl.erstelleUeber35(); 
            }
            else 
            {
                Console.Write("Wiegt das Auto mehr als 3,5 Tonnen? (y/n) ");
                bool lkw = Console.ReadLine().ToLower().Equals("y");

                //Fahrzeug fahrzeug;
                if (lkw) fahrzeug = ErstelleUeber35Befehl.erstelleUeber35();
                else fahrzeug = ErstelleBis35Befehl.erstelleBis35(); 
            }

            if (fahrzeug != null)
                fahrzeuge.Add(fahrzeug);
        }

        private static void fahrzeugeAnzeigen(List<Fahrzeug> fahrzeuge)
        {
            foreach (var fahrzeug in fahrzeuge)
            {
                fahrzeug.ZeigeDetails();
                fahrzeug.fahrzeugKlasse();
                fahrzeug.fahrzeugTyp();
                fahrzeug.Rechnung();
            }
        }

        private static void erstelleKunde(List<Kunde> kunden)
        {
            Console.Write("Soll der Kunde ein Privatkunde sein? (y/n) ");
            bool privatKunde = Console.ReadLine().ToLower().Equals("y");

            Kunde kunde;
            if (privatKunde) kunde = ErstellePrivatkundeBefehl.erstellePrivatkunde();
            else kunde = ErstelleFirmenkundeBefehl.erstelleFirmenkunde();

            kunden.Add(kunde);
        }

    }
    
}
