
using System;
    class Program

    {
        static void Main(string[] args)
        {
            int jahr;
            try
            {
                //int jahr = int.Parse(args[0]);//Projekt/Eigenschaften/Debuggen/Anwendungargumente
                jahr = Int32.Parse(Console.ReadLine());
                do
                {
                    if (jahr != 0)
                    {
                        if (jahr % 400 == 0) Console.WriteLine("Schaltjahr");
                        else if (jahr % 100 == 0) Console.WriteLine("kein Schaltjahr");
                        else if (jahr % 4 == 0) Console.WriteLine("Schaltjahr");
                        else Console.WriteLine("kein Schaltjahr");
                        jahr = Int32.Parse(Console.ReadLine());
                    }
                } while (jahr != 0);
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
