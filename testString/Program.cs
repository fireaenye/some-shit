using System;
using System.Text;



    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Ma string", 100);
            sb.Insert(9, " make with StringBuilder");
            Console.WriteLine(sb);
        }
    }

