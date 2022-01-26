using System;
using System.Collections.Generic;

namespace Leetcode._1291._Sequential_Digits
{
    public class Solution
    {
        public IList<int> SequentialDigits(int low, int high)
        {
            var Sequens = new List<int>();
         
            for (var pow = Math.Floor(Math.Log10(low)); pow <= Math.Floor(Math.Log10(high)); pow++)
            {
                for (var digit = 1; digit <= 9 - pow; digit++)
                {
                    var num = CalculateNumber(digit, pow);
                    if (num >= low && num <= high)
                    {
                        Sequens.Add(Convert.ToInt32(num));
                    }
                    else if (num > high)
                    {
                        return Sequens;
                    }
                }
            }
            return Sequens;
        }

        private double CalculateNumber(int startDigit, double pow)
        {
            double number = 0.0d;
            if (pow < 0 || startDigit > 9)
            {
                return number;
            }
            number += startDigit * Math.Pow( 10, pow) + CalculateNumber(++startDigit, --pow);
            return number;
        }
    }
}