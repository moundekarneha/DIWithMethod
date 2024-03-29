﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIWithMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentBussinessLayer obj = new StudentBussinessLayer();
            var result = obj.GetStudents(new StudentDataAccessLayer());
            foreach (var item in result)
            {
                Console.WriteLine("ID = " + item.id + "Name = " + item.name + " Standard = " + item.standard);
            }


            Console.ReadLine();
        }
    }

    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string standard { get; set; }

    }

    public interface IStudentDataAccessLayer
    {
        List<Student> GetStudents();
    }



    public class StudentDataAccessLayer : IStudentDataAccessLayer
    {
        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student() { id = 1, name = "Neha", standard = "A" });
            students.Add(new Student() { id = 2, name = "Sneha", standard = "B" });
            students.Add(new Student() { id = 3, name = "Nehal", standard = "A" });
            return students;
        }
    }

    public class StudentBussinessLayer
    {
        private IStudentDataAccessLayer obj;
        public List<Student> GetStudents(IStudentDataAccessLayer obj)
        {
            return obj.GetStudents();
        }
    }
}
