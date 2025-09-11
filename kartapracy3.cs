using System.Security.Cryptography;
using System.Security.Principal;

internal class Program
{

    private static void Main(string[] args)
    {
        //3.1
        for (int i = 100; i < 1000; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine(i);
            }
        }
        //3.2
        for (int i = 100; i < 1000; i++)
        {
            if (i % 15 == 0)
            {
                Console.WriteLine(i);
            }
        }
        //3.3

        int a = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i < 100; i++)
        {
            if (a % i == 0)
            {
                Console.WriteLine(i);
            }
        }
        //3.4
        int sum = 0;
        for (int i = 10; i <= 99; i++)
        {
            sum += i;

        }
        Console.WriteLine(sum);


        ////3.5
        int n = Convert.ToInt32(Console.ReadLine());
        int h = 1;
        string input = Console.ReadLine();

        List<long> list1 = input.Split(' ').Select(long.Parse).ToList();


        list1.Sort();
        for (int i = 0; i < n; i++)
        {
            if (h == list1[i])
            {
                h = (int)list1[i];
                Console.WriteLine(h);
            }
            else
            {
                Console.WriteLine(h);
                break;

            }
        }



        //3.6
        List<ulong> list = new List<ulong> { 0, 1 };
        for (int i = 0; i <= 100; i++)
        {
            list.Add(list[i] + list[i + 1]);

        }
        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);

        }

    }
}
