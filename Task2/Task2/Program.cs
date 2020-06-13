using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            InOut File = new InOut();
            Circle[] ar1 = File.InputCircle("input1.txt");
            File.OutputCircle(ar1);
        }
    }
}