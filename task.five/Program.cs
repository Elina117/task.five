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


        static string task2(List<string[]> ph)
        {

            string phrase1 = "Drinks All Round! Free Beers on Bjorg!";
            string phrase2 = "Ой, Бьорг - пончик! Ни для кого пива!";

            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < ph[0].Length; i++)
            {
                if (ph[0][i] == "5")
                {
                    counter1++;
                }
            }
            for (int j = 0; j < ph[1].Length; j++)
                if (ph[0][j] == "5")
                {
                    counter2++;
                }
            return counter2 == counter1 ? phrase1 : phrase2;

        }


        public struct citizen
        {
            public string name;
            public int pasport;
            public string problem; //number and discription
            public int temperament; //0-10
            public int brain; //0-1

            public citizen(string name, int pasport, string problem, int temperament, int brain)
            {
                this.name = name;
                this.pasport = pasport;
                this.problem = problem;
                this.temperament = temperament;
                this.brain = brain;
            }


            public void PrintCitizen()
            {
                Console.WriteLine($"{name}, {pasport}, {problem}, {temperament}, {brain}");
            }

        }
        public static void task3()
        {
            citizen citizen1 = new citizen("Элина", 886322, "Проблема с отоплением", 6, 1);
            citizen citizen2 = new citizen("Настя", 886542, "Проблема с оплатой", 8, 0);
            citizen citizen3 = new citizen("Даша", 886322, "Другоем", 6, 1);
            citizen citizen4 = new citizen("Рустам", 886322, "Проблема с отоплением", 6, 1);
            citizen citizen5 = new citizen("Артем", 886322, "Проблема с оплатой", 6, 0);
            citizen citizen6 = new citizen("Данил", 886322, "Другое", 6, 1);

            Stack<citizen> zhekh = new Stack<citizen>();

            LinkedList<string> window1 = new LinkedList<string>(); //проблема с оплатой
            LinkedList<string> window2 = new LinkedList<string>(); //проблема с отоплением
            LinkedList<string> window3 = new LinkedList<string>(); //другое

            zhekh.Push(citizen1);
            zhekh.Push(citizen2);
            zhekh.Push(citizen3);
            zhekh.Push(citizen4);
            zhekh.Push(citizen5);
            zhekh.Push(citizen6);

            int i = zhekh.Count;

            while (i>0)
            {
                var elem1 = zhekh.Pop();
                if (elem1.problem == "Проблема с оплатой")
                {
                    string name = elem1.name;
                    int scandal = elem1.temperament;
                    int mind = elem1.brain;
                    Console.WriteLine(name + " ,Вставайте в первое окно");

                    if (mind == 1)
                    {
                        if (scandal < 5)
                        {
                            window2.AddLast(name);
                        }
                        else
                        {
                            if (window2.Count > 0)
                            {
                                Console.WriteLine(name + $", перед вами {window2.Count} людей. Сколько хотите обогнать?");
                                byte obgon = Convert.ToByte(Console.ReadLine());
                                if (obgon < window2.Count)
                                {
                                    window2.AddBefore(window2.Last, name);
                                }
                                else
                                {
                                    window2.AddLast(name);
                                }

                            }
                        }

                    }
                    else
                    {
                        Random r = new Random();
                        int rndWin = r.Next(0, 2);
                        if (rndWin == 0)
                        {
                            if (scandal < 5)
                            {
                                window1.AddLast(name);
                            }
                            else
                            {
                                if (window2.Count > 0)
                                {
                                    Console.Write(name + $", перед вами {window1.Count} человек. Сколько хотите обогнать? ");
                                    byte obgon = Convert.ToByte(Console.ReadLine());
                                    if (obgon < window1.Count)
                                    {
                                        window1.AddBefore(window1.Last, name);
                                    }
                                    else
                                    {
                                        window1.AddFirst(name);
                                    }
                                }
                                else
                                {
                                    window1.AddLast(name);
                                }
                            }
                        }
                        else

                        {
                            if (scandal < 5)
                            {
                                window3.AddLast(name);
                            }
                            else
                            {
                                if (window3.Count > 0)
                                {
                                    Console.Write(name + $", перед вами {window3.Count} человек. Сколько человек вы хотите обогнать? ");
                                    byte temp = Convert.ToByte(Console.ReadLine());
                                    if (temp < window3.Count)
                                    {
                                        window1.AddBefore(window3.Last, name);
                                    }
                                    else
                                    {
                                        window3.AddFirst(name);
                                    }
                                }
                                else
                                {
                                    window3.AddLast(name);
                                }
                            }

                        }
                    }

                } else if (elem1.problem == "Проблема с отоплением")
                    {
                        string name = elem1.name;
                        int scandal = elem1.temperament;
                        int mind = elem1.brain;
                        Console.WriteLine(name + " ,Вставайте в первое окно");
                        if (mind == 1)
                        {
                            if (scandal < 5)
                            {
                                window2.AddLast(name);
                            }
                            else
                            {
                                if (window2.Count > 0)
                                {
                                    Console.WriteLine(name + $", перед вами {window2.Count} людей. Сколько хотите обогнать?");
                                    byte obgon = Convert.ToByte(Console.ReadLine());
                                    if (obgon < window2.Count)
                                    {
                                        window2.AddBefore(window2.Last, name);
                                    }
                                    else
                                    {
                                        window2.AddLast(name);
                                    }

                                }
                            }
                        }
                        else
                        {
                            Random r = new Random();
                            int rndWin = r.Next(0, 2);
                            if (rndWin == 0)
                            {
                                if (scandal < 5)
                                {
                                    window1.AddLast(name);
                                }
                                else
                                {
                                    if (window2.Count > 0)
                                    {
                                        Console.Write(name + $", перед вами {window1.Count} человек. Сколько хотите обогнать? ");
                                        byte obgon = Convert.ToByte(Console.ReadLine());
                                        if (obgon < window1.Count)
                                        {
                                            window1.AddBefore(window1.Last, name);
                                        }
                                        else
                                        {
                                            window1.AddFirst(name);
                                        }
                                    }
                                    else
                                    {
                                        window1.AddLast(name);
                                    }
                                }
                            }
                            else
                            {
                                if (scandal < 5)
                                {
                                    window3.AddLast(name);
                                }
                                else
                                {
                                    if (window3.Count > 0)
                                    {
                                        Console.Write(name + $", перед вами {window3.Count} человек. Сколько человек вы хотите обогнать? ");
                                        byte temp = Convert.ToByte(Console.ReadLine());
                                        if (temp < window3.Count)
                                        {
                                            window1.AddBefore(window3.Last, name);
                                        }
                                        else
                                        {
                                            window3.AddFirst(name);
                                        }
                                    }
                                    else
                                    {
                                        window3.AddLast(name);
                                    }
                                }
                            }
                        }
                }
                    else
                    {
                        string name = elem1.name;
                        int scandal = elem1.temperament;
                        int mind = elem1.brain;
                        Console.WriteLine(name + " ,Вставайте в первое окно");
                        if (mind == 1)
                        {
                            if (scandal < 5)
                            {
                                window2.AddLast(name);
                            }
                            else
                            {
                                if (window2.Count > 0)
                                {
                                    Console.WriteLine(name + $", перед вами {window2.Count} людей. Сколько хотите обогнать?");
                                    byte obgon = Convert.ToByte(Console.ReadLine());
                                    if (obgon < window2.Count)
                                    {
                                        window2.AddBefore(window2.Last, name);
                                    }
                                    else
                                    {
                                        window2.AddLast(name);
                                    }

                                }
                            }
                        }
                        else
                        {
                            Random r = new Random();
                            int rndWin = r.Next(0, 2);
                            if (rndWin == 0)
                            {
                                if (scandal < 5)
                                {
                                    window1.AddLast(name);
                                }
                                else
                                {
                                    if (window2.Count > 0)
                                    {
                                        Console.Write(name + $", перед вами {window1.Count} человек. Сколько хотите обогнать? ");
                                        byte obgon = Convert.ToByte(Console.ReadLine());
                                        if (obgon < window1.Count)
                                        {
                                            window1.AddBefore(window1.Last, name);
                                        }
                                        else
                                        {
                                            window1.AddFirst(name);
                                        }
                                    }
                                    else
                                    {
                                        window1.AddLast(name);
                                    }
                                }
                            }
                            else
                            {
                                if (scandal < 5)
                                {
                                    window3.AddLast(name);
                                }
                                else
                                {
                                    if (window3.Count > 0)
                                    {
                                        Console.Write(name + $", перед вами {window3.Count} человек. Сколько человек вы хотите обогнать? ");
                                        byte temp = Convert.ToByte(Console.ReadLine());
                                        if (temp < window3.Count)
                                        {
                                            window1.AddBefore(window3.Last, name);
                                        }
                                        else
                                        {
                                            window3.AddFirst(name);
                                        }
                                    }
                                    else
                                    {
                                        window3.AddLast(name);
                                    }
                                }
                            }

                        }
                    }
                    i--;
            }
                Console.WriteLine("Очередь в первое окно:");
                foreach (string name in window1)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Очередь во второе окно:");
                foreach (string name in window2)
                {
                    Console.WriteLine(name);
                }
                Console.WriteLine("Очередь в третье окно окно:");
                foreach (string name in window3)
                {
                    Console.WriteLine(name);
                }




        }

        public static void task4(int[][] graph)
        {
            Console.WriteLine("Задание 4 Обход графа в ширину");
            Random rand = new Random();
            Queue<int> NumbOfVersh = new Queue<int>();
            Console.Write("Введите количество вершин: ");
            int KolishVersh = int.Parse(Console.ReadLine());
            
            if (KolishVersh >= 3)
            {
                bool[] UsedVersh = new bool[KolishVersh + 1];
                int[][] SmezhVersh = new int[KolishVersh + 1][];

                for (int i = 0; i < KolishVersh + 1; i++)
                {
                    SmezhVersh[i] = new int[KolishVersh + 1];
                    Console.Write($"\n{i + 1} вершина - [");
                    for (int j = 0; j < KolishVersh + 1; j++)
                    {
                        SmezhVersh[i][j] = rand.Next(0, 2);
                    }
                    SmezhVersh[i][i] = 0;
                    foreach (var item in SmezhVersh[i])
                    {
                        Console.Write($" {item}");
                    }
                    Console.Write("]\n");
                }
                UsedVersh[KolishVersh] = true;//информация о том, посещали мы вершину или нет 
                NumbOfVersh.Enqueue(KolishVersh);
                Console.WriteLine("Начинаем обход с {0} вершины", KolishVersh + 1);
                while (NumbOfVersh.Count != 0)
                {
                    KolishVersh = NumbOfVersh.Peek();
                    NumbOfVersh.Dequeue();
                    Console.WriteLine("Перешли к узлу {0}", KolishVersh + 1);

                    for (int i = 0; i < SmezhVersh.Length; i++)
                    {
                        if (Convert.ToBoolean(SmezhVersh[KolishVersh][i]))
                        {
                            int v = i;
                            if (!UsedVersh[v])
                            {
                                UsedVersh[v] = true;
                                NumbOfVersh.Enqueue(v);
                                Console.WriteLine("Добавили в очередь узел {0}", v + 1);
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Количество вершин некорректно");
            }
        }





        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            task1();
            Console.ReadKey();


            Console.WriteLine("Task2");
            List<string[]> lst = new List<string[]>();
            Console.WriteLine("Введите массив чисел первого клана (0..9)");
            string[] arr1 = Console.ReadLine().Split(' ');
            Console.WriteLine("Введите массив чисел второго клана (0..9)");
            string[] arr2 = Console.ReadLine().Split(' ');
            lst.Add(arr1);
            lst.Add(arr2);
            Console.WriteLine(task2(lst));


            Console.WriteLine("Task3");
            task3();

            Console.WriteLine("Task4");
            //task4();


        }

    }   
    
}

