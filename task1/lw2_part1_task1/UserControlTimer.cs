using System;
using System.Timers;
using System.Windows.Forms;

namespace lw2_part1_task1
{
    public partial class UserControlTimer : UserControl
    {
        public UserControlTimer()
        {
            InitializeComponent();
        }

        public bool TimerEnable
        {
            get => timer.Enabled;
            set => timer.Enabled = value;
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            label.Text = DateTime.Now.ToLongTimeString();
        }
    }
}