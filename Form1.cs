using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTable
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>()
        {
            new Student() {major="뉴미디어 소프트웨어과", name="김미림", student_number=3101, math_score=100, english_score=75},
            new Student() {major="뉴미디어 웹솔루션과", name="이가람", student_number=3305, math_score=80, english_score=90},
            new Student() {major="뉴미디어 소프트웨어과", name="방예리", student_number=3110, math_score=90, english_score=82},
            new Student() {major="뉴미디어 소프트웨어과", name="우도희", student_number=3206, math_score=75, english_score=100},
            new Student() {major="뉴미디어 디자인과", name="박수빈", student_number=3507, math_score=65, english_score=25},
            new Student() {major="뉴미디어 웹솔루션과", name="전지우", student_number=3312, math_score=88, english_score=90},
            new Student() {major="뉴미디어 웹솔루션과", name="민리나", student_number=3304, math_score=98, english_score=95},
            new Student() {major="뉴미디어 디자인과", name="박민지", student_number=3603, math_score=60, english_score=70},
            new Student() {major="뉴미디어 소프트웨어과", name="권라온", student_number=3201, math_score=43, english_score=80},
            new Student() {major="뉴미디어 웹솔루션과", name="배로나", student_number=3205, math_score=75, english_score=65},
            new Student() {major="뉴미디어 디자인과", name="천리안", student_number=3512, math_score=97, english_score=75},
            new Student() {major="뉴미디어 웹솔루션과", name="이지호", student_number=3306, math_score=28, english_score=80},
            new Student() {major="뉴미디어 소프트웨어과", name="김이진", student_number=3102, math_score=64, english_score=70},
            new Student() {major="뉴미디어 디자인과", name="양미희", student_number=3508, math_score=83, english_score=60},
            new Student() {major="뉴미디어 디자인과", name="장해린", student_number=3611, math_score=100, english_score=90},
            new Student() {major="뉴미디어 디자인과", name="김소혜", student_number=3501, math_score=93, english_score=95},
            new Student() {major="뉴미디어 소프트웨어과", name="임민주", student_number=3111, math_score=70, english_score=65},
            new Student() {major="뉴미디어 소프트웨어과", name="차승희", student_number=3113, math_score=65, english_score=85},
            new Student() {major="뉴미디어 웹솔루션과", name="이예빈", student_number=3310, math_score=82, english_score=100},
            new Student() {major="뉴미디어 웹솔루션과", name="김지율", student_number=3301, math_score=10, english_score=100},
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = students;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              orderby item.major
                                              select item;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = students;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              orderby item.english_score descending
                                              select item;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
                                              orderby item.name
                                              select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentBindingSource.DataSource = from item in students
            where item.math_score >= 80
            orderby item.math_score descending
            select item;
        }
    }
}
