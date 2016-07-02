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

namespace GUI_Application9
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

        private List<Student> listOfStudents = new List<Student>();
        int currentListIndx;

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student studnt = new Student();

            if (txtFirstName.Text == null || txtFirstName.Text == "" || txtLastName.Text == null || txtLastName.Text == "" || txtCity.Text == null || txtCity.Text == "")
            {
                MessageBox.Show("Could not create new student due to empty fields");
                txtFirstName.Clear();
                txtLastName.Clear();
                txtCity.Clear();
            }
            else
            {
                studnt.FirstName = txtFirstName.Text;
                studnt.LastName = txtLastName.Text;
                studnt.City = txtCity.Text;
                listOfStudents.Add(studnt);
                MessageBox.Show("New student created");
                currentListIndx = listOfStudents.Count;
                txtFirstName.Clear();
                txtLastName.Clear();
                txtCity.Clear();
            }

        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            if (currentListIndx < listOfStudents.Count - 1)
            {
                txtFirstName.Text = listOfStudents[currentListIndx + 1].FirstName;
                txtLastName.Text = listOfStudents[currentListIndx + 1].LastName.ToString();
                txtCity.Text = listOfStudents[currentListIndx + 1].City.ToString();
                currentListIndx += 1;
            }
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            if (currentListIndx > 0 && listOfStudents.Count != 1)
            {
                txtFirstName.Text = listOfStudents[currentListIndx - 1].FirstName;
                txtLastName.Text = listOfStudents[currentListIndx - 1].LastName.ToString();
                txtCity.Text = listOfStudents[currentListIndx - 1].City.ToString();
                currentListIndx -= 1;
            }
        }
    }
}