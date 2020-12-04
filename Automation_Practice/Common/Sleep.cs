using OpenQA.Selenium;
using System.Threading;

namespace Automation_Practice.Common
{
    class Sleep
    {
       public static void Wait(float sleepValueInSeconds)
        {
            Thread.Sleep((int)(sleepValueInSeconds * 1000.0));
        }

    }
}
