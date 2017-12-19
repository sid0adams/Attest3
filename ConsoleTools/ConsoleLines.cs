using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Logic;

namespace ConsoleTools
{
    public class ConsoleLines
    {
        static List<Line> ConsoleInput()
        {
            StringBuilder sb = new StringBuilder();
            string temp;
            temp = Console.ReadLine();
            while (temp != "")
            {
                sb.AppendLine(temp);
                temp = Console.ReadLine();
            }
            return LineConvert.StrToLineList(sb.ToString());
        }
        static List<Line> FileInput(string Path)
        {
            LinesFile file = new LinesFile(Path);
            return file.ReadLines();
        }
        public static List<Line> Input()
        {
            while (true)
            {
                Console.Write("Считать линии из файла ? (y/n)");
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.Write("введите имя файла:");
                        try
                        {
                            return FileInput(Console.ReadLine());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    while (true)
                    {
                        Console.WriteLine("введите линии");
                        try
                        {
                            return ConsoleInput();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
            }
        }
        static void FileOutput(List<Line> Lines, string Path)
        {
            LinesFile file = new LinesFile(Path);
            file.WriteLines(Lines);
        }
        static void ConsoleOutput(List<Line> Lines)
        {
            Console.WriteLine(LineConvert.LineListToStr(Lines));
        }
        public static void Output(List<Line> Lines)
        {
            while (true)
            {
                Console.Write("записать линии в файл ? (y/n)");
                ConsoleKeyInfo result = Console.ReadKey();
                Console.WriteLine();
                if ((result.KeyChar == 'y') || (result.KeyChar == 'Y'))
                {
                    while (true)
                    {
                        Console.Write("введите имя файла:");
                        try
                        {
                            FileOutput(Lines, Console.ReadLine());
                            return;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                }
                if ((result.KeyChar == 'n') || (result.KeyChar == 'N'))
                {
                    ConsoleOutput(Lines);
                    break;
                }
            }
        }
    }
}
