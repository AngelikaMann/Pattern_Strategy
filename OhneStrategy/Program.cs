using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OhneStrategy.Ducks;

namespace OhneStrategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubberDuck());


            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();
                if (duck is IQuackable)
                (duck as IQuackable).Quack();
                if (duck is IFlyable)
                (duck as IFlyable).Fly();               
            }   
        
        }
    }
}
