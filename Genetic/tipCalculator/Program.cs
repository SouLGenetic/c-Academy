// Collect the bill amount and tip percentage
Console.WriteLine("Enter Bill total: ");
var billString = Console.ReadLine();
decimal billTotal = Convert.ToDecimal(billString);
Console.WriteLine("Enter tip percentage: ");
var tipString = Console.ReadLine();
decimal tipPercent = Convert.ToDecimal(tipString);

// Display the entered values
Console.WriteLine($"\nBill Total: ${billTotal}");
Console.WriteLine($"Tip Percentage: {tipPercent}%");
// Calculate the tip and total
decimal tipAmount = billTotal * (tipPercent / 100);
billTotal = billTotal + tipAmount;

// Display the results
Console.WriteLine($"\nTotal tip: ${tipAmount}");
Console.WriteLine($"\nNew Total: ${billTotal}");
Console.ReadLine();