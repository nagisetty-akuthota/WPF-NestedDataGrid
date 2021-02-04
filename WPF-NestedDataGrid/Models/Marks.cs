using System;
using System.Collections.Generic;
using System.Text;

namespace WPF_NestedDataGrid.Models
{
    public class Marks : BaseModel
    {
        private double english;
        private double maths;
        private double science;

        public double English
        {
            get { return english; }
            set
            {
                english = value;
                RaisePropertyChanged("English");
            }
        }

        public double Maths {
            get { return maths; }
            set
            {
                maths = value;
                RaisePropertyChanged("Maths");
            }
        }

        public double Science {
            get { return science; }
            set
            {
                science = value;
                RaisePropertyChanged("Science");
            }
        }
    }
}
