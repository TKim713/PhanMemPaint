namespace PhanMemPaint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            picColor = new PictureBox();
            btnFill = new Button();
            nupEraserWidth = new NumericUpDown();
            label3 = new Label();
            label2 = new Label();
            nupPenWidth = new NumericUpDown();
            btnColor = new Button();
            btnSelect = new Button();
            btnEraser = new Button();
            panel3 = new Panel();
            btnEllipse = new Button();
            btnFilledPolygon = new Button();
            btnCircle = new Button();
            btnFilledEllipse = new Button();
            btnPolygon = new Button();
            btnArc = new Button();
            btnFilledCircle = new Button();
            btnLine = new Button();
            btnFilledRect = new Button();
            btnRect = new Button();
            panel2 = new Panel();
            label1 = new Label();
            btnPencil = new Button();
            pbMain = new PictureBox();
            colorDialog1 = new ColorDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            groupToolStripMenuItem = new ToolStripMenuItem();
            ungroupToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupEraserWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupPenWidth).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMain).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(picColor);
            panel1.Controls.Add(btnFill);
            panel1.Controls.Add(nupEraserWidth);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nupPenWidth);
            panel1.Controls.Add(btnColor);
            panel1.Controls.Add(btnSelect);
            panel1.Controls.Add(btnEraser);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnPencil);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 435);
            panel1.TabIndex = 0;
            // 
            // picColor
            // 
            picColor.BackColor = Color.Black;
            picColor.Location = new Point(4, 357);
            picColor.Name = "picColor";
            picColor.Size = new Size(60, 19);
            picColor.TabIndex = 2;
            picColor.TabStop = false;
            // 
            // btnFill
            // 
            btnFill.BackColor = Color.Pink;
            btnFill.FlatAppearance.BorderColor = Color.White;
            btnFill.FlatAppearance.BorderSize = 2;
            btnFill.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFill.FlatStyle = FlatStyle.Flat;
            btnFill.Image = Properties.Resources.FillIcon;
            btnFill.Location = new Point(80, 225);
            btnFill.Name = "btnFill";
            btnFill.Size = new Size(60, 60);
            btnFill.TabIndex = 14;
            btnFill.UseVisualStyleBackColor = false;
            btnFill.Click += btnFill_Click;
            // 
            // nupEraserWidth
            // 
            nupEraserWidth.Location = new Point(71, 353);
            nupEraserWidth.Name = "nupEraserWidth";
            nupEraserWidth.Size = new Size(60, 23);
            nupEraserWidth.TabIndex = 13;
            nupEraserWidth.Value = new decimal(new int[] { 50, 0, 0, 0 });
            nupEraserWidth.ValueChanged += nupEraserWidth_ValueChanged;
            nupEraserWidth.Enter += nupEraserWidth_Enter;
            nupEraserWidth.Leave += nupEraserWidth_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 335);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 12;
            label3.Text = "Eraser Width";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 291);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Pen Width";
            // 
            // nupPenWidth
            // 
            nupPenWidth.Location = new Point(71, 309);
            nupPenWidth.Name = "nupPenWidth";
            nupPenWidth.Size = new Size(60, 23);
            nupPenWidth.TabIndex = 2;
            nupPenWidth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            nupPenWidth.ValueChanged += nupPenWidth_ValueChanged;
            nupPenWidth.Leave += nupPenWidth_Leave;
            nupPenWidth.Enter += nupPenWidth_Enter;
            // 
            // btnColor
            // 
            btnColor.BackColor = Color.Pink;
            btnColor.FlatAppearance.BorderColor = Color.White;
            btnColor.FlatAppearance.BorderSize = 2;
            btnColor.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnColor.FlatStyle = FlatStyle.Flat;
            btnColor.Image = Properties.Resources.ColorPalletteIcon;
            btnColor.Location = new Point(4, 291);
            btnColor.Name = "btnColor";
            btnColor.Size = new Size(60, 60);
            btnColor.TabIndex = 11;
            btnColor.UseVisualStyleBackColor = false;
            btnColor.Click += btnColor_Click;
            btnColor.MouseLeave += btnColor_MouseLeave;
            btnColor.MouseHover += btnColor_MouseHover;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = Color.Pink;
            btnSelect.FlatAppearance.BorderColor = Color.White;
            btnSelect.FlatAppearance.BorderSize = 2;
            btnSelect.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Image = Properties.Resources.MouseCursorIcon;
            btnSelect.Location = new Point(4, 225);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(60, 60);
            btnSelect.TabIndex = 10;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            btnSelect.MouseLeave += btnSelect_MouseLeave;
            btnSelect.MouseHover += btnSelect_MouseHover;
            // 
            // btnEraser
            // 
            btnEraser.BackColor = Color.Pink;
            btnEraser.FlatAppearance.BorderColor = Color.White;
            btnEraser.FlatAppearance.BorderSize = 2;
            btnEraser.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnEraser.FlatStyle = FlatStyle.Flat;
            btnEraser.Image = (Image)resources.GetObject("btnEraser.Image");
            btnEraser.Location = new Point(80, 159);
            btnEraser.Name = "btnEraser";
            btnEraser.Size = new Size(60, 60);
            btnEraser.TabIndex = 9;
            btnEraser.UseVisualStyleBackColor = false;
            btnEraser.Click += btnEraser_Click;
            btnEraser.MouseLeave += btnEraser_MouseLeave;
            btnEraser.MouseHover += btnEraser_MouseHover;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnEllipse);
            panel3.Controls.Add(btnFilledPolygon);
            panel3.Controls.Add(btnCircle);
            panel3.Controls.Add(btnFilledEllipse);
            panel3.Controls.Add(btnPolygon);
            panel3.Controls.Add(btnArc);
            panel3.Controls.Add(btnFilledCircle);
            panel3.Controls.Add(btnLine);
            panel3.Controls.Add(btnFilledRect);
            panel3.Controls.Add(btnRect);
            panel3.Location = new Point(3, 43);
            panel3.Name = "panel3";
            panel3.Size = new Size(137, 110);
            panel3.TabIndex = 8;
            // 
            // btnEllipse
            // 
            btnEllipse.FlatAppearance.BorderSize = 0;
            btnEllipse.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnEllipse.FlatStyle = FlatStyle.Flat;
            btnEllipse.Image = Properties.Resources.EllipseIcon;
            btnEllipse.Location = new Point(55, 5);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(28, 28);
            btnEllipse.TabIndex = 1;
            btnEllipse.UseVisualStyleBackColor = true;
            btnEllipse.Click += btnEllipse_Click;
            btnEllipse.MouseLeave += btnEllipse_MouseLeave;
            btnEllipse.MouseHover += btnEllipse_MouseHover;
            // 
            // btnFilledPolygon
            // 
            btnFilledPolygon.FlatAppearance.BorderSize = 0;
            btnFilledPolygon.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFilledPolygon.FlatStyle = FlatStyle.Flat;
            btnFilledPolygon.Image = Properties.Resources.FilledPolygonIcon;
            btnFilledPolygon.Location = new Point(89, 73);
            btnFilledPolygon.Name = "btnFilledPolygon";
            btnFilledPolygon.Size = new Size(28, 28);
            btnFilledPolygon.TabIndex = 7;
            btnFilledPolygon.UseVisualStyleBackColor = true;
            btnFilledPolygon.MouseLeave += btnFilledPolygon_MouseLeave;
            btnFilledPolygon.MouseHover += btnFilledPolygon_MouseHover;
            // 
            // btnCircle
            // 
            btnCircle.FlatAppearance.BorderSize = 0;
            btnCircle.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnCircle.FlatStyle = FlatStyle.Flat;
            btnCircle.Image = Properties.Resources.CircleIcon;
            btnCircle.Location = new Point(68, 39);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(28, 28);
            btnCircle.TabIndex = 4;
            btnCircle.UseVisualStyleBackColor = true;
            btnCircle.Click += btnCircle_Click;
            btnCircle.MouseLeave += btnCircle_MouseLeave;
            btnCircle.MouseHover += btnCircle_MouseHover;
            // 
            // btnFilledEllipse
            // 
            btnFilledEllipse.FlatAppearance.BorderSize = 0;
            btnFilledEllipse.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFilledEllipse.FlatStyle = FlatStyle.Flat;
            btnFilledEllipse.Image = Properties.Resources.FilledEllipseIcon;
            btnFilledEllipse.Location = new Point(89, 5);
            btnFilledEllipse.Name = "btnFilledEllipse";
            btnFilledEllipse.Size = new Size(28, 28);
            btnFilledEllipse.TabIndex = 1;
            btnFilledEllipse.UseVisualStyleBackColor = true;
            btnFilledEllipse.Click += btnFilledEllipse_Click;
            btnFilledEllipse.MouseLeave += btnFilledEllipse_MouseLeave;
            btnFilledEllipse.MouseHover += btnFilledEllipse_MouseHover;
            // 
            // btnPolygon
            // 
            btnPolygon.FlatAppearance.BorderSize = 0;
            btnPolygon.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnPolygon.FlatStyle = FlatStyle.Flat;
            btnPolygon.Image = Properties.Resources.PolygonIcon;
            btnPolygon.Location = new Point(55, 73);
            btnPolygon.Name = "btnPolygon";
            btnPolygon.Size = new Size(28, 28);
            btnPolygon.TabIndex = 6;
            btnPolygon.UseVisualStyleBackColor = true;
            btnPolygon.MouseLeave += btnPolygon_MouseLeave;
            btnPolygon.MouseHover += btnPolygon_MouseHover;
            // 
            // btnArc
            // 
            btnArc.FlatAppearance.BorderSize = 0;
            btnArc.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnArc.FlatStyle = FlatStyle.Flat;
            btnArc.Image = Properties.Resources.ArcIcon;
            btnArc.Location = new Point(21, 73);
            btnArc.Name = "btnArc";
            btnArc.Size = new Size(28, 28);
            btnArc.TabIndex = 6;
            btnArc.UseVisualStyleBackColor = true;
            btnArc.Click += btnArc_Click;
            btnArc.MouseLeave += btnArc_MouseLeave;
            btnArc.MouseHover += btnArc_MouseHover;
            // 
            // btnFilledCircle
            // 
            btnFilledCircle.FlatAppearance.BorderSize = 0;
            btnFilledCircle.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFilledCircle.FlatStyle = FlatStyle.Flat;
            btnFilledCircle.Image = Properties.Resources.FilledCircleIcon;
            btnFilledCircle.Location = new Point(102, 39);
            btnFilledCircle.Name = "btnFilledCircle";
            btnFilledCircle.Size = new Size(28, 28);
            btnFilledCircle.TabIndex = 5;
            btnFilledCircle.UseVisualStyleBackColor = true;
            btnFilledCircle.Click += btnFilledCircle_Click;
            btnFilledCircle.MouseLeave += btnFilledCircle_MouseLeave;
            btnFilledCircle.MouseHover += btnFilledCircle_MouseHover;
            // 
            // btnLine
            // 
            btnLine.FlatAppearance.BorderSize = 0;
            btnLine.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnLine.FlatStyle = FlatStyle.Flat;
            btnLine.Image = Properties.Resources.LineIcon;
            btnLine.Location = new Point(21, 5);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(28, 28);
            btnLine.TabIndex = 1;
            btnLine.UseVisualStyleBackColor = false;
            btnLine.Click += btnLine_Click;
            btnLine.MouseLeave += btnLine_MouseLeave;
            btnLine.MouseHover += btnLine_MouseHover;
            // 
            // btnFilledRect
            // 
            btnFilledRect.FlatAppearance.BorderSize = 0;
            btnFilledRect.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFilledRect.FlatStyle = FlatStyle.Flat;
            btnFilledRect.Image = Properties.Resources.FilledRectIcon;
            btnFilledRect.Location = new Point(37, 39);
            btnFilledRect.Name = "btnFilledRect";
            btnFilledRect.Size = new Size(28, 28);
            btnFilledRect.TabIndex = 0;
            btnFilledRect.UseVisualStyleBackColor = false;
            btnFilledRect.Click += btnFilledRect_Click;
            btnFilledRect.MouseLeave += btnFilledRect_MouseLeave;
            btnFilledRect.MouseHover += btnFilledRect_MouseHover;
            // 
            // btnRect
            // 
            btnRect.FlatAppearance.BorderSize = 0;
            btnRect.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnRect.FlatStyle = FlatStyle.Flat;
            btnRect.Image = Properties.Resources.RectIcon;
            btnRect.Location = new Point(3, 39);
            btnRect.Name = "btnRect";
            btnRect.Size = new Size(28, 28);
            btnRect.TabIndex = 1;
            btnRect.UseVisualStyleBackColor = false;
            btnRect.Click += btnRect_Click;
            btnRect.MouseLeave += btnRect_MouseLeave;
            btnRect.MouseHover += btnRect_MouseHover;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleVioletRed;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(137, 39);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(37, 12);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 2;
            label1.Text = "Shape";
            // 
            // btnPencil
            // 
            btnPencil.BackColor = Color.Pink;
            btnPencil.FlatAppearance.BorderColor = Color.White;
            btnPencil.FlatAppearance.BorderSize = 2;
            btnPencil.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnPencil.FlatStyle = FlatStyle.Flat;
            btnPencil.Image = Properties.Resources.PencilIcon;
            btnPencil.Location = new Point(4, 159);
            btnPencil.Name = "btnPencil";
            btnPencil.Size = new Size(60, 60);
            btnPencil.TabIndex = 3;
            btnPencil.UseVisualStyleBackColor = false;
            btnPencil.Click += btnPencil_Click;
            btnPencil.MouseLeave += btnPencil_MouseLeave;
            btnPencil.MouseHover += btnPencil_MouseHover;
            // 
            // pbMain
            // 
            pbMain.BackColor = Color.White;
            pbMain.Location = new Point(161, 12);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(583, 435);
            pbMain.TabIndex = 1;
            pbMain.TabStop = false;
            pbMain.Paint += pbMain_Paint;
            pbMain.MouseClick += pbMain_MouseClick;
            pbMain.MouseDown += pbMain_MouseDown;
            pbMain.MouseHover += pbMain_MouseHover;
            pbMain.MouseMove += pbMain_MouseMove;
            pbMain.MouseUp += pbMain_MouseUp;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { groupToolStripMenuItem, ungroupToolStripMenuItem, deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(122, 70);
            // 
            // groupToolStripMenuItem
            // 
            groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            groupToolStripMenuItem.Size = new Size(121, 22);
            groupToolStripMenuItem.Text = "Group";
            // 
            // ungroupToolStripMenuItem
            // 
            ungroupToolStripMenuItem.Name = "ungroupToolStripMenuItem";
            ungroupToolStripMenuItem.Size = new Size(121, 22);
            ungroupToolStripMenuItem.Text = "Ungroup";
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(121, 22);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(756, 459);
            Controls.Add(pbMain);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupEraserWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupPenWidth).EndInit();
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbMain).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pbMain;
        private Panel panel3;
        private Button btnEllipse;
        private Button btnFilledPolygon;
        private Button btnCircle;
        private Button btnFilledEllipse;
        private Button btnPolygon;
        private Button btnArc;
        private Button btnFilledCircle;
        private Button btnLine;
        private Button btnFilledRect;
        private Button btnPencil;
        private Button btnRect;
        private Button btnEraser;
        private Button btnSelect;
        private Button btnColor;
        private ColorDialog colorDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem groupToolStripMenuItem;
        private ToolStripMenuItem ungroupToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private Label label2;
        private NumericUpDown nupPenWidth;
        private NumericUpDown nupEraserWidth;
        private Label label3;
        private Button btnFill;
        private PictureBox picColor;
    }
}