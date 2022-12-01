using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryClock3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Afisarea orei, minutului si secundei actuale in format binar (0 si 1):");
            Console.WriteLine();
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;

            string ora = Binary(hour);
            string minut = Binary(minute);
            string secunda = Binary(second);

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($" {ora[i]}  {minut[i]}  {secunda[i]}   {(Math.Pow(2, i))}"); // ora, min, secunda in binar--> puterile lui 2 de la 0 - 5
            }
            Console.WriteLine();
            Console.WriteLine(" O  M  S PuterileLui2");
        }

        private static string Binary(int n)
        {
            List<string> thisList = new List<string>();
            if (n == 0)
                thisList.Add("0");
            int rest;
            while (n != 0)
            {
                rest = n % 2;
                string h = rest.ToString(); 
               thisList.Add(h);
                n /= 2;
            }
            for (int i = 0; i < thisList.Count; i++)
            {
                if (thisList[i].Contains("1"))
                    thisList[i] = "1";
                if (thisList[i].Contains("0"))
                    thisList[i] = "0";
            }
            string x = String.Join("", thisList);
            while (x.Length <= 5)
                x = x + "0";
            return x;
        }
    }
}
