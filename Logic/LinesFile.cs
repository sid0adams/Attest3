using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Logic
{
    public class LinesFile
    {
        public string Path { get; set; }
        public List<Line> ReadLines()
        {
            return LineConvert.StrToLineList(File.ReadAllText(Path));
        }
        public void WriteLines(List<Line> lines)
        {
            File.WriteAllText(Path, LineConvert.LineListToStr(lines));
        }

        public LinesFile(string path)
        {
            Path = path;
        }
    }
}
