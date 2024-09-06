namespace meinPrüfungskalender
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ihre anstehenden Prüfungen");
            Console.WriteLine("Geben sie ein Monat und Jahr ein(mm, yyyy): ");
            string eingabe = Console.ReadLine();
            if (eingabe 
            {
                Console.WriteLine();
            

            DateTime Prüfung1 = new DateTime(2024, 9, 6, 13, 05, 00);
            DateTime Prüfung2 = new DateTime(2024, 9, 11, 09, 30, 00);
            DateTime Prüfung3 = new DateTime(2024, 9, 17, 14, 00, 00);
            DateTime Prüfung4 = new DateTime(2024, 9, 19, 07, 45, 00);
            DateTime Prüfung5 = new DateTime(2024, 9, 19, 09, 30, 00);
            DateTime fantasyExam = new DateTime(2024, 11, 19, 09, 30, 00);

                Console.WriteLine();
            Console.Write("Deutsch Prüfung: ");
            Console.Write(Prüfung1.ToString("dddd "));
            Console.WriteLine(Prüfung1);
            Console.Write("Mathe Prüfung Potenzen: ");
            Console.Write(Prüfung2.ToString("dddd "));
            Console.WriteLine(Prüfung2);
            Console.Write("Französich Grammatik Prüfung: ");
            Console.Write(Prüfung3.ToString("dddd "));
            Console.WriteLine(Prüfung3);
            Console.Write("Sfrw Prüfung: ");
            Console.Write(Prüfung4.ToString("dddd "));
            Console.WriteLine(Prüfung4);
            Console.Write("Deutsch Kurzgeschichten: ");
            Console.Write(Prüfung5.ToString("dddd "));
            Console.WriteLine(Prüfung5);
        }
    }
}
