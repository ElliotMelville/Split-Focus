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
using System.Collections.Generic;

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
        private void hbtnReturn_Click(object sender, EventArgs e)
        {
            SplitFocus splitFocus = new SplitFocus();
            splitFocus.ShowDialog();
        }
    }
}
