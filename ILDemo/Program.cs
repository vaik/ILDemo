using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ILDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            string str = "string";
            List<string> list = new List<string>() { "first", "second" };
            int id = 1;
            One one = new One();
            one.ID = id;
            Two two = new Two();
            Console.WriteLine(two.SayHello());
        }
     
    }
}
