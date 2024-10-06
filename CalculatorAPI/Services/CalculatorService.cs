using CalculatorAPI.Interfaces;

namespace CalculatorAPI.Services
{
    public class CalculatorService : ICalculatorService<double>
    {
        // Method to add two numbers
        public double Sum(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }
        // Method to subtract the second number from the first
        public double Difference(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }
        // Method to multiply two numbers
        public double Product(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }
        // Method to divide the first number by the second
        public double Quotient(double firstOperand, double secondOperand)
        {
            if (secondOperand == 0)
                throw new DivideByZeroException("Division by zero is not allowed.");
            return firstOperand / secondOperand;
        }
    }
}
