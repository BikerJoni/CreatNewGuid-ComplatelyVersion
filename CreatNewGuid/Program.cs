using System;
using System.Reflection;
using TextCopy;

string userInput;
do
{
    
    Console.WriteLine("Press 1 for new Guid or press 2 for DateTimeOffSet");
    int input = int.Parse(s: Console.ReadLine());
    if (input is 1)
    {
        string stringFildGuid = Guid.NewGuid().ToString();
        Console.WriteLine(stringFildGuid);
        ClipboardService.SetText(stringFildGuid);
        Console.WriteLine("New Guid has been copied");
    }
    else if (input is 2)
    {
        string dateTimeOffSet = DateTimeOffset.UtcNow.ToString();
        Console.WriteLine(dateTimeOffSet);
        ClipboardService.SetText(dateTimeOffSet);
        Console.WriteLine("New DateTimeOffSet has been copied");
    }

    Console.WriteLine("do you want another Guid ? (if yes press + , or any bottom to exit )");
    userInput = Console.ReadLine();
}
while (userInput == "+");
