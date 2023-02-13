using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Numerics;

namespace Cs_hw_3_ANM
{
    public static class Vector { }
    class Student
    {
        static int id = 0;
        public int Id { get; set; } = id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public double Avg { get; set; }

        static string Group;
        static Student()
        {
            Group = "PV221";            
        }
        public Student() : this(" ", " ", 0, 0.0) { }

        public Student(string _Name, string _Surname, int _Age, double _Avg)
        {
            Name = _Name;
            Surname = _Surname;
            Age = _Age;
            Avg = _Avg;
        }

        public void SetSt()
        {
            Name = $"Name {++id}";
            Surname = $"Surname {id}";
            Age = 18+id;
            
        }
        public void St_add()
        {
            Write($"Введите имя: ");
            Name = ReadLine(); WriteLine();
            Write($"Введите фамилию: ");
            Surname = ReadLine(); WriteLine();
            Write($"Введите возраст: ");
            Age = int.Parse(ReadLine()); WriteLine();

        }
        public override string ToString()
        {
            return $"{Id+1}  {Surname} {Name}  {Age}  {Avg}  {Group}";
        }

        static public void Add_st(ref List<Student> st_all, out Student st, int num)
        {
            st = new Student();            
            if (num == 1) st.SetSt();
            else st.St_add();
            st_all.Add(st);
        }

    }
    class Program
    {
       
        static void Main(string[] args)
        {
            Title = "Домашнее задание № 3";
            List<Student> students=new List<Student>();
            bool key = true;

            for (int i = 0; i < 10; i++)
            {
                Student.Add_st(ref students, out Student st, 1);                
            }
            do
            {
                Clear();
                WriteLine(@"        Домашнее задание № 3
        Для класса Студент создать методы с использованием 
        операторов ref и out для полей этого класса.

        1 - Добавить студента
        2 - Вывести на экран
        0 - Выход");
                WriteLine();
                Write("\tEnter: ");
                string str = ReadLine();
                switch (str)
                {
                    case "1":
                        {
                            Student.Add_st(ref students, out Student st, 0);
                        }
                        break;

                        break;
                    case "2":
                        {
                            foreach (var item in students)
                            {
                                WriteLine(item);
                            }
                        }
                        break;
                    case "0":
                        {
                            key = false;
                        }
                        break;
                    default:
                        WriteLine();
                        WriteLine("\tОшибка ввода");
                        break;
                } 
                WriteLine("\tНажмите \"Enter\" чтобы продолжить ... ");
                ReadLine();

            } while (key);      
        }
    }
}
