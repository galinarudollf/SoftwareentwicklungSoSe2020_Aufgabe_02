using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        string[] namen = new string[]{"Dorothea Wierer",
            "Tiril Eckhoff",
            "Denise Herrmann",
            "Hanna Öberg",
            "Marte Olsbu Røiseland",
            "Franziska Preuß",
            "Ingrid Landmark Tandrevold",
            "Julia Simon",
            "Justine Braisaz",
            "Lisa Vittozzi"};
        int index = 0;
        foreach (string s in namen) Console.WriteLine(s);
        do   
            {
                try
                {
                    index = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(namen[index]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("FormatFehler");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index nicht vorhanden");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
        } while (index >= 0);
     }
}


