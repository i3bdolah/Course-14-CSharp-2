using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int FormWidthCenterPoint = this.Width / 2;
            int FormHeightCenterPoint = this.Height / 2;

            int ArtifactWidth = 10;
            int ArtifactHeight = 10;

            int ArtifactX = FormWidthCenterPoint - (ArtifactWidth / 2);
            int ArtifactY = FormHeightCenterPoint - (ArtifactHeight / 2);

            Color Red = Color.Red;

            Pen MyPen = new Pen(Red, 10);

            MyPen.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            MyPen.EndCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;

            // DrawEllipse(X-axis, Y-axis, Width, Height)
            e.Graphics.DrawEllipse(MyPen, ArtifactX, ArtifactY, 100, 100);
        }
    }
}
