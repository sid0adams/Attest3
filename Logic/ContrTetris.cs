using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Logic
{
    public enum Colors
    {
        empty,
        green,
        red,
        yellow,
        blue
    }
    public class ContrTetris
    {
        Random rnd = new Random();
        bool run = false;
        int timeBusy = 5;
        int timeStep = 3000;
        Timer timer;
        public delegate void Update(Colors[,] colors, int score, bool GameOver);
        Update update;
        public int Height { get; }
        public int Width { get; }
        public Colors[,] Map { get; private set; }
        bool[,] search;
        bool busy = false;
        public int score { get; private set; }

        public ContrTetris(Update update, int height, int width)
        {
            this.update = update;
            Height = height;
            Width = width;
            Map = new Colors[height, width];
            update(Map, score, false);
        }
        void Reset()
        {
            score = 0;
            Map = new Colors[Height, Width];
            for (int i = Height*3/4; i < Height; i++)
            {
                Randomline(i);
            }
            busy = false;
        }
        public void Start()
        {
            run = true;
            Reset();
            timer = new Timer(AddRandomLine, null, timeStep, timeStep);
            update(Map,score,false);
        }
        public void Stop()
        {
            run = false;
            timer.Change(Timeout.Infinite, Timeout.Infinite);
            update(Map, score, true);
        }
        void AddRandomLine(object obj)
        {
            while (busy)
                Thread.Sleep(timeBusy);
            busy = true;
            if (Check())
            {
                AddRandomLine();
                update(Map, score, false);
            }
            else
                Stop();
            busy = false;
        }
        void AddRandomLine()
        {
            for (int i = 1; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    Map[i - 1, j] = Map[i, j];
                }
            }
            Randomline(Height - 1);
        }
        void Randomline(int index)
        {
            for (int i = 0; i < Width; i++)
            {
                Map[index, i] = (Colors)rnd.Next(1, 5);
            }
        }
        bool Check()
        {
            for (int i = 0; i < Width; i++)
            {
                if (Map[0, i] != Colors.empty)
                    return false;
            }
            return true;
        }


        public void Delete(int row, int column)
        {
            if (!run || Map[row,column] == Colors.empty)
                return;
            while (busy)
                Thread.Sleep(timeBusy);
            busy = true;
            int count = CanDelete(row, column);
            if (count>2)
            {
                score += count;
                DeleteColor(row, column);
                Gravity();
            }
            update(Map, score, false);
            busy = false;
        }
        void Gravity()
        {
            int firstEmpty = -1;
            for (int i = 0; i < Width; i++)
            {
                firstEmpty = -1;
                for (int j = Height - 1; j >= 0; j--)
                {
                    if (Map[j, i] == Colors.empty && firstEmpty == -1)
                    {
                        firstEmpty = j;
                    }
                    if (Map[j, i] != Colors.empty && firstEmpty != -1)
                    {
                        Map[firstEmpty--, i] = Map[j, i];
                        Map[j, i] = Colors.empty;
                    }
                }
            }
        }

        void DeleteColor(int row, int column) 
            => DeleteColor(row, column, Map[row, column]);
        void DeleteColor(int row, int column, Colors color)
        {
            if (Map[row, column] == color)
            {
                Map[row, column] = Colors.empty;
                if (row != 0)
                    DeleteColor(row - 1, column, color);
                if (row != Height - 1)
                    DeleteColor(row + 1, column, color);
                if (column != 0)
                    DeleteColor(row, column - 1, color);
                if (column != Width - 1)
                    DeleteColor(row, column + 1, color);
            }
        }

        int CanDelete(int row, int column)
        {
            search = new bool[Height, Width];
            return CanDelete(row, column, Map[row, column]);
        }
        int CanDelete(int row, int column, Colors color)
        {
            if (Map[row, column] != color || search[row, column])
                return 0;
            search[row, column] = true;
            int count = 1;
            if (row != 0)
                count += CanDelete(row - 1, column, color);
            if (row != Height - 1)
                count += CanDelete(row + 1, column, color);
            if (column != 0)
                count += CanDelete(row, column - 1, color);
            if (column != Width - 1)
                count += CanDelete(row, column + 1, color);
            return count;
        }

    }
}
