using System;
using System.Xml;
using System.Collections.Generic;
using System.Diagnostics;

namespace XMLParsing
{
	/// <summary>
    /// Summary description for XmlProductReader.
	/// </summary>
	public class XmlProductReader {

        public XmlProductReader()
        {
		}

		public List<Product> ParseProducts(string xmlPath) {
			XmlReader reader = null;
            List<Product> products = new List<Product>();
            Product prod = null;
			try {
                BooleanSwitch debugSwitch = new BooleanSwitch("BreakIntoDebugger", String.Empty);
                if (debugSwitch.Enabled)
                {
                    Debugger.Break();
                }
				reader = XmlReader.Create(xmlPath);
				//Read through the XML stream and find proper tokens
				while (reader.Read()) {
					if (reader.NodeType == XmlNodeType.Element) {
						switch (reader.Name) {
							case "product":
                                prod = new Product();
								if (reader.HasAttributes) {
									string modelNumber = reader.GetAttribute("modelNumber");
									if (!String.IsNullOrEmpty(modelNumber)) {
                                        prod.ModelNumber = modelNumber;
									} else {
										WriteTrace("modelNumber is empty");
                                        return null;
                                    }
								} else {
                                    WriteTrace("modelNumber doesn't exist");
                                    return null;
								}
								break;
							case "category":
								string category = reader.ReadString();
								if (!String.IsNullOrEmpty(category)) {
                                    prod.Category = category;
								} else { //Must have category name
									WriteTrace("category is empty");
                                    return null;
								}
								break;
							case "modelName":
								string modelName = reader.ReadString();
								if (!String.IsNullOrEmpty(modelName)) {
                                    prod.ModelName = modelName;
								}
								break;
							case "productImage":
								string productImage = reader.ReadString();
								if (!String.IsNullOrEmpty(productImage)) {
                                    prod.ProductImage = productImage;
								}
								break;  
							case "unitCost":
								string unitCostString = reader.ReadString();
								if (!String.IsNullOrEmpty(unitCostString)) {
                                    decimal unitCost;
                                    bool status = Decimal.TryParse(unitCostString, out unitCost);
                                    if (status)
                                    {
                                        prod.UnitCost = unitCost;
                                    }
								} else {
									WriteTrace("unitCost is empty");
									return null;
								}
								break;
							case "description":
								string description = reader.ReadString();
								if (!String.IsNullOrEmpty(description)) {
                                    prod.Description = description.Replace(Environment.NewLine," ").Replace("\t"," ");
								}
								break;
						}
					}
					//XmlNodeType check
					if (reader.NodeType == XmlNodeType.EndElement) {
						//Find closing product tag to know when
						//to add paramCol to ArrayList
						if (reader.Name == "product") {
                            products.Add(prod);
						}
					}
				} //End while
			} catch (Exception exp) {
                WriteTrace(exp.Message + Environment.NewLine + exp.StackTrace);
			} finally {
				if (reader != null) reader.Close();
			}

            return products;
		}

        private void WriteTrace(string msg)
        {
            Trace.WriteLine(String.Format("{0}: {1}",
                new System.Diagnostics.StackFrame(1).GetMethod().Name,msg));
        }
	}

}
