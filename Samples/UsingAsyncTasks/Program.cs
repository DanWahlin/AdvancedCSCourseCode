using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace UsingAsyncTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            DownloadAndPrintString("http://microsoft.com");
            DoAdd();

            Console.Read();
        }

        private async static void DoAdd()
        {
            var val = await AddAsync(1, 1);
            Console.WriteLine("Called AddAsync. Return value is: " + val);
            Console.WriteLine(Environment.NewLine);
        }

        private static async void DownloadAndPrintString(string url)
        {
            var wc = new WebClient();
            var val = await wc.DownloadStringTaskAsync(url);
            Console.WriteLine(val);
        }

        public static Task<int> AddAsync(int x, int y)
        {
            var task = Task<int>.Factory.StartNew(() => x + y);
            return task;
        }

        public static Task AddAsync2(int x, int y)
        {
            var task = Task.Factory.StartNew(() => new Customer());
            return task;
        }

    }

    public class Customer
    {

    }
}
