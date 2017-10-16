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

        public int block_height = 250 / 20;
        public int block_width = 250 / 20;

        public Keys last_pressed = Keys.W;

        public Point[] snake = new Point[] { new Point(8, 8), new Point(8, 9), new Point(8, 10) };

        public Boolean isPlaying = false;

        public int score = 0;
        public int highscore = 0;

        public int speed;

        public Point food;
        
        public Form1()
        {
            height = 250;
            width = 250;
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            highscore = Properties.Settings.Default.Highscore;
            label_record.Text = "Record: " + highscore;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            draw();
        }

        public void draw()
        {
            panel_game.Refresh();
            label_score.Text = "Score: " + score;
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
                y_mod--;
            } else if (last_pressed == Keys.S)
            {
                y_mod++;
            }
            
            oldpoint.X += x_mod;
            oldpoint.Y += y_mod;

            for (int i = 0; i < snake.Length - 1; i++)
            {
                snake[snake.Length - 1 - i] = snake[snake.Length - 2 - i];
            }

            snake[0] = oldpoint;

            eat();
           

            draw();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.A || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.W)
            {
                if(e.KeyCode == Keys.W && last_pressed == Keys.S)
                {
                    return;
                }
                if (e.KeyCode == Keys.S && last_pressed == Keys.W)
                {
                    return;
                }
                if (e.KeyCode == Keys.A && last_pressed == Keys.D)
                {
                    return;
                }
                if (e.KeyCode == Keys.D && last_pressed == Keys.A)
                {
                    return;
                }

                last_pressed = e.KeyCode;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (checkDeath())
            {
                e.Graphics.DrawString("You died...", SystemFonts.MenuFont, Brushes.Red, 100, 75);
                e.Graphics.DrawString("Score: " + score, SystemFonts.MenuFont, Brushes.Yellow, 100, 90);
                e.Graphics.DrawIcon(SystemIcons.Warning, 70, 75);               
                timer1.Stop();
                return;
            }     
            
            if(food != null)
            {
                e.Graphics.FillRectangle(Brushes.Green, food.X * block_width, food.Y * block_height, block_width, block_height);
            }

            for(int i = 0; i < snake.Length; i++)
            {
                Point p = snake[i];

                if (i != 0)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(0, 200 + (int) (Math.Sin(i * 0.5) * 20), 0)) , p.X * block_width, p.Y * block_height, block_width, block_height);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.AntiqueWhite, p.X * block_width, p.Y * block_height, block_width, block_height);
                }
            }

            //e.Graphics.DrawRectangle(Pens.LightGreen, 0, 0, 249, 249);
        }

        public void hideButtons()
        {
            if (isPlaying)
            {
                panel_start.Visible = false;
                panel_reset.Visible = true;
                
            }
            else
            {
                panel_start.Visible = true;
                panel_reset.Visible = false;
            }

            label_speed.Visible = !isPlaying;
            label_speed_minus.Visible = !isPlaying;
            label_speed_plus.Visible = !isPlaying;
            label_speed_show.Visible = !isPlaying;
        }

        //buttons

        private void panel_start_Click(object sender, EventArgs e)
        {
            if (isPlaying)
            {
                panel_start.Visible = false;
                return;
            }

            if(100 - (speed * 10) <= 0)
            {
                speed = 9;
                label_speed_show.Text = speed.ToString();
                return;
            }

            timer1.Interval = 100 - (speed * 10);

            isPlaying = true;
            hideButtons();
            createFood();
            timer1.Start();
        }

        private void panel_reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            score = 0;
            snake = new Point[] { new Point(8, 8), new Point(8, 9), new Point(8, 10) };
            isPlaying = false;
            draw();
            hideButtons();
        }


        //Game logic
        private Boolean checkDeath()
        {
            for(int i = 1; i < snake.Length; i++)
            {
                if(snake[0].X == snake[i].X && snake[0].Y == snake[i].Y)
                {
                    return true;
                }
            }

            if(snake[0].X < 0 || snake[0].Y < 0)
            {
                return true;
            }

            if(snake[0].X > 20 || snake[0].Y > 20)
            {
                return true;
            }

            return false;
        }

        private void eat()
        {
            if(snake[0].X == food.X && snake[0].Y == food.Y)
            {
                score += 100 + (speed * 50);

                if(score > highscore)
                {
                    label_record.Text = "Record: " + score;
                    highscore = score;
                }

                Point[] temp = new Point[snake.Length + 1];

                for(int i = 0; i < snake.Length; i++)
                {
                    temp[i] = snake[i];
                }

                snake = temp;
                snake[snake.Length - 1] = snake[snake.Length - 2];
                createFood();
            }
        }

        private void createFood()
        {
            while (true)
            {
                Random rnd = new Random();
                int x = rnd.Next(0, 20);
                int y = rnd.Next(0, 20);

                Boolean inSnake = false;
                for (int i = 0; i < snake.Length - 1; i++)
                {
                    if (x == snake[i].X && y == snake[i].Y)
                    {
                        inSnake = true;
                        break;
                    }
                }
                if (inSnake)
                {
                    continue;
                }

                food = new Point(x, y);
                break;
            }
        }

        private void label_speed_minus_Click(object sender, EventArgs e)
        {
            speed--;

            if (speed < 0)
            {
                speed = 0;
                MessageBox.Show("Speed cannot be lower then 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            label_speed_show.Text = speed.ToString();
        }

        private void label_speed_plus_Click(object sender, EventArgs e)
        {
            speed++;   

            label_speed_show.Text = speed.ToString();          
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Highscore = highscore;
            Properties.Settings.Default.Save();
        }
    }
}
