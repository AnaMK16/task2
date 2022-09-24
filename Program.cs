using System.Collections;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    { /* კომპილაციის ეტაპები :
       * 1.c# code
       2.c# compiler 
        3.common intermediate language (CIL)
        4. common language runtime (CLR) 
        5.Machine code */
        //task 2 
        
        Console.WriteLine("enter first number");
        double first = Double.Parse(Console.ReadLine());
        Console.WriteLine("enter second number");
        double second = Double.Parse(Console.ReadLine());
        double y = first + second;
        double z = first - second;
        double m = first * second;
        Console.WriteLine($"sum :{y}, substraction {z}, product {m}");
        //task 3 
        Console.WriteLine("enter first number");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number");

        int second = int.Parse(Console.ReadLine());

        int area = first * second;
        int perimeter = 2*(first + second);

        Console.WriteLine(area);
        Console.WriteLine(perimeter); 

        //task4
        Console.WriteLine("enter first number");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number");

        int second = int.Parse(Console.ReadLine());
        Console.WriteLine("enter third number");
        int third  = int.Parse(Console.ReadLine());

        List<int> list1 = new List<int>();
        list1.Add(first);
        list1.Add(second);
        list1.Add(third);
        

        list1.Sort();
        foreach(int i in list1)
        {
            Console.WriteLine(i);
        }





    }
}