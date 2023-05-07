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
        Cursor tempCursor;
        float penWidth;

        ColorDialog cd = new ColorDialog();

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
        bool bSelect = false;
        bool bFill = false;

        //Danh sách đương thẳng
        List<clsDrawObject> lstObject = new List<clsDrawObject>();
        List<clsDrawObject> selectedShapes = new List<clsDrawObject>();
        private clsDrawObject currentShape;
        private Point lastPoint;
        Point p1, p2;

        private int handleSize = 10;
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
            penWidth = 1;
            myPen = new Pen(myColor, penWidth);
            myBrush = new SolidBrush(myColor);
            myEraser = new Pen(Color.White, 100);
            myPen.LineJoin = LineJoin.Round;
            myPen.StartCap = LineCap.Round;
            myPen.EndCap = LineCap.Round;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void nupPenWidth_Leave(object sender, EventArgs e)
        {
            nupPenWidth.TabStop = false;
        }
        private void nupPenWidth_Enter(object sender, EventArgs e)
        {
            nupPenWidth.TabStop = true;
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
            this.bSelect = false;
            this.bFill = false;

            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
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
            this.bSelect = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.bSelect = true;
            btnSelect.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;
            this.bFill = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
            btnFill.BackColor = Color.Pink;
        }
        private void nupPenWidth_ValueChanged(object sender, EventArgs e)
        {
            penWidth = (float)nupPenWidth.Value;
        }
        private void nupEraserWidth_ValueChanged(object sender, EventArgs e)
        {
            eraserWidth = (float)nupEraserWidth.Value;
        }
        private void btnFill_Click(object sender, EventArgs e)
        {
            this.bFill = true;
            btnFill.BackColor = Color.LightCoral;

            this.bLine = false;
            this.bEllipse = false;
            this.bFilledEllipse = false;
            this.bRect = false;
            this.bFilledRect = false;
            this.bCircle = false;
            this.bFilledCircle = false;
            this.bArc = false;

            this.bPencil = false;
            this.bEraser = false;
            this.bSelect = false;

            btnLine.BackColor = Color.White;
            btnEllipse.BackColor = Color.White;
            btnFilledEllipse.BackColor = Color.White;
            btnRect.BackColor = Color.White;
            btnFilledRect.BackColor = Color.White;
            btnCircle.BackColor = Color.White;
            btnFilledCircle.BackColor = Color.White;
            btnArc.BackColor = Color.White;

            btnPencil.BackColor = Color.Pink;
            btnEraser.BackColor = Color.Pink;
            btnSelect.BackColor = Color.Pink;
            btnColor.BackColor = Color.Pink;
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            btnColor.BackColor = Color.LightCoral;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                btnColor.BackColor = Color.Pink;
                picColor.BackColor = cd.Color;
                myColor = cd.Color;
            }
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
        private void btnSelect_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Select", btnSelect);
            btnSelect.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnSelect_MouseLeave(object sender, EventArgs e)
        {
            btnSelect.FlatAppearance.BorderColor = Color.White;
        }
        private void btnColor_MouseHover(object sender, EventArgs e)
        {
            t1.Show("Choose color", btnColor);
            btnColor.FlatAppearance.MouseOverBackColor = Color.LightCoral;
        }
        private void btnColor_MouseLeave(object sender, EventArgs e)
        {
            btnColor.FlatAppearance.BorderColor = Color.White;
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
            if (bSelect == true)
                pbMain.Cursor = Cursors.Arrow;
            else pbMain.Cursor = Cursors.Cross;
            tempCursor = pbMain.Cursor;
        }
        private void pbMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (bFill == true)
            {
                if (lstObject.Any() == true)
                {
                    foreach (var shape in lstObject)
                    {
                        if (shape.Contains(e.Location))
                        {
                            Bitmap bmp = new Bitmap(pbMain.Width, pbMain.Height);
                            shape.Fill(bmp, myColor);

                            // Hiển thị bitmap lên PictureBox
                            pbMain.Image = bmp;
                        }
                    }
                }
                Point point = set_point(pbMain, e.Location);
                Fill(bm, point.X, point.Y, myColor);
            }
        }
        private void pbMain_Paint(object sender, PaintEventArgs e)
        {
            if (lstObject.Any() == true)
            {
                foreach (var shape in lstObject)
                {
                    shape.Draw(e.Graphics);
                    if (bSelect == true && selectedShapes.Any() == true)
                    {
                        foreach (var selectedShape in selectedShapes)
                        {/*
                            if (selectedShape is clsLine)
                            {
                                // tính toán điểm đầu và cuối của đường thẳng
                                Point start = new Point(Math.Min(selectedShape.p1.X, selectedShape.p2.X), Math.Min(selectedShape.p1.Y, selectedShape.p2.Y));
                                Point end = new Point(Math.Max(selectedShape.p1.X, selectedShape.p2.X), Math.Max(selectedShape.p1.Y, selectedShape.p2.Y));

                                // tính toán vị trí các điểm resize
                                Rectangle p1ResizeHandleRect = new Rectangle(start.X - handleSize / 2, start.Y - handleSize / 2, handleSize, handleSize);
                                Rectangle p2ResizeHandleRect = new Rectangle(end.X - handleSize / 2, end.Y - handleSize / 2, handleSize, handleSize);

                                e.Graphics.FillEllipse(Brushes.SlateGray, p1ResizeHandleRect);
                                e.Graphics.FillEllipse(Brushes.SlateGray, p2ResizeHandleRect);
                            }
                            else
                            {    */
                                //4 corner
                                Rectangle ltResizeHandleRect = new Rectangle(selectedShape.p1.X - handleSize / 2, selectedShape.p1.Y - handleSize / 2, handleSize, handleSize);
                                Rectangle rtResizeHandleRect = new Rectangle(selectedShape.p1.X + selectedShape.Size.Width - handleSize / 2, selectedShape.p1.Y - handleSize / 2, handleSize, handleSize);
                                Rectangle lbResizeHandleRect = new Rectangle(selectedShape.p1.X - handleSize / 2, selectedShape.p1.Y + selectedShape.Size.Height - handleSize / 2, handleSize, handleSize);
                                Rectangle rbResizeHandleRect = new Rectangle(selectedShape.p1.X + selectedShape.Size.Width - handleSize / 2, selectedShape.p1.Y + selectedShape.Size.Height - handleSize / 2, handleSize, handleSize);

                                e.Graphics.FillEllipse(Brushes.SlateGray, ltResizeHandleRect);
                                e.Graphics.FillEllipse(Brushes.SlateGray, rtResizeHandleRect);
                                e.Graphics.FillEllipse(Brushes.SlateGray, lbResizeHandleRect);
                                e.Graphics.FillEllipse(Brushes.SlateGray, rbResizeHandleRect);

                                //Border line
                                Pen borderPen = new Pen(Color.SlateGray, 1);
                                borderPen.DashStyle = DashStyle.Dot;
                                e.Graphics.DrawRectangle(borderPen, new Rectangle(selectedShape.p1.X, selectedShape.p1.Y, selectedShape.Size.Width, selectedShape.Size.Height));
                            //}
                        }
                    }
                }
            }
        }
        private void pbMain_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            if (bSelect == true)
            {
                foreach (var shape in lstObject)
                {
                    if (shape.Contains(e.Location))
                    {
                        if (e.Button == MouseButtons.Right)
                        {
                            contextMenuStrip1.Show(this, e.Location);
                        }
                        if (Control.ModifierKeys == Keys.Control)
                        {
                            isCtrlKeyPressed = true;
                            if (selectedShapes.Contains(shape))
                            {
                                selectedShapes.Remove(shape);
                            }
                            else selectedShapes.Add(shape);
                        }
                        if (isCtrlKeyPressed == false)
                        {
                            selectedShapes.Clear();
                            selectedShapes.Add(shape);
                        }
                        break;
                    }
                    else
                    {
                        selectedShapes.Clear();
                        isCtrlKeyPressed = false;
                    }/*
                    if (shape is clsLine)
                    {
                        // tính toán điểm đầu và cuối của đường thẳng
                        Point start = new Point(Math.Min(shape.p1.X, shape.p2.X), Math.Min(shape.p1.Y, shape.p2.Y));
                        Point end = new Point(Math.Max(shape.p1.X, shape.p2.X), Math.Max(shape.p1.Y, shape.p2.Y));

                        // tính toán vị trí các điểm resize
                        Rectangle p1ResizeHandleRect = new Rectangle(start.X - handleSize / 2, start.Y - handleSize / 2, handleSize, handleSize);
                        Rectangle p2ResizeHandleRect = new Rectangle(end.X - handleSize / 2, end.Y - handleSize / 2, handleSize, handleSize);

                        if (p1ResizeHandleRect.Contains(e.Location))
                        {
                            currentShape = shape;
                            resizeHandleStartPoint = new Point(shape.p1.X, shape.p1.Y);

                            pbMain.Cursor = Cursors.SizeNWSE;
                            break;
                        }
                        if (p2ResizeHandleRect.Contains(e.Location))
                        {
                            currentShape = shape;
                            resizeHandleStartPoint = new Point(shape.p2.X, shape.p2.Y);

                            pbMain.Cursor = Cursors.SizeNESW;
                            break;
                        }
                    }
                    else
                    {
                        Rectangle ltResizeHandleRect = new Rectangle(shape.p1.X - handleSize / 2, shape.p1.Y - handleSize / 2, handleSize, handleSize);
                        Rectangle rtResizeHandleRect = new Rectangle(shape.p1.X + shape.Size.Width - handleSize / 2, shape.p1.Y - handleSize / 2, handleSize, handleSize);
                        Rectangle lbResizeHandleRect = new Rectangle(shape.p1.X - handleSize / 2, shape.p1.Y + shape.Size.Height - handleSize / 2, handleSize, handleSize);
                        Rectangle rbResizeHandleRect = new Rectangle(shape.p1.X + shape.Size.Width - handleSize / 2, shape.p1.Y + shape.Size.Height - handleSize / 2, handleSize, handleSize);

                        //Top left corner
                        if (ltResizeHandleRect.Contains(e.Location))
                        {
                            currentShape = shape;
                            resizeHandleStartPoint = new Point(shape.p1.X, shape.p1.Y);

                            pbMain.Cursor = Cursors.SizeNWSE;
                            break;
                        }
                        //Top right corner
                        if (rtResizeHandleRect.Contains(e.Location))
                        {
                            currentShape = shape;
                            resizeHandleStartPoint = new Point(shape.p1.X + shape.Size.Width, shape.p1.Y);

                            pbMain.Cursor = Cursors.SizeNESW;
                            break;
                        }
                        //Bottom left corner
                        if (lbResizeHandleRect.Contains(e.Location))
                        {
                            currentShape = shape;
                            resizeHandleStartPoint = new Point(shape.p1.X, shape.p1.Y + shape.Size.Height);

                            pbMain.Cursor = Cursors.SizeNESW;
                            break;
                        }
                        //Bottom right corner
                        if (rbResizeHandleRect.Contains(e.Location))
                        {
                            currentShape = shape;
                            resizeHandleStartPoint = new Point(shape.p1.X + shape.Size.Width, shape.p1.Y + shape.Size.Height);

                            pbMain.Cursor = Cursors.SizeNWSE;
                            break;
                        }
                    }*/
                }
            }
            else if (bPencil == true || bEraser == true)
            {
                isDrawing = true;
                p2 = e.Location;
            }
            else if (selectedShapes.Any() == false && bFill != true)
            {
                isDrawing = true;
                if (bLine == true)
                    currentShape = new clsLine { Color = myColor, PenWidth = penWidth, p1 = e.Location };
                if (bEllipse == true)
                    currentShape = new clsEllipse { Color = myColor, PenWidth = penWidth, p1 = e.Location };
                if (bFilledEllipse == true)
                    currentShape = new clsFilledEllipse { Color = myColor, p1 = e.Location };
                if (bRect == true)
                    currentShape = new clsRect { Color = myColor, PenWidth = penWidth, p1 = e.Location };
                if (bFilledRect == true)
                    currentShape = new clsFilledRect { Color = myColor, p1 = e.Location };
                if (bCircle == true)
                    currentShape = new clsCircle { Color = myColor, PenWidth = penWidth, p1 = e.Location };
                if (bFilledCircle == true)
                    currentShape = new clsFilledCircle { Color = myColor, p1 = e.Location };
                lstObject.Add(currentShape);
            }
        }
        private void pbMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing == true)
            {
                if (bPencil == true)
                {
                    p1 = e.Location;
                    gp.DrawLine(new Pen(myColor, penWidth), p1, p2);
                    p2 = p1;
                }
                else if (bEraser == true)
                {
                    p1 = e.Location;
                    gp.DrawLine(myEraser, p1, p2);
                    p2 = p1;
                }
                else currentShape.p2 = e.Location;
            }
            else if (bSelect == true)
            {
                if (selectedShapes.Any() == true)
                {
                    int dx = e.Location.X - lastPoint.X;
                    int dy = e.Location.Y - lastPoint.Y;
                    lastPoint = e.Location;
                    if (e.Button == MouseButtons.Left && resizeHandleStartPoint == Point.Empty)
                    {
                        foreach (var selectedShape in selectedShapes)
                        {
                            pbMain.Cursor = Cursors.SizeAll;
                            selectedShape.Move(dx, dy);
                        }
                    }
                    else if (resizeHandleStartPoint != Point.Empty)
                    {
                        foreach (var selectedShape in selectedShapes)
                        {
                            selectedShape.p1.X = selectedShape.p1.X + dx;
                            selectedShape.p1.Y = selectedShape.p1.Y + dy;
                        }
                    }
                }
            }
            pbMain.Refresh();
        }
        private void pbMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawing == true || bSelect == false)
            {
                currentShape = null;
                selectedShapes.Clear();
                isDrawing = false;
            }
            resizeHandleStartPoint = Point.Empty;
            pbMain.Cursor = tempCursor;
        }
        static Point set_point(PictureBox pbMain, Point pt)
        {
            float pX = 1f * pbMain.Width / pbMain.Width;
            float pY = 1F * pbMain.Height / pbMain.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color oldColor, Color newColor)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == oldColor)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, newColor);
            }
        }
        private void Fill(Bitmap bm, int x, int y, Color newClr)
        {
            Color oldColor = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, newClr);
            if (oldColor == newClr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, oldColor, newClr);
                    validate(bm, pixel, pt.X, pt.Y - 1, oldColor, newClr);
                    validate(bm, pixel, pt.X + 1, pt.Y, oldColor, newClr);
                    validate(bm, pixel, pt.X, pt.Y + 1, oldColor, newClr);
                }
            }
        }

    };
    public abstract class clsDrawObject
    {
        public Point p1;
        public Point p2;
        public Size Size;
        public Color Color { get; set; }
        public float PenWidth { get; set; }
        public abstract void Draw(Graphics myGp);
        public virtual void Move(int dx, int dy)
        {
            p1.X = p1.X + dx;
            p1.Y = p1.Y + dy;

            p2.X = p2.X + dx;
            p2.Y = p2.Y + dy;
        }
        public virtual void Fill(Bitmap bm, Color newClr)
        {
            int left = Math.Min(p1.X, p2.X);
            int top = Math.Min(p1.Y, p2.Y);
            int right = Math.Max(p1.X, p2.X);
            int bottom = Math.Max(p1.Y, p2.Y);

            for (int x = left; x < right; x++)
            {
                for (int y = top; y < bottom; y++)
                {
                    if (Contains(new Point(x, y)))
                    {
                        bm.SetPixel(x, y, newClr);
                    }
                }
            }
        }
        public abstract bool Contains(Point point);
    };
    public class clsLine : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            using (Pen myPen = new Pen(Color, PenWidth))
            {
                myGp.DrawLine(myPen, p1, p2);
            }
        }
        public override bool Contains(Point point)
        {
            double distance = Math.Abs((p2.Y - p1.Y) * point.X - (p2.X - p1.X) * point.Y + p2.X * p1.Y - p2.Y * p1.X) / Math.Sqrt(Math.Pow(p2.Y - p1.Y, 2) + Math.Pow(p2.X - p1.X, 2));
            return distance <= PenWidth / 2; // đường kính của đường vẽ
        }
    };
    public class clsEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            using (Pen myPen = new Pen(Color, PenWidth))
            {
                myGp.DrawEllipse(myPen, new Rectangle(p1.X, p1.Y, Size.Width, Size.Height));
            }
        }
        public override bool Contains(Point point)
        {
            int centerX = (p1.X + p2.X) / 2;
            int centerY = (p1.Y + p2.Y) / 2;
            int rx = Math.Abs(p2.X - p1.X) / 2;
            int ry = Math.Abs(p2.Y - p1.Y) / 2;
            int dx = point.X - centerX;
            int dy = point.Y - centerY;
            return (dx * dx) / (rx * rx) + (dy * dy) / (ry * ry) <= 1;
        }
    };
    public class clsFilledEllipse : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            using (Brush myBrush = new SolidBrush(Color))
            {
                myGp.FillEllipse(myBrush, new Rectangle(p1.X, p1.Y, Size.Width, Size.Height));
            }
        }
        public override bool Contains(Point point)
        {
            int centerX = (p1.X + p2.X) / 2;
            int centerY = (p1.Y + p2.Y) / 2;
            int rx = Math.Abs(p2.X - p1.X) / 2;
            int ry = Math.Abs(p2.Y - p1.Y) / 2;
            int dx = point.X - centerX;
            int dy = point.Y - centerY;
            return (dx * dx) / (rx * rx) + (dy * dy) / (ry * ry) <= 1;
        }
    };
    public class clsRect : clsDrawObject
    {
        public override void Draw(Graphics myGp)
        {
            Size.Width = Math.Abs(p2.X - p1.X);
            Size.Height = Math.Abs(p2.Y - p1.Y);
            using (Pen myPen = new Pen(Color, PenWidth))
            {
                myGp.DrawRectangle(myPen, new Rectangle(p1.X, p1.Y, Size.Width, Size.Height));
            }
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
            using (Brush myBrush = new SolidBrush(Color))
            {
                myGp.FillRectangle(myBrush, new Rectangle(p1.X, p1.Y, Size.Width, Size.Height));
            }
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
            using (Pen myPen = new Pen(Color, PenWidth))
            {
                myGp.DrawEllipse(myPen, new Rectangle(p1.X, p1.Y, diameter, diameter));
            }
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
            using (Brush myBrush = new SolidBrush(Color))
            {
                myGp.FillEllipse(myBrush, new Rectangle(p1.X, p1.Y, diameter, diameter));
            }
        }
        public override bool Contains(Point point)
        {
            int centerX = (p1.X + p2.X) / 2;
            int centerY = (p1.Y + p2.Y) / 2;
            int rx = Math.Abs(p2.X - p1.X) / 2;
            int ry = Math.Abs(p2.Y - p1.Y) / 2;
            int dx = point.X - centerX;
            int dy = point.Y - centerY;
            return (dx * dx) / (rx * rx) + (dy * dy) / (ry * ry) <= 1;
        }
    };
}