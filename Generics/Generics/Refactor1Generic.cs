using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Refactoring all three to one generic method
namespace Generics
{
    public class Refactor1Generic
    {
        public T findMaximum<T>(T first, T second, T third) where T : struct, IComparable<T>
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("The Maximum is : " + first);
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("The Maximum is : " + second);
                return second;
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {

                Console.WriteLine("The Maximum is: " + third);
                return third;
            }
            return default;
        }
    }
}
