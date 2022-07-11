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
            string whereFile = @"D:\notes.txt";
            StreamWriter write = new StreamWriter(whereFile, true, Encoding.UTF8);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Title = "NotePad_";
            Console.WriteLine("I want the text, please! If you done enter --save!");
            string fullText = "";

            
            while (true)
            {
                string text = Console.ReadLine();
                if (text == "--save")
                {
                    write.WriteLine(fullText);
                    write.Close();
                    break;
                }
                else
                {
                    fullText += text + "\n";
                }
            }
            

        }
    }
}
