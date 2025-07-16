using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.Qauck
{
    public class SimpleQuack: IQuackable
    {
        public void Quack()
        {
            Console.WriteLine("Quack! Quack!");
        }
    }
}
