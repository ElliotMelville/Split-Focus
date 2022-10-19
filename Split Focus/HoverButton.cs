using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Media;
using System.Drawing;
using System.ComponentModel; //use this for the descriptions

namespace Split_Focus
{
    public class HoverButton : Button
    {
        private int maximumGrowSize = 60; [Description("The maximum size that the button will grow. (must be divisible by speed property)")]
        public int MaximumGrowSize
        {
            get
            {
                return maximumGrowSize;
            }
            set
            {
                maximumGrowSize = value;
            }
        }

        private int speed = 10;[Description("The speed that the button will grow. (must be even)")]
        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        Timer timer;

        int ogTop, ogLeft, ogHeight, ogWidth;
        int hasGrownBy = 0;

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.MouseLeave += new System.EventHandler(this.OnMouseLeave);

            this.ogTop = this.Top;
            this.ogLeft = this.Left;
            this.ogHeight = this.Height;
            this.ogWidth = this.Width;
        }

        protected void OnMouseEnter(object sender, EventArgs e)
        {
            this.timer = new Timer();
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.OnTimerTick);
            this.timer.Enabled = true;
        }
        protected void OnMouseLeave(object sender, EventArgs e)
        {
            this.timer.Enabled = false;

            this.Top = ogTop;
            this.Left = ogLeft;
            this.Height = ogHeight;
            this.Width = ogWidth;
            hasGrownBy = 0;
        }
        protected void OnTimerTick(object sender, EventArgs e)
        {
            if(hasGrownBy < maximumGrowSize)
            {
                this.Height += speed;
                this.Top -= (speed / 2);
                this.Width += speed;
                this.Left -= (speed / 2);
                hasGrownBy += speed;
            }
        }

    }
}
