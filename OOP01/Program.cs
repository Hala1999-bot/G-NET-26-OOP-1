using System;
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
    #endregion
}
    }
    }
