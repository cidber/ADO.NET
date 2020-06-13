using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Zadanie1
{
    public class InOut
    {
        public Triangle[] input(string path)
        {
            Triangle[] abc = null;
            Triangle tr = new Triangle();
            using (StreamReader fileIn = new StreamReader("C:/Users/Aldan/source/repos/Класс Triangle задание 1/input.txt"))
            {
                int n;
                if (int.TryParse(fileIn.ReadLine(), out n))
                {
                    abc = new Triangle[n];

                    for (int i = 0; i < n; i++)
                    {
                        string[] text = fileIn.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        double x;
                        double y;
                        Point a = null;
                        Point b = null;
                        Point c = null;

                        if (double.TryParse(text[0], out x) && double.TryParse(text[1], out y))
                        {
                            a = new Point(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Wrong parametr.");
                        }

                        if (double.TryParse(text[2], out x) && double.TryParse(text[3], out y))
                        {
                            b = new Point(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Wrong parametr.");
                        }


                        if (double.TryParse(text[4], out x) && double.TryParse(text[5], out y))
                        {
                            c = new Point(x, y);
                        }
                        else
                        {
                            throw new ArgumentException("Wrong parametr.");
                        }

                        if ((tr.Side(a, b) + tr.Side(b, c) > tr.Side(c, a))
                            && (tr.Side(a, b) + tr.Side(c, a) > tr.Side(b, c))
                            && (tr.Side(b, c) + tr.Side(c, a) > tr.Side(a, b)))

                        {
                            abc[i] = new Triangle(a, b, c);
                        }

                        else
                        {
                            throw new ArgumentException("Triangle doesn't exist.");
                        }
                    }
                }
                return abc;
            }
        }
        public void output(Triangle[] ar)
        {
            using (StreamWriter fileOut = new StreamWriter("C:/Users/Aldan/source/repos/Класс Triangle задание 1/output.txt"))
            {
                foreach (Triangle item in ar)
                {
                    fileOut.WriteLine("Координаты точки a = ({0},{1})", item.a.x, item.a.y);
                    fileOut.WriteLine("Координаты точки b = ({0},{1})", item.b.x, item.b.y);
                    fileOut.WriteLine("Координаты точки c = ({0},{1})", item.c.x, item.c.y);
                    fileOut.WriteLine("Периметр треугольника составленного по точкам a,b,c = {0}",item.P);
                    fileOut.WriteLine("Площадь треугольника составленного по точкам a,b,c = {0}", item.S);
                    fileOut.WriteLine();
                }
            }
        }
    }
}