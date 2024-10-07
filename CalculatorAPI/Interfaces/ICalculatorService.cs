namespace CalculatorAPI.Interfaces
{
    public interface ICalculatorService<T>
    {
        // This interface defines basic arithmetic operations (Sum, Difference, Product, Quotient) for two operands of type T.
       // Each method accepts two operands and returns the result of the respective operation.
        T Sum(T firstOperand, T secondOperand);
        T Difference(T firstOperand, T secondOperand);
        T Product(T firstOperand, T secondOperand);
        T Quotient(T firstOperand, T secondOperand);
    }
}
