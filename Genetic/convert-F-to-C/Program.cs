using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Is your input C or F: ");
var input = Console.ReadLine();
input = input.ToLower();

if (input == "f")
{
    // Store a Fahrenheit temperature
    Console.WriteLine("Input temp in F: ");
    string tempFString = Console.ReadLine();
    decimal tempF = Convert.ToDecimal(tempFString);

    // Convert it to Celsius
    decimal tempC = (tempF - 32) * 5 / 9;
    // Display the result
    Console.WriteLine($"{tempF} in Celcius is: {tempC}");
}
else if (input == "c")
{
    // Store a Fahrenheit temperature
    Console.WriteLine("Input temp in C: ");
    string tempCString = Console.ReadLine();
    decimal tempC = Convert.ToDecimal(tempCString);

    // Convert it to Celsius
    decimal tempF = (tempC * 9 / 5) + 32;
    // Display the result
    Console.WriteLine($"{tempC} in Farenheit is: {tempF}");
}
else
{
    Console.WriteLine("PLEASE ENTER A VALID INPUT!: ");
}
