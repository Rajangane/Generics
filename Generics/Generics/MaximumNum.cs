using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Given 3 Integers Finding Maximum
namespace Generics
{
    public class MaximumNum
    {
        public static int MaximumIntNumber(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                return thirdNum;
            }
            throw new Exception("FirstNumber, SecondNumber and ThirdNumber are same or Maybe 2 Numbers are Same");
        }
        //Float method to find Maximum Number
        public static float MaxFloatNumber(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
            if (secondNum.CompareTo(thirdNum) > 0 && secondNum.CompareTo(firstNum) > 0)
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0)
            {
                return thirdNum;
            }
            throw new Exception("FirstNumber, SecondNumber and ThirdNumber are same or Maybe 2 Numbers are Same");
        }
        //String Method to find Maximum Number
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
               firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
               firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
               secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
               secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
               thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
               thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            throw new Exception("FirstNumber, SecondNumber and ThirdNumber are Same or Maybe 2 Numbers are Same");
        }
    }
}
