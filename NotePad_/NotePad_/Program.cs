using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NotePad_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //streamwriter
            string whereFile = @"D:\notes.txt";
            StreamWriter write = new StreamWriter(whereFile, false, Encoding.Default);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "NotePad_";
            Console.WriteLine("I want the text, please!");
            string text = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("If you want to save enter --save");
            string text2 = Console.ReadLine();
            while (true)
            {
                if (text2 == "--save")
                {
                    write.WriteLine(text);
                    write.Close();
                    break;
                }
            }

        }
    }
}
