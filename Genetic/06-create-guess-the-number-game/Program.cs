// Set up the game
Random random = new Random();
int secret = random.Next(1,21);
int maxGuess = 12;
int highs = 0;
int lows = 0;
int lastGuess = 0;
int guessCounter = 0;
bool isWinner = false;
bool high = false;
bool low = false;

Console.WriteLine("I'm thinking of a number between 1 and 20!");
Console.WriteLine($"you have {maxGuess} attempts to guess the number, GLHF!");

// Ask the player to guess
while (guessCounter < maxGuess)
{
    guessCounter++;
    Console.Clear();
    Console.WriteLine($"Guess: {guessCounter}\nLast Guess: {lastGuess}");
    Console.WriteLine($"High: {high}\nLow: {low}");
    low = false;
    high = false;
    Console.WriteLine("\nPick a number!: ");
    int curGuess = Convert.ToInt32(Console.ReadLine());
    lastGuess = curGuess;
    // Check the guess and give feedback
if (curGuess == secret)
    {
        Console.Clear();
        Console.WriteLine($"Amazing!\nYou guessed the correct number: {secret}");
        isWinner = true;
        break;
    }
    else if (curGuess < secret)
    {
        Console.WriteLine("Too low...\n");
        low = true;
        lows++;
        Thread.Sleep(1000);
    }
    else
    {
        Console.WriteLine("Too high...\n");
        high = true;
        highs++;
        Thread.Sleep(1000);
    }
}
// Announce the result
while (isWinner)
{
    Console.Clear();
    Console.WriteLine($"Congrats you have won!\nThe number was: {secret}\nStats:");
    Console.WriteLine($"Guesses used: {guessCounter} / {maxGuess}");
    Console.WriteLine($"Times guessed LOW: {lows}");
    Console.WriteLine($"Times guessed HIGH: {highs}");
    Thread.Sleep(10000);
    isWinner = false;

}
if (!isWinner)
{
    Console.Clear();
    Console.WriteLine($"Out of guesses...\nThe number was {secret}");
    Thread.Sleep(15000);
}
