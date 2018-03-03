using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Explicit
{
    struct CurrencyInfo
    {
        public float euro;
        public float dolar;
        public float gold;
    }
    class CurrencyData : IObservable
    {
        List<IObserver> observers = new List<IObserver>();
        CurrencyInfo readings = new CurrencyInfo();

        public void HasChanged() { Notify(); }
        public void UpdateReadings(CurrencyInfo newReadings)
        {
            readings = newReadings;
            HasChanged();
        }
        public void Register(IObserver observer) { observers.Add(observer); }
        public void UnRegister(IObserver observer) { observers.Remove(observer); }
        public void Notify() { foreach (IObserver obs in observers) obs.Update(readings); }
    }
}