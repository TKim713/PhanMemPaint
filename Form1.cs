﻿namespace PhanMemPaint
{
    public partial class Form1 : Form
    {
        ToolTip t1 = new ToolTip();
        Graphics gp;
        Color myColor;
        SolidBrush myBrush;
        Pen myPen;

        private bool isCtrlKeyPressed = false;
        bool bEllipse = false;
        bool bFilledEllipse = false;
        bool bCircle = false;
        bool bFilledCircle = false;

        //Danh sách đương thẳng
        List<clsDrawObject> lstObject = new List<clsDrawObject>();
        //private List<clsDrawObject> selectedShapes = new List<clsDrawObject>();
        private clsDrawObject selectedShape;
        private clsDrawObject movingShape;
        private Point lastPoint;
        //private Point endPoint;

        private int handleSize = 10;
        private int selectedShapeWidth;
        private int selectedShapeHeight;
        private Point resizeHandleStartPoint;

        public Form1()
        {
            InitializeComponent();
            gp = this.pnMain.CreateGraphics();
            //gp.SmoothingMode = SmoothingMode.AntiAlias;
            //myPen.StartCap = LineCap.Round;
            //myPen.EndCap = LineCap.Round;
            //myPen.LineJoin = LineJoin.Round;
            myColor = Color.Black;
            myPen = new Pen(myColor);
            myBrush = new SolidBrush(myColor);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnNull_Click(object sender, EventArgs e)
        {
            //this.bNull = true;
        }
        private void btnLine_Click(object sender, EventArgs e)
        {
            //this.bLine = true;
        }
        private void btnEllipse_Click(object sender, EventArgs e)
        {
            this.bEllipse = true;
            btnEllipse.BackColor = Color.LightCoral;

            this.bFilledEllipse = false;
            this.bCircle = false;
            this.bFilledCircle = false;

            btnFilledEllipse.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
        }
        private void btnFilledEllipse_Click(object sender, EventArgs e)
        {
            this.bFilledEllipse = true;
            btnFilledEllipse.BackColor = Color.LightCoral;

            this.bEllipse = false;
            this.bCircle = false;
            this.bFilledCircle = false;

            btnEllipse.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
        }
        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.bCircle = true;
            btnCircle.BackColor = Color.LightCoral;

            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bFilledCircle = false;

            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
        }
        private void btnFilledCircle_Click(object sender, EventArgs e)
        {
            this.bFilledCircle = true;
            btnFilledCircle.BackColor = Color.LightCoral;

            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bCircle = false;

            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
        }
        private void btnNull_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Default Pen", btnNull);
            btnNull.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnNull_MouseLeave(object sender, EventArgs e)
        {
            btnNull.FlatAppearance.BorderColor = Color.White;
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
        private void pnMain_MouseHover(object sender, EventArgs e)
        {
            pnMain.Cursor = Cursors.Cross;
        }
        private void pnMain_Paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in lstObject)
            {
                shape.Draw(e.Graphics);
                if (movingShape != null && selectedShape != null)
                {
                    //4 corner
                    Rectangle ltResizeHandleRect = new Rectangle(movingShape.Location.X - handleSize / 2, movingShape.Location.Y - handleSize / 2, handleSize, handleSize);
                    Rectangle rtResizeHandleRect = new Rectangle(movingShape.Location.X + movingShape.Size.Width - handleSize / 2, movingShape.Location.Y - handleSize / 2, handleSize, handleSize);
                    Rectangle lbResizeHandleRect = new Rectangle(movingShape.Location.X - handleSize / 2, movingShape.Location.Y + movingShape.Size.Height - handleSize / 2, handleSize, handleSize);
                    Rectangle rbResizeHandleRect = new Rectangle(movingShape.Location.X + movingShape.Size.Width - handleSize / 2, movingShape.Location.Y + movingShape.Size.Height - handleSize / 2, handleSize, handleSize);

                    e.Graphics.FillEllipse(Brushes.SlateGray, ltResizeHandleRect);
                    e.Graphics.FillEllipse(Brushes.SlateGray, rtResizeHandleRect);
                    e.Graphics.FillEllipse(Brushes.SlateGray, lbResizeHandleRect);
                    e.Graphics.FillEllipse(Brushes.SlateGray, rbResizeHandleRect);

                    //Border line
                    Pen borderPen = new Pen(Color.SlateGray, 1);
                    borderPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                    e.Graphics.DrawRectangle(borderPen, new Rectangle(movingShape.Location, movingShape.Size));
                }
            }
        }
        private void pnMain_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var shape in lstObject)
            {
                Rectangle ltResizeHandleRect = new Rectangle(shape.Location.X - handleSize / 2, shape.Location.Y - handleSize / 2, handleSize, handleSize);
                Rectangle rtResizeHandleRect = new Rectangle(shape.Location.X + shape.Size.Width - handleSize / 2, shape.Location.Y - handleSize / 2, handleSize, handleSize);
                Rectangle lbResizeHandleRect = new Rectangle(shape.Location.X - handleSize / 2, shape.Location.Y + shape.Size.Height - handleSize / 2, handleSize, handleSize);
                Rectangle rbResizeHandleRect = new Rectangle(shape.Location.X + shape.Size.Width - handleSize / 2, shape.Location.Y + shape.Size.Height - handleSize / 2, handleSize, handleSize);

                if (shape.Contains(e.Location))
                {
                    selectedShape = shape;
                    lastPoint = e.Location;
                    break;
                }
                //Top left corner
                if (ltResizeHandleRect.Contains(e.Location))
                {
                    selectedShape = shape;
                    selectedShapeWidth = shape.Size.Width;
                    selectedShapeHeight = shape.Size.Height;
                    resizeHandleStartPoint = new Point(shape.Location.X, shape.Location.Y);

                    pnMain.Cursor = Cursors.SizeNWSE;
                    break;
                }
                //Top right corner
                if (rtResizeHandleRect.Contains(e.Location))
                {
                    selectedShape = shape;
                    selectedShapeWidth = shape.Size.Width;
                    selectedShapeHeight = shape.Size.Height;
                    resizeHandleStartPoint = new Point(shape.Location.X + shape.Size.Width, shape.Location.Y);

                    pnMain.Cursor = Cursors.SizeNESW;
                    break;
                }
                //Bottom left corner
                if (lbResizeHandleRect.Contains(e.Location))
                {
                    selectedShape = shape;
                    selectedShapeWidth = shape.Size.Width;
                    selectedShapeHeight = shape.Size.Height;
                    resizeHandleStartPoint = new Point(shape.Location.X, shape.Location.Y + shape.Size.Height);

                    pnMain.Cursor = Cursors.SizeNESW;
                    break;
                }
                //Bottom right corner
                if (rbResizeHandleRect.Contains(e.Location))
                {
                    selectedShape = shape;
                    selectedShapeWidth = shape.Size.Width;
                    selectedShapeHeight = shape.Size.Height;
                    resizeHandleStartPoint = new Point(shape.Location.X + shape.Size.Width, shape.Location.Y + shape.Size.Height);

                    pnMain.Cursor = Cursors.SizeNWSE;
                    break;
                }
            }
            if (selectedShape == null)
            {
                if (bEllipse == true)
                    selectedShape = new clsEllipse { myPen = myPen, Location = e.Location, Size = new Size(0, 0) };
                if (bFilledEllipse == true)
                    selectedShape = new clsFilledEllipse { myBrush = myBrush, Location = e.Location, Size = new Size(0, 0) };
                if (bCircle == true)
                    selectedShape = new clsCircle { myPen = myPen, Location = e.Location, Size = new Size(0, 0) };
                if (bFilledCircle == true)
                    selectedShape = new clsFilledCircle { myBrush = myBrush, Location = e.Location, Size = new Size(0, 0) };
                lstObject.Add(selectedShape);
            }
        }
        private void pnMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectedShape != null)
            {
                int dx = e.Location.X - lastPoint.X;
                int dy = e.Location.Y - lastPoint.Y;
                lastPoint = e.Location;

                if (selectedShape.Contains(e.Location) && resizeHandleStartPoint == Point.Empty)
                {
                    pnMain.Cursor = Cursors.SizeAll;
                    movingShape = selectedShape;
                    selectedShape.Move(dx, dy);
                    pnMain.Refresh();
                }
                else if (resizeHandleStartPoint != Point.Empty)
                {
                    // Dragging
                    int newWidth = selectedShapeWidth + (e.Location.X - resizeHandleStartPoint.X);
                    int newHeight = selectedShapeHeight + (e.Location.Y - resizeHandleStartPoint.Y);

                    // Keep proportions of the shape
                    if (Control.ModifierKeys == Keys.Shift)
                    {
                        double aspectRatio = (double)selectedShape.Size.Width / selectedShape.Size.Height;
                        if (newWidth / aspectRatio > newHeight)
                            newWidth = (int)(newHeight * aspectRatio);
                        else newHeight = (int)(newWidth / aspectRatio);
                    }
                    selectedShape.Size = new Size(newWidth, newHeight);
                    pnMain.Refresh();
                }
                else
                {
                    movingShape = null;
                    if (bCircle == true || bFilledCircle == true)
                    {
                        int diameter;
                        diameter = Math.Min(Math.Abs(e.Location.X - selectedShape.Location.X), Math.Abs(e.Location.Y - selectedShape.Location.Y));
                        selectedShape.Size = new Size(diameter, diameter);
                    }
                    else
                        selectedShape.Size = new Size(e.Location.X - selectedShape.Location.X, e.Location.Y - selectedShape.Location.Y);
                    pnMain.Refresh();
                }
            }
        }
        private void pnMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (selectedShape != null)
                selectedShape = null;
            selectedShapeWidth = 0;
            selectedShapeHeight = 0;
            resizeHandleStartPoint = Point.Empty;
            movingShape = null;
            pnMain.Cursor = Cursors.Cross;
        }
    };
    public abstract class clsDrawObject
    {
        public Point Location { get; set; }
        public Size Size { get; set; }
        public Pen myPen { get; set; }
        public SolidBrush myBrush { get; set; }
        public abstract void Draw(Graphics myGp);
        public virtual void Move(int dx, int dy)
        {
            Location = new Point(Location.X + dx, Location.Y + dy);
        }
        public abstract bool Contains(Point point);
    };
    public class clsEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.DrawEllipse(myPen, new Rectangle(Location, Size));
        }
        public override bool Contains(Point point)
        {
            int r = Size.Width / 2;
            int dx = point.X - (Location.X + r);
            int dy = point.Y - (Location.Y + r);
            return dx * dx + dy * dy < r * r;
        }
    };
    public class clsFilledEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.FillEllipse(myBrush, new Rectangle(Location, Size));
        }
        public override bool Contains(Point point)
        {
            int r = Size.Width / 2;
            int dx = point.X - (Location.X + r);
            int dy = point.Y - (Location.Y + r);
            return dx * dx + dy * dy < r * r;
        }
    };
    public class clsCircle : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.DrawEllipse(myPen, new Rectangle(Location, Size));
        }
        public override bool Contains(Point point)
        {
            int r = Size.Width / 2;
            int dx = point.X - (Location.X + r);
            int dy = point.Y - (Location.Y + r);
            return dx * dx + dy * dy < r * r;
        }
    };
    public class clsFilledCircle : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            myGp.FillEllipse(myBrush, new Rectangle(Location, Size));
        }
        public override bool Contains(Point point)
        {
            int r = Size.Width / 2;
            int dx = point.X - (Location.X + r);
            int dy = point.Y - (Location.Y + r);
            return dx * dx + dy * dy < r * r;
        }
    };
}