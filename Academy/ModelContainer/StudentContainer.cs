using Academy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Academy.ModelContainer
{
    public class StudentContainer
    {
        public List<Student> students;

        public StudentContainer()
        {
            students = new List<Student>();
        }

        // 등원한다, 퇴원한다, 기타를 연주한다, 피아노를 연주한다, 돈을 낸다
        public void 등록한다(string name, string phoneNumber, bool piano, bool guitar)
        {
            var s = new Student(Guid.NewGuid().ToString(), name, phoneNumber, piano, guitar);
            students.Add(s);
        }
        
        public void 등원한다(string studentName, DateTime time)
        {

        }

        public void 퇴원한다(string studentName, DateTime time)
        {

        }

        public void 연주(string studentName, string 악기)
        {

        }

        public void 돈냄(string studentName, int amount)
        {

        }

    }
}
