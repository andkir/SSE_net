// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace MyApp
{

    public class Program
    {
        public static void Main(string[] args)
        {
            List<A> list;
            A[] arr;

            //list = new List<AB>();

            arr = new AB[1];

            //arr[0] = new AC();

            Console.WriteLine("Hello World!");
        }
    }



    public class A
    {
        public int Id { get; set; }
    }
    public class AB : A
    {
        public string Name { get; set; }
    }
    public class AC : A
    {
        public string Title { get; set; }
    }
}