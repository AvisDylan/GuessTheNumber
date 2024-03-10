Boolean correct = false;
Random random = new Random();
int number1 = random.Next(1, 10);
int level = 1;

Console.WriteLine("Guess a number between 1 & 10");

string input;

while(level == 1)
{
    input = Console.ReadLine();

    if (int.Parse(input) == number1)
    {
        Console.WriteLine("Correct!");
        level++;
    }else if(int.Parse(input) > number1)
    {
        Console.WriteLine("The number is smaller");
    }
    else
    {
        Console.WriteLine("The number is bigger");
    }
}

Console.WriteLine("Guess a number between 1 & 20");
int number2 = random.Next(1, 20);

while (level == 2)
{
    input = Console.ReadLine();

    if (int.Parse(input) == number2)
    {
        Console.WriteLine("Correct!");
        level++;
    }
    else if (int.Parse(input) > number2)
    {
        Console.WriteLine("The number is smaller");
    }
    else
    {
        Console.WriteLine("The number is bigger");
    }
}

Console.WriteLine("Guess a number between 1 & 50");
int number3 = random.Next(1, 50);

while (level == 3)
{
    input = Console.ReadLine();

    if (int.Parse(input) == number3)
    {
        Console.WriteLine("Correct!");
        level++;
    }
    else if (int.Parse(input) > number3)
    {
        Console.WriteLine("The number is smaller");
    }
    else
    {
        Console.WriteLine("The number is bigger");
    }
}

Console.WriteLine("Guess a number between 1 & 100");
int number4 = random.Next(1, 100);

while (level == 4)
{
    input = Console.ReadLine();

    if (int.Parse(input) == number4)
    {
        Console.WriteLine("Correct!");
        level++;
    }
    else if (int.Parse(input) > number4)
    {
        Console.WriteLine("The number is smaller");
    }
    else
    {
        Console.WriteLine("The number is bigger");
    }
}

Console.WriteLine("Guess a number between 1 & 1000");
int number5 = random.Next(1, 1000);

while (level == 5)
{
    input = Console.ReadLine();

    if (int.Parse(input) == number5)
    {
        Console.WriteLine("Correct!");
        level++;
    }
    else if (int.Parse(input) > number5)
    {
        Console.WriteLine("The number is smaller");
    }
    else
    {
        Console.WriteLine("The number is bigger");
    }
}

if(level == 6)
    Console.WriteLine("GGs you won!");

