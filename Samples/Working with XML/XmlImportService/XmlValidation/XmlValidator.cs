namespace XmlImportService.Validation {
	using System;
	using System.Xml;
	using System.Xml.Schema;
	using System.IO;
	using System.Text;
	using System.Net;
    using System.Collections.Generic;
	using System.Web;

	/// <summary>
	///		The Validator class encapsulates various XML validation functionality
	/// </summary>
	public class XmlValidator {
		bool _valid;
		string _logFile;
		string _validationErrors = String.Empty;

		XmlReader xmlReader = null;
		public ValidationStatus ValidateXml<T>(T xml,
			XmlSchemaSet schemaCol, string[] dtdInfo,
			string logFile) {

			_logFile = logFile;
			_valid = true;
            XmlParserContext context = null;

			try {
			
				//DTD info can be passed into the ValidateXml() method
				//to dynamically validate XML against a DTD event when
				//the DOCTYPE keyword is not added directly into the XML document.
				
				//The dtdInfo array should contain the name of the root 
				//tag (docTypeName) in position 0 and the path to the DTD
				//in position 1 of the array: 
				//string[] dtdInfo = {"customers",dtdPath};
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.ValidationEventHandler += new ValidationEventHandler(this.ValidationCallBack);
				if (dtdInfo != null && dtdInfo.Length > 0) {
					context = new XmlParserContext(null,null,dtdInfo[0],"",dtdInfo[1],"",dtdInfo[1],"",XmlSpace.Default);
					settings.ValidationType = ValidationType.DTD;
				} else {
                    if (schemaCol != null) settings.Schemas = schemaCol;
                    settings.ValidationType = ValidationType.Schema;
				}
                if (xml is String) xmlReader = XmlReader.Create(xml as string,settings,context);
                if (xml is StringReader) xmlReader = XmlReader.Create(xml as StringReader, settings, context);

				// Parse through XML
				while (xmlReader.Read()){}
			} catch  {
				_valid = false;
			} finally {  //Close our readers
				if (xmlReader != null) xmlReader.Close();
			}
			ValidationStatus status = new ValidationStatus();
			status.Status = _valid;
			status.ErrorMessages = _validationErrors;
			return status;
		}

		private void ValidationCallBack(object sender, ValidationEventArgs args)	{
			_valid = false;  //hit callback so document has a problem
			DateTime today = DateTime.Now;
			StreamWriter writer = null;
			try {			
				if (_logFile != null) {
					writer = new StreamWriter(_logFile,true,Encoding.ASCII);
					writer.WriteLine("Validation error in XML: ");
					writer.WriteLine();
					writer.WriteLine(args.Message + " " + today.ToString());
					writer.WriteLine();
					writer.WriteLine();
					writer.Flush();
				} else {
					_validationErrors = args.Message + "\n\n";
				}
			}
			catch {}
			finally {
				if (writer != null) {
					writer.Close();
				}
			}
		}
	} 

	public struct ValidationStatus {
		public bool Status;
		public string ErrorMessages;
	}
}
