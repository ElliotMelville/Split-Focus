
namespace Split_Focus
{
    partial class SplitFocus
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
            this.tmrTarget = new System.Windows.Forms.Timer(this.components);
            this.tmrScore = new System.Windows.Forms.Timer(this.components);
            this.lblHitrate = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.tmrDanger = new System.Windows.Forms.Timer(this.components);
            this.picTitle = new System.Windows.Forms.PictureBox();
            this.picBombImage = new System.Windows.Forms.PictureBox();
            this.picTargetImage = new System.Windows.Forms.PictureBox();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblHTP = new System.Windows.Forms.Label();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.hbtnHTP = new Split_Focus.HoverButton();
            this.hbtnStart = new Split_Focus.HoverButton();
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBombImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTargetImage)).BeginInit();
            this.pnlGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrTarget
            // 
            this.tmrTarget.Interval = 3000;
            this.tmrTarget.Tick += new System.EventHandler(this.tmrTarget_Tick);
            // 
            // tmrScore
            // 
            this.tmrScore.Interval = 10;
            this.tmrScore.Tick += new System.EventHandler(this.tmrScore_Tick);
            // 
            // lblHitrate
            // 
            this.lblHitrate.AutoSize = true;
            this.lblHitrate.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHitrate.Location = new System.Drawing.Point(12, 788);
            this.lblHitrate.Name = "lblHitrate";
            this.lblHitrate.Size = new System.Drawing.Size(288, 39);
            this.lblHitrate.TabIndex = 0;
            this.lblHitrate.Text = "Average Hitrate: 0ms";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(12, 724);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(122, 39);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Score: 0";
            // 
            // tmrDanger
            // 
            this.tmrDanger.Tick += new System.EventHandler(this.tmrDanger_Tick);
            // 
            // picTitle
            // 
            this.picTitle.Image = global::Split_Focus.Properties.Resources.Untitled;
            this.picTitle.Location = new System.Drawing.Point(0, 0);
            this.picTitle.Name = "picTitle";
            this.picTitle.Size = new System.Drawing.Size(1111, 881);
            this.picTitle.TabIndex = 4;
            this.picTitle.TabStop = false;
            // 
            // picBombImage
            // 
            this.picBombImage.Image = global::Split_Focus.Properties.Resources.bomb2;
            this.picBombImage.Location = new System.Drawing.Point(12, 87);
            this.picBombImage.Name = "picBombImage";
            this.picBombImage.Size = new System.Drawing.Size(40, 42);
            this.picBombImage.TabIndex = 3;
            this.picBombImage.TabStop = false;
            // 
            // picTargetImage
            // 
            this.picTargetImage.Image = global::Split_Focus.Properties.Resources.targetbutton;
            this.picTargetImage.Location = new System.Drawing.Point(12, 30);
            this.picTargetImage.Name = "picTargetImage";
            this.picTargetImage.Size = new System.Drawing.Size(40, 42);
            this.picTargetImage.TabIndex = 2;
            this.picTargetImage.TabStop = false;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStart.Location = new System.Drawing.Point(125, 643);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(190, 80);
            this.lblStart.TabIndex = 7;
            this.lblStart.Text = "START";
            // 
            // lblHTP
            // 
            this.lblHTP.BackColor = System.Drawing.Color.Transparent;
            this.lblHTP.Font = new System.Drawing.Font("Impact", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTP.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHTP.Location = new System.Drawing.Point(475, 470);
            this.lblHTP.Name = "lblHTP";
            this.lblHTP.Size = new System.Drawing.Size(153, 96);
            this.lblHTP.TabIndex = 8;
            this.lblHTP.Text = "HOW TO PLAY";
            this.lblHTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGame
            // 
            this.pnlGame.Controls.Add(this.lblName);
            this.pnlGame.Controls.Add(this.label1);
            this.pnlGame.Controls.Add(this.txtName);
            this.pnlGame.Controls.Add(this.picTitle);
            this.pnlGame.Location = new System.Drawing.Point(0, 0);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(1100, 900);
            this.pnlGame.TabIndex = 9;
            this.pnlGame.Click += new System.EventHandler(this.pnlGame_Click);
            this.pnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlGame_Paint);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblName.Location = new System.Drawing.Point(925, 786);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 39);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(304, 796);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAME:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(380, 798);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 27);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "anon";
            // 
            // hbtnHTP
            // 
            this.hbtnHTP.BackColor = System.Drawing.Color.Transparent;
            this.hbtnHTP.BackgroundImage = global::Split_Focus.Properties.Resources.targetbutton;
            this.hbtnHTP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hbtnHTP.FlatAppearance.BorderSize = 0;
            this.hbtnHTP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.hbtnHTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.hbtnHTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtnHTP.Location = new System.Drawing.Point(492, 326);
            this.hbtnHTP.MaximumGrowSize = 60;
            this.hbtnHTP.Name = "hbtnHTP";
            this.hbtnHTP.Size = new System.Drawing.Size(120, 120);
            this.hbtnHTP.Speed = 10;
            this.hbtnHTP.TabIndex = 6;
            this.hbtnHTP.UseVisualStyleBackColor = false;
            this.hbtnHTP.Click += new System.EventHandler(this.hbtnHTP_Click);
            // 
            // hbtnStart
            // 
            this.hbtnStart.BackColor = System.Drawing.Color.Transparent;
            this.hbtnStart.BackgroundImage = global::Split_Focus.Properties.Resources.targetbutton;
            this.hbtnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hbtnStart.FlatAppearance.BorderSize = 0;
            this.hbtnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.hbtnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.hbtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtnStart.Location = new System.Drawing.Point(139, 460);
            this.hbtnStart.MaximumGrowSize = 60;
            this.hbtnStart.Name = "hbtnStart";
            this.hbtnStart.Size = new System.Drawing.Size(160, 160);
            this.hbtnStart.Speed = 10;
            this.hbtnStart.TabIndex = 5;
            this.hbtnStart.UseVisualStyleBackColor = false;
            this.hbtnStart.Click += new System.EventHandler(this.hbtnStart_Click);
            // 
            // SplitFocus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.hbtnHTP);
            this.Controls.Add(this.hbtnStart);
            this.Controls.Add(this.lblHTP);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.picBombImage);
            this.Controls.Add(this.picTargetImage);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblHitrate);
            this.Controls.Add(this.pnlGame);
            this.Name = "SplitFocus";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBombImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTargetImage)).EndInit();
            this.pnlGame.ResumeLayout(false);
            this.pnlGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrTarget;
        private System.Windows.Forms.Timer tmrScore;
        private System.Windows.Forms.Label lblHitrate;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.PictureBox picTargetImage;
        private System.Windows.Forms.PictureBox picBombImage;
        private System.Windows.Forms.Timer tmrDanger;
        private System.Windows.Forms.PictureBox picTitle;
        private HoverButton hbtnStart;
        private HoverButton hbtnHTP;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblHTP;
        private System.Windows.Forms.Panel pnlGame;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
    }
}

