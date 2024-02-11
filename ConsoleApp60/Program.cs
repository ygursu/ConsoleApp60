using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace switchcasegunhaftaicihaftasonu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Lütfen bir gün giriniz");
            string gun = Console.ReadLine();

            switch (gun)
            {

                case "pazartesi": Console.WriteLine("Hafta içi"); break;
                case "salı": Console.WriteLine("Hafta içi"); break;
                case "çarşamba": Console.WriteLine("Hafta içi"); break;
                case "perşembe": Console.WriteLine("Hafta içi"); break;
                case "cuma": Console.WriteLine("Hafta içi"); break;
                case "cumartesi": Console.WriteLine("Hafta sonu"); break;
                case "pazar": Console.WriteLine("Hafta sonu"); break;
                default: Console.WriteLine("Böyle bir gün yok! hafta içi veya hafta sonu olduğu bulunamaz"); break;
            }

            Console.ReadLine();

        }
    }
}
