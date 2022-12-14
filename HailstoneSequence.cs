//Hailstone sequence

Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine()!);

Console.Write($"{number}: {number} ");

int counter = 0;

while (number != 1)
{
    if (number % 2 == 0)
    {
        number = number / 2;
    }
    else
    {
        number = (number * 3) + 1;
    }

    Console.Write(number + " ");

    counter++;
}

Console.WriteLine();
Console.WriteLine($"The length of the sequence is {counter}");