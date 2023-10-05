using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDPFormInputValidation
{
    //Abstract Handler
    public abstract class ValidationHandler
    {
        protected ValidationHandler nextHandler;
        public void SetNext(ValidationHandler handler)
        {
            nextHandler = handler;
        }
        public abstract bool Validate(UserInput input);
    }
}
