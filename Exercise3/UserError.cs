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
        public string errorMessage = " This fired an error!";
       
        //Properties
        //public string? UEMessageProperty { get; } 
        public string UEMessageProperty { get => ueMessage; set => ueMessage = value; }
        //Methods
        public virtual string UEMessage(string ueMessage) //With Argument
        {
            return UEMessageProperty;
        }
        public virtual string UEMessage() //Overide Without passing Argument
        {
            return UEMessageProperty;
        }

    }

    public class NumericInputError : UserError
    {
        public override string UEMessage(string ueMessage)
        {
            return UEMessageProperty = "You tried to use a numeric input in a text only field." + errorMessage;
        }
    }

    public class TextInputError : UserError
    {
        public override string UEMessage(string ueMessage)
        {
            return UEMessageProperty = "You tried to use a text input in a numeric only field." + errorMessage;
        }
    }
    //9. Skapa nu tre egna klasser med tre egna definitioner på UEMessage()
    public class FileUpploadError : UserError //[9.1]
    {
        public override string UEMessage(string ueMessage)
        {
           if (string.IsNullOrEmpty(ueMessage))
            { 
            return UEMessageProperty = "You tried to upload a file the extension is incorrect or not given." + errorMessage;
            }
            return UEMessageProperty = ueMessage;
        }
    }
    public class FilePathError : UserError //[9.2]
    {
        public override string UEMessage(string ueMessage)
        {
          
            return UEMessageProperty = "You tried to use an incorrect path input." + errorMessage;
        }
    }
    public class FileSizeError : UserError //[9.3]
    {
        public override string UEMessage()
        {
            return UEMessageProperty = "You tried to upload a file in an incorrect size." + errorMessage;
        }
    }

}
