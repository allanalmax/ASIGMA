/* namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.Write($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }
} */

/*STRINGS
 * 
 * Console.WriteLine("Hello David!");

string firstFriend = "    Maria    ";
firstFriend = firstFriend.TrimStart();

string secondFriend = "    Scott    ";

string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}.";
Console.WriteLine(friends);
Console.WriteLine(friends.Contains("Scott"));
Console.WriteLine(friends.ToUpper());
Console.WriteLine(friends.Length);
Console.WriteLine(friends.StartsWith("My  "));*/

using System;

class Program
{
    static void Main()
    {
        /*//Strings
        Console.WriteLine("Hello David!");

        string firstFriend = "    Maria    ";
        firstFriend = firstFriend.TrimStart();

        string secondFriend = "    Scott    ";

        string friends = $"My friends are {firstFriend} and {secondFriend.Trim()}.";
        Console.WriteLine(friends);
        Console.WriteLine(friends.Contains("Scott"));
        Console.WriteLine(friends.ToUpper());
        Console.WriteLine(friends.Length);
        Console.WriteLine(friends.StartsWith("My  "));*/

        //Numbers
        int a = 18;
        int b = 6;
        int c = a + b;
        Console.WriteLine(c);

        /*double d = 18.3; // natural type*/
        decimal d = 32.2M; // explicit type
        decimal e = 6.32M;
        decimal f = checked(d + e);
        Console.WriteLine($"The answer is {f}");
    }
}
