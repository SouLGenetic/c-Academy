Console.WriteLine("Is your input C or F: ");
var input = Console.ReadLine();

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
else
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