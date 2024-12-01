using System;
using System.Windows.Forms;

namespace BouncingBall
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var form = new Form
            {
                Text = "Bouncing Balls Simulation",
                ClientSize = new Size(800, 600)
            };

            Application.Run(form);
        }
    }
}