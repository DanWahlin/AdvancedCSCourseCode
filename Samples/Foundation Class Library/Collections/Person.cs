using System;

namespace Chapter2.Collections
{
    public class Person {
        private string _FirstName;
        private string _LastName;

        public string FirstName {
			get {
				return _FirstName;
			}
			set {
				_FirstName = value;
			}
        }

		public string LastName {
			get {
				return _LastName;
			}
			set {
				_LastName = value;
			}
		}
    }
}
