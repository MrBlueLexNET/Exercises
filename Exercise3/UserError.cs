using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise3
{
    //3.2 Polymorfism
    //Abstract Class
    //Incomplete, with at least one property or method not implemented
    //Incomplete = Cannot be instantiated = cannot use the new KeyWord
    public abstract class UserError
    {
        //Fields
        public string ueMessage = string.Empty;
       
        //Properties
        //public string? UEMessageProperty { get; } 
        public string UEMessageProperty { get => ueMessage; set => ueMessage = value; }
        //Methods
        public virtual string UEMessage(string ueMessage) 
        {
            return UEMessageProperty;
        }

    }

    public class NumericInputError : UserError
    {
        public override string UEMessage(string ueMessage)
        {
            return UEMessageProperty = "You tried to use a numeric input in a text only field. This fired an error!";
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage(string ueMessage)
        {
            return UEMessageProperty = "You tried to use a text input in a numeric only field. This fired an error!";
        }
    }
}
