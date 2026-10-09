// Generate a random number of days until expiration
Random random = new Random();
int daysToExpire = random.Next(12);
int discountPercent = 0;

// Display an expiration message based on the days remaining
if (daysToExpire == 0)
{
    Console.WriteLine("Subscription has expired..");
} else if (daysToExpire == 1)
{
    discountPercent = 20;
    Console.WriteLine($"1 day left to renew!\nhave a {discountPercent}% discount!");
}else if (daysToExpire < 6)
{
    discountPercent = 10;
    Console.WriteLine($"{daysToExpire} days left to renew!\nhave a {discountPercent}% discount!");
} else if (daysToExpire < 11)
{
    Console.WriteLine($"{daysToExpire} days till your subscription expires!\nthink about renewing soon!");
} else
{
    return;
}
// Display a discount message if a discount applies