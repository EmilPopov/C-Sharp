//Using delegates write a class Timer that can execute certain method at each t seconds.

using System;
using System.Threading;
namespace Timer
{
    class TimerDelegat
    {
        static void Main()
        {
            SetInterval(new Action(() => Console.WriteLine(DateTime.Now)), 1, 10);
        }
        static void SetInterval(Action f, int t,int count)
        {
            while (count != 0)
            {
                Thread.Sleep(t * 1000);

                f();
                count--;
            }
        }
    }
}
