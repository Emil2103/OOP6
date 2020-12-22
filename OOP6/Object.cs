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
            this.OValue = this.OValue + dx;
            createShape();
            outOfBounds(this.x, this.y);
        }

        public void Move(int dx, int dy)
        {
            this.x = this.x + dx;
            this.y = this.y + dy;
            createShape();
            outOfBounds(this.x, this.y);
            
        }

        public abstract void createShape();

        public void outOfBounds(int x, int y)
        {
                if (x - OValue/2 < circuit.Left)
                    Move(1, 0);       
                if (x + OValue/2 > circuit.Right - circuit.X)
                    Move(-1, 0);      
                if (y - OValue/2 < circuit.Top)
                    Move(0, 1);      
                if (y + OValue/2 > circuit.Bottom - circuit.Y)
                    Move(0, -1);   
        }

        public void getRectangleF(RectangleF r)
        {
            this.circuit = r;
        }
        
        public void ChangeColor(Color color)
        {
            this.color = color;
        }
    }
}
