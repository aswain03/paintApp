namespace paintApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.colour_picker = new System.Windows.Forms.PictureBox();
            this.btn_line = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_fill = new System.Windows.Forms.Button();
            this.btn_colour = new System.Windows.Forms.Button();
            this.pic_colour = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btm_clear = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colour_picker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.btm_clear);
            this.panel1.Controls.Add(this.colour_picker);
            this.panel1.Controls.Add(this.btn_line);
            this.panel1.Controls.Add(this.btn_rect);
            this.panel1.Controls.Add(this.btn_ellipse);
            this.panel1.Controls.Add(this.btn_eraser);
            this.panel1.Controls.Add(this.btn_pencil);
            this.panel1.Controls.Add(this.btn_fill);
            this.panel1.Controls.Add(this.btn_colour);
            this.panel1.Controls.Add(this.pic_colour);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 110);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // colour_picker
            // 
            this.colour_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colour_picker.Image = global::paintApp.Properties.Resources.color_palette;
            this.colour_picker.Location = new System.Drawing.Point(0, 3);
            this.colour_picker.Name = "colour_picker";
            this.colour_picker.Size = new System.Drawing.Size(197, 104);
            this.colour_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.colour_picker.TabIndex = 8;
            this.colour_picker.TabStop = false;
            this.colour_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.colour_picker_MouseClick);
            // 
            // btn_line
            // 
            this.btn_line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_line.ForeColor = System.Drawing.Color.White;
            this.btn_line.Image = global::paintApp.Properties.Resources.line;
            this.btn_line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_line.Location = new System.Drawing.Point(691, 18);
            this.btn_line.Name = "btn_line";
            this.btn_line.Size = new System.Drawing.Size(67, 62);
            this.btn_line.TabIndex = 7;
            this.btn_line.Text = "Line";
            this.btn_line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_line.UseVisualStyleBackColor = true;
            this.btn_line.Click += new System.EventHandler(this.btn_line_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::paintApp.Properties.Resources.rectangle;
            this.btn_rect.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rect.Location = new System.Drawing.Point(618, 18);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(67, 62);
            this.btn_rect.TabIndex = 6;
            this.btn_rect.Text = "Rectangle";
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::paintApp.Properties.Resources.circle;
            this.btn_ellipse.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_ellipse.Location = new System.Drawing.Point(545, 18);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(67, 62);
            this.btn_ellipse.TabIndex = 5;
            this.btn_ellipse.Text = "Ellipse";
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_eraser
            // 
            this.btn_eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.ForeColor = System.Drawing.Color.White;
            this.btn_eraser.Image = global::paintApp.Properties.Resources.eraser;
            this.btn_eraser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_eraser.Location = new System.Drawing.Point(472, 18);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(67, 62);
            this.btn_eraser.TabIndex = 4;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = true;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.White;
            this.btn_pencil.Image = global::paintApp.Properties.Resources.pencil;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_pencil.Location = new System.Drawing.Point(399, 18);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(67, 62);
            this.btn_pencil.TabIndex = 3;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_fill
            // 
            this.btn_fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Image = global::paintApp.Properties.Resources.bucket;
            this.btn_fill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_fill.Location = new System.Drawing.Point(326, 18);
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(67, 62);
            this.btn_fill.TabIndex = 2;
            this.btn_fill.Text = "Fill";
            this.btn_fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_fill.UseVisualStyleBackColor = true;
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_colour
            // 
            this.btn_colour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_colour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_colour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_colour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colour.ForeColor = System.Drawing.Color.White;
            this.btn_colour.Image = global::paintApp.Properties.Resources.color;
            this.btn_colour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_colour.Location = new System.Drawing.Point(253, 18);
            this.btn_colour.Name = "btn_colour";
            this.btn_colour.Size = new System.Drawing.Size(67, 62);
            this.btn_colour.TabIndex = 1;
            this.btn_colour.Text = "Colour";
            this.btn_colour.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_colour.UseVisualStyleBackColor = true;
            this.btn_colour.Click += new System.EventHandler(this.btn_colour_Click);
            // 
            // pic_colour
            // 
            this.pic_colour.BackColor = System.Drawing.Color.White;
            this.pic_colour.Location = new System.Drawing.Point(202, 32);
            this.pic_colour.Name = "pic_colour";
            this.pic_colour.Size = new System.Drawing.Size(35, 38);
            this.pic_colour.TabIndex = 0;
            this.pic_colour.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(243, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 104);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 484);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 27);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(899, 511);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btm_clear
            // 
            this.btm_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btm_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btm_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btm_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btm_clear.ForeColor = System.Drawing.Color.White;
            this.btm_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btm_clear.Location = new System.Drawing.Point(789, 55);
            this.btm_clear.Name = "btm_clear";
            this.btm_clear.Size = new System.Drawing.Size(88, 27);
            this.btm_clear.TabIndex = 8;
            this.btm_clear.Text = "Clear";
            this.btm_clear.UseVisualStyleBackColor = true;
            this.btm_clear.Click += new System.EventHandler(this.btm_clear_Click);
            // 
            // btn_save
            // 
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_save.Location = new System.Drawing.Point(789, 18);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(88, 27);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 511);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.colour_picker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_colour;
        private System.Windows.Forms.Button pic_colour;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_line;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_fill;
        private System.Windows.Forms.PictureBox colour_picker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btm_clear;
    }
}

