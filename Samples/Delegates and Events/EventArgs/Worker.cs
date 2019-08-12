using System;
namespace Chapter5.EventArgs
{

    public class Worker {
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

        public virtual void DoWork(int hours, WorkType workType) {
            //Do work here

            //Notify class consumer that work has been performed
            //Create eventargs
            WorkPerformedEventArgs e = new WorkPerformedEventArgs();
            e.Hours = hours;
            e.WorkType = workType;
            OnWorkPerformed(this, e);
        }

		private void OnWorkPerformed(object sender, WorkPerformedEventArgs e) {
			if (WorkPerformed != null) {
				WorkPerformed(sender,e);
			}
		}
    }
}
