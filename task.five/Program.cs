using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static task.five.Program;

namespace task.five
{
    class Program 
    {
        public struct student
        {
            public string name;
            public string secondname;
            public DateTime birthday;
            public string exam;
            public int ball;

            public student(string name, string secondname, DateTime birthday, string exam, int ball)
            {
                this.name = name;
                this.secondname = secondname;
                this.birthday = birthday;
                this.exam = exam;
                this.ball = ball;
            }


            public void PrintStudent()
            {
                Console.WriteLine($"{name} {secondname}\n{birthday.ToShortDateString()}\n{exam} {ball}");
            }
        }
        static void task1()
        {
            List<student> addstudent(List<student> students)
            {
                try
                {
                    student New_Student;

                    Console.Write("name: ");
                    New_Student.name = Console.ReadLine();
                    Console.Write("secondname: ");
                    New_Student.secondname = Console.ReadLine();
                    Console.Write("birthday: ");
                    New_Student.birthday = DateTime.Parse(Console.ReadLine());
                    Console.Write("exam: ");
                    New_Student.exam = Console.ReadLine();
                    Console.Write("ball: ");
                    New_Student.ball = int.Parse(Console.ReadLine());

                    students.Add(New_Student);
                    

                }
                catch(FormatException)
                {
                    Console.Clear();
                }
                finally
                {
                    Console.WriteLine("thank u))");
                }
                return students;
            }
            List<student> inputstudent(List<student> students)
            {
                student student_1 = new student("Элина", "Галимова", DateTime.Parse("20/09/2004"), "Информатика", 260);
                student student_2 = new student("Диана", "Хамидуллина", DateTime.Parse("14/10/2004"), "Английский", 300);
                student student_3 = new student("Петр", "Петрович", DateTime.Parse("10/12/2004"), "Информатика", 260);
                student student_4 = new student("Алина", "Османова", DateTime.Parse("01/09/2004"), "Физика", 260);
                student student_5 = new student("Алена", "Германова", DateTime.Parse("20/09/2004"), "Информатика", 260);
                student student_6 = new student("Диана", "Шишкина", DateTime.Parse("20/03/2004"), "География", 260);
                student student_7 = new student("Алексей", "Баранов", DateTime.Parse("31/01/2004"), "Литература", 260);
                student student_8 = new student("Артем", "Агапов", DateTime.Parse("16/06/2004"), "Информатика", 260);
                student student_9 = new student("Денис", "Черников", DateTime.Parse("15/05/2004"), "Физкультура", 260);
                student student_10 = new student("Анастасия", "Сташкевич", DateTime.Parse("20/09/2003"), "Информатика", 260);

                students.Add(student_1);
                students.Add(student_2);
                students.Add(student_3);
                students.Add(student_4);
                students.Add(student_5);
                students.Add(student_6);
                students.Add(student_7);
                students.Add(student_8);
                students.Add(student_9);
                students.Add(student_10);


                return students;

            }

            List<student> deletestudent(List<student> students)
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();
                Console.Write("Enter secondname: ");
                string secondname = Console.ReadLine();

                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].name == name & students[i].secondname == secondname)
                    {
                        students.RemoveAt(i);
                    }
                }

                return students;
            }

            List<student> sortstudent(List<student> students)
            {
                var sortedstudent = students.OrderBy(i => i.ball);
                return students;
            }

            void PrintStudent(List<student> students)
            {

                foreach (student i in students)
                {
                    i.PrintStudent();
                }
            }


            string str = "start";
            List<student> students = new List<student>();
            students = inputstudent(students);
            while (str!="end")
            {
                if (str == "new student")
                {
                    students = addstudent(students);
                    PrintStudent(students);
                }
                else if (str == "delete")
                {
                    students = deletestudent(students);
                    PrintStudent(students);

                }
                else if (str == "sort")
                {

                    students = sortstudent(students);
                    PrintStudent(students);

                }
            }
        }

        static void Main(string[] args)
        {
            task1();
            Console.ReadKey();

        }

    }   
    
}

