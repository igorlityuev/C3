using System.Security.Cryptography;

internal class Program
{

    private static int Sum(int a, int b) {
        
        
      
        return a+b;
    
    }

    
    
    private static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadanie 1 z Kart pracy nr1: "+Sum(a*a,b*b));
        
        
        int c = Convert.ToInt32(Console.ReadLine());
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadanie 2 z Kart pracy nr1: " + (c+b)*(c+b));


        int q = Convert.ToInt32(Console.ReadLine());
        int w = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadanie 3 z Kart pracy nr1: " + Math.Pow((q-w),3));

        int r = Convert.ToInt32(Console.ReadLine());
        int t = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadanie 4 z Kart pracy nr1: " + r*t*y);


        int u = Convert.ToInt32(Console.ReadLine());
        int i = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadanie 5 z Kart pracy nr1: " + 2*(u+i)/5);
        Console.WriteLine("Zadanie 5 z Kart pracy nr1: " + (u+i)*0.4);




        int brutto = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadanie 6 z Kart pracy nr1: " +brutto/1.23);



        int ty = Convert.ToInt32(Console.ReadLine());
        int yt = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Zadanie 6 z Kart pracy nr1: " + ty%yt);
    }
}
