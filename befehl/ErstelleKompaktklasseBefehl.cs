using System;
using System.Collections.Generic;
using System.Text;

namespace Projekt_Autovermieten.befehl
{
    class ErstelleKompaktklasseBefehl
    {
        public static Kompaktklasse erstelleKompaktklasse()
        {
            Console.WriteLine("Geben Sie die Farbe ein");
            string farbe = Console.ReadLine();
            Console.WriteLine("Geben Sie PS ein");
            int ps = int.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie das Kennzeichen ein");
            string kennzeichen = Console.ReadLine();
            Console.WriteLine("Geben Sie die Marke ein");
            string marke = Console.ReadLine();
            Console.WriteLine("Geben Sie Kilometerstand ein");
            double kilometerstand = double.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie den Preis pro Tag ein");
            double preisProTag = double.Parse(Console.ReadLine());
            Console.WriteLine("Geben Sie die Miettage ein");
            int miettage = int.Parse(Console.ReadLine());

            return new Kompaktklasse(ps, farbe, kennzeichen, marke, kilometerstand, preisProTag, miettage);
        }
    }
}
