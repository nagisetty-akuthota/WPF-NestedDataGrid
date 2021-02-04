using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_NestedDataGrid.Models
{
    public class Student:BaseModel
    {
        private int id;
        private string name;
        private DateTime birthday;
        private List<Marks> myMarks;

        public int Id {
            get { return id; }
            set
            {
                id = value;
                RaisePropertyChanged("Id");
            }
        }
        public string Name {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged("Name");
            }
        }
        public DateTime Birthday {
            get { return birthday; }
            set
            {
                birthday = value;
                RaisePropertyChanged("Birthday");
            }
        }
        public List<Marks> MyMarks {
            get { return myMarks; }
            set
            {
                myMarks = value;
                RaisePropertyChanged("MyMarks");
            }
        }
    }
}
