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

            if (listDays.SelectedIndex == -1)
            {
                return;
            }

            textConsole.Clear();
       
        

            OOTODay details = AllUsers._users[listBox.SelectedIndex]._timeOff[listDays.SelectedIndex];

            textConsole.Text = details.Date + " " + details.Duration + " " + details.Reason;


        }

        private void UpdateDaysBox()
        {

            //Error Prevention
            if (listBox.SelectedIndex == -1)
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
            if (String.IsNullOrEmpty(textBox.Text))
            {
                MessageBox.Show("Enter a first name");
                return;
            }
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Enter a last name");
                return;
            }

            AllUsers._users.Add(new Person(textBox.Text, textBox1.Text));
            listBox.Items.Add(textBox.Text + " " + textBox1.Text);
            textBox1.Clear();
            textBox.Clear();


        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            UpdateDaysBox();
            UpdateTotalOOTOTime();
        }

        private void listDays_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DisplayDayDetails();
        }

        private void UpdateTotalOOTOTime()
        {
            Person tempPerson;
            tempPerson = AllUsers._users[listBox.SelectedIndex];

            lblTotalTime.Content = "Total Time OOTO: " + tempPerson.GetTotalTimeOff();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            foreach (var person in AllUsers._users)
            {
               bool success =  OOTOWriter.SavePerson(person, @"c:\projects\" + person.FirstName + person.LastName + ".json");
            }
        }
    }
}
