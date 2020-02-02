using System;
using System.Windows.Forms;

namespace WindowTransitionTest001
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (!IsHandleCreated) return;
            _timer.Enabled = false;
            using (var subForm = new SubForm1())
            {
                subForm.ShowDialog(this);
                _timer.Enabled = true;
            }
        }
    }
}
