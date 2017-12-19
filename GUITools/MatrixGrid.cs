using System;
using System.Windows.Forms;

namespace GUITools
{
    public class MatrixGrid
    {
        DataGridView data;
        public MatrixGrid(DataGridView data)
        {
            this.data = data;
        }
        public double[,] GetMatrix()
        {
            double[,] matrix = new double[data.RowCount, data.ColumnCount];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (data[j, i].Value == null)
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = double.Parse(data[j, i].Value.ToString());
                }
            }
            return matrix;
        }
        public void SetMatrix<T>(T[,] Matrix)
        {
            if (Matrix.Length == 0)
            {
                throw new Exception("линии отсутсвуют");
            }
            data.ColumnCount = 0;
            string s;
            for (int i = 0; i < Matrix.GetLength(1); i++)
            {
                s = i.ToString();
                data.Columns.Add(s, s);
                data.Columns[s].Width = 30;
            }
            data.RowCount = Matrix.GetLength(0);
            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    data[j, i].Value = Matrix[i, j];
                }
            }
        }
        public void DeleteRow(object sender, EventArgs e)
        {
            if (data.RowCount != 1)
                data.Rows.RemoveAt(data.RowCount - 1);
        }
        public void AddRow(object sender,EventArgs e)
        {
            data.Rows.Add();
            for (int i = 0; i < data.ColumnCount; i++)
            {
                data[i, data.RowCount - 1].Value = 0;
            }
        }
        public void DeleteColumn(object sender, EventArgs e)
        {
            if (data.ColumnCount != 1)
                data.Columns.RemoveAt(data.ColumnCount - 1);
        }
        public void AddColumn(object sender, EventArgs e)
        {
            string s = data.ColumnCount.ToString();
            data.Columns.Add(s, s);
            data.Columns[s].Width = 30;
            for (int i = 0; i < data.RowCount; i++)
            {
                data[data.ColumnCount - 1, i].Value = 0;
            }
        }
    }
}
