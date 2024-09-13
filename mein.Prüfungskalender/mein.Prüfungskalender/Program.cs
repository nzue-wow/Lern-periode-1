using System.ComponentModel.Design;

namespace mein.Prüfungskalender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ihre anstehenden Prüfungen");
            Console.WriteLine("Geben sie ein Monat und Jahr ein(mm, yyyy): ");
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            DateTime lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);



            DateTime Prüfung1 = new DateTime(2024, 9, 17, 14, 00, 00);
            DateTime Prüfung2 = new DateTime(2024, 9, 19, 07, 45, 00);
            DateTime Prüfung3 = new DateTime(2024, 9, 19, 09, 30, 00);
            DateTime Prüfung4 = new DateTime(2024, 10, 14, 23, 59, 59);


            //die Daten in einer Liste speichern
            DateTime[] Prüfungen = { Prüfung1, Prüfung2, Prüfung3, Prüfung4 };

            //Prüfungen in dem Gesuchten monat rausfinden
            foreach (DateTime prüfung in Prüfungen)
            {
                {

                    if (prüfung >= firstDayOfMonth && prüfung <= lastDayOfMonth)
                    {
                        Console.WriteLine(prüfung.ToString("dddd, dd.MM.yyyy HH:mm: "));
                        if (prüfung == Prüfung1) Console.WriteLine("Französich Grammatik Prüfung");
                        else if (prüfung == Prüfung2) Console.WriteLine("Sfrw Prüfung");
                        else if (prüfung == Prüfung3) Console.WriteLine("Deutsch Kurzgeschichten");
                        else if (prüfung == Prüfung4) Console.WriteLine("Abgabe portfolio iap");
                    }


                }





            }
        }
    }
}
