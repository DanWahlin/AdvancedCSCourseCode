using System;
using System.Net;
using System.IO;

namespace Chapter2.Networking {
    public class RequestResponseDemo {
        public static void Main() {
             string uri = "http://msdn.microsoft.com/";
             StreamReader reader = null;
             HttpWebRequest request = null; 

			try {
				//Make request and get response
				request = (HttpWebRequest)WebRequest.Create(uri);

				//If we needed to go through a proxy the following code could be used:
				// proxy As New WebProxy("http://proxy.com:8080", True)
				// creds As New NetworkCredential("uid", "password", "domain")
				//proxy.Credentials = creds
				//request.Proxy = proxy

				HttpWebResponse response = (HttpWebResponse)request.GetResponse();
				//Response returned as a stream so read it with a StreamReader
				Stream resStream  = response.GetResponseStream();
				reader = new StreamReader(resStream);
				Console.WriteLine(reader.ReadToEnd());
			} catch (WebException netExp) {
				Console.WriteLine(netExp.Message);
				Console.WriteLine(netExp.StackTrace);
			} catch (NullReferenceException nullExp) {
				Console.WriteLine(nullExp.Message);
				Console.WriteLine(nullExp.StackTrace);
			} catch (System.Exception exp) {
				Console.WriteLine(exp.Message);
				Console.WriteLine(exp.StackTrace);
			} finally {
				reader.Close();
			}
            Console.ReadLine();
        }
    }
}
