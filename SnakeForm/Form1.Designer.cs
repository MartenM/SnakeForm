namespace SnakeForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_game = new System.Windows.Forms.Panel();
            this.label_score = new System.Windows.Forms.Label();
            this.panel_reset = new System.Windows.Forms.Panel();
            this.panel_start = new System.Windows.Forms.Panel();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_speed_minus = new System.Windows.Forms.Label();
            this.label_speed_show = new System.Windows.Forms.Label();
            this.label_speed_plus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel_game
            // 
            this.panel_game.Location = new System.Drawing.Point(10, 82);
            this.panel_game.Name = "panel_game";
            this.panel_game.Size = new System.Drawing.Size(250, 250);
            this.panel_game.TabIndex = 0;
            this.panel_game.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("Endless Boss Battle", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.ForeColor = System.Drawing.Color.Lime;
            this.label_score.Location = new System.Drawing.Point(12, 63);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(113, 16);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "Score: 0000";
            this.label_score.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_reset
            // 
            this.panel_reset.BackgroundImage = global::SnakeForm.Properties.Resources.reset;
            this.panel_reset.Location = new System.Drawing.Point(160, 369);
            this.panel_reset.Name = "panel_reset";
            this.panel_reset.Size = new System.Drawing.Size(100, 30);
            this.panel_reset.TabIndex = 4;
            this.panel_reset.Click += new System.EventHandler(this.panel_reset_Click);
            // 
            // panel_start
            // 
            this.panel_start.BackgroundImage = global::SnakeForm.Properties.Resources.play;
            this.panel_start.Location = new System.Drawing.Point(10, 369);
            this.panel_start.Name = "panel_start";
            this.panel_start.Size = new System.Drawing.Size(100, 30);
            this.panel_start.TabIndex = 3;
            this.panel_start.Click += new System.EventHandler(this.panel_start_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackgroundImage = global::SnakeForm.Properties.Resources.snake;
            this.panel_header.Location = new System.Drawing.Point(10, 10);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(250, 50);
            this.panel_header.TabIndex = 1;
            // 
            // label_speed
            // 
            this.label_speed.AutoSize = true;
            this.label_speed.Font = new System.Drawing.Font("Endless Boss Battle", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed.ForeColor = System.Drawing.Color.Lime;
            this.label_speed.Location = new System.Drawing.Point(12, 344);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(45, 12);
            this.label_speed.TabIndex = 6;
            this.label_speed.Text = "Speed";
            // 
            // label_speed_minus
            // 
            this.label_speed_minus.AutoSize = true;
            this.label_speed_minus.Font = new System.Drawing.Font("Endless Boss Battle", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed_minus.ForeColor = System.Drawing.Color.Lime;
            this.label_speed_minus.Location = new System.Drawing.Point(64, 344);
            this.label_speed_minus.Name = "label_speed_minus";
            this.label_speed_minus.Size = new System.Drawing.Size(12, 12);
            this.label_speed_minus.TabIndex = 7;
            this.label_speed_minus.Text = "<";
            this.label_speed_minus.Click += new System.EventHandler(this.label_speed_minus_Click);
            // 
            // label_speed_show
            // 
            this.label_speed_show.AutoSize = true;
            this.label_speed_show.Font = new System.Drawing.Font("Endless Boss Battle", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed_show.ForeColor = System.Drawing.Color.Lime;
            this.label_speed_show.Location = new System.Drawing.Point(77, 344);
            this.label_speed_show.Name = "label_speed_show";
            this.label_speed_show.Size = new System.Drawing.Size(13, 12);
            this.label_speed_show.TabIndex = 8;
            this.label_speed_show.Text = "0";
            this.label_speed_show.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_speed_plus
            // 
            this.label_speed_plus.AutoSize = true;
            this.label_speed_plus.Font = new System.Drawing.Font("Endless Boss Battle", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed_plus.ForeColor = System.Drawing.Color.Lime;
            this.label_speed_plus.Location = new System.Drawing.Point(96, 344);
            this.label_speed_plus.Name = "label_speed_plus";
            this.label_speed_plus.Size = new System.Drawing.Size(12, 12);
            this.label_speed_plus.TabIndex = 9;
            this.label_speed_plus.Text = ">";
            this.label_speed_plus.Click += new System.EventHandler(this.label_speed_plus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(274, 411);
            this.Controls.Add(this.label_speed_plus);
            this.Controls.Add(this.label_speed_show);
            this.Controls.Add(this.label_speed_minus);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.panel_reset);
            this.Controls.Add(this.panel_start);
            this.Controls.Add(this.panel_header);
            this.Controls.Add(this.panel_game);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(290, 450);
            this.MinimumSize = new System.Drawing.Size(290, 450);
            this.Name = "Form1";
            this.Text = "Snake";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_game;
        private System.Windows.Forms.Panel panel_header;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Panel panel_start;
        private System.Windows.Forms.Panel panel_reset;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_speed_minus;
        private System.Windows.Forms.Label label_speed_show;
        private System.Windows.Forms.Label label_speed_plus;
    }
}

