// Ask for the user's name
Console.WriteLine("What is your name? ");
string name = Console.ReadLine();
// Ask for the user's age
Console.WriteLine("What is your age? ");
string age = Console.ReadLine();
// Display a personalized message that includes both pieces of information
Console.WriteLine($"Nice to meet you, {name.ToUpper()}, aged: {age}");