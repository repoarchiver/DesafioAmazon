using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{

    /// <summary>
    /// The greatest common divisor (GCD), also called highest common factor (HCF) of N numbers is the largest positive integer that divides all numbers without giving a remainder.
    /// Write an algorithm to determine the GCD of N positive integers.
    /// O maior divisor comum (GCD), também chamado de maior fator comum (HCF) de números N, é o maior inteiro positivo que divide todos os números sem dar um restante.
    /// Escreva um algoritmo para determinar o GCD de N inteiros positivos.
    /// </summary>
    public class GCDCalculator
    {
        public int generalizedGCD(int num, int[] arr)
        {
            num = arr.Length;
            var numberOrdered = System.Linq.Enumerable.ToList(System.Linq.Enumerable.OrderBy(arr, x => x)).ToArray();
            bool found = false;
            int index = 0;
            var div = numberOrdered[index];
            while (!found)
            {
                found = true;
                for (int i = 0; i < num; i++)
                {
                    if (numberOrdered[i] % div != 0)
                    {
                        found = false;
                        break;
                    }
                }

                if (!found)
                    div -= 1;
            }

            return div;
        }
    }
}
