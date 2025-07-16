using Pattern_Strategy.Ducks;
using Pattern_Strategy.Fly;
using Pattern_Strategy.Qauck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Strategy
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new ExoticDuck());
            ducks.Add(new SimpleDuck());

            ducks.Add(new WooderDuck());
            ducks.Add(new RubberDuck());

            foreach (var duck in ducks)
            {
                duck.Display();
                duck.Swim();               
                duck.Quack();

                duck.Fly();

                Console.WriteLine();
            }


            DuckBase upgradebleDuck = new UpgradableDuck();
            upgradebleDuck.Display();
            upgradebleDuck.Swim();
            upgradebleDuck.Fly();
            upgradebleDuck.Quack();


            upgradebleDuck.SetQuackBehaviour(new ExoticQuack());
               
            upgradebleDuck.SetFlyBehaviour(new FlyWithWings());
            upgradebleDuck.Quack();
            upgradebleDuck.Fly();

            Console.ReadKey();
        }
    }
}
