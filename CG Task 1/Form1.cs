using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CG_Task_1
{
    public partial class Form1 : Form
    {
        Point click;
        Graphics g;
        int speed = 15;
        int x = 161;
        int y = 80;                 // координаты
        int d = 200;                // диаметр шара
        public Form1()
        {
            InitializeComponent();
            Bitmap bmp = new Bitmap(1500, 600);
            Graphics g = Graphics.FromImage(bmp);
        }

        public void DrawMoon(int x, int y)
        {
            g.FillEllipse(Brushes.Yellow, x, y, d, d);
            g.FillEllipse(Brushes.DarkBlue, x + 50, y - 60, d, d);
        }

        public bool check()
        {
            return true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            Graphics g;
           g = CreateGraphics();



            g.FillEllipse(Brushes.DarkBlue, x, y, d, d);
            g.FillEllipse(Brushes.DarkBlue, x + 50, y - 60, d, d);



            x += speed;

            DrawMoon(x, y);
  

            if (x > 750)
            {
                speed *= -1;
            }
            if (x < 160)
                {
                    speed *= -1;
                }
         
        }
        public void DrawStar( int X, int Y)
        {
            g = CreateGraphics();
            Point point1 = new Point(X, Y - 45);
            Point point2 = new Point(X + 31, Y + 48);
            Point point3 = new Point(X - 51, Y - 6);
            Point point4 = new Point(X + 51, Y - 6);
            Point point5 = new Point(X - 31, Y + 48);
            Point[] points = {
                point1,point2,point3,point4,point5
            };
            Pen pen = new Pen(Color.Yellow, 12);
            g.DrawPolygon(pen, points);
        }

        public void DrawNight(Graphics g, Point click)
        {
            g = CreateGraphics();
  
            g.Clear(Color.DarkBlue);



            DrawStar(100, 420);
            DrawStar(1050, 420);
            DrawStar(1060, 35);
            DrawStar(20, 20);
            DrawStar(500, 400);
            DrawStar(1200, 490);


            g.FillEllipse(Brushes.SandyBrown, 1, 400, 1300, 1000);
            g.DrawEllipse(Pens.Black, 1, 400, 1300, 1000);
            g.FillEllipse(Brushes.DarkSlateGray, 800, 550, 100, 50);
            g.FillEllipse(Brushes.DarkSlateGray, 850, 500, 100, 50);
            g.FillEllipse(Brushes.DarkSlateGray, 900, 570, 100, 50);
            g.FillEllipse(Brushes.DarkSlateGray, 300, 550, 240, 100);
            g.FillEllipse(Brushes.DarkSlateGray, 450, 500, 120, 50);

        }

        public void DrawAlien(Graphics g, Point click)
        {
            g = CreateGraphics();
            g.DrawLine(Pens.Aquamarine, 630, 445, 610, 420);
            g.DrawLine(Pens.Aquamarine, 700, 445, 730, 420);
            g.FillEllipse(Brushes.Aquamarine, 600, 425, 150, 80);
            g.FillEllipse(Brushes.Black, 650, 480, 50, 10);
            g.FillEllipse(Brushes.Aquamarine, 630, 490, 100, 140);
            g.FillEllipse(Brushes.Aquamarine, 600, 510, 50, 90);
            g.FillEllipse(Brushes.Aquamarine, 705, 510, 50, 90);
            g.FillEllipse(Brushes.Aquamarine, 600, 510, 50, 90);
            g.FillEllipse(Brushes.Aquamarine, 620, 600, 50, 90);
            g.FillEllipse(Brushes.Aquamarine, 680, 600, 50, 90);
        }

        public void Eyes(int E, int EY)
        {
            g.FillEllipse(Brushes.Black, E, 445, 38, 18);
            g.FillEllipse(Brushes.Black, EY, 445, 38, 18);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawNight(g, click);
      

        }
 
          private void Form1_MouseClick(object sender, MouseEventArgs e)
            {

            click = e.Location;
   
            DrawStar(click.X, click.Y);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        int E = 613;
        int EY = 680;
        int speed1 = 1;

        private void timer2_Tick(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            Graphics g;
            g = CreateGraphics();

            DrawAlien(g, click);

            g.FillEllipse(Brushes.Aquamarine, 613, 445, 38, 18);
            g.FillEllipse(Brushes.Aquamarine, 680, 445, 38, 18);


            E += speed1;
            EY += speed1;

            Eyes(E, EY);

            if ( E > 624)
            {
                speed1 *= -1;
            }
            if (E < 613)
            {
                speed1 *= -1;
            }
        }
    }
}
