using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class LineConvert
    {
        public static Line StrToLine(string str)
        {
            try
            {
                string[] split = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                return new Line(double.Parse(split[0]), double.Parse(split[1]), double.Parse(split[2]));
            }
            catch (Exception)
            {
                throw new Exception("некорректная строка");
            }
        }
        public static List<Line> StrToLineList(string str)
        {
            string[] split = str.Split(new char[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            List<Line> lines = new List<Line>();
            foreach (string item in split)
            {
                lines.Add(StrToLine(item));
            }
            return lines;
        }
        public static string LineListToStr(List<Line> lines)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Line item in lines)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
        public static double[,] LineListToMatrix(List<Line> Lines)
        {
            double[,] Matrix = new double[Lines.Count, 3];
            for (int i = 0; i < Lines.Count; i++)
            {
                Matrix[i, 0] = Lines[i].A;
                Matrix[i, 1] = Lines[i].B;
                Matrix[i, 2] = Lines[i].C;
            }
            return Matrix;
        }
        public static List<Line> MatrixToLineList(double[,] Matrix)
        {
            List<Line> Lines = new List<Line>();
            if (Matrix.GetLength(1) != 3)
                throw new Exception("невозможно преобразовать");
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                Lines.Add(new Line(Matrix[i, 0], Matrix[i, 1], Matrix[i, 2]));
            }
            return Lines;
        }
    }
}
