using System;
using System.Globalization;
namespace Loes02
{
        class A1
        {
            static void Main(string[] args)
            {
                     int minuten;
                     double gebühr;
                     char tarif;
                     try
                     {
                         minuten = Int32.Parse(Console.ReadLine());
                         if (minuten <= 100)
                             gebühr = 3.99;
                         else gebühr = 3.99 + (minuten - 100) * 9.9/100;
                         //b
                         tarif = Char.Parse(Console.ReadLine());
                         switch(tarif)
                         {
                             case 'S': gebühr = gebühr + 6;break;
                             case 'M': gebühr = gebühr + 11; break;
                             case 'L': gebühr = gebühr + 20; break;
                         }
                         Console.WriteLine(minuten+" "+tarif+" "+gebühr);
                     }
                     catch (FormatException)
                     {
                         Console.WriteLine("Falsches Format");
                     }
                     catch (OverflowException)
                     {
                         Console.WriteLine("Überschreitung des Wertebereichs");
                     }
                     catch (Exception)
                     {
                         Console.WriteLine("Fehler");
                     }
             

            }
        }
}
