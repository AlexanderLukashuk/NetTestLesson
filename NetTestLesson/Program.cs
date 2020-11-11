using System;
using System.Net;
using System.Threading.Tasks;

namespace NetTestLesson
{
    class Program
    {
        private static string data = string.Empty;
        static async Task Main(string[] args)
        {
            using (var webClient = new WebClient())
            {
                //webClient.DownloadStringCompleted += StringDowload;
                //webClient.DownloadStringAsync(new Uri("https://mail.ru"));

                //webClient.DownloadStringTaskAsync("https://mail.ru");
                
                Console.WriteLine(await webClient.DownloadStringTaskAsync("https://mail.ru"));
                Console.ReadLine();
            }

            var webRequest = WebRequest.Create(("https://mail.ru"));
            webRequest.Method = "GET";
            var webResponse = webRequest.GetResponse();
            webResponse.Close();

            //var httpRecuest = HttpWebRequest.Create("https://mail.ru");
        }

        private static void StringDowload(object sender, DownloadStringCompletedEventArgs e)
        {
            data = e.Result;
        }
    }
}
