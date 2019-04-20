using AutofacProject.Interfaces;
using System;

namespace AutofacProject.Concrets
{
    class TodayWriter : IDateWriter
    {
        private IOutput _output;

        public TodayWriter(IOutput output) // Resolve by constructor, Autofac Resolver
        {
            this._output = output;
        }

        public void WriteDate()
        {
            string date = this._output.Write(DateTime.Today.ToShortDateString());

            Console.WriteLine(date);            
        }
    }
}
