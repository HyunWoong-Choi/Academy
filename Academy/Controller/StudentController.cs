using Academy.Model;
using Academy.ModelContainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Controller
{
    public class StudentController
    {
        public StudentContainer studentContainer;

        public StudentController() {
            studentContainer = new StudentContainer();
        }


        // 
        // 학생을 등록한다.
        // 학생이 돈을 내야된다.
        // 학생 정보에 등록.
        public void 학원등록(string name, string phoneNumber, bool piano, bool guitar)
        {
            studentContainer.등록한다(name, phoneNumber, piano, guitar);
            studentContainer.돈냄(name, 10000);

        }

    }
}
