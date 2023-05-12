using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Model
{
    public class Student
    {
        // id, name, phoneNumber
        public string id;
        public string name;
        public string phoneNumber;
        bool piano;
        bool guitar;

        public Student(string id, string name, string phoneNumber, bool piano, bool guitar)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.piano = piano;
            this.guitar = guitar;
        }
    }
}
