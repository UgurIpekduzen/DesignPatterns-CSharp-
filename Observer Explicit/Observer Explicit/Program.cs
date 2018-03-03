using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using static System.Console;
namespace Observer_Explicit
{
    class Program
    {
        static void Main(string[] args)
        {
            CurrencyData curData = new CurrencyData();

            Site1 s1 = new Site1(curData);
            Site2 s2 = new Site2(curData);
            Site3 s3 = new Site3(curData);

            CurrencyInfo readings = new CurrencyInfo();
            readings.gold = 3.5F;
            readings.dolar = 3.8F;
            readings.euro = 4.5F;

            //Update
            curData.UpdateReadings(readings);

            //Update randomly
            Random rand = new Random();
            int whichCur, AddOrSub;
            while (true)
            {
                Thread.Sleep(1000);
                whichCur = rand.Next(3);
                AddOrSub = rand.Next(2);

                switch (whichCur)
                {
                    case 0: readings.gold += (AddOrSub == 0) ? 0.001F : -0.001F; break;
                    case 1: readings.dolar += (AddOrSub == 0) ? 0.001F : -0.001F; break;
                    case 2: readings.euro += (AddOrSub == 0) ? 0.001F : -0.001F; break;
                }
                SetCursorPosition(0, 0);
                curData.UpdateReadings(readings);
            }
        }
    }
}
