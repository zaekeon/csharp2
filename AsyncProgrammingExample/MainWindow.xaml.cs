using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncProgrammingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            //DownloadHtmlAsync("http://msdn.microsoft.com");

            var html = await GetHtmlAsync("http://msdn.microsoft.com");
            MessageBox.Show(html.Substring(0, 10));

        }

        

        public string GetHtml(string url)
        {
            var webClient = new WebClient();

            return webClient.DownloadString(url);
        }

        public async Task<string> GetHtmlAsync(string url)
        {
            var webClient = new WebClient();
             return await webClient.DownloadStringTaskAsync(url);
        }



        public void DownloadHtml(string url)
        {
            var webClient = new System.Net.WebClient();
            var html = webClient.DownloadString(url);

            using (var streamWriter = new StreamWriter(@"c:\projects\results.html"))
            {

                streamWriter.Write(html);
            }

        }

        public async Task DownloadHtmlAsync(string url)  //async methods need the async keyword. returns a task object.  Use the generic version if you return an object/value
        {
            var webClient = new System.Net.WebClient();
            var html = await webClient.DownloadStringTaskAsync(url);

            using (var streamWriter = new StreamWriter(@"c:\projects\results.html"))
            {

                await streamWriter.WriteAsync(html);
            }



        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DateTime today = DateTime.Now;
            DateTime vault = new DateTime(2015, 10, 27);

            TimeSpan amountOfTime = today - vault;

            MessageBox.Show(Convert.ToString(amountOfTime.TotalDays));
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
