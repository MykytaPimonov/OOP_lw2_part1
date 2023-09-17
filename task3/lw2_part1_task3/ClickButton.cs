using System;
using System.Drawing;
using System.Windows.Forms;

namespace lw2_part1_task3
{
    public class ClickButton : Button
    {
        private int countClicks = 0;

        public int Clicks
        {
            get => countClicks;
        }

        protected override void OnClick(EventArgs e)
        {
            countClicks++;
            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Graphics graphics = pevent.Graphics;
            SizeF size = graphics.MeasureString(Clicks.ToString(), this.Font, this.Width);
            graphics.DrawString(
                Clicks.ToString(), 
                this.Font, 
                System.Drawing.SystemBrushes.ControlText,
                this.Width - size.Width - 3,
                this.Height - size.Height - 3
            );
        }
    }
}