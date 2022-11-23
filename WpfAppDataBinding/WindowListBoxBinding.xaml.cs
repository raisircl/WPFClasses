using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using System.Windows.Shapes;
using WpfAppDataBinding.Models;
namespace WpfAppDataBinding
{
    /// <summary>
    /// Interaction logic for WindowListBoxBinding.xaml
    /// </summary>
    public partial class WindowListBoxBinding : Window
    {
        public WindowListBoxBinding()
        {
            InitializeComponent();
        }
        StudentRepository studentRepository=new StudentRepository();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            loadStudents();
          

        }
        void loadStudents()
        {


            ObservableCollection<Student> s = studentRepository.GetAll();
            lstStudents.ItemsSource = s;

        }

        private void btnadd_click(object sender, RoutedEventArgs e)
        {
            Student student = new Student() { RollNo = 7, Name = "Amit", Percentage = 80 };
            studentRepository.Add(student);
            loadStudents();
        }
    }
}
