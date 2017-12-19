using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Line
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Line(double A, double B, double C)
        {
            if (A == 0 && B == 0)
                throw new Exception("линия не существует");
            this.A = A;
            this.B = B;
            this.C = C;
        }
        public double GetY(double x)
        {
            if (B == 0)
                throw new Exception("вертикальная линия");
            return (-A * x - C) / B;
        }
        public bool IsParallel(Line line)
        {
            if (A == 0 && B != 0 && line.A == 0 && line.B != 0
                || A != 0 && B == 0 && line.A != 0 && line.B == 0)
                return true;
            if (A != 0 && B != 0 && line.A != 0 && line.B != 0)
                return A * line.B == B * line.A;
            return false;
        }
        private Position CompareTtoK(double t, double k)
        {
            if (t == k)
                return Position.Matches;
            if (t > k)
                return Position.Above;
            if (t < k)
                return Position.Below;
            throw new Exception("CompareTtoK");
        }
        public Position PositionTo(Line line)
        {
            if (!IsParallel(line))
                return Position.NotParallel;
            if (B == 0)
                return CompareTtoK(-C / A, -line.C / line.A);
            double Y1 = GetY(0);
            double Y2 = line.GetY(0);
            return CompareTtoK(Y1, Y2);
        }
        public static List<Line> GetMaxLines(List<Line> lines)
        {
            List<Line> MaxLines = new List<Line>();
            foreach (Line item in lines)
            {
                for (int i = 0; i <= MaxLines.Count; i++)
                {
                    if (i == MaxLines.Count)
                    {
                        MaxLines.Add(item);
                        break;
                    }
                    Position P = item.PositionTo(MaxLines[i]);
                    if (P != Position.NotParallel) 
                    {
                        if (P == Position.Above)
                            MaxLines[i] = item;
                        break;
                    }
                }
            }
            return MaxLines;
        }
        public override string ToString()
        {
            return A + " " + B + " " + C;
        }
    }
    public enum Position
    {
        NotParallel,
        Below,
        Matches,
        Above
    }
}
