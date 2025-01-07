using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    public class Student
    {
        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;

        public Student()
        {
        }

        public Student(string name, bool gender, int age, int std, char div, double marks)
        {
            _name = name;
            _gender = gender;
            _age = age;
            _std = std;
            _div = div;
            _marks = marks;
        }

        public string name { get { return _name; } set { _name = value; } }

        public bool gender { get { return _gender; } set { _gender = value; } }

        public int age { get { return _age; } set { _age = value; } }

        public int std { get { return _std; } set { _std = value; } }

        public char div { get { return _div; } set { _div = value; } }

        public double marks { get { return _marks; } set { _marks = value; } }




        public void acceptData()
        {
            Console.WriteLine("Enter name: ");
            _name = Console.ReadLine();

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Gender: 1. Male 2.Female");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        {
                            _gender = true;
                            flag = false;
                            break;
                        }
                    case 2:
                        {
                            _gender = false;
                            flag = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Wrong choice!!");
                            break;
                        }
                }
            }

            Console.WriteLine("Enter Age: ");
            _age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Std: ");
            _std = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Div: ");
            _div = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Marks: ");
            _marks = int.Parse(Console.ReadLine());

        }

        public void displayData()
        {
            Console.WriteLine("Name: " + _name);

            if (_gender == true)
            {
                Console.WriteLine("Gender: Male");
            }
            else
            {
                Console.WriteLine("Gender: Female");
            }

            Console.WriteLine("Age: " + _age);

            Console.WriteLine("Std: " + _std);

            Console.WriteLine("Div: " + _div);

            Console.WriteLine("Marks: " + _marks);
        }
    }
}
