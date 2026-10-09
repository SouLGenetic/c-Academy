// Store a Fahrenheit temperature
Console.WriteLine("Input temp in F: ");
string tempFString = Console.ReadLine();
decimal tempF = Convert.ToDecimal(tempFString);

// Convert it to Celsius
decimal tempC = (tempF - 32) * 5 / 9;
// Display the result
Console.WriteLine($"{tempF} in Celcius is: {tempC}");