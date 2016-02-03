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

namespace OOTO_Tracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserTracker AllUsers;

        public MainWindow()
        {
            InitializeComponent();
            AllUsers = new UserTracker();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                System.Windows.MessageBox.Show("No users selected");
                return;
            }

            if (textrReason.Text == "")
            {
                System.Windows.MessageBox.Show("No reason entered");
                return;
            }

            if (textHours.Text == "")
            {
                System.Windows.MessageBox.Show("No hours entered");
                return;
            }



            AllUsers._users[listBox.SelectedIndex].AddTimeOff(System.Convert.ToDouble(textHours.Text), textrReason.Text);
            
            DisplayDetails();

            textHours.Clear();
            textrReason.Clear();
            UpdateDaysBox();

        }

        private void TotalTimeOff()
        {
            TimeSpan timeOff = AllUsers._users[listBox.SelectedIndex].GetTotalTimeOff();
            System.Windows.MessageBox.Show(String.Format(AllUsers._users[listBox.SelectedIndex].FirstName + " has been off for {0} hours", timeOff.TotalHours));
        }

        private void DisplayDetails()
        {
            textConsole.Clear();
            foreach (var item in AllUsers._users[listBox.SelectedIndex].GetOOTODays())
            {
                textConsole.AppendText(item.Date + " " + item.Duration + " " + item.Reason + "\n");
            }
        }

        private void DisplayDayDetails()
        {
            textConsole.Clear();
       
        

            OOTODay details = AllUsers._users[listBox.SelectedIndex]._timeOff[listDays.SelectedIndex];

            textConsole.Text = details.Date + " " + details.Duration + " " + details.Reason;


        }

        private void UpdateDaysBox()
        {

            //Error Prevention
            if (listDays.SelectedIndex == -1)
            {
                return;
            }


            listDays.Items.Clear();
            foreach (var item in AllUsers._users[listBox.SelectedIndex].GetOOTODays())
            {
                listDays.Items.Add(item.Date);
            }
        }



        private void button1_Click(object sender, RoutedEventArgs e)
        {

            AllUsers._users.Add(new Person(textBox1.Text, textBox.Text));
            listBox.Items.Add(textBox.Text + " " + textBox1.Text);


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            UpdateDaysBox();
        }

        private void listDays_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayDayDetails();
        }
    }
}
