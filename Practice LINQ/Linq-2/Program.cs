using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
            };

            //var allStudents = GetAllStudents(classes);
            var allStudents = GetAllStudentsShorter(classes);

            Console.WriteLine(string.Join(" ", allStudents));
            Console.ReadKey();
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            List<string> result = new List<string>();
            result = classes[0].Students;
            for (int i = 1; i < classes.Count(); i++)
            {
                result = result.Concat(classes[i].Students).ToList();
            }
            return result.ToArray();
        }

        static string[] GetAllStudentsShorter(Classroom[] classes)
        {
            return classes.SelectMany(room => room.Students).ToArray();
        }


        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}