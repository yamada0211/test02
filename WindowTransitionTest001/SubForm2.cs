using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowTransitionTest001
{
    public partial class SubForm2 : Form
    {
        public SubForm2()
        {
            InitializeComponent();

        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            Task.Factory.StartNew(() =>
            {
                Task.Delay(3000).Wait();
                Invoke((MethodInvoker)(() => Close()));
            });
        }
    }
}
