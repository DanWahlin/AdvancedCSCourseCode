using System;
namespace Chapter5.EventArgs
{
    public class Manager : Worker {
        public override void DoWork(int hours , WorkType workType) {
            //Make it look as if manager worked really hard on project
            int hoursWorked = hours + 10;
            //Managers delegates to worker
            base.DoWork(hoursWorked, workType);
        }
    }
}
