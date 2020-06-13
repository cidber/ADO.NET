using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    class InOut
    {
        public Circle[] InputCircle(string path)
        {
            Circle[] OR = null;
            using (StreamReader fileIn = new StreamReader("C:/Users/Aldan/source/repos/Task2/Task2/input.txt"))
            {
                int n;
                if (int.TryParse(fileIn.ReadLine(), out n))
                {
                    OR = new Circle[n];

                    for (int i = 0; i < n; i++)
                    {
                        string[] text = fileIn.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                        double x;
                        double y;
                        Point centr = null;
                        double radius;
                        double radius2;
                        if (text.Length == 3)
                        {
                            if (double.TryParse(text[0], out x) && double.TryParse(text[1], out y))
                            {
                                centr = new Point(x, y);
                            }
                            else
                            {
                                throw new ArgumentException("Wrong parametr.");
                            }

                            if (double.TryParse(text[2], out radius))
                            {
                                radius = double.Parse(text[2]);
                            }
                            else
                            {
                                throw new ArgumentException("Wrong parametr.");
                            }
                            OR[i] = new Circle(centr, radius);
                        }


                        if (text.Length == 4)
                        {
                            if (double.TryParse(text[0], out x) && double.TryParse(text[1], out y))
                            {
                                centr = new Point(x, y);
                            }
                            else
                            {
                                throw new ArgumentException("Wrong parametr.");
                            }
                            if (double.TryParse(text[2], out radius))
                            {
                                radius = double.Parse(text[2]);
                            }
                            else
                            {
                                throw new ArgumentException("Wrong parametr.");
                            }

                            if (double.TryParse(text[3], out radius2))
                            {
                                radius2 = double.Parse(text[3]);
                            }
                            else
                            {
                                throw new ArgumentException("Wrong parametr.");
                            }
                            if (Math.Abs(radius - radius2) != 0)
                            {
                                OR[i] = new Ring(centr, radius, radius2);
                            }
                            else
                            {
                                throw new ArgumentException("Wrong parametr.");
                            }
                        }

                    }
                }
                return OR;

            }
        }
        public void OutputCircle(Circle[] OR)
        {
            using (StreamWriter fileOut = new StreamWriter("C:/Users/Aldan/source/repos/Task2/Task2/output.txt"))
            {
                foreach (Circle item in OR)
                {
                    fileOut.Write(item.Show());
                    fileOut.Write("Площадь = {0}\n", item.S);
                    fileOut.Write("Длина = {0}\n", item.P);
                    fileOut.WriteLine();
                }
            }
        }
    }
}