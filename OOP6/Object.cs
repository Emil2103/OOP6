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
    public abstract class Object
    {
        
        protected int x;
        protected int y;
        protected int OValue = 50;
        protected RectangleF circuit;
        protected GraphicsPath myPath = new GraphicsPath();
        Color color;
        Pen redpen = new Pen(Color.Red);
        public bool popal = false;
       
        public void DrawShape(Graphics G)
        {
            Pen pen = new Pen(color, 2);
            redpen.Width = 2;
            G.DrawPath(popal ? redpen : pen, myPath);
        }

        public bool Popal(int x, int y)
        {
            return myPath.IsVisible(x, y);
        }

        public void ObjSize(int dx)
        {
            OValue = OValue + dx;
            createShape();
            outOfBounds(); 
        }

        public void Move(int dx, int dy)
        {
            x = x + dx;
            y = y + dy;
            createShape();
            outOfBounds();
        }

        public abstract void createShape();

        public void outOfBounds()
        {
            //if (x - OValue / 2 < circuit.Left)
            //    Move(1, 0);
            //if (y - OValue / 2 < circuit.Top)
            //    Move(0, 1);
            //if (x + OValue / 2 > circuit.Right)
            //    Move(-1, 0);
            //if (y + OValue / 2 > circuit.Bottom)
            //    Move(0, -1);
            
            
            while (!circuit.Contains(myPath.GetBounds()))
            {
                RectangleF ShapeCircuit = myPath.GetBounds();
                PointF LeftTop = ShapeCircuit.Location;
                PointF RightTop = new PointF(ShapeCircuit.Right, ShapeCircuit.Top);
                PointF LeftBottom = new PointF(ShapeCircuit.Left, ShapeCircuit.Bottom);
                PointF RightBottom = new PointF(ShapeCircuit.Right, ShapeCircuit.Bottom);
                if (!circuit.Contains(LeftTop) && !circuit.Contains(LeftBottom))
                    ++x;
                if (!circuit.Contains(LeftTop) && !circuit.Contains(RightTop))
                    ++y;
                if (!circuit.Contains(RightTop) && !circuit.Contains(RightBottom))
                    --x;
                if (!circuit.Contains(LeftBottom) && !circuit.Contains(RightBottom))
                    --y;
                createShape();
            }
        }

        public void getRectangleF(RectangleF r)
        {
            circuit = r;
        }
        
        public void ChangeColor(Color color)
        {
            this.color = color;
        }
    }
}
