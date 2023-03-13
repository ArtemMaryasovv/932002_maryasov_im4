using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace im4
{
    public partial class MAIN_WINDOW : Form
    {
        GOL Gol { get; set; }

        private readonly Graphics gfx;

        public MAIN_WINDOW()
        {
            InitializeComponent();
            Gol = new(lifeBox.Width / 10, lifeBox.Height / 10);
            gfx = lifeBox.CreateGraphics();

            comboPreset.SelectedIndex = 0;
        }
        private void TimerLife_Tick(object s, EventArgs e)
        {
            for (int x = 0; x < Gol.Width; x++)
                for (int y = 0; y < Gol.Height; y++)
                    if (Gol.GetLife(x,y))
                        SetPixel(x, y, Brushes.Black);
                    else
                        SetPixel(x, y, Brushes.White);
            
            Gol.MakeLife();
        }

        private void SetPixel(int x, int y, Brush Brush) => 
            gfx.FillRectangle(Brush, x * 10, y * 10, 8, 8);

        private void ButtonStartStop_Click(object s, EventArgs e)
        {
            if (TimerLife.Enabled == true)
            {
                TimerLife.Enabled = false;
                buttonStartStop.Text = "GO";
                buttonStep.Enabled = true;
            }
            else
            {
                TimerLife.Enabled = true;
                buttonStartStop.Text = "Pause";
                buttonStep.Enabled = false;
            }
        }

        private void ButtonStep_Click(object s, EventArgs e) => 
            TimerLife_Tick(s, e);

        private void ButtonReset_Click(object s, EventArgs e)
        {
            TimerLife.Enabled = false;
            Gol.InitializeLife(comboPreset.SelectedItem);
            TimerLife.Enabled = true;
        }

        private void comboPreset_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    public class GRID
    {
        public List<COL> Cols { get; set; }
        public GRID(int NoOfCols, int NoOfRows)
        {
            Cols = new(NoOfCols);

            for (int i = 0; i < NoOfCols; i++)
                Cols.Add(new(NoOfCols));

            foreach (COL row in Cols)
                for (int i = 0; i < NoOfRows; i++)
                    row.Cells.Add(new());
        }
    }
    public class COL
    {
        public List<CELL> Cells { get; set; }
        public COL(int NoOfCells) =>
            Cells = new(NoOfCells);
    }
    public class CELL
    {
        public bool IsAlive { get; set; }
        public CELL() =>
            IsAlive = false;
    }

    public class GOL
    {
        public int Width { get; set; }
        public int Height { get; set; }
        private readonly byte[,] _neighbors;

        private GRID current; 
        private readonly GRID next; 

        public GOL(int GameWidth, int GameHeight)
        {
            Width = GameWidth;
            Height = GameHeight;

            _neighbors = new byte[Width, Height];

            current = new(Width, Height);
            next = new(Width, Height);

            InitializeLife(-1);
        }
        
        public void InitializeLife(object preset)
        {
            foreach (COL col in current.Cols)
                foreach (CELL cell in col.Cells)
                    cell.IsAlive = false;
            foreach (COL col in next.Cols)
                foreach (CELL cell in col.Cells)
                    cell.IsAlive = false;

            switch (preset)
            {
                case "Random":
                    {
                        DrawRandom(current);
                        break;
                    }
                default:
                    break;
            }

            FillNeighbors();
        }
        
        public bool GetLife(int x, int y)
        {
            if (current.Cols[x].Cells[y].IsAlive)
                return true;
            return false;
        }

        private void FillNeighbors()
        {
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                    _neighbors[x, y] = GetNeighbors(x, y);
        }

        private byte GetNeighbors(int x, int y)
        {
            byte _n = 0;

            if (current.Cols[(x - 1 + Width) % Width].Cells[(y - 1 + Height) % Height].IsAlive) _n++;
            if (current.Cols[(x - 1 + Width) % Width].Cells[y].IsAlive) _n++;
            if (current.Cols[(x - 1 + Width) % Width].Cells[(y + 1) % Height].IsAlive) _n++;
            if (current.Cols[x].Cells[(y - 1 + Height) % Height].IsAlive) _n++;
            if (current.Cols[x].Cells[(y + 1) % Height].IsAlive) _n++;
            if (current.Cols[(x + 1) % Width].Cells[(y - 1 + Height) % Height].IsAlive) _n++;
            if (current.Cols[(x + 1) % Width].Cells[y].IsAlive) _n++;
            if (current.Cols[(x + 1) % Width].Cells[(y + 1) % Height].IsAlive) _n++;

            return _n;
        }

        internal void MakeLife()
        {
            for (int x = 0; x < Width; x++)
                for (int y = 0; y < Height; y++)
                {
                    byte _n;
                    _n = _neighbors[x, y];

                    if (current.Cols[x].Cells[y].IsAlive && (_n < 2 || _n > 3))
                        next.Cols[x].Cells[y].IsAlive = false;
                    if (current.Cols[x].Cells[y].IsAlive && (_n == 2 || _n == 3))
                        next.Cols[x].Cells[y].IsAlive = true;
                    if (!current.Cols[x].Cells[y].IsAlive && _n == 3)
                        next.Cols[x].Cells[y].IsAlive = true;
                }

            current = next;
            FillNeighbors();
        }

        void DrawRandom(GRID g)
        {
            Random _rnd = new();
            foreach (var row in g.Cols)
                foreach (var cell in row.Cells)
                {
                    if (_rnd.Next(3) < 1) cell.IsAlive = false;
                    else cell.IsAlive = true;
                }
        }
    }
}