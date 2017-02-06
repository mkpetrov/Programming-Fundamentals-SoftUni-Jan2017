using System;
class TrickyStrings
{
    static void Main(string[] args)
    {
        var delimiter = Console.ReadLine();

        var numberOfStrings = int.Parse(Console.ReadLine());

        var result = string.Empty;

        for (int i = 0; i <= numberOfStrings; i++)
        {
            if (i<numberOfStrings-1)
            {
                result += Console.ReadLine();
                result += delimiter;
            }
            else
            {
                result += Console.ReadLine();
            }
        }

        

        Console.WriteLine(result);
    }
}