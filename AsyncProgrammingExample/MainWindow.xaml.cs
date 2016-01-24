using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            DownloadHtmlAsync("http://msdn.microsoft.com");
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
    }
}
