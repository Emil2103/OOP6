using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OOP6
{
    class CTriangle: Object
    {
        public CTriangle(int x, int y, RectangleF circuit)
        {
            this.x = x;
            this.y = y;
            this.circuit = circuit;
            createShape();
        }

        public override void createShape()
        {
            myPath.Reset();
            Point[] point = new Point[]
            {
                new Point(x, y - OValue/2),
                new Point(x-OValue/2, y + OValue/2),
                new Point(x + OValue/2, y + OValue/2)

            };
            myPath.AddPolygon(point);
        }
    }
}
