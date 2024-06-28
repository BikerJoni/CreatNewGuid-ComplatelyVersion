using System;
using TextCopy;

namespace CreatNewGuid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            do
            {
                string stringFildGuid = Guid.NewGuid().ToString();
                Console.WriteLine(stringFildGuid);
                TextCopy.ClipboardService.SetText(stringFildGuid);

                Console.WriteLine("do you want another Guid ? (yes or press any bottom to exit )");
                userInput = Console.ReadLine();
            }
            while (userInput == "yes");

        }
    }
}

