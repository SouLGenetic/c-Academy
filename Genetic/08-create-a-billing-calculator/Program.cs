// Bring in the Billing namespace
using Billing;
// Set up the order
double subTotal = 51.99;
double taxRate = 0.10;
Console.WriteLine("Enter Sub-Total: \n");
subTotal = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("\nEnter Tax Rate(E.G 0.10)");
taxRate = Convert.ToDouble(Console.ReadLine());

// Calculate tax and total
double tax = Calculator.CalculateTax(subTotal, taxRate);
double total = Calculator.CalculateTotal(subTotal, tax);

// Print the receipt
Console.Clear();
Console.WriteLine($"subtotal: {subTotal:C}\ncalculated tax: {tax:C}\ncalculated total:{total:C}");
Console.ReadLine();
