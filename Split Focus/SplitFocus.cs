using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Split_Focus.Resources;

namespace Split_Focus
{
    public partial class SplitFocus : Form
    {
        //progress bar drawing
        Graphics g;
        TargetBar progress = new TargetBar();

        //defining 'target' and 'bomb' to allow other functions to reference it
        PictureBox target;
        PictureBox bomb;

        //ints for setting average click time
        int popTime = 0;
        int totalPopTime = 0;
        int popCount = 0;
        int popAvg = 0;

        int targetsDown = 0;

        //i value for danger visual timer
        int tmrDangerI = 0;

        //scores
        public string name = null;
        public int score = 0;
        public int hitRate = 0;


        public SplitFocus()
        {
            InitializeComponent();
            picTargetImage.Visible = false;
            picBombImage.Visible = false;
            lblScore.Visible = false;
            lblHitrate.Visible = false;
            lblName.Visible = false;

        }
        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            progress.DrawProgress(g);
        }

        private void hbtnStart_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter a name.");
            }
            else
            {
                tmrTarget.Enabled = true;

                hbtnStart.Visible = false;
                hbtnHTP.Visible = false;
                picTitle.Visible = false;
                lblStart.Visible = false;
                lblHTP.Visible = false;
                label1.Visible = false;
                txtName.Visible = false;

                lblName.Visible = true;
                lblScore.Visible = true;
                lblHitrate.Visible = true;

                //setting the name
                name = txtName.Text;
                lblName.Text = name;

            }
        }

        private void tmrTarget_Tick(object sender, EventArgs e)
        {

            //remove the preexisting target, then create a new one in another random position
            this.Controls.Remove(target);
            this.Controls.Remove(bomb);
            CreateTarget();

            //check if all targets have spawned
            if (targetsDown > 10)
            {
                StopGame();
            }
        }

        private void CreateTarget()
        {
            //lower limit inclusive, upper limit exclusive
            Random random = new Random();

            if (random.Next(1, 6) != 1)
            {
                //create target
                target = new PictureBox
                {
                    Name = "target",
                    Size = new Size(40, 40),
                    Location = new Point(random.Next(100, this.Width - 100), random.Next(100, this.Height - 300)),
                    Image = picTargetImage.Image,
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                this.Controls.Add(target);
                target.BringToFront();
                target.Click += target_Click;

                tmrScore.Enabled = true;

                //add one to the total number of targets created
                targetsDown++;
                progress.SetBar(targetsDown, this.Width);
                pnlGame.Invalidate();
            }
            else
            {
                //create bomb
                bomb = new PictureBox
                {
                    Name = "bomb",
                    Size = new Size(40, 40),
                    Location = new Point(random.Next(100, this.Width - 100), random.Next(100, this.Height - 300)),
                    Image = picBombImage.Image
                };
                this.Controls.Add(bomb);
                bomb.BringToFront();
                bomb.Click += bomb_Click;
            }
        }

        private void tmrScore_Tick(object sender, EventArgs e)
        {
            popTime++;

            score++;
            lblScore.Text = "Score: " + score.ToString();
        }

        private void target_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(target);
            tmrScore.Enabled = false;

            //calculating the new pop average
            popCount++;
            totalPopTime += popTime;
            popAvg = totalPopTime / popCount;
            lblHitrate.Text = "Average Hitrate: " + (popAvg * 10).ToString() + "ms";
            hitRate = popAvg * 10;

            popTime = 0;
        }
        private void bomb_Click(object sender, EventArgs e)
        {
            tmrDanger.Enabled = true;

            this.Controls.Remove(bomb);
            score += 100;
            lblScore.Text = "Score: " + score.ToString();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            tmrDanger.Enabled = true;
            score += 100;
            lblScore.Text = "Score: " + score.ToString();
        }
        private void pnlGame_Click(object sender, EventArgs e)
        {
            tmrDanger.Enabled = true;
            score += 100;
            lblScore.Text = "Score: " + score.ToString();
        }

        private void tmrDanger_Tick(object sender, EventArgs e)
        {
            tmrDangerI++;
            if(tmrDangerI <= 4)
            {
                if (tmrDangerI % 2 == 0)
                {
                    lblScore.BackColor = Color.White;
                }
                else
                {
                    lblScore.BackColor = Color.Brown;
                }
            }
            else
            {
                tmrDangerI = 0;
                tmrDanger.Enabled = false;
            }
          
        }

        private void StopGame()
        {
            tmrTarget.Enabled = false;
            tmrScore.Enabled = false;
            this.Controls.Remove(target);
            this.Controls.Remove(bomb);

            FormHighscores highscores = new FormHighscores(name, score, hitRate);
            Hide();
            highscores.ShowDialog();
        }
    }
}
