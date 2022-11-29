using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class ConsoleUI : IUI
    {
        public string GetInput()
        {
            return Console.ReadLine()!;
        }

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class MockUI : IUI
    {
        public string SetInput { private get; set; } = "1";
        public string GetInput()
        {
            return SetInput;
        }

        public void Print(string message)
        {
        }
    }
}
