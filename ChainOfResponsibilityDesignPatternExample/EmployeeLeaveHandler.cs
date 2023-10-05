using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPatternExample
{
    // Handler Abstract Class
    // The Default Chaining Behavior can be implemented inside the abstract handler class.
    public abstract class EmployeeLeaveHandler
    {
        //The Supervisor will hold the reference of the Next Handler
        protected EmployeeLeaveHandler Supervisor;
        //Initializing Supervisor reference using the class constructor
        public void SetNextSupervisor(EmployeeLeaveHandler Supervisor)
        {
            this.Supervisor = Supervisor;
        }
        //The following Method needs to be implemented by the Child handler Classes
        //The following method is going to handle the request.
        public abstract void ApplyLeave(string EmployeeName, int NumberOfDaysLeave);
    }
}
