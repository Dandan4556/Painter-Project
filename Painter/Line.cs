using System;
using System.Collections.Generic;
using System.Drawing;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painter
{
    public partial class Line : Shape
    {

        public Line()
        {

        }

       
        public override void Draw(Point PStart, Point PEnd, Pen p, MouseEventArgs e, Graphics g)
        {
            //

        }

        public override void DrawFigure(Pen p, int cX, int cY, int sX, int sY, Graphics g)
        {

            //

        }
        public override void DrawStraightLine(Pen p, int cX, int cY, int x, int y, Graphics g)
        {
            g.DrawLine(p, cX, cY, x, y);
        }


    }
}
