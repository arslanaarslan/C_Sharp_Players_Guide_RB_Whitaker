// See https://aka.ms/new-console-template for more information

while (true)
{
    Console.Write("Enter the value: ");
    string inputValue = Console.ReadLine();
    if (int.TryParse(inputValue, out int value))
    {
        Console.WriteLine($"Entered Number is: {value}");
        break;
    }
    else
    {
        Console.WriteLine("Please enter integer number!!!");
    }
}

Console.WriteLine("Program ended.");