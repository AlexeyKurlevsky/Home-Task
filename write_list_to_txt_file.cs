using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask
{
    class Write_list_to_txt_file
    {
        static void Main(string[] args)
        {
            Vector v0 = new Vector(1, 2, 3);
            Vector v1 = new Vector(4, 5, 6);

            Vector v2 = v0 + v1;
            //Console.WriteLine(v2);
            string filePath = @"D:\Study\C#\HomeTask\HomeTask\test.txt";

            List<Vector> Vectors = new List<Vector>();

            List<string> lines = File.ReadAllLines(filePath).ToList();
            // read from txt file
            
            foreach (var line in lines)
            {
                string[] entries = line.Split(' ');
                Vector newVector = new Vector();

                double.TryParse(entries[0], out var numberX);
                newVector.X = numberX;
                double.TryParse(entries[1], out var numberY);
                newVector.Y = numberY;
                double.TryParse(entries[2], out var numberZ);
                newVector.Z = numberZ;

                Vectors.Add(newVector);
            }

            foreach (var vect in Vectors)
            {
                Console.WriteLine($"{vect.X} {vect.Y} {vect.Z}");
            }

            //write to txt file

            Vectors.Add(new Vector {X = 1, Y = 3, Z = 5});

            List<string> output = new List<string>();

            foreach (var vect in Vectors)
            {
                output.Add(Vector.ConvertToString(vect));
            }
            Console.WriteLine("Writing to txt file");

            File.WriteAllLines(filePath, output);
            Console.ReadKey();
        }
    }

}
