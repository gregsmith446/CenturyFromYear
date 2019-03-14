using System;

namespace CenturyFromYear
{
    class Program
    {
        static void Main(string[] args)
        {
            // to test other years, 
            int result = CenturyFromYear(1700);
            Console.WriteLine(result);
        }
        static int CenturyFromYear(int year)
        {
            if (year % 100 == 0)
            {
                return (year / 100);
            }
            else
            {
                return ((year / 100) + 1);
            }
        }
    }
}
