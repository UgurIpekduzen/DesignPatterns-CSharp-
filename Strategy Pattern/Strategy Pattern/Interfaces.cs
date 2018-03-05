using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public interface IFlyBehavior { void fly(); }
    public interface IQuackBehavior { void quack(); }
    public interface IOvulationBehavior { void ovulate(); }
    public interface IAgeBehavior { void age(); }
}
