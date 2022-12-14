using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fractal_Tree
{
    public partial class Form1 : Form
    {
        int height = 0; //Tree Height
        int width = 0; //Tree Width
        int m = -1;
        int segment = 70; //Value of the first segment of the tree

        double decrease = 0.82; //Drecrease value
        double angle = 40; //Rotation angle of the branches (degrees)

        Graphics graph;
        Brush brush;
        Pen pen;


        public Form1()
        {
            InitializeComponent();

            panel1.Text = "Fractal Tree";

            height = panel1.Height; 
            width = panel1.Width;

            brush = new SolidBrush(Color.Red);
            pen = new Pen(brush, 1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            height = panel1.Height;
            width = panel1.Width;

            //First Line Coordinates
            int x0 = width / 2;
            int y0 = height + m * 30;

            graph = panel1.CreateGraphics();
            graph.Clear(panel1.BackColor);

            graph.DrawLine(pen, x0, y0, x0, y0 + m * segment); //Drawing the trunk

            Branche(x0, y0 + m * segment, segment, 90); //Drawing branches

        }

        private void Branche(double cx0, double cy0, double reach, double initialAngle)
        {

            if(reach > 9)
            {
                //Branches angles
                double ang1 = initialAngle + (angle / 2); 
                double ang2 = initialAngle - (angle / 2);

                double dx0 = reach * Math.Cos(DegreeToRadian(ang1));
                double dy0 = reach * Math.Sin(DegreeToRadian(ang1));

                graph.DrawLine(pen, (float)cx0, (float)cy0, (float)(cx0 + dx0), (float)(cy0 + m*dy0));
                Branche(cx0+dx0, cy0+ m * dy0, reach * decrease, ang1);


                double ex0 = reach * Math.Cos(DegreeToRadian(ang2));
                double ey0 = reach * Math.Sin(DegreeToRadian(ang2));

                graph.DrawLine(pen, (float)cx0, (float)cy0, (float)(cx0 + ex0), (float)(cy0 + m * ey0));
                Branche(cx0 + ex0, cy0 + m * ey0, reach * decrease, ang2);
            }

        }

        private double DegreeToRadian(double ang)
        {
            return Math.PI * ang / 180.0;
        }

        private double RadianToDegree(double ang)
        {
            return ang * (180.0 / Math.PI);
        }
    }
}