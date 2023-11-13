using ConsoleAppTesting;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your name?");
        var nameInput = Console.ReadLine();
        Console.WriteLine($"hello there, {nameInput}");
        Console.WriteLine("What class do you want to be proficient in?");

        PlayerClasses playerClasses = new PlayerClasses();
        playerClasses.DisplayClasses();
        string chosenClass = playerClasses.ChooseClass();
        Console.WriteLine($"well I guess I should Welcome you, {nameInput} I see you are a novice {chosenClass} go to the guild over there and register proper.");

        
    }
}