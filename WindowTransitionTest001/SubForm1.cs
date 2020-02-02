using System;
using System.Windows.Forms;

namespace WindowTransitionTest001
{
    public partial class SubForm1 : Form
    {
        public SubForm1()
        {
            InitializeComponent();
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            _timer.Enabled = true;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (!IsHandleCreated) return;
            _timer.Enabled = false;
            using (var subForm = new SubForm2())
            {
                subForm.FormClosed += SubForm_FormClosed;
                subForm.ShowDialog(this);
                subForm.FormClosed -= SubForm_FormClosed;
            }
        }

        private void SubForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            BeginInvoke((MethodInvoker)(() => Close()));
        }
    }
}
