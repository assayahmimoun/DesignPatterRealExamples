using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPatternExample
{
    public class ProjectLeader : EmployeeLeaveHandler
    {
        // ProjectLeader can only approve up to 20 days of leave
        private readonly int MAX_LEAVES_CAN_APPROVE = 20;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            //Check if ProjectLeader can process this request
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine($"ProjectLeader Approved {NumberOfDaysLeave} Days Leave for the Employee {EmployeeName}");
            }
            //If ProjectLeader can't process the LeaveRequest then pass it on to the supervisor(HR) 
            // so that he can process
            else
            {
                Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
            }
        }
    }
}
