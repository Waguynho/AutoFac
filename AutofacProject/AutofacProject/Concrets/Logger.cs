using AutofacProject.Interfaces;
using System;

namespace AutofacProject.Concrets
{
    class Logger : ILogger
    {
        public void ShowInConsole(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
