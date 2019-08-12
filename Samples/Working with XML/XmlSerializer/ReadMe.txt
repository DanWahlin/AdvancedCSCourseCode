This sample uses integrated security to hit the different databases.  Before running the sample,
ensure you have done the following:

1.  Give the ASPNET account access to the Northwind database in SQL
Server Enterprise Manager. Do this by going to the security section in Enterprise Manager, adding the
ASPNET account as a user, and then given access for the account to the Northwind database. 
2.  Update the server name (the dev server name at a minimum) in the ServerConfig.config file
in order to run the demo.  By default it uses "localhost" as the server name.  

If you can't see the output (you should see a DataGrid after clicking the button in the ASP.NET
page) then turn on tracing to see what the error is.

Note:  We normally don't stick the ServerConfig.config file within the Webserver root.  Instead,
we put it somewhere else on the physical machine but somewhere that Web users couldn't possibly hit.
We then update the web.config file's ServerConfigPath value with the path physical path to the file.
See the example web.config file's <appSettings> section for more details on assigning the path.

You'll find the bulk of the code that drives this sample in the Code folder in a subfolder named ServerConfig.