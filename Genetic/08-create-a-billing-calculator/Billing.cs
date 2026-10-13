namespace Billing
{
    public static class Calculator
    {
        public static double CalculateTax(double subTotal, double taxRate = 0.10)
        {
            return subTotal * taxRate;
        }
        public static double CalculateTotal(double subTotal, double tax)
        {
            return subTotal + tax;
        }
        // Add the CalculateTax and CalculateTotal methods here
    }
}
