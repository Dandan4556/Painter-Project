using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Painter
{
    public partial class Pencil : Shape
    {
        public Pencil()
        {
            
        }

        
        public override void Draw(Point PStart, Point PEnd, Pen p,MouseEventArgs e, Graphics g)
        {
            g.DrawLine(p, PStart, PEnd);

        }
        public override void DrawFigure(Pen p, int cX, int cY, int sX, int sY, Graphics g)
        {
            //
        }
        public override void DrawStraightLine(Pen p, int cX, int cY, int x, int y, Graphics g)
        {
            //
        }
    }

}

