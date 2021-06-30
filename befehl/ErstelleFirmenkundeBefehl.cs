using System;
using System.Collections.Generic;
using System.Text;
using Projekt_Autovermieten.befehl;

namespace Projekt_Autovermieten.befehl
{
    public class ErstelleFirmenkundeBefehl
    {
        public static Firmenkunde erstelleFirmenkunde()
        {
            Console.Write("Geben Sie die Adresse ein: ");
            string adresse = Console.ReadLine();
            Console.Write("Geben Sie die IBAN ein: ");
            string iban = Console.ReadLine();
            Console.Write("Geben Sie den Vornamen des Repräsentanten ein: ");
            string vorname = Console.ReadLine();
            Console.Write("Geben Sie den Nachnamen des Repräsentanten ein: ");
            string nachname = Console.ReadLine();

            return new Firmenkunde(adresse, iban, vorname, nachname);
        }

    }
}