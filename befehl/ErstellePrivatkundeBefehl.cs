using System;

namespace Projekt_Autovermieten.befehl
{
    public class ErstellePrivatkundeBefehl
    {
        public static Privatkunde erstellePrivatkunde()
        {
            Console.Write("Geben Sie die Adresse ein: ");
            string adresse = Console.ReadLine();
            Console.Write("Geben Sie die IBAN ein: ");
            string iban = Console.ReadLine();
            Console.Write("Geben Sie den Vornamen ein: ");
            string vorname = Console.ReadLine();
            Console.Write("Geben Sie den Nachnamen ein: ");
            string nachname = Console.ReadLine();

            return new Privatkunde(adresse, iban, vorname, nachname);
        }
    }
}