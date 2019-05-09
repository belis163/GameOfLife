using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Diagnostics;
using System.Threading;

namespace Sumulacja
{
    public partial class Form1 : Form
    {
        double interval = 100.0;
        int iteratoin = 0;
        private Graphics graphics;
        int Map_width = 0;
        int Map_height = 0;
        Grid Map;
        System.Timers.Timer aTimer;

        public Form1()
        {
            InitializeComponent();
       
        }
        
        private void Start_button_Click(object sender, EventArgs e)
        { 
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);
                iteratoin = int.Parse(iterationTextBox.Text);

                for (int i = 0; i < iteratoin; i++)
                {
                    Map.UpdateVector();
                    DrawCells(Map.Map);
                }
                
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }
        }

        private void DrawCells(Cell[,] Map)
        {
            GridPictureBox.Image = new Bitmap(GridPictureBox.Width, GridPictureBox.Height);
            graphics = Graphics.FromImage(this.GridPictureBox.Image);
            SolidBrush brush = new SolidBrush(Color.Red);
            Pen pen = new Pen(Color.Yellow, (float)0.01);
            float x = 0, y = 0;

            float RecWidth = (float)GridPictureBox.Width / (float)Map_width;
            float RecHeight = (float)GridPictureBox.Height / (float)Map_height;            
            if (RecWidth > RecHeight)
            {
                RecWidth = RecHeight;
            }
            else
            {
                RecHeight = RecWidth;
            }

            for (int i = 0; i < Map_height; i++)
            {

                for (int j = 0; j < Map_width; j++)
                {
                    if (Map[i, j].getCellState() == true)
                    {
                        brush.Color = Color.DarkCyan;
                    }
                    else
                    {
                        brush.Color = Color.Pink;
                    }
                    graphics.FillRectangle(brush, x, y, RecWidth, RecHeight);
                    graphics.DrawRectangle(pen, x, y, RecWidth, RecHeight);
                    x += RecWidth;
                }

                x = 0;
                y += RecHeight;
            }
        }

        private void Glider_button_Click(object sender, EventArgs e)
        {
            GridPictureBox.Refresh();
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            Map = new Grid(Map_width, Map_height);

            Map.Map[Map_height / 2, Map_width / 2].setCellState(true);
            Map.Map[Map_height / 2, (Map_width / 2) - 1].setCellState(true);

            Map.Map[(Map_height / 2) - 1, (Map_width / 2) - 1].setCellState(true);
            Map.Map[(Map_height / 2) - 1, (Map_width / 2) - 2].setCellState(true);

            Map.Map[(Map_height / 2) - 2, Map_width / 2].setCellState(true);

            DrawCells(Map.Map);
        }
        
        private void StopButton_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = false;
        }

        private void Oscylator_button_Click(object sender, EventArgs e)
        {
            GridPictureBox.Refresh();
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            Map = new Grid(Map_width, Map_height);
            Map.Map[Map_height / 2 - 1, Map_width / 2].setCellState(true);
            Map.Map[Map_height / 2, (Map_width / 2)].setCellState(true);
            Map.Map[Map_height / 2 + 1, (Map_width / 2)].setCellState(true);
            DrawCells(Map.Map);
        }

        private void Random_button_Click(object sender, EventArgs e)
        {
            GridPictureBox.Refresh();
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            Random random = new Random();
            Map = new Grid(Map_width, Map_height);
            for (int i=0; i < Map_height; i++)
            {
                for(int j=0; j < Map_width; j++)
                {
                    Map.Map[i, j].setCellState(Convert.ToBoolean(random.Next(2)));
                }
            }

            DrawCells(Map.Map);
        }

        private void Niezmienny_button_Click(object sender, EventArgs e)
        {
            GridPictureBox.Refresh();
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            Map = new Grid(Map_width, Map_height);
            Map.Map[(Map_height)/ (2), (Map_width / 2)].setCellState(true);
            Map.Map[(Map_height) / (2), (Map_width / 2) - 1].setCellState(true);

            Map.Map[((Map_height) / (2)) - 1, (Map_width / 2) + 1].setCellState(true);
            Map.Map[((Map_height) / (2)) - 1, (Map_width / 2) - 2].setCellState(true);

            Map.Map[((Map_height) / (2)) - 2, (Map_width / 2)].setCellState(true);
            Map.Map[((Map_height) / (2)) - 2, (Map_width / 2) - 1].setCellState(true);


            DrawCells(Map.Map);
        }

        private void GridPictureBox_Click(object sender, EventArgs e)
        {
            float x;
            float y;

            MouseEventArgs clickOnPB = (MouseEventArgs)e;
            PointF coordinates = clickOnPB.Location;

            x = coordinates.X;
            y = coordinates.Y;

            float RecWidth = (float)GridPictureBox.Width / (float)Map_width;
            float RecHeight = (float)GridPictureBox.Height / (float)Map_height;
            if (RecWidth > RecHeight)
            {
                RecWidth = RecHeight;
            }
            else
            {
                RecHeight = RecWidth;
            }

            int counterX = -1;
            int counterY = -1;
            while ( x > 0 )
            {
                x -= RecWidth;
                counterX++;
            }

            while (y > 0)
            {
                y -= RecWidth;
                counterY++;
            }

            
            Map.Map[counterY, counterX].setCellState(!Map.Map[counterY, counterX].getCellState());
            DrawCells(Map.Map);
        }

        private void DrawGrid_Click(object sender, EventArgs e)
        {
            GridPictureBox.Refresh();
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            Map = new Grid(Map_width, Map_height);
            DrawCells(Map.Map);
        }

        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);

                for (int i = 0; i < 1; i++)
                {
                    Map.UpdateVector();
                    BeginInvoke((Action)(() =>
                    {
                        DrawCells(Map.Map);
                    }));
                    
                }

            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }
        }

        private void OnTimedEventGunGame(Object source, ElapsedEventArgs e)
        {
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);

                for (int i = 0; i < 1; i++)
                {
                    Map.UpdateVectorGunGame();
                    BeginInvoke((Action)(() =>
                    {
                        DrawCells(Map.Map);
                    }));

                }

            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }
        }

        private void SimulationButton_Click(object sender, EventArgs e)
        {
            try
            {
                interval = Double.Parse(intervalTextBox.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            aTimer = new System.Timers.Timer(interval);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void GunButton_Click(object sender, EventArgs e)
        {
            GridPictureBox.Refresh();
            widthTextBox.Text = "40";
            heightTextBox.Text = "40";
            try
            {
                Map_width = int.Parse(widthTextBox.Text);
                Map_height = int.Parse(heightTextBox.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            Map = new Grid(Map_width, Map_height);

            Map.Map[19, 0].setCellState(true);
            Map.Map[19, 1].setCellState(true);

            Map.Map[20, 0].setCellState(true);
            Map.Map[20, 1].setCellState(true);

            Map.Map[19, 10].setCellState(true);
            Map.Map[20, 10].setCellState(true);
            Map.Map[21, 10].setCellState(true);

            Map.Map[18, 11].setCellState(true);
            Map.Map[22, 11].setCellState(true);

            Map.Map[17, 12].setCellState(true);
            Map.Map[17, 13].setCellState(true);

            Map.Map[23, 12].setCellState(true);
            Map.Map[23, 13].setCellState(true);

            Map.Map[20, 14].setCellState(true);

            Map.Map[19, 16].setCellState(true);
            Map.Map[20, 16].setCellState(true);
            Map.Map[21, 16].setCellState(true);

            Map.Map[18, 15].setCellState(true);
            Map.Map[22, 15].setCellState(true);

            Map.Map[20, 17].setCellState(true);

            Map.Map[17, 21].setCellState(true);
            Map.Map[18, 21].setCellState(true);
            Map.Map[19, 21].setCellState(true);

            Map.Map[17, 20].setCellState(true);
            Map.Map[18, 20].setCellState(true);
            Map.Map[19, 20].setCellState(true);

            Map.Map[16, 22].setCellState(true);
            Map.Map[20, 22].setCellState(true);

            Map.Map[16, 24].setCellState(true);
            Map.Map[15, 24].setCellState(true);

            Map.Map[20, 24].setCellState(true);
            Map.Map[21, 24].setCellState(true);

            Map.Map[18, 34].setCellState(true);
            Map.Map[18, 35].setCellState(true);

            Map.Map[17, 34].setCellState(true);
            Map.Map[17, 35].setCellState(true);

            DrawCells(Map.Map);
        }

        private void GunGameButton_Click(object sender, EventArgs e)
        {
            try
            {
                interval = Double.Parse(intervalTextBox.Text);
            }
            catch (System.FormatException)
            {
                System.Windows.Forms.MessageBox.Show("Upośledzony czy niespełna rozumu - tylko cyferki");
            }

            aTimer = new System.Timers.Timer(interval);
            aTimer.Elapsed += OnTimedEventGunGame;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }
    }
}

