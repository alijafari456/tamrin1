using System;

class Program
{
    static void Main()
    {
        int totalVanill = 0, totalChocolati = 0, totalTotfarangi = 0;
        int vanillPrice = 5000, chocolatiPrice = 6000, totfarangiPrice = 5500;
        int totalIncome = 0;

        Console.Write("chand moshtari omadadn");
        int customerCount = int.Parse(Console.ReadLine());

        for (int i = 1; i <= customerCount; i++)
        {
            Console.WriteLine($"\nmoshtari shomareh {i}:");

            Console.Write("chand vanili forokhti ");
            int v = int.Parse(Console.ReadLine());

            Console.Write("chand chocolati forokhti ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("chand totfarangi forokhti ");
            int t = int.Parse(Console.ReadLine());

            // جمع فروش برای هر طعم
            totalVanill += v;
            totalChocolati += s;
            totalTotfarangi += t;

            // جمع درآمد کل
            totalIncome += (v * vanillPrice) + (s * chocolatiPrice) + (t * totfarangiPrice);
        }

        // نمایش خروجی بعد از گرفتن اطلاعات همه مشتری‌ها
        Console.WriteLine($"\nforosh emroz: {totalIncome} toman");
        Console.WriteLine($"vanili forokhteh shodeh: {totalVanill} add");
        Console.WriteLine($"chocolati forokhteh shodeh: {totalChocolati} add");
        Console.WriteLine($"totfarangi forokhteh shodeh: {totalTotfarangi} add");

        int totalAll = totalVanill + totalChocolati + totalTotfarangi;
        Console.WriteLine($"kol bastani hay ke forokhti: {totalAll}add");

        // پیدا کردن بیشترین فروش
        int maxSold = Math.Max(totalVanill, Math.Max(totalChocolati, totalTotfarangi));

        Console.Write("mahbob tarin bastani: ");
        bool printed = false;

        if (totalVanill == maxSold)
        {
            Console.Write("vanili");
            printed = true;
        }

        if (totalChocolati == maxSold)
        {
            if (printed) Console.Write(" va ");
            Console.Write("chocolati");
            printed = true;
        }

        if (totalTotfarangi == maxSold)
        {
            if (printed) Console.Write(" va ");
            Console.Write("totfarangi");
        }

        Console.WriteLine(" (bishtarin forosh)");
    }
}