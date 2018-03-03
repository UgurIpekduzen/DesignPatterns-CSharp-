using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Explicit
{
    interface IObservable
    {
        void Register(IObserver observer);
        void UnRegister(IObserver observer);
        void Notify();
    }
    interface IObserver
    {
        void Display();
        void Update(CurrencyInfo newReadings);
    }
}