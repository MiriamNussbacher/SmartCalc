using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartCalc
{
    public static class Calulator
    {

        public static string plus(int a, int b)
        {

            int res= a + b;

            return $"{a}+{b}={res}";
        }
        public static string minus(int a, int b)
        {

            int res = a - b;
            return $"{a}-{b}={res}";
        }
        public static string multiply(int a, int b)
        {

            int res = a * b;
            return $"{a}*{b}={res}";
        }
        public static string divide(int a, int b)
        {

            double res = a / b;
            return $"{a}/{b}={res}";
        }

        //public static string resultBuilder (string Operator, double res)
        //{
        //    return $"{a}{Operator}{b}={res}";
        //}
    }
}
