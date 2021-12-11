using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Student
    {
        public string _fullName;
        public int _course;
        public string _subject;
        public string _university;
        public string _email;
        public int _phoneNumber;
        public Student(string fullname, int course, string subject, string university, string email, int phoneNumber)
        {
            _fullName = fullname;
            _course = course;
            _subject = subject;
            _university = university;
            _email = email;
            _phoneNumber = phoneNumber;


        }
       

        public string FullInfo()
        {
            return $"{_fullName} {_course} {_subject} {_university} {_email} {_phoneNumber}";

        }
    }
}
