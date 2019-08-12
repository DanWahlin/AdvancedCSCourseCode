namespace Chapter5.MultipleEvents
{
	public class Manager : Worker {
		public event WorkPerformedHandler ManagerWorkPerformed; 

		public override void DoWork(int hours, WorkType workType) {
			OnManagerWorkPerformed(1, workType);
			//Make it look as if manager worked really hard on project
			int hoursWorked = hours + 10;
			//Managers delegates to worker
			base.DoWork(hoursWorked, workType);
		}

		private void OnManagerWorkPerformed(int hours, WorkType workType) {
			if (ManagerWorkPerformed != null) {
				ManagerWorkPerformed(hours,workType);
			}
		}
	}
}
