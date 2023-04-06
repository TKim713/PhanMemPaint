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
            panel1 = new Panel();
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
            btnNull = new Button();
            btnRect = new Button();
            panel2 = new Panel();
            label1 = new Label();
            pbMain = new PictureBox();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Pink;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 435);
            panel1.TabIndex = 0;
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
            panel3.Controls.Add(btnNull);
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
            btnEllipse.Location = new Point(68, 5);
            btnEllipse.Name = "btnEllipse";
            btnEllipse.Size = new Size(28, 28);
            btnEllipse.TabIndex = 1;
            btnEllipse.UseVisualStyleBackColor = true;
            btnEllipse.MouseLeave += btnEllipse_MouseLeave;
            btnEllipse.MouseHover += btnEllipse_MouseHover;
            btnEllipse.Click += btnEllipse_Click;
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
            btnCircle.MouseLeave += btnCircle_MouseLeave;
            btnCircle.MouseHover += btnCircle_MouseHover;
            btnCircle.Click += btnCircle_Click;
            // 
            // btnFilledEllipse
            // 
            btnFilledEllipse.FlatAppearance.BorderSize = 0;
            btnFilledEllipse.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnFilledEllipse.FlatStyle = FlatStyle.Flat;
            btnFilledEllipse.Image = Properties.Resources.FilledEllipseIcon;
            btnFilledEllipse.Location = new Point(102, 5);
            btnFilledEllipse.Name = "btnFilledEllipse";
            btnFilledEllipse.Size = new Size(28, 28);
            btnFilledEllipse.TabIndex = 1;
            btnFilledEllipse.UseVisualStyleBackColor = true;
            btnFilledEllipse.MouseLeave += btnFilledEllipse_MouseLeave;
            btnFilledEllipse.MouseHover += btnFilledEllipse_MouseHover;
            btnFilledEllipse.Click += btnFilledEllipse_Click;
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
            btnArc.MouseLeave += btnArc_MouseLeave;
            btnArc.MouseHover += btnArc_MouseHover;
            btnArc.Click += btnArc_Click;
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
            btnFilledCircle.MouseLeave += btnFilledCircle_MouseLeave;
            btnFilledCircle.MouseHover += btnFilledCircle_MouseHover;
            btnFilledCircle.Click += btnFilledCircle_Click;
            // 
            // btnLine
            // 
            btnLine.FlatAppearance.BorderSize = 0;
            btnLine.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnLine.FlatStyle = FlatStyle.Flat;
            btnLine.Image = Properties.Resources.LineIcon;
            btnLine.Location = new Point(37, 5);
            btnLine.Name = "btnLine";
            btnLine.Size = new Size(28, 28);
            btnLine.TabIndex = 1;
            btnLine.UseVisualStyleBackColor = false;
            btnLine.MouseLeave += btnLine_MouseLeave;
            btnLine.MouseHover += btnLine_MouseHover;
            btnLine.Click += btnLine_Click;
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
            btnFilledRect.MouseLeave += btnFilledRect_MouseLeave;
            btnFilledRect.MouseHover += btnFilledRect_MouseHover;
            btnFilledRect.Click += btnFilledRect_Click;
            // 
            // btnNull
            // 
            btnNull.FlatAppearance.BorderSize = 0;
            btnNull.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btnNull.FlatStyle = FlatStyle.Flat;
            // btnNull.Image = Properties.Resources.NullIcon;
            btnNull.Location = new Point(3, 5);
            btnNull.Name = "btnNull";
            btnNull.Size = new Size(28, 28);
            btnNull.TabIndex = 3;
            btnNull.UseVisualStyleBackColor = true;
            btnNull.MouseLeave += btnNull_MouseLeave;
            btnNull.MouseHover += btnNull_MouseHover;
            btnNull.Click += btnNull_Click;
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
            btnRect.MouseLeave += btnRect_MouseLeave;
            btnRect.MouseHover += btnRect_MouseHover;
            btnRect.Click += btnRect_Click;
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
            label1.Location = new Point(30, 12);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 2;
            label1.Text = "Shape";
            // 
            // pbMain
            // 
            pbMain.BackColor = Color.White;
            pbMain.Location = new Point(161, 12);
            pbMain.Name = "pbMain";
            pbMain.Size = new Size(583, 435);
            pbMain.TabIndex = 1;
            pbMain.Paint += pbMain_Paint;
            pbMain.MouseDown += pbMain_MouseDown;
            pbMain.MouseMove += pbMain_MouseMove;
            pbMain.MouseUp += pbMain_MouseUp;
            pbMain.MouseHover += pbMain_MouseHover;
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
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Button btnNull;
        private Button btnRect;
    }
}