using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1.Program
{
    internal class DayProgram : IProgram
    {

        // 윤년 계산
        private static bool IsLeapYear(int year)
        {
            // 윤년의 조건
            // Case 1. 서기 연수가 4로 나누어 떨어지는 해는 윤년으로 한다.
            // Case 2. Case 1의 경우 중 100으로 나누어 떨어지는 해는 !평년으로 한다.
            // Case 3. Case 2의 경우 중 400으로 나누어 떨어지는 해는 다시 윤년으로 한다.
            bool result = false;
            // 4의 배수일때
            //if ((year % 4) == 0)
            //{
            //    result = true;
            //}
            //else
            //{
            //    result = false;
            //}

            //if (result)
            //{
            //    // 100의 배수가 아닐때 또는 400의 배수일때
            //    // 2000년이 여기서 걸림
            //    if ((year % 100) != 0)
            //    {
            //        result = true;
            //    }
            //    else if ((year % 400) == 0)
            //    {
            //        result = false;
            //    }
            //}
            //return result;

            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }


        public void Run()
        {
            Console.WriteLine("년도를 적어주세요: ");
            string value = Console.ReadLine();
            int year = Convert.ToInt32(value);

            if (year >= 1 && year <= 50000)
            {
                if (IsLeapYear(year))
                {
                    Console.WriteLine("윤년이지요.");
                }
                else
                {
                    Console.WriteLine("윤년이 아니지요.");
                }
            }
        }
    }
}
