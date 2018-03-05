using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Strategy_Pattern
{
    enum Sex { MALE = 1, FEMALE = 2 };
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
        public IQuackBehavior quackBehavior;
        public IAgeBehavior ageBehavior;
        public IOvulationBehavior ovulationBehavior;
        public int sex, currentAge, adultAge, oldAge;
        protected string introduceYourself;
        public const int lifetimeAsYear = 15;

        public Duck() { }
        public Duck(int currentAge, int adultAge, int oldAge, int sex)
        {
            this.adultAge = adultAge;
            this.oldAge = oldAge;
            this.sex = sex;
            setAge(currentAge);  
        }

        public void performQuack() { quackBehavior.quack(); }
        public void performFly() { flyBehavior.fly(); }
        public void performOvulate() { ovulationBehavior.ovulate(); }
        public void performAge()
        {
            ageBehavior.age();
            setAge(currentAge + 1);
        }

        public void swim() { WriteLine("Swishhhh Swissssshhh!"); }
        public virtual void display()
        {
            WriteLine(introduceYourself + "\nAge:" + currentAge);
            performAge();
            performFly();
            performQuack();
        }
        
        public void setFlyBehavior(IFlyBehavior flyBehavior) { this.flyBehavior = flyBehavior; }
        public void setQuackBehavior(IQuackBehavior quackBehavior) { this.quackBehavior = quackBehavior; }
        public void setAgeBehavior(IAgeBehavior ageBehavior) { this.ageBehavior = ageBehavior; }
        public void setOvulationBehavior(IOvulationBehavior ovulationBehavior) { this.ovulationBehavior = ovulationBehavior; }
        void setAge(int currentAge)
        {
            this.currentAge = currentAge;

            if (sex == (int)Sex.FEMALE)
            {
                if (currentAge < adultAge)
                {
                    setAgeBehavior(new YoungDuck());
                    setOvulationBehavior(new OvulateFailure());
                }
                else if (currentAge >= adultAge && currentAge < oldAge)
                {
                    setAgeBehavior(new AdultDuck());
                    setOvulationBehavior(new Ovulate());
                }
                else if (currentAge >= oldAge && currentAge < lifetimeAsYear)
                {
                    setAgeBehavior(new OldDuck());
                    setOvulationBehavior(new OvulateFailure());
                }
                else
                {
                    setAgeBehavior(new DeadDuck());
                    setOvulationBehavior(new OvulateFailure());
                }
            }
            else
            {
                if (currentAge < adultAge)
                {
                    setAgeBehavior(new YoungDuck());
                    setOvulationBehavior(new OvulateFailure());
                }
                else if (currentAge >= adultAge && currentAge < oldAge)
                {
                    setAgeBehavior(new AdultDuck());
                    setOvulationBehavior(new OvulateFailure());
                }
                else if (currentAge >= oldAge && currentAge < lifetimeAsYear)
                {
                    setAgeBehavior(new OldDuck());
                    setOvulationBehavior(new OvulateFailure());
                }
                else
                {
                    setAgeBehavior(new DeadDuck());
                    setOvulationBehavior(new OvulateFailure());
                }
            }
        }
    }

    public class MallardDuck : Duck
    {
        public MallardDuck(int age, int sex) : base (age, 2, 9, sex)
        {
            setQuackBehavior(new Quack());
            setFlyBehavior(new FlyWithWings());
            introduceYourself = "I'm a Mallard duck!";
        }  
    }
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck(int age, int sex) : base(age, 3, 10, sex)
        {
            setQuackBehavior(new Quack());
            setFlyBehavior(new FlyWithWings());
            introduceYourself = "I'm a Red Head duck!";
        }
    }
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            setQuackBehavior(new Squeak());
            setFlyBehavior(new FlyNoWay());
            setAgeBehavior(new AgeFailure());
            introduceYourself = "I'm a Rubber duck!";
        }
    }
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            setQuackBehavior(new MuteQuack());
            setFlyBehavior(new FlyRocketPowered());
            setAgeBehavior(new AgeFailure());
            introduceYourself = "I'm look like a duck, but I'm not real! Hahahahahaha >:D";
        }
    }
}
