using System;
namespace Chapter5
{
	public delegate void WorkPerformedHandler(int hours, WorkType workType);

	public class Worker {
		public event WorkPerformedHandler WorkPerformed;

		public virtual void DoWork(int hours, WorkType workType) {
			//Do work here

			//Notify class consumer that work has been performed
			//Worker likes to "work" by playing golf
			OnWorkPerformed(hours, WorkType.Golf);
		}

		private void OnWorkPerformed(int hours, WorkType workType) {
			if (WorkPerformed != null) {
				WorkPerformed(hours,workType);
			}
		}
	}
}
