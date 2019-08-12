The code included within this solution allows XML documents to be validated
and parsed with a Windows Service.  To get the sample going, run the
XmlImportServiceSetup.msi file included with this zip archive.

After the installation completes, update the 
XmlImportService.exe.config file located in the installation directory.  You will
need to update the paths where the XML document will be watched as well as the 
location of the XML schema and error log file if they differ from those listed.
The sample uses the Northwind database so you may need to update the connection string.

A sample schema named Customers.xsd can be used to test XML validation characteristics of 
the service.  Once you have completed the above steps,
go into the Services applet in the Control Panel and start XmlImportService. 

To test the service, drop the included Customers.xml file into the watch folder 
(named Data by default) that
you specified in the configuration file. Assuming it is a valid document 
(it will be validated by Customers.xsd by default), you should see that 
the northwind database is updated with data contained in the XML document.

Code written by Dan Wahlin - dwahlin@xmlforasp.net
http://www.XMLforASP.NET