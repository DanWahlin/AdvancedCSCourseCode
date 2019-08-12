using System;
namespace Chapter5
{
	public class EventsTest {
		public static void Main() {
			Manager lazyManager = new Manager();
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