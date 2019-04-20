using AutofacProject.Interfaces;

namespace AutofacProject.Concrets
{
    class ConsoleOutput : IOutput
    {
        public string Write(string content)
        {
            return content;
        }
    }
}
