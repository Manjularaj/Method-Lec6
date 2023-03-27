using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
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

namespace Method_Lec6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();
        


        public MainWindow()
        {

            InitializeComponent();
            csi122 = new Course("CSI 122", "Will Cram");


        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {

            AddStudentToList();

            
            int lastStudentEntered = students.Count - 1;
            Student lastStudent = (students[lastStudentEntered]);


            csi122.EnrollStudent(lastStudent);

            MessageBox.Show(csi122.CourseRoster.Count.ToString());

            runDisplay.Text = "";

            runDisplay.Text = csi122.CourseName + " " + csi122.Teacher + "\n";



            foreach (Student student in csi122.CourseRoster)
            {
                runDisplay.Text += student + "\n";

            }

            //DisplayStudents();

            //Student s = students[0];

            //How do I display my student FROM my list
            //runDisplay.Text = s. FirstName + " " +s.LastName + " " + s.CsiGrade + " " + s.GenEdGrade;
            //runDisplay.Text = s.ToString();

        }//btnAddStudent_click

        public void AddStudentToList()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            double csiGrade = double.Parse(txtCSIGrade.Text);
            double genEdGrade = double.Parse(txtGenEdGrade.Text);

            //Add student to my List of students
            students.Add(new Student(firstName, lastName, csiGrade, genEdGrade));
        }


        public void DisplayStudents()
        {
            //Clear our Display
            runDisplay.Text = "";

            //Show all of our Students
            for (int i =0; i < students.Count; i++)
            {
                runDisplay.Text += students[i] + "\n";;

            }


            //            What is a method ?
            //Ans;  A block of code that is given a name, and runs when it is called


            //What is the purpose of a method?
            //Ans; Easy to code, easy to read, easy to refactor, and easy to reuse


            //What is a class method?
            //Ans; A class method directly interacts with the memebers of a class

            //Review: What’s the name for any field, constructor, property or method that is part of a class?
            //Ans; members

            //Review: What are the 4 parts of declaring a method?
            //Ans;  Access Modifier - return type - Name - Paremeters


            //What keyword allows you to access members related to the specific instance?
            //Ans; this.

            //A method build inside a class has access to what, even it’s access modifier is set to private?
            //Ans; a method that is built inside a class has access to all the members of that class, even if they are marked as private.

            //What does “override .ToString()” allow us to do?

            //Ans; allows us to override the default implementation of the ToString() method that is inherited from the Object class.

            //You use the* ____ operator * do you use to access members inside of an instanced class?
            //Ans:dot opreator

         





        }
    }
}
