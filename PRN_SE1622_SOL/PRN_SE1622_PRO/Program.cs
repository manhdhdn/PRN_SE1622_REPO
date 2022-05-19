namespace fptedu.se1622;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Everything start from Hello, World!");

        //declare
        /*Console.Write($"Enter x: ");
        int x = int.Parse(Console.ReadLine());
        Console.Write($"Enter y: ");
        int y = int.Parse(Console.ReadLine());

        var salary = "abc"; //System.Double (CTS) double
        Console.WriteLine(salary.GetType());

        dynamic age = 20;
        age = true;

        Console.WriteLine($"Sum of {x} and {y}: {Sum(x, y)}");*/
        //Console.WriteLine(args[0]);

        int i = 1;
        Console.WriteLine(i++);
        Console.WriteLine(i);
        Console.WriteLine(++i);
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}