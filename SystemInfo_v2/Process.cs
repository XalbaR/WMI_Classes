using System;
using System.Management;
using System.Diagnostics;

namespace SystemInfo_v2
{
    public static class Process
    {
        public static void Bilgiler(string win32Query, int secilen)
        {
            var query = new ObjectQuery(win32Query);
            var searcher = new ManagementObjectSearcher(query);

            var namesValuesDict = new Dictionary<string, object>();

            var stopwatch = new Stopwatch();
            stopwatch.Start();

            foreach (var obj in searcher.Get())
            {
                foreach (var prop in obj.Properties)
                {
                    var propName = prop.Name;
                    var propValue = prop.Value;
                    if (!namesValuesDict.ContainsKey(propName))
                    {
                        namesValuesDict.Add(propName, propValue);
                    }
                }

                if (stopwatch.ElapsedMilliseconds > 4000) // işlem 4 saniyeden fazla sürerse
                {
                    Console.Write("İşlem 4 saniyeden fazla sürdü. İptal etmek ister misiniz? (E/H): ");
                    var cevap = Console.ReadLine().ToLower();
                    if (cevap == "e")
                    {
                        return; // işlemi iptal et
                    }
                    else
                    {
                        break; // işleme devam et
                    }
                }
            }

            stopwatch.Stop();

            string aciklama = getClassesDescription(secilen);
            Console.WriteLine($"Sınıfın kısa açıklaması: {aciklama,40}\n");

            if (namesValuesDict.Count == 0)
            {
                Console.WriteLine("Bu sınıfta hiç veri yoktu veya bilgi alınamadı.");
            }
            else
            {
                foreach (var kvp in namesValuesDict)
                {
                    Console.WriteLine($"{kvp.Key,-40}: {kvp.Value}");
                }
            }
            finisQuest();
           
        }
         
        static void finisQuest ()
        {
            Console.Write("\nAna listeye dönmek için 'A' tuşuna basın, programdan çıkmak için 'Ç' tuşuna basın: ");
            var input = Console.ReadLine().ToLower();
            if (input == "a")
            {
                Program.Main(new string[0]); // ana menüye dön
            }
            else if (input == "ç")
            {
                Environment.Exit(0); // programı kapat
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Program sonlandırıldı.");
                Environment.Exit(0); // geçersiz seçim, programı kapat
            }
        }
        static string getClassesDescription(int secim)
        {
            string sonuc = "";

            ClassesTurkishDescription ctd = new ClassesTurkishDescription();
            Dictionary<string, string> names = ctd.Descriptions;

            sonuc = names.Values.ElementAt(secim);
            return sonuc;
        }
    }
}
