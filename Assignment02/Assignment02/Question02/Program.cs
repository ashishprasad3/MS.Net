using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Question02;


namespace Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Student student = new Student();

            Console.WriteLine("Enter size of array");
            Student[] studentsArray = CreateArray(int.Parse(Console.ReadLine()));

            PrintArray(studentsArray);

            Console.WriteLine("Reversed array");
            PrintArray(ReverseArray(studentsArray));

        }

        public static Student[] CreateArray(int count)
        {

            Student[] array = new Student[count];

            for (int i = 0; i < count; i++)
            {

                array[i] = new Student();

                array[i].acceptData();
            }

            return array;
        }

        public static void PrintArray(Student[] array)
        {
            foreach (Student i in array)
            {

                i.displayData();

            }
        }

        public static Student[] ReverseArray(Student[] arr)
        {

            Student[] reversedArray = new Student[arr.Length];

            for (int i = 0, j = arr.Length - 1; i < reversedArray.Length && j >= 0; i++, j--)
            {

                reversedArray[i] = arr[j];

            }
            return reversedArray;

        }

    }
}
