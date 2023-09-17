using System;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace lw2_part1_task2
{
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
        {
            InitializeComponent();
        }
        
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            graphics.FillRectangle(Brushes.Aqua, 0, 0, this.Width, this.Height);
            graphics.DrawString(DateTime.Now.ToLongTimeString(), this.Font, new SolidBrush(this.ForeColor), 0, 0);
        }

        private void timer1_Elapsed(object sender, ElapsedEventArgs e)
        {
            this.Refresh();
        }
    }
}