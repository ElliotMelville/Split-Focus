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
using System.Media;

namespace Split_Focus.Resources
{
    class TargetBar
    {
        public int x, y, width, height;
        public Image progressImage;
        public Rectangle progressRec;

        public TargetBar()
        {
            x = 0;
            y = 850;
            width = 20;
            height = 20;
            progressImage = Properties.Resources.progressbar;
            progressRec = new Rectangle(x, y, width, height);
        }
        public void DrawProgress(Graphics g)
        {
            g.DrawImage(progressImage, progressRec);
        }
        public void SetBar(int targetsDown, int formWidth)
        {
            //percantage of targets down
            width = (formWidth * targetsDown) / 10;
            progressRec = new Rectangle(x, y, width, height);
        }
    }
}
