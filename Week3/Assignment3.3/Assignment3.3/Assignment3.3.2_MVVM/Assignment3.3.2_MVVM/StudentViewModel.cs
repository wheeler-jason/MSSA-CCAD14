using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3._3._2_MVVM
{
    public class StudentViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Student>? _studentList;
        public ObservableCollection<Student> StudentList
        {
            get 
            {
                if (_studentList != null)
                    return _studentList;
                else
                {
                    _studentList = new ObservableCollection<Student>();
                    return _studentList;
                }
            }
            set
            {
                _studentList = value;
                OnPropertyChanged(nameof(StudentList));
            }
        }

        public StudentViewModel()
        {
            StudentList = new ObservableCollection<Student>();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
