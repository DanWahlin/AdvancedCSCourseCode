using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Web;
using System.Text;



namespace SVG {
	/// <summary>
	/// Summary description for SVGCreator.
	/// </summary>
	/// 

	public class SVGCreator {
		List<Airport> Airports;
		XmlReaderSettings rs = null;
		XmlWriterSettings ws = null;

		public SVGCreator() {
			Airports = new List<Airport>();
			rs = new XmlReaderSettings();
			rs.IgnoreWhitespace = true;
			rs.IgnoreProcessingInstructions = true;
			rs.IgnoreComments = true;

			ws = new XmlWriterSettings();
			ws.Encoding = Encoding.UTF8;
			ws.CheckCharacters = false;
			ws.OmitXmlDeclaration = true;
			//Necessary since the writer is called several times to 
			//generate fragments of a document.
			ws.ConformanceLevel = ConformanceLevel.Fragment;
		}

		public byte[] GetBytes(string s) {
			return Encoding.ASCII.GetBytes(s);
		}

		public bool GenerateWorldSvg(Stream gz, string xmlPath) {
			bool status = true;
			XmlReader reader = null;
			XmlWriter writer = null;
			MemoryStream ms = null;
			try {
				//Create Reader
				reader = XmlReader.Create(xmlPath,rs);
				string line_segment = reader.NameTable.Add("line_segment");
				string point = reader.NameTable.Add("point");

				//Create Writer
				ms = new MemoryStream();
				writer = XmlWriter.Create(ms, ws);
				int pointPosition = 0;
				while (reader.Read()) {
					//Check for start elements
					if (reader.NodeType == XmlNodeType.Element) {
						if (reader.Name.Equals(line_segment)) {
							writer.WriteStartElement("path");
							writer.WriteAttributeString("fill","none");
							writer.WriteAttributeString("stroke","black");
							writer.WriteAttributeString("stroke-width",".05pt");
							writer.WriteStartAttribute("d",String.Empty);
						}
						if (reader.Name.Equals(point)) {								
							if (pointPosition == 0) {
								writer.WriteString("M ");
								writer.WriteString(reader.GetAttribute("lon"));
								writer.WriteString(" ");
								writer.WriteString(GetLatitude(reader).ToString());
							} else {
								writer.WriteString(" L ");
								writer.WriteString(reader.GetAttribute("lon"));
								writer.WriteString(" ");
								writer.WriteString(GetLatitude(reader).ToString());
							}
							pointPosition++;
						}
					}

					//Check for end elements
					if (reader.NodeType == XmlNodeType.EndElement) {
						if (reader.Name.Equals("line_segment")) {
							pointPosition = 0;
							writer.WriteEndAttribute();
							writer.WriteEndElement();
						}
					}
				}
			}
			catch (Exception exp) {
				status = false;
			}
			finally {
				reader.Close();
				writer.Close();			
			}
			ms.Position = 0;
			byte[] bytes = ms.ToArray();
			gz.Write(bytes,0,bytes.Length);
			return status;
		}

		public bool GenerateFlightsSvg(Stream gz, string xmlPath, 
			string airportID, string airportLon, string airportLat) {
			bool status = true;
			string from = "";
			string to = "";
			string type = "";
			
			XmlReader reader = null;
			XmlWriter writer = null;
			MemoryStream ms = null;

			DateTime now = new DateTime();
			now = DateTime.UtcNow;
			DateTime midnight = new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day,0,0,0,0);
			TimeSpan ts = now.Subtract(midnight);
			int lNowDaily = ts.Minutes;
			int lNowWeekly = lNowDaily + ((int)DateTime.UtcNow.DayOfWeek * 24 * 60);
			int lNow;
			bool showFlight;

			try {
				reader = XmlReader.Create(xmlPath, rs);
				string flight = reader.NameTable.Add("flight");
				ms = new MemoryStream();
				writer = new XmlTextWriter(ms,Encoding.UTF8);
				while (reader.Read()) {
					showFlight = true;
					//Check for start elements
					if (reader.NodeType == XmlNodeType.Element) {
						if (reader.Name.Equals(flight)) {
							if (reader.GetAttribute("period") == "WEEK") {
								lNow = lNowWeekly;
							} else {
								lNow = lNowDaily;
							}
							int departuredatetime = Convert.ToInt32(reader.GetAttribute("departuredatetime", String.Empty ));
							int arrivaldatetime = Convert.ToInt32(reader.GetAttribute("arrivaldatetime", String.Empty));
							if ((departuredatetime <= lNow ) &&  (lNow <= arrivaldatetime)) {
								double percentcomplete = (double)(lNow - departuredatetime) / (double)(arrivaldatetime - departuredatetime);
								string leg = reader.GetAttribute("leg");
								string flightid = reader.GetAttribute("id");
								from = leg.Substring(0,4);
								to = leg.Substring (5,4);
								if (airportID != null) {
									if (from != airportID && to != airportID) {
										showFlight = false;
									}
								}
								if (showFlight) {
									MakePath(writer, flightid, from, to, percentcomplete);							

									writer.WriteStartElement("use");
									writer.WriteAttributeString("onmouseover","aircraft_mouseover(evt)");
									writer.WriteAttributeString("onmouseout","aircraft_mouseout(evt)");
									writer.WriteAttributeString("id",flightid);
									type = reader.GetAttribute("type");
									writer.WriteAttributeString("type", type);
									writer.WriteAttributeString("xlink:href", "#" + ConvType(type));
									writer.WriteAttributeString("alt", reader.GetAttribute("alt"));
									writer.WriteAttributeString("from", from);
									writer.WriteAttributeString("to", to);
									writer.WriteStartElement("animateMotion");

									writer.WriteAttributeString("dur", Convert.ToString((arrivaldatetime - departuredatetime) * (1 - percentcomplete)) + "min");
									writer.WriteAttributeString("repeatCount","1");
									writer.WriteAttributeString("rotate","auto");
									writer.WriteStartElement("mpath");
									writer.WriteAttributeString("id", "#" + flightid + leg);
									writer.WriteAttributeString("xlink:href", "#" + flightid + leg);
									writer.WriteEndElement();
									writer.WriteEndElement();
									writer.WriteEndElement();
								}
								
							}
						}
					}
				}
			}
			catch (Exception exp) {
				status = false;
			}
			finally {
				reader.Close();
				writer.Close();					
			}
			byte[] bytes = ms.ToArray();
			gz.Write(bytes,0,bytes.Length);
			return status;		
		}

		public bool GenerateAirportSvg(Stream gz, string xmlPath) {

			bool status = true;
			string cx = "";
			string cy = "";
			string id = "";
			
			XmlReader reader = null;
			XmlWriter writer = null;
			MemoryStream ms = null;
			try {
				reader = XmlReader.Create(xmlPath, rs);
				string airport = reader.NameTable.Add("airport");
 				ms = new MemoryStream();
				writer = XmlWriter.Create(ms, ws);
				while (reader.Read()) {
					//Check for start elements
					if (reader.NodeType == XmlNodeType.Element) {
						if (reader.Name.Equals(airport)) {
							writer.WriteStartElement("g");
							writer.WriteAttributeString("onclick","airport_mouselick(evt)");
							writer.WriteAttributeString("onmouseover","airport_mouseover(evt)");
							writer.WriteAttributeString("onmouseout","airport_mouseout(evt)");
							id = reader.GetAttribute("id");
							writer.WriteAttributeString("id",id);

							
							writer.WriteStartElement("circle");
							writer.WriteAttributeString("fill","red");
							writer.WriteAttributeString("stroke","red");
							writer.WriteAttributeString("stroke-width","0");
							writer.WriteAttributeString("r",".1");
						}
						if (reader.Name.Equals("location")) {
							cx = reader.GetAttribute("lon");
							cy = GetLatitude(reader).ToString();

							Airport thisAirport = new Airport();
							thisAirport.id = id;
							thisAirport.lon = Convert.ToDouble(cx);
							thisAirport.lat = Convert.ToDouble(cy);
							Airports.Add(thisAirport);

							writer.WriteAttributeString("cx",cx);
							writer.WriteAttributeString("cy",cy);
							writer.WriteEndElement();

							writer.WriteStartElement("text");
							writer.WriteAttributeString("font-family", "Verdana");
							writer.WriteAttributeString("font-size", ".3");
							writer.WriteAttributeString("fill", "blue");
							writer.WriteAttributeString("code", id);
							writer.WriteAttributeString("x", Convert.ToString (thisAirport.lon + (double)0.3));
							writer.WriteAttributeString("y",Convert.ToString (thisAirport.lat + (double)0.1));
						}
						if (reader.Name.Equals("name")) {
							writer.WriteAttributeString("name", reader.ReadString());
						}
						if (reader.Name.Equals("city")) {
							writer.WriteAttributeString("city", reader.ReadString());
						}
					}
					//Check for end elements
					if (reader.NodeType == XmlNodeType.EndElement) {
						if (reader.Name.Equals(airport)) {
							writer.WriteString (id);
							writer.WriteEndElement();
							writer.WriteEndElement();
						}
					}
				}
			}
			catch (Exception exp) {
				status = false;
			}
			finally {
				reader.Close();
				writer.Close();
			}
			byte[] bytes = ms.ToArray();
			gz.Write(bytes,0,bytes.Length);
			return status;		
		}

		private void MakePath(XmlWriter writer, string flightid, string from, string to, double percentcomplete) {
				if (to != from) {
					GetGreatCirclePath(writer, flightid, from,to,percentcomplete);
				}
		}

		private string ConvType(string type) {
			string retval = "";

			switch (type) {
				case "A319":
				case "A318":
				case "A320":
				case "B737":
				case "B733":
				case "B732":
				case "B734":
				case "B735":
				case "B738":
				case "B739":
				case "B762":
				case "B763":
				case "B772":
				case "B773":
				case "B764":
				case "B767":
				case "B777":
				case "A300":
					retval = "B767";
					break;
				case "B747":
				case "B742":
				case "B744":
				case "B743":
				case "74S":
				case "B74F":
					retval ="B747";
					break;
				case "B757":
				case "B752":
				case "B753":
				case "A321":
					retval = "B757";
					break;
				case "SF34":
				case "DH8C":
				case "AT43":
				case "AT72":
				case "B190":
				case "DH8A":
				case "D328":
				case "JS41":
					retval = "SF34";
					break;
				case "A330":
					retval = "A330";
					break;
				case "A340":
					retval = "A340";
					break;
				case "MD11": 
					retval = "MD11";
					break;
				case "DC10":
				case "MD10":
					retval = "DC10";
					break;
				case "MD80":
				case "MD90":
				case "MD81":
				case "MD82":
				case "MD83":
				case "MD87":
				case "MD88":
					retval = "MD80";
					break;
				default:
					retval = "DC9";
					break;
			}
			return retval;
		}
		private double GetLatitude(XmlReader reader) {
			reader.MoveToAttribute("lat");
			return reader.ReadContentAsDouble() * -1;
		}

		private Airport FindAirport(string id) {
			Airport retval = new Airport();
			foreach (Airport a in Airports) {
				if (a.id == id) {
					retval = a;		
					break;
				}
			}

			return retval;
		}

		private Airport GreatCircleLatAtALon(double lon, Airport fromAirport, Airport toAirport) {
			Airport middle = new Airport();
			double templon = lon * Math.PI/180; 
			double lat1 = fromAirport.lat * Math.PI/180;
			double lon1 = fromAirport.lon * Math.PI/180;
			double lat2 = toAirport.lat * Math.PI/180;
			double lon2 = toAirport.lon * Math.PI/180;

			middle.lat=(Math.Atan((Math.Sin(lat1)*Math.Cos(lat2)*Math.Sin(templon-lon2)
				-Math.Sin(lat2)*Math.Cos(lat1)*Math.Sin(templon-lon1))/(Math.Cos(lat1)*Math.Cos(lat2)*Math.Sin(lon1-lon2)))) * (180/Math.PI);
			middle.lon = lon;

			return middle;
		}

		private Airport GreatCircleMidPoint(double f, Airport fromAirport, Airport toAirport) {
			Airport middle = new Airport();

			double lat1 = fromAirport.lat * Math.PI/180;
			double lon1 = fromAirport.lon * Math.PI/180;
			double lat2 = toAirport.lat * Math.PI/180;
			double lon2 = toAirport.lon * Math.PI/180;
			double d = 2*Math.Asin(Math.Sqrt(((Math.Sin((lat1-lat2)/2))*(Math.Sin((lat1-lat2)/2)))+Math.Cos(lat1)*Math.Cos(lat2)*(Math.Sin((lon1-lon2)/2)*Math.Sin((lon1-lon2)/2))));
			double A = Math.Sin((1-f)*d)/Math.Sin(d);
			double B = Math.Sin(f*d)/Math.Sin(d);
			double x = A*Math.Cos(lat1)*Math.Cos(lon1) +  B*Math.Cos(lat2)*Math.Cos(lon2);
			double y = A*Math.Cos(lat1)*Math.Sin(lon1) +  B*Math.Cos(lat2)*Math.Sin(lon2);
			double z = A*Math.Sin(lat1)           +  B*Math.Sin(lat2);
			double lat = Math.Atan2(z,Math.Sqrt((x*x)+(y*y))) * (180/Math.PI);
			double lon = Math.Atan2(y,x) * (180/Math.PI);

			middle.id = "";
			middle.lat = lat;
			middle.lon = lon;

			return middle;
		}
		
		private void DrawRoute(XmlWriter writer, string pathid, Airport StartAirport, Airport EndAirport, double start, double end) {
			writer.WriteStartElement("path");
			writer.WriteAttributeString("fill","none");
			writer.WriteAttributeString("stroke","red");
			writer.WriteAttributeString("stroke-width","0.001pt");
			writer.WriteAttributeString("id",pathid);
			writer.WriteStartAttribute("d",String.Empty);
			Airport lastmiddle, thismiddle;
			
			lastmiddle = StartAirport;

			int i=0;
			string si = "";
			string retval = "";
			for (double f=start;f<=end;f+=0.05) {
				if (++i == 1) {
					si=" M";
				} else {
					si=" L";
				}
				thismiddle = GreatCircleMidPoint(f, StartAirport, EndAirport);
				if (Math.Abs(thismiddle.lon - lastmiddle.lon) > 180) {
					if (lastmiddle.lon < thismiddle.lon) {
						if (i > 1) {
							thismiddle = GreatCircleLatAtALon(-180,StartAirport, EndAirport);	
							retval += " L" + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
						}
						thismiddle = GreatCircleLatAtALon(180,StartAirport, EndAirport);	
						retval += " M" + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
					} else {
						if (i > 1) {
							thismiddle = GreatCircleLatAtALon(180,StartAirport, EndAirport);	
							retval += " L" + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
						}
						thismiddle = GreatCircleLatAtALon(-180,StartAirport, EndAirport);	
						retval += " M" + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
					}
				}
				else {
					retval += si + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
				}

				lastmiddle=thismiddle;
			}

			thismiddle = GreatCircleMidPoint(end, StartAirport, EndAirport);

			if (Math.Abs(thismiddle.lon - lastmiddle.lon) > 180) {
				if (lastmiddle.lon < thismiddle.lon) {
					thismiddle = GreatCircleLatAtALon(-180,StartAirport, EndAirport);	
					retval += " L" + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
					thismiddle = GreatCircleLatAtALon(180,StartAirport, EndAirport);	
					retval += " M" + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
				} else {
					thismiddle = GreatCircleLatAtALon(180,StartAirport, EndAirport);	
					retval += " L" + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
					thismiddle = GreatCircleLatAtALon(-180,StartAirport, EndAirport);	
					retval += " M" + Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat); 
				}
			}
			else {
				retval += " L" 	+ Convert.ToString(thismiddle.lon) + " " + Convert.ToString(thismiddle.lat);
			}

			writer.WriteString(retval);
			writer.WriteEndAttribute();
			writer.WriteEndElement();


		}

		private void GetGreatCirclePath(XmlWriter writer, string flightid, string from, string to, double percentcomplete) {
			Airport StartAirport = FindAirport(from);
			Airport EndAirport = FindAirport(to);

			DrawRoute(writer, flightid + from + "-" + to,StartAirport,EndAirport,percentcomplete,1);
			DrawRoute(writer, from + "-" + to,StartAirport,EndAirport,0, percentcomplete);

		}
	}

	public class Airport {
		string _id;
		double _lon;
		double _lat;

		public string id {
			get {return _id;}
			set {_id = value;}
		}

		public double lon {
			get {return _lon;}
			set {_lon = value;}
		}

		public double lat {
			get {return _lat;}
			set {_lat = value;}
		}
	}
}

