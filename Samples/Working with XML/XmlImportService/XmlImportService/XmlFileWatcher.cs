using System;
using System.IO;
using System.Diagnostics;
using System.Xml.Schema;
using System.Configuration;
using XmlImportService.Validation;

namespace XmlImportService {

	public class XmlFileWatcher {
		FileSystemWatcher watcher = null;
		string _directory;
		string _filter;

		public XmlFileWatcher(string directory,string filter) {
			_directory = directory;
			_filter = filter;
		}

        public void StopXmlFileWatcher()
        {
            if (watcher != null) watcher.EnableRaisingEvents = false;
        }

		public void StartXmlFileWatcher() { 
			// If a directory is not specified, exit program.
			WriteToLog("Starting XmlImporter file watcher.");
			if(_directory == String.Empty || _directory == null) {
				WriteToLog("XmlImporter: No directory specified to watch. " +
					       "Update the application config file");
				throw new Exception("No directory specified");
			}

			// Create a new FileSystemWatcher
            if (watcher == null)
            {
                watcher = new FileSystemWatcher(_directory, _filter);
                // Watch for changes in LastAccess and LastWrite times, and 
                // the renaming of files or directories.
                watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite
                    | NotifyFilters.FileName | NotifyFilters.DirectoryName;

                // Add event handlers
                watcher.Created += new FileSystemEventHandler(File_OnChanged);
            }

			// Begin watching for XML file
			watcher.EnableRaisingEvents = true;
		}

		// Event Handler
		public void File_OnChanged(object source, FileSystemEventArgs e) {
			//Pause to allow file handle to be cleaned up
			System.Threading.Thread.Sleep(1000);

			string filePath = e.FullPath;
			
			//*** Validate XML document against schema

			//Get schema document path
			string schemaPath = ConfigurationManager.AppSettings["XmlSchemaFile"];
			if (schemaPath != null) { 
				//XML doc should be validated against schema
				//Create XmlValidator object
				XmlValidator validator = new XmlValidator();
				
				//Build schema collection
                XmlSchemaSet schemaCol = new XmlSchemaSet();
				schemaCol.Add(null,schemaPath);
				
				//Get error log file
                string logFile = ConfigurationManager.AppSettings["XmlValidationErrorLogFile"];
				//Validate Document
				ValidationStatus validationStatus = 
					validator.ValidateXml<string>(filePath,
					schemaCol,null,((logFile != null)?logFile:null));

				//Check validation status
				if (!validationStatus.Status) {
					//Log that errors occurred during validation and 
					//stop processing on this document
					this.WriteToLog("Validation of " + filePath + " failed. " +
						"See error log file for more details.");
					File.Move(filePath,filePath + "." + Guid.NewGuid().ToString() + ".notValid");
					return;
				} else { //Validation successful
					this.WriteToLog(filePath + " validated successfully. ");
				}
			}
			//Call XML import object to move XML into db
			SQLGenerator gen = new SQLGenerator();
			SQLInfo info = gen.CreateSQLStatement(filePath);

			if (info.Status) {
				WriteToLog(filePath + " parsed successfully!");

				//Execute SQL statement against database
				SQLInfo dbInfo = gen.ExecuteNonQuery(info.SQL);
				if (dbInfo.Status) {
					WriteToLog(filePath + " data updated successfully in database!");
				} else {
					WriteToLog(filePath + " not updated in db successfully. Error: " +
						dbInfo.StatusMessage);
				}
			} else {
				WriteToLog(filePath + " not parsed successfully. Error: " +
					       info.StatusMessage);
			}

			//Rename the file
			File.Move(filePath,filePath + "." + Guid.NewGuid().ToString() + ".old");
		}

		public void WriteToLog(string logEntry) {
			// Create the source, if it does not already exist.
			if(!EventLog.SourceExists("XmlImportService")){
				EventLog.CreateEventSource("XmlImportservice", "XmlImportLog");
			}
                
			// Create an EventLog instance and assign its source.
			EventLog myLog = new EventLog();
			myLog.Source = "XmlImportService";
        
			// Write an entry to the event log   
			myLog.WriteEntry(logEntry);
		}
	}
}
