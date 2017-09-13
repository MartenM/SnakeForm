using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeForm
{
    public partial class Form1 : Form
    {

        public int height;
        public int width;

        public int block_height = 250 / 10;
        public int block_width = 250 / 10;

        public Keys last_pressed = Keys.W;

        public Point[] snake = new Point[] { new Point(1, 1) };

        private Graphics g;
        
        public Form1()
        {
            height = 250;
            width = 250;
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            draw(g);
        }

        public void draw(Graphics g)
        {
            g.FillRectangle(Brushes.Black, 10, 10, width, height);
            g.DrawRectangle(Pens.Cyan, 10, 10, width, height);

            foreach (Point p in snake)
            {
                g.FillRectangle(Brushes.White, 10 + p.X * block_width, 10 + p.Y * block_height, block_width, block_height);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x_mod = 0;
            int y_mod = 0;

            Point oldpoint = snake[0];

            if (last_pressed == Keys.A)
            {
                x_mod--;
            } else if (last_pressed == Keys.D)
            {
                x_mod++;
            } else if (last_pressed == Keys.W)
            {
                y_mod++;
            } else if (last_pressed == Keys.S)
            {
                y_mod--;
            }
            

            for (int i = snake.Length - 1; i > 0; i++)
            {
                snake[i] = snake[i - 1];
            }

            oldpoint.X += x_mod;
            oldpoint.Y += y_mod;

            snake[0] = oldpoint;

            draw(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.W)
            {
                last_pressed = e.KeyCode;
            }
        }
    }
}
