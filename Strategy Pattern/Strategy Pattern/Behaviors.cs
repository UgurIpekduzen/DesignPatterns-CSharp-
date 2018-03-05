using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Strategy_Pattern
{
    //Fly Behaviors
    public class FlyWithWings : IFlyBehavior { public void fly() { WriteLine("I'm flying!"); } }
    public class FlyNoWay : IFlyBehavior { public void fly() { WriteLine("I can't fly!"); } }
    public class FlyRocketPowered : IFlyBehavior { public void fly() { WriteLine("WHHOOOOOOSSSSSSHHHH !"); } }
    //Quack Behaviors
    public class Quack : IQuackBehavior { public void quack() { WriteLine("Quack quack!"); } }
    public class Squeak : IQuackBehavior { public void quack() { WriteLine("Squeak squeak!"); } }
    public class MuteQuack : IQuackBehavior { public void quack() { WriteLine("<<silence>>"); } }
    //Ovulate Behaviors
    public class OvulateEmpty : IOvulationBehavior { public void ovulate() { WriteLine("Something's wrong, these are empty."); } }
    public class Ovulate : IOvulationBehavior { public void ovulate() { WriteLine("I have 15 or 20 eggs."); } }
    public class OvulateFailure : IOvulationBehavior { public void ovulate() { WriteLine("I can't ovulate."); } }
    //Age Behaviors
    public class YoungDuck : IAgeBehavior { public void age() { WriteLine("I'm young, I'm too vulnerable and cute ^-^"); } }
    public class AdultDuck : IAgeBehavior { public void age() { WriteLine("Oh yes! I can do everything now B)"); } }
    public class OldDuck : IAgeBehavior { public void age() { WriteLine("Oh! I'm too old for this :("); } }
    public class DeadDuck : IAgeBehavior { public void age() { WriteLine("I'm dead :'("); } }
    public class AgeFailure : IAgeBehavior { public void age() { WriteLine("I can't age."); } }
}
