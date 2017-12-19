using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using ConsoleTools;

namespace _10._3_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Task();
            }
        }

        private static void Task()
        {
            List<Line> lines = ConsoleLines.Input();
            List<Line> linesFilt = Line.GetMaxLines(lines);
            ConsoleLines.Output(linesFilt);
        }
    }
}
