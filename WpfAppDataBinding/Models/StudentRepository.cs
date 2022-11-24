using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WpfAppDataBinding.Models
{
    public class StudentRepository : IStudentRepository
    {
        ObservableCollection<Student> students;
        //List<Student> students;
        public StudentRepository()
        {
            students = new ObservableCollection<Student>()
            {
                new Student(){RollNo=1,Name="Anil",Percentage=90},
                new Student(){RollNo=2,Name="Jatin",Percentage=70},
                new Student(){RollNo=3,Name="Ankit",Percentage=85},
                new Student(){RollNo=4,Name="Oman",Percentage=45},
                new Student(){RollNo=5,Name="Pulkit",Percentage=60},
                new Student(){RollNo=6,Name="Sunil",Percentage=55},

            };
        }
        public void Add(Student student)
        {
            students.Add(student);
        }

        public void DeleteById(int id)
        {
            var student =students.FirstOrDefault(x => x.RollNo == id);
            if (student != null)
            {
                students.Remove(student);
            }
        }

        public ObservableCollection<Student> GetAll()
        {
            return students;
        }

        public Student GetById(int id)
        {
            var student = students.FirstOrDefault(x => x.RollNo == id);
            return student;
        }

        public Student GetByName(string name)
        {
            var student = students.FirstOrDefault(x => x.Name == name);
            return student;
        }

        public void Update(Student student)
        {
           
            var updatedStudent = students.FirstOrDefault(x => x.RollNo == student.RollNo);
            if (updatedStudent != null)
            {
                int i = students.IndexOf(updatedStudent);
                if (i >= 0)
                {
                    students[i] = student;
                }
            }
           
        }
    }
}
