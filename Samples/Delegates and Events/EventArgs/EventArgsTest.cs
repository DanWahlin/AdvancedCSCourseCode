using System;
namespace Chapter5.EventArgs {
	public class EventArgsTest {
		private static Manager lazyManager;
		public static void Main() {
			lazyManager = new Manager();
			//Dynamic event handler
			lazyManager.WorkPerformed += new EventHandler<WorkPerformedEventArgs>(Manager_WorkPerformed);

			//Tell manager to work 10 hours on creating a report
			lazyManager.DoWork(10, WorkType.CreateReport);
			Console.ReadLine();

		}

		public static void Manager_WorkPerformed(object sender,
			WorkPerformedEventArgs e) {
			Console.WriteLine("WorkPerformed event fired.  Hours: {0}  WorkType: {1}",
				e.Hours.ToString(), e.WorkType.ToString());
		}

    }
}
