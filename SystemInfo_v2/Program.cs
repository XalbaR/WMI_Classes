using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace SystemInfo_v2
{
    class Program
    {
       public static void Main(string[] args)
        {
            Program.Islemler();
            //ListWmiClasses.List();
        }


        private static void Islemler()
        {
            ClassesTurkishName sınıf = new ClassesTurkishName();
            Dictionary<string, string> names = sınıf.Names;

            Console.WriteLine("WMI sınıfları listeleniyor:");
            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine($"{i + 1}-] {names.Values.ElementAt(i)}");
                //Console.WriteLine($"{i + 1}-] {names.Keys.ElementAt(i)}");
            }

            int choiceInt;
            do
            {
                Console.Write("Detaylarını görmek istediğiniz WMI sınıfının sıra numarasını giriniz: ");
            } while (!int.TryParse(Console.ReadLine(), out choiceInt) || choiceInt < 1 || choiceInt > names.Count);

            string className = names.Keys.ElementAt(choiceInt - 1);
            string classDisplayName = names.Values.ElementAt(choiceInt - 1);
            Console.Clear();
            Console.WriteLine($"\nSeçilen WMI sınıfı: {classDisplayName} ({className})");
            Process.Bilgiler($"select * from {className}", choiceInt - 1);

            Console.Write("\nProgramı sonlandırmak için bir tuşa basın.");
            Console.ReadKey();
        }
    }
}
