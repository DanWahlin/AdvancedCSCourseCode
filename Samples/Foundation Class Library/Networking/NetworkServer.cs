using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace Chapter2.Networking {
	public class NetworkServer {
		private const int portNumber = 10000;
		public static void Main() {
			TcpClient tcpClient = null;
			IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
			TcpListener tcpListener = new TcpListener(ipAddress,portNumber);
			tcpListener.Start();
			System.Console.WriteLine("Started and waiting....");
			try {
				tcpClient = tcpListener.AcceptTcpClient();
				//Accept the pending client connection and return a TcpClient initialized for communication. 
				System.Console.WriteLine("Connection accepted.");
				NetworkStream networkStream = tcpClient.GetStream();
				string responseString = "You have successfully connected to me.";

				byte[] sendBytes = Encoding.ASCII.GetBytes(responseString);
				networkStream.Write(sendBytes, 0, sendBytes.Length);

				System.Console.WriteLine("Message Sent: " + responseString);
			} catch (System.Exception e) {
				System.Console.WriteLine(e.ToString());
			} finally {
				tcpClient.Close();
				tcpListener.Stop();
			}

		}
    }
}