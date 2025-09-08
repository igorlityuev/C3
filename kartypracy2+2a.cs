using System.Security.Cryptography;

internal class Program
{

    
    
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        if (a % 3 == 0)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }


        int b = Convert.ToInt32(Console.ReadLine());

        if (b / 100 != 0 && b % 17 == 0)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }



        int wiek = Convert.ToInt32(Console.ReadLine());

        if (wiek >= 18)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }



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



        int j = Convert.ToInt32(Console.ReadLine());
        int k = Convert.ToInt32(Console.ReadLine());
        int l = Convert.ToInt32(Console.ReadLine());

        if ( (j<l && l<k) || (j > l && l > k) )
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }





        int a2 = Convert.ToInt32(Console.ReadLine());
        int p = Convert.ToInt32(Console.ReadLine());

        if (())
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }




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

        double a5 = Convert.ToDouble(Console.ReadLine());
        double b5 = Convert.ToDouble(Console.ReadLine());
        double c5 = Convert.ToDouble(Console.ReadLine());
        double d5 = Convert.ToDouble(Console.ReadLine());

        if (a4 == b4 || a4 == c4 || b4 == c4)
        {
            Console.WriteLine("Tak");

        }
        else
        {
            Console.WriteLine("Nie");
        }


    }
}
