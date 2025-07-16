using Pattern_Strategy.Fly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy.Ducks
{
    public class RubberDuck:DuckBase
    {
        public RubberDuck()
        {
            flyBehaviour = new NoFly();
        }
        public override void Display()
        {
            Console.WriteLine("Hi! I'm an rubber duck.");
        }
    }
}
