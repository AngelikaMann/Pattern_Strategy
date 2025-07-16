using Pattern_Strategy.Fly;
using Pattern_Strategy.Qauck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.Ducks
{
    public class WooderDuck:DuckBase
    {
        public WooderDuck()
        {
            flyBehaviour = new NoFly();
            quackBehaviour = new NoQuack();
        }
        public override void Display()
        {
            Console.WriteLine("Hi, I'm a wooder duck!");
        }
    }
}
