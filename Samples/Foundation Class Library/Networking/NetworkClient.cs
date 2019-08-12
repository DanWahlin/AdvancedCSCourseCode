using System;
using System.Net.Sockets;
using System.IO;
using System.Text;

namespace Chapter2.Networking {
	public class NetworkClient {
		private const int portNumber = 10000;
		public static void Main() {
			TcpClient tcpClient = new TcpClient();
			try {
				tcpClient.Connect("localhost", portNumber);
				NetworkStream networkStream = tcpClient.GetStream();

				// Does a simple write.
				byte[] sendBytes = Encoding.ASCII.GetBytes("Is anybody there");
				networkStream.Write(sendBytes, 0, sendBytes.Length);

				// Reads the NetworkStream into a byte buffer.
				byte[] bytes = new byte[tcpClient.ReceiveBufferSize];
				networkStream.Read(bytes, 0, Convert.ToInt32(tcpClient.ReceiveBufferSize));

				// Returns the data received from the host to the console.
				string returndata = Encoding.ASCII.GetString(bytes);
				System.Console.WriteLine("This is what the host returned to you: " + 
					returndata);
			} catch (System.Exception exp) {
				System.Console.WriteLine(exp.Message);
			}
			System.Console.ReadLine();
		}
	}
}
