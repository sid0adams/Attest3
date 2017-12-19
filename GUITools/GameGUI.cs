using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;

namespace GUITools
{
    public class GameGUI
    {
        public DataGridView Dgv { get; private set; }
        public Label Output { get; private set; }
        public Button Start { get; set; }
        ContrTetris Game { get; set; }
        bool LabelGO = false;
        System.Threading.Timer timer;

        public GameGUI(DataGridView dgv, Label output, Button start)
        {
            Dgv = dgv;
            Output = output;
            Game = new ContrTetris(Update, 20, 11);
            dgv.CellClick += (sender, e) =>
            {
                Game.Delete(e.RowIndex, e.ColumnIndex);
            }; ;
            dgv.CellPainting += (sender,e) =>
            {
                e.PaintBackground(e.CellBounds, false);
                e.Handled = true;
            };
            Start = start;
            Start.Click += (sender, e) =>
            {
                if(timer != null)
                {
                    timer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite);
                    timer = null;
                }
                if (Output.InvokeRequired)
                    Output.BeginInvoke(new Action<string>((S) => Output.Text = S), "0");
                else
                    Output.Text = "0";
                Game.Start();
                start.Enabled = false;
            };

        }
        void End(object obj)
        {
            if(timer == null)
            {
                timer = new System.Threading.Timer(End, null, 2000, 2000);
            }
            string text;
            if (LabelGO)
                text = Game.score.ToString();
            else
                text = "Game Over";
            LabelGO = !LabelGO;

            if (Output.InvokeRequired)
                Output.BeginInvoke(new Action<string>((S) => Output.Text = S), text);
            else
                Output.Text = text;

        }
        void Update(Colors[,] colors, int score, bool GameOver)
        {
            for (int i = 0; i < colors.GetLength(0); i++)
            {
                for (int j = 0; j < colors.GetLength(1); j++)
                {
                    switch (colors[i,j])
                    {
                        case Colors.empty:
                            Dgv[j, i].Style.BackColor = System.Drawing.Color.White;
                            break;
                        case Colors.green:
                            Dgv[j, i].Style.BackColor = System.Drawing.Color.Green;
                            break;
                        case Colors.red:
                            Dgv[j, i].Style.BackColor = System.Drawing.Color.Red;
                            break;
                        case Colors.yellow:
                            Dgv[j, i].Style.BackColor = System.Drawing.Color.Yellow;
                            break;
                        case Colors.blue:
                            Dgv[j, i].Style.BackColor = System.Drawing.Color.Blue;
                            break;
                    }
                }
            }
            string text = GameOver ? "Game Over" : score.ToString();
            if (GameOver)
            {
                End(new object());
                text = "Game Over";
                if (Start.InvokeRequired)
                    Start.BeginInvoke(new Action<bool>((S) => Start.Enabled = S), true);
                else
                    Start.Enabled = true;
            }
            else
            {
                if (Output.InvokeRequired)
                    Output.BeginInvoke(new Action<string>((S) => Output.Text = S), text);
                else
                    Output.Text = text;
            }
        }
    }
}
