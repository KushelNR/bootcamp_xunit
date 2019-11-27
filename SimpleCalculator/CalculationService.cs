using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    public class CalculationService
    {
        public int AddNumber(int number1, int number2)
        {
            return number1 + number2;
        }

        public int DivideNumbers(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException();
            }
            return number1 / number2;
        }
        
        public string GetFullName(string firstName, string LastName)
        {
            return $"{firstName} {LastName}";
        }
    }
}
