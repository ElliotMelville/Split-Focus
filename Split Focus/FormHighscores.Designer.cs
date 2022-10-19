
namespace Split_Focus
{
    partial class FormHighscores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.hbtnReturn = new Split_Focus.HoverButton();
            this.lblPlayerHitrate = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstBoxName = new System.Windows.Forms.ListBox();
            this.lstBoxScore = new System.Windows.Forms.ListBox();
            this.lstBoxHitrate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPlayerName.Location = new System.Drawing.Point(74, 247);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(109, 23);
            this.lblPlayerName.TabIndex = 2;
            this.lblPlayerName.Text = "player name";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPlayerScore.Location = new System.Drawing.Point(220, 247);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(55, 23);
            this.lblPlayerScore.TabIndex = 3;
            this.lblPlayerScore.Text = "score";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(74, 380);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(57, 23);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "label7";
            // 
            // hbtnReturn
            // 
            this.hbtnReturn.BackgroundImage = global::Split_Focus.Properties.Resources.targetbutton;
            this.hbtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hbtnReturn.FlatAppearance.BorderSize = 0;
            this.hbtnReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.hbtnReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.hbtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hbtnReturn.Location = new System.Drawing.Point(540, 140);
            this.hbtnReturn.MaximumGrowSize = 60;
            this.hbtnReturn.Name = "hbtnReturn";
            this.hbtnReturn.Size = new System.Drawing.Size(150, 150);
            this.hbtnReturn.Speed = 10;
            this.hbtnReturn.TabIndex = 7;
            this.hbtnReturn.UseVisualStyleBackColor = true;
            this.hbtnReturn.Click += new System.EventHandler(this.hbtnReturn_Click);
            // 
            // lblPlayerHitrate
            // 
            this.lblPlayerHitrate.AutoSize = true;
            this.lblPlayerHitrate.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHitrate.ForeColor = System.Drawing.Color.DarkRed;
            this.lblPlayerHitrate.Location = new System.Drawing.Point(324, 247);
            this.lblPlayerHitrate.Name = "lblPlayerHitrate";
            this.lblPlayerHitrate.Size = new System.Drawing.Size(64, 23);
            this.lblPlayerHitrate.TabIndex = 8;
            this.lblPlayerHitrate.Text = "hitrate";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(325, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "AVG. HITRATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(535, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "RETURN TO HOME";
            // 
            // lstBoxName
            // 
            this.lstBoxName.FormattingEnabled = true;
            this.lstBoxName.Location = new System.Drawing.Point(74, 87);
            this.lstBoxName.Name = "lstBoxName";
            this.lstBoxName.Size = new System.Drawing.Size(109, 147);
            this.lstBoxName.TabIndex = 12;
            // 
            // lstBoxScore
            // 
            this.lstBoxScore.FormattingEnabled = true;
            this.lstBoxScore.Location = new System.Drawing.Point(219, 87);
            this.lstBoxScore.Name = "lstBoxScore";
            this.lstBoxScore.Size = new System.Drawing.Size(91, 147);
            this.lstBoxScore.TabIndex = 13;
            // 
            // lstBoxHitrate
            // 
            this.lstBoxHitrate.FormattingEnabled = true;
            this.lstBoxHitrate.Location = new System.Drawing.Point(325, 87);
            this.lstBoxHitrate.Name = "lstBoxHitrate";
            this.lstBoxHitrate.Size = new System.Drawing.Size(105, 147);
            this.lstBoxHitrate.TabIndex = 14;
            // 
            // FormHighscores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBoxHitrate);
            this.Controls.Add(this.lstBoxScore);
            this.Controls.Add(this.lstBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblPlayerHitrate);
            this.Controls.Add(this.hbtnReturn);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormHighscores";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblMessage;
        private HoverButton hbtnReturn;
        private System.Windows.Forms.Label lblPlayerHitrate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstBoxName;
        private System.Windows.Forms.ListBox lstBoxScore;
        private System.Windows.Forms.ListBox lstBoxHitrate;
    }
}