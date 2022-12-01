//FizzBuzz

System.Console.Write("Until how much: ");
int n = Convert.ToInt32(Console.ReadLine()!);

System.Console.Write("Enter the first Multiply: ");
int a = Convert.ToInt32(Console.ReadLine()!);

System.Console.Write("Enter the second Multiply: ");
int b = Convert.ToInt32(Console.ReadLine()!);



for (int i = 1; i <= n; i++)
{
    if(i % a == 0 && i % b == 0)
    {
        System.Console.Write("FizzBuzz ");
    }
    else if(i % a == 0)
    {
        System.Console.Write("Fizz " );
    }
    else if(i % b == 0)
    {
        System.Console.Write("Buzz " );
    }
    else
    {
        System.Console.Write($"{i} ");
    }
}