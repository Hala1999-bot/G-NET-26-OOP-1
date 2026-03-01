using System;
using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;

namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part01
            //Q1: Explain with code example how class and struct behave differently

            //    Struct >> Value type , Stored In Stack , Assignment Copies the data , Small, simple data
            // example>>
            //    Point p1;
            //p1.X = 10;
            //p1.Y = 20;

            //Point p2 = p1;   // p2 is a COPY of p1
            //p2.X = 99;        // p1.X is still 10!
            //    Class >>Reference type , Stored In Heap , Copies the reference , Complex entities with behavior
            //example>>
            //class Student
            //public string Name;
            //    public int Age;

            //    public void Introduce()
            //    {
            //        Console.WriteLine($"Hi, I'm {Name}, age {Age}");
            //    }
            //}

            //Q2 : Explain the difference between public and private access modifiers with an example.
            //private>>Accessibility: The member is only accessible within the class or struct it is defined in. It cannot be accessed from outside the class.
            //public>>Accessibility: The member is accessible from anywhere in the application, both within the same assembly (project) and from other assemblies.

            //Q4 : What is a class library? Why do we use class libraries?
            //A Class Library is a separate project that contains reusable classes, but has no Main method and cannot run on its own.It compiles into a .dll file(Dynamic Link Library).
            //Reusability ,Organization , Teamwork ,  Maintenance
            #endregion
        }
    }
    }
