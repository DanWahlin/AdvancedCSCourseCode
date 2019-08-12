using System;
namespace Chapter5.EventArgs
{
	public class WorkPerformedEventArgs : System.EventArgs {
		private int _Hours;
		private WorkType _WorkType;

		public int Hours {
			get {
				return _Hours;
			}
			set {
				_Hours = value;
			}
		}

		public WorkType WorkType {
			get {
				return _WorkType;
				}
			set {
				_WorkType = value;
			}
		}

    }
}
