namespace Calc.Interfaces
{
    public interface ICalcInterface
    {
        double Sum(double secondNum);
        double Minus(double secondNum);
        double Divide(double secondNum);
        double Multiply(double secondNum);
        double Factorial();
        void PutNum(double firstNum);
        void ClearFirstNum();
    }
}
