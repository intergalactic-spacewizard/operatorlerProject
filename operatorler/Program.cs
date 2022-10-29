// See https://aka.ms/new-console-template for more information
using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("işlemli atama");
            int x = 100;
            //işlemli atama
            x /= 5;
            Console.WriteLine(x);
            x = x / 5;
            Console.WriteLine(x);
            //------
            //mantıksal operatörler 
            Console.WriteLine("mantıksal operatörler");
            bool isCompleted = true;
            bool isSuccess = false | isCompleted;
            bool isWriteable = isSuccess & isCompleted;

            if ((isCompleted & isSuccess) && isWriteable)
            {
                Console.WriteLine("writed");
            }
            if ((isCompleted | !isSuccess) && isWriteable)
            {
                isWriteable = !isCompleted && isSuccess;
                if (!isWriteable)
                {
                    Console.WriteLine("is not writeable but writed");
                }
            }

            //----- 
            // ilişkisel operatörler
            Console.WriteLine("ilişkisel operatörler");
            // <, >, >=, <=, ==, !=
            int a = 3;
            int b = 4;
            Boolean b00l = a < b;
            Console.WriteLine(b00l);
            b00l = a < b || (b > a && a < b);
            Console.WriteLine(b00l);
            b00l = a + 2 > b && b - 2 < a;
            Console.WriteLine(b00l);

            //aritmetik operatörler 
            Console.WriteLine("aritmetk operatorler");
            int sayi0 = 5;
            int sayi1 = 10;
            int sonuc = sayi0 * sayi1;
            Console.WriteLine(sonuc);
            Console.WriteLine(sayi0);
            sonuc = sayi1 / sayi0++;
            Console.WriteLine(sonuc);
            Console.WriteLine(sayi0);
            sonuc = sayi1 = sayi0;
            Console.WriteLine(sayi1);
            sonuc = sayi1++;
            Console.WriteLine(sonuc);
            
            // % (mod), ifadeleri böldüktek sonra kalanı gösteren ifade.
            int sonuc2 = 20 % 3;  // 3 * 7 = 3, 6, 9, 12, 15, 18, (21 limitin dışına çıkar) sonuç (kalan) 2 dir;
            Console.WriteLine(sonuc2);

        }
    }
}