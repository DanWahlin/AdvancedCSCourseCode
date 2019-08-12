using System;
namespace Chapter5.MultipleEvents
{
	public class MultipleEventsTest {
		//WithEvents keyword is necessary to access Manager events
		private static Manager lazyManager;
		public static void Main() {
			lazyManager = new Manager();
			//Dynamic event handler
			lazyManager.WorkPerformed += new WorkPerformedHandler(Manager_WorkPerformed);

			//Tell manager to work 10 hours on creating a report
			lazyManager.DoWork(10, WorkType.CreateReport);
			Console.ReadLine();

		}

		public static void Manager_WorkPerformed(int hours,
			WorkType workType) {
			Console.WriteLine("WorkPerformed event fired.  Hours: {0}  WorkType: {1}",
				hours.ToString(), workType.ToString());
		}

	}
}