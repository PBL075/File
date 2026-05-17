using System;
using System.IO;

namespace ss_file
{
    class Program
    {
        static void Main()
        {
            string nume = "scrisoare.txt";
            string text = "buna ziua!!";

            File.WriteAllText (nume , text);

            if (File.Exists(nume))
            {
                string textul = File.ReadAllText(nume);
                Console.WriteLine(textul);
            }

            
        }
    }
}