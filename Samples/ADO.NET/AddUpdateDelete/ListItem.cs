using System;

namespace DataDemos.AddUpdateDelete {
	public class ListItem {
		private string _Value;
		private int _ID;


		public int ID {
			get {
				return _ID;
			}

			set {
				_ID = value;
			}
		}

		public string Value {
			get {
				return _Value;
			}

			set {
				_Value = value;
			}
		}

		public ListItem(string strValue, int intID) {
			_Value = strValue;
			_ID = intID;
		}

		public ListItem() {
			_Value = "";
			_ID = 0;
		}

		public override string ToString() {
			return _Value;
		}
	}

}
