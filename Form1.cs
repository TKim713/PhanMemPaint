﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net;

namespace PhanMemPaint
{
    public partial class Form1 : Form
    {
        ToolTip t1 = new ToolTip();
        Graphics gp;
        Color myColor;
        SolidBrush myBrush;
        Pen myPen, myEraser;
        Bitmap bm;

        private bool isCtrlKeyPressed = false;
        bool isDrawing = false;
        bool bLine = false;
        bool bEllipse = false;
        bool bFilledEllipse = false;
        bool bRect = false;
        bool bFilledRect = false;
        bool bCircle = false;
        bool bFilledCircle = false;
        bool bArc = false;

        bool bPencil = false;
        bool bEraser = false;

        //Danh sách đương thẳng
        List<clsDrawObject> lstObject = new List<clsDrawObject>();
        //private List<clsDrawObject> selectedShapes = new List<clsDrawObject>();
        private clsDrawObject selectedShape;
        private clsDrawObject movingShape;
        private Point lastPoint;
        Point p1, p2;

        private int handleSize = 10;
        private int selectedShapeWidth;
        private int selectedShapeHeight;
        private Point resizeHandleStartPoint;

        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(pbMain.Width, pbMain.Height);
            gp = Graphics.FromImage(bm);
            gp.Clear(Color.White);
            pbMain.Image = bm;
            gp.SmoothingMode = SmoothingMode.AntiAlias;
            myColor = Color.Black;
            myPen = new Pen(myColor);
            myEraser = new Pen(Color.White, 100);
            myPen.LineJoin = LineJoin.Round;
            myPen.StartCap = LineCap.Round;
            myPen.EndCap = LineCap.Round;
            myBrush = new SolidBrush(myColor);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            this.bLine = true;
            btnLine.BackColor = Color.LightCoral;

            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;

            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            this.bEllipse = true;
            btnEllipse.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;

            btnLine.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
        }
        private void btnFilledEllipse_Click(object sender, EventArgs e)
        {
            this.bFilledEllipse = true;
            btnFilledEllipse.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
        }
        private void btnRect_Click(object sender, EventArgs e)
        {
            this.bRect = true;
            btnRect.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
        }
        private void btnFilledRect_Click(object sender, EventArgs e)
        {
            this.bFilledRect = true;
            btnFilledRect.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.bCircle = true;
            btnCircle.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
        }
        private void btnFilledCircle_Click(object sender, EventArgs e)
        {
            this.bFilledCircle = true;
            btnFilledCircle.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
        }
        private void btnArc_Click(object sender, EventArgs e)
        {
            this.bArc = true;
            btnArc.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;

            this.bPencil = false;
            this.bEraser = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
        }
        private void btnPencil_Click(object sender, EventArgs e)
        {
            this.bPencil = true;
            btnPencil.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bEraser = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnEraser.BackColor = Color.Pink;
        }
        private void btnEraser_Click(object sender, EventArgs e)
        {
            this.bEraser = true;
            btnEraser.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
        }
        private void btnPencil_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw", btnPencil);
            btnPencil.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnPencil_MouseLeave(object sender, EventArgs e)
        {
            btnPencil.FlatAppearance.BorderColor = Color.White;
        }
        private void btnEraser_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Erase", btnEraser);
            btnEraser.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnEraser_MouseLeave(object sender, EventArgs e)
        {
            btnEraser.FlatAppearance.BorderColor = Color.White;
        }
        private void btnLine_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Line", btnLine);
            btnLine.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnLine_MouseLeave(object sender, EventArgs e)
        {
            btnLine.FlatAppearance.BorderColor = Color.White;
        }
        private void btnEllipse_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Ellipse", btnEllipse);
            btnEllipse.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnEllipse_MouseLeave(object sender, EventArgs e)
        {
            btnEllipse.FlatAppearance.BorderColor = Color.White;
        }
        private void btnFilledEllipse_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Filled Ellipse", btnFilledEllipse);
            btnFilledEllipse.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnFilledEllipse_MouseLeave(object sender, EventArgs e)
        {
            btnFilledEllipse.FlatAppearance.BorderColor = Color.White;
        }
        private void btnRect_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Rectangle", btnRect);
            btnRect.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnRect_MouseLeave(object sender, EventArgs e)
        {
            btnRect.FlatAppearance.BorderColor = Color.White;
        }
        private void btnFilledRect_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Filled Rectangle", btnFilledRect);
            btnFilledRect.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnFilledRect_MouseLeave(object sender, EventArgs e)
        {
            btnFilledRect.FlatAppearance.BorderColor = Color.White;
        }
        private void btnCircle_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Circle", btnCircle);
            btnCircle.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnCircle_MouseLeave(object sender, EventArgs e)
        {
            btnCircle.FlatAppearance.BorderColor = Color.White;
        }
        private void btnFilledCircle_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Filled Circle", btnFilledCircle);
            btnFilledCircle.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnFilledCircle_MouseLeave(object sender, EventArgs e)
        {
            btnFilledCircle.FlatAppearance.BorderColor = Color.White;
        }
        private void btnArc_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Arc", btnArc);
            btnArc.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnArc_MouseLeave(object sender, EventArgs e)
        {
            btnArc.FlatAppearance.BorderColor = Color.White;
        }
        private void btnPolygon_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Polygon", btnPolygon);
            btnPolygon.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnPolygon_MouseLeave(object sender, EventArgs e)
        {
            btnPolygon.FlatAppearance.BorderColor = Color.White;
        }
        private void btnFilledPolygon_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Draw Filled Polygon", btnFilledPolygon);
            btnFilledPolygon.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnFilledPolygon_MouseLeave(object sender, EventArgs e)
        {
            btnFilledPolygon.FlatAppearance.BorderColor = Color.White;
        }
        private void pbMain_MouseHover(object sender, EventArgs e)
        {
            pbMain.Cursor = Cursors.Cross;
        }
        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in lstObject)
            {
                shape.Draw(e.Graphics);
                if (movingShape != null && selectedShape != null)
                {
                    //4 corner
                    Rectangle ltResizeHandleRect = new Rectangle(movingShape.p1.X - handleSize / 2, movingShape.p1.Y - handleSize / 2, handleSize, handleSize);
                    Rectangle rtResizeHandleRect = new Rectangle(movingShape.p1.X + movingShape.Size.Width - handleSize / 2, movingShape.p1.Y - handleSize / 2, handleSize, handleSize);
                    Rectangle lbResizeHandleRect = new Rectangle(movingShape.p1.X - handleSize / 2, movingShape.p1.Y + movingShape.Size.Height - handleSize / 2, handleSize, handleSize);
                    Rectangle rbResizeHandleRect = new Rectangle(movingShape.p1.X + movingShape.Size.Width - handleSize / 2, movingShape.p1.Y + movingShape.Size.Height - handleSize / 2, handleSize, handleSize);

                    e.Graphics.FillEllipse(Brushes.SlateGray, ltResizeHandleRect);
                    e.Graphics.FillEllipse(Brushes.SlateGray, rtResizeHandleRect);
                    e.Graphics.FillEllipse(Brushes.SlateGray, lbResizeHandleRect);
                    e.Graphics.FillEllipse(Brushes.SlateGray, rbResizeHandleRect);

                    //Border line
                    Pen borderPen = new Pen(Color.SlateGray, 1);
                    borderPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    e.Graphics.DrawRectangle(borderPen, new Rectangle(movingShape.p1.X, movingShape.p1.Y, movingShape.Size.Width, movingShape.Size.Height));
                }
            }
        }
        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            foreach (var shape in lstObject)
            {
                Rectangle ltResizeHandleRect = new Rectangle(shape.p1.X - handleSize / 2, shape.p1.Y - handleSize / 2, handleSize, handleSize);
                Rectangle rtResizeHandleRect = new Rectangle(shape.p1.X + shape.Size.Width - handleSize / 2, shape.p1.Y - handleSize / 2, handleSize, handleSize);
                Rectangle lbResizeHandleRect = new Rectangle(shape.p1.X - handleSize / 2, shape.p1.Y + shape.Size.Height - handleSize / 2, handleSize, handleSize);
                Rectangle rbResizeHandleRect = new Rectangle(shape.p1.X + shape.Size.Width - handleSize / 2, shape.p1.Y + shape.Size.Height - handleSize / 2, handleSize, handleSize);

                if (shape.Contains(e.Location))
                {
                    selectedShape = shape;
                    break;
                }
                //Top left corner
                if (ltResizeHandleRect.Contains(e.Location))
                {
                    selectedShape = shape;
                    selectedShapeWidth = shape.Size.Width;
                    selectedShapeHeight = shape.Size.Height;
                    resizeHandleStartPoint = new Point(shape.p1.X, shape.p1.Y);

                    pbMain.Cursor = Cursors.SizeNWSE;
                    break;
                }
                //Top right corner
                if (rtResizeHandleRect.Contains(e.Location))
                {
                    selectedShape = shape;
                    selectedShapeWidth = shape.Size.Width;
                    selectedShapeHeight = shape.Size.Height;
                    resizeHandleStartPoint = new Point(shape.p1.X + shape.Size.Width, shape.p1.Y);

                    pbMain.Cursor = Cursors.SizeNESW;
                    break;
                }
                //Bottom left corner
                if (lbResizeHandleRect.Contains(e.Location))
                {
                    selectedShape = shape;
                    selectedShapeWidth = shape.Size.Width;
                    selectedShapeHeight = shape.Size.Height;
                    resizeHandleStartPoint = new Point(shape.p1.X, shape.p1.Y + shape.Size.Height);

                    pbMain.Cursor = Cursors.SizeNESW;
                    break;
                }
                //Bottom right corner
                if (rbResizeHandleRect.Contains(e.Location))
                {
                    selectedShape = shape;
                    selectedShapeWidth = shape.Size.Width;
                    selectedShapeHeight = shape.Size.Height;
                    resizeHandleStartPoint = new Point(shape.p1.X + shape.Size.Width, shape.p1.Y + shape.Size.Height);

                    pbMain.Cursor = Cursors.SizeNWSE;
                    break;
                }
            }
            if (bPencil == true || bEraser == true)
            {
                isDrawing = true;
                p2 = e.Location;
            }
            else if (selectedShape == null)
            {
                isDrawing = true;
                if (bLine == true)
                    selectedShape = new clsLine { myPen = myPen, p1 = e.Location};
                if (bEllipse == true)
                    selectedShape = new clsEllipse { myPen = myPen, p1 = e.Location };
                if (bFilledEllipse == true)
                    selectedShape = new clsFilledEllipse { myBrush = myBrush, p1 = e.Location };
                if (bRect == true)
                    selectedShape = new clsRect { myPen = myPen, p1 = e.Location };
                if (bFilledRect == true)
                    selectedShape = new clsFilledRect { myBrush = myBrush, p1 = e.Location };
                if (bCircle == true)
                    selectedShape = new clsCircle { myPen = myPen, p1 = e.Location };
                if (bFilledCircle == true)
                    selectedShape = new clsFilledCircle { myBrush = myBrush, p1 = e.Location };
                lstObject.Add(selectedShape);
            }
        }
        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                if (bPencil == true)
                {
                    p1 = e.Location;
                    gp.DrawLine(myPen, p1, p2);
                    p2 = p1;
                }
                else if (bEraser == true)
                {
                    p1 = e.Location;
                    gp.DrawLine(myEraser, p1, p2);
                    p2 = p1;
                }
                else selectedShape.p2 = e.Location;
            }
            else if (isDrawing == false && selectedShape != null)
            {
                int dx = e.Location.X - lastPoint.X;
                int dy = e.Location.Y - lastPoint.Y;
                lastPoint = e.Location;

                if (selectedShape.Contains(e.Location) && resizeHandleStartPoint == Point.Empty)
                {
                    pbMain.Cursor = Cursors.SizeAll;
                    movingShape = selectedShape;
                    selectedShape.Move(dx, dy);
                    pbMain.Refresh();
                }
                else if (resizeHandleStartPoint != Point.Empty)
                {
                    selectedShape.p1.X = selectedShape.p1.X + dx;
                    selectedShape.p1.Y = selectedShape.p1.Y + dy;
                    pbMain.Refresh();
                }
            }
            pbMain.Refresh();
        }
        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedShape != null)
                selectedShape = null;
            isDrawing = false;
            selectedShapeWidth = 0;
            selectedShapeHeight = 0;
            resizeHandleStartPoint = Point.Empty;
            movingShape = null;
            pbMain.Cursor = Cursors.Cross;
        }
    };
    public abstract class clsDrawObject
    {
        public Point p1;
        public Point p2;
        public Size Size;
        public Pen myPen { get; set; }
        public SolidBrush myBrush { get; set; }
        public abstract void Draw(Graphics myGp);
        public virtual void Move(int dx, int dy)
        {
            p1.X = p1.X + dx;
            p1.Y = p1.Y + dy;

            p2.X = p2.X + dx;
            p2.Y = p2.Y + dy;
        }
        public abstract bool Contains(Point point);
    };
    public class clsLine : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.DrawLine(myPen, p1, p2);
        }
        public override bool Contains(Point point)
        {
            if (point.X >= p1.X && point.X <= p1.X + Size.Width && point.Y >= p1.Y && point.Y <= p1.Y + Size.Height)
                return true;
            return false;
        }
    };
    public class clsEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            myGp.DrawEllipse(myPen, new Rectangle(p1.X, p1.Y, Size.Width, Size.Height));
        }
        public override bool Contains(Point point)
        {
            int r = Size.Width / 2;
            int dx = point.X - (p1.X + r);
            int dy = point.Y - (p1.Y + r);
            return dx * dx + dy * dy < r * r;
        }
    };
    public class clsFilledEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            myGp.FillEllipse(myBrush, new Rectangle(p1.X, p1.Y, Size.Width, Size.Height));
        }
        public override bool Contains(Point point)
        {
            int r = Size.Width / 2;
            int dx = point.X - (p1.X + r);
            int dy = point.Y - (p1.Y + r);
            return dx * dx + dy * dy < r * r;
        }
    };
    public class clsRect : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            myGp.DrawRectangle(myPen, new Rectangle(p1.X, p1.Y, Size.Width, Size.Height));
        }
        public override bool Contains(Point point)
        {
            if (point.X >= p1.X && point.X <= p1.X + Size.Width && point.Y >= p1.Y && point.Y <= p1.Y + Size.Height)
                return true;
            return false;
        }
    };
    public class clsFilledRect : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            myGp.FillRectangle(myBrush, new Rectangle(p1.X, p1.Y, Size.Width, Size.Height));
        }
        public override bool Contains(Point point)
        {
            if (point.X >= p1.X && point.X <= p1.X + Size.Width && point.Y >= p1.Y && point.Y <= p1.Y + Size.Height)
                return true;
            return false;
        }
    };
    public class clsCircle : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            int diameter;
            diameter = Math.Min(Size.Width, Size.Height);
            myGp.DrawEllipse(myPen, new Rectangle(p1.X, p1.Y, diameter, diameter));
        }
        public override bool Contains(Point point)
        {
            int r = Size.Width / 2;
            int dx = point.X - (p1.X + r);
            int dy = point.Y - (p1.Y + r);
            return dx * dx + dy * dy < r * r;
        }
    };
    public class clsFilledCircle : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            int diameter;
            diameter = Math.Min(Size.Width, Size.Height);
            myGp.FillEllipse(myBrush, new Rectangle(p1.X, p1.Y, diameter, diameter));
        }
        public override bool Contains(Point point)
        {
            int r = Size.Width / 2;
            int dx = point.X - (p1.X + r);
            int dy = point.Y - (p1.Y + r);
            return dx * dx + dy * dy < r * r;
        }
    };
}