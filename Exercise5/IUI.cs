using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public interface IUI
    {
        string GetInput();
        string GetInputToUpper();
        void Print(string message);
    }
}
