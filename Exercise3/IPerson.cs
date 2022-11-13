using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    //10. Skapa gränssnittet (interface) IPerson med en metod deklaration Talk();
    public interface IPerson
    {
       string Talk();
    }
    public class Wolfman : Wolf, IPerson
    {
        public string Talk() => $"Wolfam says:";
       
    }
    public class Wolf
    { }
}
