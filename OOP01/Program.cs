using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net.Sockets;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Security.Claims;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            #region part02
            //            User Story: You're building a simple Movie Ticket Booking System for a cinema. The system manages ticket types, seat locations, pricing, and payments. Build it as a Console Application that reads data from the user and prints the booking summary.

            //what you need to build:
            //Each ticket has a type that can only be one of: Standard, VIP, or IMAX. How would you represent this?
            //enum TicketType
            //{
            //    Standard,
            //        VIP,
            //        IMAX
            //}

            //You need a type to represent a seat location (Row as a char like 'A', 'B', and Number as an int). Should this be a class or a struct? Create it.
            //    struct Seat
            //{
            //    public char Row;
            //    public int Number;

            //    public Seat(char row, int number)
            //    {
            //        Row = row;
            //        Number = number;
            //    }

            //    public override string ToString()
            //    {
            //        return $"{Row}{Number}";
            //    }
            //}

            //Create a Ticket class with: 
            //            MovieName(public), 
            //Type(public)
            //Seat(public)
            //Price(private). 
            //Sometimes a ticket is created with all info, sometimes with just the movie   name(default type Standard, seat A1, price 50). Handle both without repeating initialization logic.

            //    class Ticket
            //{
            //    public string MovieName;
            //    public TicketType Type;
            //    public Seat Seat;

            //    private double Price;

            //    // Full constructor
            //    public Ticket(string movieName, TicketType type, Seat seat, double price)
            //    {
            //        MovieName = movieName;
            //        Type = type;
            //        Seat = seat;
            //        Price = price;
            //    }

            //    // Constructor with only movie name (defaults)
            //    public Ticket(string movieName)
            //        : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
            //    {
            //    }

            //    // Calculate total after tax (without changing price)
            //    public double CalcTotal(double taxPercent)
            //    {
            //        return Price + (Price * taxPercent / 100);
            //    }

            //    // Apply discount
            //    public void ApplyDiscount(ref double discountAmount)
            //    {
            //        if (discountAmount > 0 && discountAmount <= Price)
            //        {
            //            Price -= discountAmount;
            //            discountAmount = 0;
            //        }
            //    }

            //    // Print ticket info
            //    public void PrintTicket()
            //    {
            //        Console.WriteLine("----- Ticket Summary -----");
            //        Console.WriteLine($"Movie: {MovieName}");
            //        Console.WriteLine($"Type: {Type}");
            //        Console.WriteLine($"Seat: {Seat}");
            //        Console.WriteLine($"Price: {Price}");
            //    }
            //}

            //            Add three methods to the Ticket class:
            //CalcTotal() — receives a taxPercent (double), calculates the total after tax and returns it.The original price must stay unchanged.
            //ApplyDiscount() — receives a discountAmount (double) . If discount is valid (> 0 and ≤ Price), deducts it from Price and sets discountAmount to 0 (consumed). Otherwise, the discount stays unchanged.
            //PrintTicket() — prints the full ticket info.

        //    class Program
        //{
        //    static void Main()
        //    {
        //        Console.Write("Enter movie name: ");
        //        string movie = Console.ReadLine();

        //        Console.Write("Enter ticket type (Standard, VIP, IMAX): ");
        //        TicketType type = Enum.Parse<TicketType>(Console.ReadLine(), true);

        //        Console.Write("Enter seat row (A,B,...): ");
        //        char row = char.Parse(Console.ReadLine());

        //        Console.Write("Enter seat number: ");
        //        int number = int.Parse(Console.ReadLine());

        //        Console.Write("Enter price: ");
        //        double price = double.Parse(Console.ReadLine());

        //        Ticket ticket = new Ticket(movie, type, new Seat(row, number), price);

        //        Console.Write("Enter discount amount: ");
        //        double discount = double.Parse(Console.ReadLine());
        //        ticket.ApplyDiscount(ref discount);

        //        Console.Write("Enter tax percent: ");
        //        double tax = double.Parse(Console.ReadLine());

        //        double total = ticket.CalcTotal(tax);

        //        Console.WriteLine();
        //        ticket.PrintTicket();
        //        Console.WriteLine($"Total after tax: {total}");
        //    }
        //}

        #endregion
    }
}
    }
