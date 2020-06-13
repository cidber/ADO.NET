using System;
using System.IO;
namespace Zadanie1
{

    public class Program
    {
        static void Main()
        {
            InOut file = new InOut();
            Triangle[] abc = file.input("input.txt");
            file.output(abc);

        }
    }
}