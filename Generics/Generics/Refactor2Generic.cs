using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Refactoring generic class to take 3 variables of generic type
namespace Generics
{
    public class Refactor2Generic<T> where T : IComparable
    {
        private T first, second, third;
        public Refactor2Generic(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third = third;
        }
        public void findMaximum()
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("The Greatest is : " + first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("The Greatest  is : " + second);
            }
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            {
                Console.WriteLine("The Greatest  is : " + third);
            }
            else
            {
                Console.WriteLine("All are Equal");
            }

        }

    }
}
