using System;

namespace RSSDemo {

	public struct RSSItem {
		private string _Title;
		private string _Link;
		private string _Description;

		public RSSItem(string title,string link,string desc) {
			_Title = title;
			_Link = link;
			_Description = desc;
		}

		public string Title {
			get {
				return _Title;
			}
			set {
				_Title = value;
			}
		}

		public string Link {
			get {
				return _Link;
			}
			set {
				_Link = value;
			}	
		}

		public string Description {
			get {
				return _Description;
			}
			set {
				_Description = value;
			}	
		}
	}
}
