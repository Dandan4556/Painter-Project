using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Painter
{
    public partial class Painter : Form
    {
        public Painter()
        {
            InitializeComponent();

            this.Width = 870;
            this.Height= 650;
            bm = new Bitmap(Pic.Width, Pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Pic.Image = bm;


        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point PStart,PEnd;
        Pen p = new Pen(Color.Teal, 1);
        int index;
        Shape shape;
        int x, y, sX, sY, cX, cY;
        ColorDialog cd = new ColorDialog();
        Color New_Color;
       
       

        private void Pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            PEnd = e.Location;
            cX = e.X;
            cY = e.Y;
        }
        private void Pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                PStart = e.Location;
                shape.Draw(PStart, PEnd, p, e, g);
                PEnd = PStart;
                }
            }
            Pic.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;  
        }
        private void Pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;

            if (index == 2)
            {
                shape.DrawFigure(p, cX, cY, sX, sY, g);
            }
            if (index == 3)
            {
                shape.DrawStraightLine( p, cX, cY, x, y, g);
            }

        }
        private void Painter_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            New_Color = cd.Color;
            Pic_Color.BackColor = cd.Color;
            p.Color = cd.Color;
        }


        private void Btn_Ellipse_Click(object sender, EventArgs e)
        {
            index = 2;
            this.shape = new Ellipse();
        }

        private void Btn_Circle_Click(object sender, EventArgs e)
        {
            index = 2;
            this.shape = new Circle();
        }
        private void Btn_Rectangle_Click(object sender, EventArgs e)
        {
            index = 2;
            this.shape = new Rect();
        }

        private void Btn_Pencil_Click(object sender, EventArgs e)
        {
            index = 1;
            this.shape = new Pencil();
        }

        private void Btn_Eraser_Click(object sender, EventArgs e)
        {
            index = 1;
            this.shape = new Eraser();
        }


        private void Btn_Line_Click(object sender, EventArgs e)
        {
            index = 3;
            this.shape = new Line();
        }
        private void Btn_Square_Click(object sender, EventArgs e)
        {
            index = 2;
            this.shape = new Square();
        }



        private void Pic_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 2)
                {
                    shape.DrawFigure(p, cX, cY, sX, sY, g);
                }
                if (index == 3)
                {
                    shape.DrawStraightLine(p, cX, cY, x, y, g);
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            p = new Pen(Btn_Color.BackColor, (float)NumericUpDown1.Value);
        }

        private void Btn_Background_Click(object sender, EventArgs e)
        {

            cd.ShowDialog();
            Fill(bm, 1, 1, cd.Color);
        }
        private void Validate (Bitmap bm , Stack<Point>sp, int x, int y, Color old_color, Color New_Color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, New_Color);
            }
        }

        public void Fill (Bitmap bm , int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    Validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    Validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    Validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);

                }

            }
        }


        private void Btn_Fill_Click(object sender, EventArgs e)
        {
            index = 4;
        }


        private void Pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 4)
            {
                Point point = set_point(Pic, e.Location);
                Fill(bm, point.X, point.Y, New_Color);
            }
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Width / pb.Width;
            float pY = 1f * pb.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void Btn_Load_image_Click(object sender, EventArgs e)
        {
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png";
                if (open.ShowDialog() == DialogResult.OK)
                {
                    bm = new Bitmap(open.FileName);
                    bm = new Bitmap(bm, new Size(this.Width, this.Height));
                    g = Graphics.FromImage(bm);
                    Pic.Image = bm;
                    MessageBox.Show("Image loaded succesfully :)");
                }
            }
        }
        private void Btn_Cats_Image_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            Stream stream = client.OpenRead("https://cataas.com/cat");
            bm = new Bitmap(stream);
            bm = new Bitmap(bm, new Size(this.Width, this.Height));
            g = Graphics.FromImage(bm);
            Pic.Image = bm;
        }
        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Pic.Image = bm;
            index = 0;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Image(*.jpg)|*.jpg";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, Pic.Width, Pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
                MessageBox.Show("Image saved succesfully :)");
            }
        }
    }
}


