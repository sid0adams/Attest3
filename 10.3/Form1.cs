using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using GUITools;

namespace _10._3
{
    public partial class Form1 : Form
    {
        MatrixGrid Input, Output;
        public Form1()
        {
            InitializeComponent();
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LinesFile file = new LinesFile(openFileDialog.FileName);
                    List<Line> lines = file.ReadLines();
                    Input.SetMatrix(LineConvert.LineListToMatrix(lines));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LinesFile file = new LinesFile(saveFileDialog.FileName);
                    file.WriteLines(LineConvert.MatrixToLineList(Output.GetMatrix()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ошибка");
                }
            }
        }

        private void Filt_Click(object sender, EventArgs e)
        {
            try
            {
                List<Line> lines = LineConvert.MatrixToLineList(Input.GetMatrix());
                List<Line> LinesFilt = Line.GetMaxLines(lines);
                Output.SetMatrix(LineConvert.LineListToMatrix(LinesFilt));
                save.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ошибка");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Input = new MatrixGrid(InputMatrix);
            Input.AddRow(sender,e);
            AddRowBtn.Click += Input.AddRow;
            RemoveRowBtn.Click += Input.DeleteRow;
            Output = new MatrixGrid(OutputMatrix);
        }
    }
}
