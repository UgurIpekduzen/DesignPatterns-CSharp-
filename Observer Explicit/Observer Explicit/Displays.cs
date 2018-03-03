using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Observer_Explicit
{
    class Site1 : IObserver
    {
        IObservable curData = null;
        CurrencyInfo readings = new CurrencyInfo();

        public Site1(IObservable newCurrencyData)
        {
            curData = newCurrencyData;
            curData.Register(this);
        }

        void UnRegister() { if (curData != null) curData.UnRegister(this); }

        public void Display() { WriteLine("SITE 1: Gold: " + readings.gold); }

        public void Update(CurrencyInfo newReadings)
        {
            readings = newReadings;
            Display();
        }

    }
    class Site2 : IObserver
    {
        IObservable curData = null;
        CurrencyInfo readings = new CurrencyInfo();

        public Site2(IObservable newCurrencyData)
        {
            curData = newCurrencyData;
            curData.Register(this);
        }

        void UnRegister() { if (curData != null) curData.UnRegister(this); }

        public void Display() { WriteLine("SITE 2: Dolar: " + readings.dolar); }

        public void Update(CurrencyInfo newReadings)
        {
            readings = newReadings;
            Display();
        }
    }
    class Site3 : IObserver
    {
        IObservable curData = null;
        CurrencyInfo readings = new CurrencyInfo();

        public Site3(IObservable newCurrencyData)
        {
            curData = newCurrencyData;
            curData.Register(this);
        }

        void UnRegister() { if (curData != null) curData.UnRegister(this); }

        public void Display() { WriteLine("SITE 3: Euro: " + readings.euro); }

        public void Update(CurrencyInfo newReadings)
        {
            readings = newReadings;
            Display();
        }
    }
}
