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

        public string GetInputToUpper()
        {
            return Console.ReadLine()!.ToUpper();
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

        public string GetInputToUpper()
        {
            return SetInput;
        }

        public void Print(string message)
        {
        }
    }
}
