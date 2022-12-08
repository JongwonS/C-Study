using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2.Decimal
{
    internal class DecimalProgram : IProgram
    {
        private static bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            if(num == 2)
            {
                return true;
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {

                    return false;
                }
            }
            return true;
        }

        public void Run()
        {
            Console.WriteLine("소수를 찾을 수를 정해주세요");

            String value = Console.ReadLine();
            int num = Convert.ToInt32(value);

            if (IsPrimeNumber(num))
            {
                Console.WriteLine("소수입니다.");
            }
            else
            {
                Console.WriteLine("소수 아니지요");
            }

        }
    }
}
