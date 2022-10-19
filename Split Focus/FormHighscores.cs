using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Split_Focus
{
    public partial class FormHighscores : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";
        List<HighScores> highScores = new List<HighScores>();

        public FormHighscores(string playerName, int playerScore, int playerHitRate)
        {
            InitializeComponent();
            lblPlayerName.Text = playerName;
            lblPlayerScore.Text = playerScore.ToString();
            lblPlayerHitrate.Text = playerHitRate.ToString();

            var reader = new StreamReader(binPath);
            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                //names are in values[0], scores in values[1], and hitrates in values[2]
                var values = line.Split(',');
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1]), Int32.Parse(values[2])));
            }
            reader.Close();

            int highestScore = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(lblPlayerScore.Text) < highestScore)
            {
                lblMessage.Text = "You are in the top ten!";
                highScores.Add(new HighScores(lblPlayerName.Text, int.Parse(lblPlayerScore.Text), int.Parse(lblPlayerHitrate.Text)));
            }
            else
            {
                lblMessage.Text = "Keep trying to surpass Medaassee's ranks!";
            }

            SortHighScores();
            DisplayHighScores();

        }
        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                lstBoxName.Items.Add(s.Name);
                lstBoxScore.Items.Add(s.Score);
                lstBoxHitrate.Items.Add(s.HitRate);

            }
        }
        public void SortHighScores()
        {
            highScores = highScores.OrderBy(hs => hs.Score).Take(10).ToList();
        }
        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score, {2} is for the hitrate, and {3} is for a new line
                builder.Append(string.Format("{0},{1},{2}{3}", score.Name, score.Score, score.HitRate, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }


        private void hbtnReturn_Click(object sender, EventArgs e)
        {
            SaveHighScores();
            SplitFocus splitFocus = new SplitFocus();
            Hide();
            splitFocus.ShowDialog();
        }
    }
}
