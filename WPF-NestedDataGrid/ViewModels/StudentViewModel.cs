using System;
using System.Collections.Generic;
using System.Text;
using WPF_NestedDataGrid.Models;

namespace WPF_NestedDataGrid.ViewModels
{
    public class StudentViewModel:BaseViewModel
    {
        private Student student;
        private List<Student> studentList;

        public StudentViewModel() {

            Student = new Student();
            StudentList = new List<Student>();

            #region Data Preparatoin

            Marks JohnMark = new Marks();
            JohnMark.English = 75;
            JohnMark.Maths = 85;
            JohnMark.Science = 95;

            Marks RichardMark = new Marks();
            RichardMark.English = 70;
            RichardMark.Maths = 80;
            RichardMark.Science = 90;

            Marks SamMark = new Marks();
            SamMark.English = 72;
            SamMark.Maths = 82;
            SamMark.Science = 92;

            List<Marks> MarksList = new List<Marks>();
            MarksList.Add(JohnMark);
            MarksList.Add(RichardMark);
            MarksList.Add(SamMark);

            StudentList.Add(new Student() { Id = 1, Name = "John Doe", Birthday = new DateTime(1971, 7, 23), MyMarks = MarksList });
            StudentList.Add(new Student() { Id = 2, Name = "Richard Doe", Birthday = new DateTime(1974, 1, 17), MyMarks = MarksList });
            StudentList.Add(new Student() { Id = 3, Name = "Sammy Doe", Birthday = new DateTime(1991, 9, 2), MyMarks = MarksList });
            #endregion

        }
        public Student Student
        {
            get { return student; }
            set { student = value; RaisePropertyChanged("Student"); }
        }

        public List<Student> StudentList {
            get { return studentList; }
            set { studentList = value; RaisePropertyChanged("StudentList"); }
        }
    }
}
