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
using System.Globalization;

namespace DateTimePicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///             

    public partial class MainWindow : Window
    {
        public DateTime myDate = new DateTime(2019, 2, 20, 23, 33, 0);
        public string dateString;
        public string visibleString;
        public string format;
        public string textFieldString;
        public DateTime inputDate = new DateTime(2019, 2, 20, 14, 33, 0);
        public DateTime now = DateTime.Now;
        public TextBox hours;
        public TextBox mins;
        public TextBox amPm;

        public MainWindow()
        {
            InitializeComponent();

            myCalendar.SelectedDate = DateTime.Now;
            format = myDate.ToString("MM/dd/yyyy");
            textFieldString = inputDate.ToString("h:mm tt");
            textBox.Text = textFieldString;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)// up hour
        {

            inputDate = inputDate.AddHours(1);
            textFieldString = inputDate.ToString("h:mm tt");
            textBox.Text = textFieldString;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)// down hour
        {
            inputDate = inputDate.AddHours(-1);
            textFieldString = inputDate.ToString("h:mm tt");
            textBox.Text = textFieldString;
        }

        private void Select_Click(object sender, RoutedEventArgs e)// select (print date)
        {

            myDate = myCalendar.SelectedDate ?? DateTime.Now;
            System.TimeSpan difference = myDate - now;
            int daysOff = Convert.ToInt32(difference.Days);
            daysOff++;
            if (myDate.DayOfYear == now.DayOfYear)
            {
                daysOff--;
            }
            string displayText;
            string daysOffString = daysOff.ToString();
            //string formated = myDate.ToString("MM/dd/yyyy");
            string formated = myDate.ToString("MMMM, dd, yyyy");

            string textFieldString = inputDate.ToString("h:mm tt");
            //textBox1.Text = daysOff.ToString();
            if (daysOff == 1)
            {
                displayText = "Your appointment is on " + formated + ", at " + textFieldString + ". It's " + daysOffString + " day from today.";
            }
            else
            {
                displayText = "Your appointment is on " + formated + ", at " + textFieldString + ". It's " + daysOffString + " days from today.";
            }
            textBox1.Text = displayText;
            //textBox1.Text = formated.ToString();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)// up min
        {
            inputDate = inputDate.AddMinutes(1);
            textFieldString = inputDate.ToString("h:mm tt");
            textBox.Text = textFieldString;
        }

        private void Button1_Click_1(object sender, RoutedEventArgs e)// down min
        {
            inputDate = inputDate.AddMinutes(-1);
            textFieldString = inputDate.ToString("h:mm tt");
            textBox.Text = textFieldString;
        }

        private void Button2_Click(object sender, RoutedEventArgs e)// AM/PM
        {
            inputDate = inputDate.AddHours(12);
            textFieldString = inputDate.ToString("h:mm tt");
            textBox.Text = textFieldString;
        }

    }
}
