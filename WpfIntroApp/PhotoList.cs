using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIntroApp
{
    public class PhotoList : ObservableCollection<Photo>
    {
        private DirectoryInfo _directory;

        public PhotoList()
        {
        }

        public PhotoList(string path) : this(new DirectoryInfo(path))
        {
        }

        public PhotoList(DirectoryInfo directory)
        {
            _directory = directory;
            Update();
        }

        public string Path
        {
            set
            {
                _directory = new DirectoryInfo(value);
                Update();
            }
            get { return _directory.FullName; }
        }

        public DirectoryInfo Directory
        {
            set
            {
                _directory = value;
                Update();
            }
            get { return _directory; }
        }

        private void Update()
        {
            foreach (var f in _directory.GetFiles("*.jpg"))
            {
                Add(new Photo(f.FullName));
            }
        }
    }
}
