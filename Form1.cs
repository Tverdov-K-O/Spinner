using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spinner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = CreateGraphics();
            Spinner.Geometric_Shape.Spinner spinner = new Spinner.Geometric_Shape.Spinner(new Point(this.Width/2,this.Height/2),g);
            new Task(() => { spinner.Execute(); }).Start();
        }
    }
}
