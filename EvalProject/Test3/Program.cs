using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Humanoid(new Dancing());
            Console.WriteLine(john.ShowSkill());

            var alex = new Humanoid(new Cooking());
            Console.WriteLine(alex.ShowSkill());

            var bob = new Humanoid();
            Console.WriteLine(bob.ShowSkill());
        }
    }
}
