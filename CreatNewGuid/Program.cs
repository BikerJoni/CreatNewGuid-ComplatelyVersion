using System;
using TextCopy;

internal class Program
{
    private static void Main(string[] args)
    {
        string userInput;
        do
        {
            string stringFildGuid = Guid.NewGuid().ToString();
            Console.WriteLine(stringFildGuid);
            string dateTimeOffSet = DateTimeOffset.UtcNow.ToString();
            Console.WriteLine(dateTimeOffSet);
            ClipboardService.SetText($" {stringFildGuid} {dateTimeOffSet}");

            Console.WriteLine("do you want another Guid ? (if yes press + , or any bottom to exit )");
            userInput = Console.ReadLine();
        }
        while (userInput == "+");
    }
}