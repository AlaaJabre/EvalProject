using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test5
{
    class Program
    {
        static void Main(string[] args)
        {
            Call();
            Console.ReadLine();
        }

        private static async void Call()
        {
            var (averageSalary, numberOfEmployee) = await SomeCalculation(0L, 10, 0L == 10L);            
        }

        private static async Task<(int,int)> SomeCalculation(long v1, int v2, bool v3)
        {
            return (1, 2);
        }
    }
}
