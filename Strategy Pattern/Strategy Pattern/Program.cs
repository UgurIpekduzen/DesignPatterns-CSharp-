using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Strategy_Pattern
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck(8, 1);
            mallard.display();
            mallard.setFlyBehavior(new FlyRocketPowered());
            // FlyRocketPowered class is inherited from IFlyBehavior interface.
            // Shortly, they have the same attributes. So the descendent can be use as the ancestor.
            WriteLine();
            mallard.performFly();
            mallard.swim();
            WriteLine();

            mallard.performOvulate();
            WriteLine();
            mallard.display();
            WriteLine();

            Duck redHead = new RedHeadDuck(2, 2);
            redHead.display();
            redHead.performOvulate();
            WriteLine();
            redHead.display();
            redHead.performOvulate();
            WriteLine();

            Duck rubber = new RubberDuck();
            rubber.display();
            WriteLine();

            Duck decoy = new DecoyDuck();
            decoy.display();
            WriteLine();

            Duck redHead2 = new RedHeadDuck(14 , 1);
            redHead2.display();
            WriteLine();
            redHead2.display();
        }
    }
}
