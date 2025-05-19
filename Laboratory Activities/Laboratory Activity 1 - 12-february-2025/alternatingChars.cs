using System;

class AlternatingChars
{
    static void Main()
    {
        Console.Write("First character: ");
        char firstChar = Console.ReadLine()[0];

        Console.Write("Second character: ");
        char secondChar = Console.ReadLine()[0];
        
        Console.Write("Enter size: ");
        int size = int.Parse(Console.ReadLine());

        for (int i = 1; i <= size; i++)
        {
            for (int h = 1; h < i; h++)
            {
                Console.Write("-");
            }

            char toPrint = (i % 2 == 1) ? firstChar : secondChar;
            Console.Write(toPrint);
            
            Console.WriteLine();
        }
    }
}

