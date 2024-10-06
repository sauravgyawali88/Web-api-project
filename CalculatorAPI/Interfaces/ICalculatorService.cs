namespace CalculatorAPI.Interfaces
{
    public interface ICalculatorService<T>
    {
        T Sum(T firstOperand, T secondOperand);
        T Difference(T firstOperand, T secondOperand);
        T Product(T firstOperand, T secondOperand);
        T Quotient(T firstOperand, T secondOperand);
    }
}
