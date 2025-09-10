using System.Security.Cryptography;

internal class Program
{



    private static void Main(string[] args)
    {
        //*2.1
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 3 == 0)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }

        //*2.2
        int b = Convert.ToInt32(Console.ReadLine());

        if (b / 100 != 0 && b % 17 == 0)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }


        //*2.3
        int wiek = Convert.ToInt32(Console.ReadLine());

        if (wiek >= 18)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }


        //*2.4
        int waga = Convert.ToInt32(Console.ReadLine());
        int limit = 20;

        if (waga < limit)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }


        //*2.5
        int j = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());

        if ((j < l && l < k) || (j > l && l > k))
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }




        //*2.6
        int a2 = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());

        if ((Math.Pow(a2, p) - a) % p == 0)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }



        //*2.7
        int v = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());

        if (((v + m) * 3) >= n)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }











        //Karty pracy nr2a
        //*2a.1
        int a1 = Convert.ToInt32(Console.ReadLine());
        int b1 = Convert.ToInt32(Console.ReadLine());

        if ((a1 + b1) % 2 == 0)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }

        //*2a.2
        double a3 = Convert.ToDouble(Console.ReadLine());
        double b3 = Convert.ToDouble(Console.ReadLine());

        if (Math.Sqrt(a3 + b3) > Math.Sqrt(a3 * b3))
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }


        //*2a.3
        double a4 = Convert.ToDouble(Console.ReadLine());
        double b4 = Convert.ToDouble(Console.ReadLine());
        double c4 = Convert.ToDouble(Console.ReadLine());

        if (a4 == b4 || a4 == c4 || b4 == c4)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }



        //*2a.4

        double a5 = Convert.ToDouble(Console.ReadLine());
        double b5 = Convert.ToDouble(Console.ReadLine());
        double c5 = Convert.ToDouble(Console.ReadLine());
        double d5 = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine(Math.Min(Math.Min(a5, b5), Math.Min(c5, d5)));




        //*2a.5

        int a6 = Convert.ToInt32(Console.ReadLine());
        int b6 = Convert.ToInt32(Console.ReadLine());
        int c6 = Convert.ToInt32(Console.ReadLine());


        if (a6 + b6 > c6 && a6 + c6 > b6 && b6 + c6 > a6)
        {
            Console.WriteLine("TAK");
        }
        else
        {

            Console.WriteLine("NIE");
        }

        //*2a.6

        int a7 = Convert.ToInt32(Console.ReadLine());
        int b7 = Convert.ToInt32(Console.ReadLine());
        int c7 = Convert.ToInt32(Console.ReadLine());

        if (!(a7 + b7 > c7 && a7 + c7 > b7 && b7 + c7 > a7))
        {
            Console.WriteLine()
        }

    }
}
