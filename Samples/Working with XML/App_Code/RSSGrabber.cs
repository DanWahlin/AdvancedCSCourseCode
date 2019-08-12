using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Web;

namespace RSSDemo {

	public class RSSGrabber {
		static XmlWriterSettings ws = null;

		static RSSGrabber() {
			ws = new XmlWriterSettings();
			ws.CheckCharacters = false;
			ws.Indent = true;
			ws.OmitXmlDeclaration = true;
		}

		public static string GetRssItems(string[] rssURLs,int numberToShow) {
			List<RSSItem> alItems = new List<RSSItem>();
			foreach (string url in rssURLs) {
				if (url.Length > 0) {
					string title = null;
					string link = null;
					string desc = null;
					XmlReader reader = null;
					try {
						reader = XmlReader.Create(url);
						while (reader.Read()) {
							if (reader.NodeType == XmlNodeType.Element) {
								switch (reader.Name.ToLower()) {
									case "title":
										title = reader.ReadString();
										break;
									case "link":
										link = reader.ReadString();
										break;
									case "description":
										desc = reader.ReadString();
										if (desc.Length > 250) {
											desc = desc.Substring(0,250) + "...";
										}
										break;
								}
							}
							//After each item end tag create HTML output
							if (reader.NodeType == XmlNodeType.EndElement && reader.Name.ToLower() == "item") {
								RSSItem item = new RSSItem(title,link,desc);
								alItems.Add(item);
							}
						}
					}
					catch {}
					finally {
						reader.Close();
					}
				}
			}

			return CreateHtml(alItems,numberToShow);
		}

		private static string CreateHtml(List<RSSItem> alItems,int numberToShow) {
			StringWriter s = new StringWriter();
			XmlWriter writer = XmlWriter.Create(s, ws);
			writer.WriteStartElement("ul");
			RSSItem[] rssItems = GetRSSItems(alItems,numberToShow);
			if (rssItems != null) {
				foreach (RSSItem item in rssItems) {
					WriteItem(writer,item);
				}
			}
			writer.WriteEndElement();
			writer.Close();
			return s.ToString();
		}

		private static RSSItem[] GetRSSItems(List<RSSItem> alItems, int numberToShow) {
			RSSItem[] rssItems = (alItems.Count > 0)?alItems.ToArray():null;
			if (numberToShow > rssItems.Length || numberToShow == 0) numberToShow = rssItems.Length;
			if (rssItems != null && numberToShow > 0) {
				List<string> currTitles = new List<string>();
				RSSItem[] rssItemsFilter = new RSSItem[numberToShow];
				Random r = new Random();
				for (int i=0;i<numberToShow;i++) {  //Look through each item
					int num = r.Next(rssItems.Length);
					while (currTitles.BinarySearch(rssItems[num].Title) > -1) { //Avoid duplicates
						num = r.Next(rssItems.Length);
					}
					rssItemsFilter[i] = rssItems[num];
					currTitles.Add(rssItems[num].Title);
					currTitles.Sort();					
				}
				return rssItemsFilter;
			}
			return rssItems;
		}

		private static void WriteItem(XmlWriter writer,RSSItem item) {
			writer.WriteStartElement("li");
			writer.WriteStartElement("a");
			writer.WriteAttributeString("href",item.Link);
			writer.WriteString(item.Title);
			writer.WriteEndElement();
			writer.WriteElementString("br",String.Empty);
			writer.WriteString(item.Description);
			writer.WriteElementString("p",String.Empty);
			writer.WriteEndElement();
		}
	}
}
