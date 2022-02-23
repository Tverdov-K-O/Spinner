using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Spinner.Geometric_Shape
{
    class Spinner : ICommand
    {
        float radius = 10f, angularSpeed = 2f;
        float angle = 0f;
        Graphics g;
        public Point pointOnForm { get; set; }
        public Spinner(Point frm, Graphics _g)
        {
            pointOnForm = frm;
            g = _g;
        }

        private void Paint()
        {
            
            while (true)
            {

                SolidBrush solidBrushRed = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
                g.FillEllipse(solidBrushRed, pointOnForm.X - radius*2 + MathF.Cos(angle) * radius, pointOnForm.Y - radius*2 + MathF.Sin(angle) * radius, 20, 20);
                g.DrawEllipse(Pens.Coral, pointOnForm.X - radius*2 + MathF.Cos(angle) * radius, pointOnForm.Y - radius*2 + MathF.Sin(angle) * radius, 20, 20);
                angle = angle + 0.10f * angularSpeed;
                if (angle >= 360f)
                {
                    angle = 0;
                }
                Thread.Sleep(20);
            }
        }

        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter = null) => true;
        public void Execute(object parameter = null) => Paint();
    }
}
