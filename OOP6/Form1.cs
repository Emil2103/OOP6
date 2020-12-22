using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP6
{
    public partial class Form1 : Form
    {
        RectangleF circuit;
        Graphics G;
        Storage S;
        Bitmap bitmap;
        Color color;
        bool ctrlPress = false;
        bool Cpress = false;
        public int t; //выбор фигуры
        public int c; //выбор цвета
        public int dx = 0;
        public int dy = 0;
        
        public Form1()
        {
            InitializeComponent();
            S = new Storage(100);
            bitmap = new Bitmap(sheet.Width, sheet.Height);
            G = Graphics.FromImage(bitmap);
            sheet.Image = bitmap;
            circuit = new RectangleF(sheet.Location.X - 11, sheet.Location.Y - 30, sheet.Width - 2, sheet.Height - 2);
        }

        private void unselectedAll()
        {
            for (int i = 0; i < S.getsize(); i++)
            {
                if (S.obj[i] != null)
                    S.obj[i].popal = false;
            }
        }

        private void sheet_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (c)
                {
                    case 1:
                        color = Color.Yellow;
                        break;
                    case 2:
                        color = Color.Blue;
                        break;
                    case 3:
                        color = Color.Green;
                        break;
                    default:
                        color = Color.Black;
                        break;
                }
                for (int i = 0; i < S.getsize(); i++)
                {
                    if (S.obj[i] != null)
                    {
                       Object current = S.obj[i];
                       if (S.obj[i].Popal(e.X, e.Y))
                       {
                            if (!ctrlPress)
                            {
                                unselectedAll();
                            }
                            if (Cpress)
                            {
                                current.ChangeColor(color);
                            }
                            current.popal = (current.popal ? false : true);
                            this.Invalidate();
                            return;
                       }
                       
                    }
                }
                unselectedAll(); 
                switch (t)
                {
                    case 1:
                        Object newObjCir = new CCircle(e.X, e.Y, circuit);
                        S.addObject(newObjCir);
                        this.Invalidate();
                        break;
                    case 2:
                        Object newObjRec = new CRectangle(e.X, e.Y, circuit);
                        S.addObject(newObjRec);
                        this.Invalidate();
                        break;
                    case 3:
                        Object newObjTr = new CTriangle(e.X, e.Y, circuit);
                        S.addObject(newObjTr);
                        this.Invalidate();
                        break;
                }
                for (int i = S.getsize()-1; i >= 0; i--)
                {
                    if (S.obj[i] != null)
                    {
                        S.obj[i].ChangeColor(color);
                        break;
                    }
                }

            }
        }
        private void sheet_Paint(object sender, PaintEventArgs e)
        {
            G.Clear(Color.White);  
            for (int i = 0; i < S.getsize(); i++)
            {
                if (S.obj[i] != null)
                {
                    S.obj[i].DrawShape(G);
                }
            }
            sheet.Image = bitmap;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            ctrlPress = false;
            Cpress = false;
        }

        private void DrCirc_Click(object sender, EventArgs e)
        {
            DrCirc.Enabled = false;
            DrRec.Enabled = true;
            DrTr.Enabled = true;
            t = 1;
        }

        private void DrRec_Click(object sender, EventArgs e)
        {
            DrRec.Enabled = false;
            DrCirc.Enabled = true;
            DrTr.Enabled = true;
            t = 2;
        }

       
        private void DrTr_Click(object sender, EventArgs e)
        {
            DrTr.Enabled = false;
            DrRec.Enabled = true;
            DrCirc.Enabled = true;
            t = 3;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
                ctrlPress = true;
            if(e.KeyCode == Keys.C)
            {
                Cpress = true;
            }
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < S.getsize(); i++)
                {
                    if (S.obj[i] != null && S.obj[i].popal)
                    {
                        S.deleteObject(i);
                    }
                }
                this.Invalidate();
            }

            if (e.KeyCode == Keys.E || e.KeyCode == Keys.Q)
            {
                switch (e.KeyCode)
                {
                    case Keys.Q:
                        dx = -3;
                        break;
                    case Keys.E:
                        dx = 3;
                        break;
                }
                for (int i = 0; i < S.getsize(); i++)
                {
                    if (S.obj[i] != null && S.obj[i].popal)
                    {
                        S.obj[i].ObjSize(dx);
                    }
                }
                this.Invalidate();
            }
            else
            {
                dx = 0;
            }

            if(e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D ){
                switch (e.KeyCode)
                {
                    case Keys.A:
                        dx = -5;
                        dy = 0;
                        break;
                    case Keys.W:
                        dy = -5;
                        dx = 0;
                        break;
                    case Keys.S:
                        dy = 5;
                        dx = 0;
                        break;
                    case Keys.D:
                        dx = 5;
                        dy = 0;
                        break;
                }
                for (int i = 0; i < S.getsize(); i++)
                {
                    if (S.obj[i] != null && S.obj[i].popal)
                    {
                        S.obj[i].Move(dx, dy);
                    }
                }
                this.Invalidate();
            }
            else
            {
                dx = 0;
                dy = 0;
            }

            if(e.KeyCode == Keys.R)
            {
                for (int i = 0; i < S.getsize(); i++)
                {
                    if (S.obj[i] != null)
                    {
                        S.deleteObject(i);
                    }
                }
                this.Invalidate();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            bitmap = new Bitmap(sheet.Width, sheet.Height);
            G = Graphics.FromImage(bitmap);
            circuit = new RectangleF(sheet.Location.X - 11, sheet.Location.Y - 30, sheet.Width - 2, sheet.Height - 2);
            for(int i= 0; i< S.getsize(); i++)
            {
                if (S.obj[i] != null)
                    S.obj[i].getRectangleF(circuit);
            }
        }

        private void YellowBt_Click(object sender, EventArgs e)
        {
            YellowBt.Enabled = false;
            BlueBt.Enabled = true;
            GreenBt.Enabled = true;
            
            c = 1;
        }

        private void BlueBt_Click(object sender, EventArgs e)
        {
            BlueBt.Enabled = false;
            YellowBt.Enabled = true;
            GreenBt.Enabled = true;
            
            c = 2;
        }

        private void GreenBt_Click(object sender, EventArgs e)
        {
            GreenBt.Enabled = false;
            BlueBt.Enabled = true;
            YellowBt.Enabled = true;
            
            c = 3;
        }

        private void ResetBt_Click(object sender, EventArgs e)
        {
            DrCirc.Enabled = true;
            DrRec.Enabled = true;
            DrTr.Enabled = true;
            YellowBt.Enabled = true;
            BlueBt.Enabled = true;
            GreenBt.Enabled = true;
        }
    }
}

