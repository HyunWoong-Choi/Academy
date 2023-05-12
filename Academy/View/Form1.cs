using Academy.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy.View
{
    public partial class Form1 : Form
    {
        StudentController studentController;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            studentController.학원등록(tbName.Text, tbPhoneNumber.Text, 
                   rbPiano.Checked, rbGuitar.Checked);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentController = new StudentController();
        }
    }
}
