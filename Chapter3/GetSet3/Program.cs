﻿using System;

namespace GetSet3
{
    class Student
    {
        string name;
        public string Name
        { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student obj = new Student();
            obj.Name = "Korea"; // set the value
            Console.WriteLine("Name: " + obj.Name);
        }
    }
}
