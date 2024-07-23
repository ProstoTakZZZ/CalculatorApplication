using Calc.Biz;

namespace Calc
{
    public partial class Calculator : Form
    {
        enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        CCalculator calc;
        bool btnEnabled = true;
        Operation operation;
        public Calculator()
        {
            InitializeComponent();

            calc = new();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "1";
            LeftZeroRemover();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "2";
            LeftZeroRemover();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "3";
            LeftZeroRemover();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "4";
            LeftZeroRemover();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "5";
            LeftZeroRemover();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "6";
            LeftZeroRemover();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "7";
            LeftZeroRemover();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "8";
            LeftZeroRemover();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            calcDisplay.Text += "9";
            LeftZeroRemover();
        }

        private void button0_Click(object sender, EventArgs e)
        {

            LeftZeroRemover();
            calcDisplay.Text += "0";
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            double number = GetResult(operation);
            calcDisplay.Text = number % 1 == 0 ? number.ToString("N0") : number.ToString("N2");

            calc.ClearFirstNum();
            BtnsEnable();

            btnEnabled = true;
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            if (CheckEnabledBtns())
            {
                calc.PutNum(Convert.ToDouble(calcDisplay.Text));
                btn_Multiply.Enabled = false;
                btnEnabled = false;
                operation = Operation.Multiply;

                calcDisplay.Text = "0";
            }
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            if (CheckEnabledBtns())
            {
                calc.PutNum(Convert.ToDouble(calcDisplay.Text));
                btn_Divide.Enabled = false;
                btnEnabled = false;
                operation = Operation.Divide;

                calcDisplay.Text = "0";
            }

        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (CheckEnabledBtns())
            {
                calc.PutNum(Convert.ToDouble(calcDisplay.Text));
                btn_Minus.Enabled = false;
                btnEnabled = false;
                operation = Operation.Subtract;

                calcDisplay.Text = "0";
            }
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (CheckEnabledBtns())
            {
                calc.PutNum(Convert.ToDouble(calcDisplay.Text));
                btn_Plus.Enabled = false;
                btnEnabled = false;
                operation = Operation.Add;

                calcDisplay.Text = "0";
            }
        }

        private void RemoveAll_Click(object sender, EventArgs e)
        {
            calc.ClearFirstNum();
            BtnsEnable();

            calcDisplay.Text = "0";
        }


        private void btn_Dot_Click(object sender, EventArgs e)
        {
            if ((calcDisplay.Text.IndexOf(".") == -1))
                calcDisplay.Text += ".";
        }

        private void btn_Factorial_Click(object sender, EventArgs e)
        {
            if (CheckEnabledBtns())
            {
                
                double number = Convert.ToDouble(calcDisplay.Text);
                bool isInteger = number == Math.Truncate(number);  //Math.Truncate возвращает целую часть числа с плавающей точкой. 

                if (isInteger && number >= 0.0)
                {

                    calc.PutNum((int)number);                       //запоминаем значение
                    string res = calc.Factorial().ToString();
                    if (res.Length < 15)
                    {
                        calcDisplay.Text = res;
                    }
                    else
                    {
                        calcDisplay.Text = "∞";
                    }

                    calc.ClearFirstNum();                           //очищаем значение

                    BtnsEnable();
                }
                else { MessageBox.Show("Нужно целое число больше -1."); }
            }

        }

        private void LeftZeroRemover()
        {

            if (calcDisplay.Text.IndexOf("∞") != -1)
                calcDisplay.Text = calcDisplay.Text.Substring(0, calcDisplay.Text.Length - 1);

            if (calcDisplay.Text != "" && calcDisplay.Text[0] == '0' && calcDisplay.Text.IndexOf('.') != 1)
            {
                calcDisplay.Text = calcDisplay.Text.Remove(0, 1);
            }

        }

        private bool CheckEnabledBtns()
        {
            if (calcDisplay.Text == "")
                return false;

            if (btnEnabled == false) return false;


            return true;
        }

        private void BtnsEnable()
        {
            btn_Multiply.Enabled = true;
            btn_Divide.Enabled = true;
            btn_Minus.Enabled = true;
            btn_Plus.Enabled = true;
        }


        private double GetResult(Operation op)
        {

            double.TryParse(calcDisplay.Text, out double secondNum);

            double result = op switch
            {
                Operation.Add => calc.Sum(secondNum),
                Operation.Subtract => calc.Minus(secondNum),
                Operation.Multiply => calc.Multiply(secondNum),
                Operation.Divide => calc.Divide(secondNum),
                _ => throw new NotImplementedException()
            };

            return result;
        }
    }
}