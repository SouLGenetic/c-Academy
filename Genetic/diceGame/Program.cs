// Roll the dice
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

// Display the roll and total
Console.WriteLine($"dice rolls: {roll1} || {roll2} || {roll3} || Total: {total}");
Console.WriteLine("\nLoading Results..");
await Task.Delay(2500);
Console.Clear();

// Award a bonus for doubles or triples
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine($"Congrats you rolled triple {roll1}'s! \nhave a bonus 6 pts");
        total = total + 6;
    }
    else
    {
        Console.WriteLine("Congrats you rolled doubles!\nhave a bonus 2 pts");
        total = total + 2;
    }
}
// Display the final result
Console.WriteLine($"Your Total: {total} pts");
if (total >= 16)
{
    Console.WriteLine("you win a new house!");
}
else if (total >= 12)
{
    Console.WriteLine("you win a new car!");
} else if (total >= 7)
{
    Console.WriteLine("you win a gift voucher!");
}
else
{
    Console.WriteLine("better luck next time...Loser!");
}
Console.ReadLine();