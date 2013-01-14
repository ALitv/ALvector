﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ALvector
{
    public partial class Form1 : Form
    {
        List<Shape> Shapes = new List<Shape>();
        Point ShapeStart;
        bool IsShapeStart = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (rb_Cross.Checked) Shapes.Add(new Cross(e.X, e.Y));
            if (rb_Line.Checked)
            {
                if (IsShapeStart) ShapeStart = e.Location;
                else Shapes.Add(new Line(ShapeStart, e.Location));
                IsShapeStart = !IsShapeStart;
            }
            if (rb_circle.Checked)
            {
                if (IsShapeStart) ShapeStart = e.Location;
                else Shapes.Add(new Circle(ShapeStart, e.Location));
                IsShapeStart = !IsShapeStart;
            }
            this.Refresh();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = Convert.ToString(e.Location); 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape p in Shapes)
            {
                p.DrawWith(e.Graphics);
            }
        }
        public class Cross : Shape
        {
            int X, Y;
            Pen p = new Pen(Color.Red);
            public Cross(int _X, int _Y)
            {
                X = _X; Y = _Y;
            }
            public override void DrawWith(Graphics g)
            {
                g.DrawLine(p, X - 4, Y - 4, X + 4, Y + 4);
                g.DrawLine(p, X + 4, Y - 4, X - 4, Y + 4);
            }
        }
        public class Line : Shape
        {
            Point C, F;
            Pen p = new Pen(Color.Blue);
            public Line(Point _C, Point _F)
            {
                this.C = _C; this.F = _F;
            }
            public override void DrawWith(Graphics g)
            {
                g.DrawLine(p, C, F);
            }
        }
        public class Circle : Shape
        {
            Point C, P;
            Pen p = new Pen(Color.Blue);
            int r;
            public Circle(Point _C, Point _P)
            {
                C = _C;
                P = _P;
                r = Convert.ToInt32(Math.Sqrt(Math.Pow(C.X - P.X, 2) + Math.Pow(C.Y - P.Y, 2)));
            }
            public override void DrawWith(Graphics g)
            {
                g.DrawEllipse(p, C.X - r, C.Y - r, 2 * r, 2 * r);
            }
        }

        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            IsShapeStart = !IsShapeStart;
        }
        public abstract class Shape
        {
            public abstract void DrawWith(Graphics g);
        }
    }
}
