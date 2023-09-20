using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public abstract class Shape : Painter
    {
        public abstract void Draw(Point PStart, Point PEnd, Pen p, MouseEventArgs e, Graphics g);
        public abstract void DrawFigure(Pen p, int cX,int cY,int sX,int sY, Graphics g);
        public abstract void DrawStraightLine(Pen p, int cX, int cY, int x,int y, Graphics g);


       
    }
}
