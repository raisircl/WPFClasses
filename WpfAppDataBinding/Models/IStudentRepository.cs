using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDataBinding.Models
{
    public interface IStudentRepository
    {
        public ObservableCollection<Student> GetAll();
        public Student GetById(int id);
        public Student GetByName(string name);
        public void Update(Student student);
        public void DeleteById(int id);
        public void Add(Student student);

    }
}
