using System;
using System.Collections.Generic;
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

namespace WinSCPExample
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
            WinSCP.SessionOptions sessionOptions = new WinSCP.SessionOptions();

            sessionOptions.HostName = "";
            sessionOptions.Password = "";
            sessionOptions.PortNumber = 22;

            List<object> objList = new List<object>();
            int[] bacon = new int[5] { 0, 1, 2, 3, 4 };
            
            

            foreach (var item in bacon)
            {
                objList.Add(new object());
               MessageBox.Show(objList[0].GetType().ToString());
            }
            
        }
    }
}
