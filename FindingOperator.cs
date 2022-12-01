System.Console.Write("Number 1: ");
int number1 = Convert.ToInt32(Console.ReadLine()!);

System.Console.Write("Number 2: ");
int number2 = Convert.ToInt32(Console.ReadLine()!);

System.Console.Write("Result: ");
int result = Convert.ToInt32(Console.ReadLine()!);

string op = "";

if(number1+number2 == result && number1 * number2 == result)
{
    System.Console.WriteLine($"Your operation was Plus and also Multiply");
}
else if(number1+number2 == result)
{
    op = "Plus";
    System.Console.WriteLine($"Your operation was {op}");
}
else if(number1-number2 == result)
{
    op = "Minus";
    System.Console.WriteLine($"Your operation was {op}");
}
else if(number1*number2 == result)
{
    op = "Multiply";
    System.Console.WriteLine($"Your operation was {op}");
}
else if(number1 / number2 == result)
{
    op = "Divide";
    System.Console.WriteLine($"Your operation was {op}");
}
else if(number1 % number2 == result)
{
    op = "Modulo";
    System.Console.WriteLine($"Your Operation was {op}");
}
else{Console.Write("Error");}