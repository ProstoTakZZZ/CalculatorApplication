using Calc.Interfaces;

namespace Calc.Biz
{
    public class CCalculator : ICalcInterface
    {
        private double _first_value = 0;
        public void ClearFirstNum()
        {
            _first_value = 0;
        }

        public double Divide(double second_value)
        {
            return _first_value / second_value;
        }

        public double Factorial()
        {
            double k = 1;
            for (int i = 1; i <= _first_value; i++)
            {
                k *= i;
            }
            return k;
        }

        public double Minus(double second_value)
        {
            return _first_value - second_value;
        }

        public double Multiply(double second_value)
        {
            return _first_value * second_value;
        }

        public void PutNum(double second_value)
        {
            _first_value = second_value;
        }

        public double Sum(double second_value)
        {
            return _first_value + second_value;
        }
    }
}
