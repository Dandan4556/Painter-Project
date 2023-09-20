namespace Painter
{
    partial class Painter
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
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Btn_Square = new System.Windows.Forms.Button();
            this.Btn_Circle = new System.Windows.Forms.Button();
            this.TextBox_DYD = new System.Windows.Forms.TextBox();
            this.TextBox_WidthD = new System.Windows.Forms.TextBox();
            this.NumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Btn_Line = new System.Windows.Forms.Button();
            this.Btn_Rectangle = new System.Windows.Forms.Button();
            this.Btn_Ellipse = new System.Windows.Forms.Button();
            this.Btn_Eraser = new System.Windows.Forms.Button();
            this.Btn_Pencil = new System.Windows.Forms.Button();
            this.Btn_Fill = new System.Windows.Forms.Button();
            this.Btn_Color = new System.Windows.Forms.Button();
            this.Pic_Color = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Btn_Cats_Image = new System.Windows.Forms.Button();
            this.Btn_Background = new System.Windows.Forms.Button();
            this.TextBox_CreatedBy = new System.Windows.Forms.TextBox();
            this.Btn_Load_image = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).BeginInit();
            this.Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Silver;
            this.Panel1.Controls.Add(this.Btn_Square);
            this.Panel1.Controls.Add(this.Btn_Circle);
            this.Panel1.Controls.Add(this.TextBox_DYD);
            this.Panel1.Controls.Add(this.TextBox_WidthD);
            this.Panel1.Controls.Add(this.NumericUpDown1);
            this.Panel1.Controls.Add(this.Btn_Line);
            this.Panel1.Controls.Add(this.Btn_Rectangle);
            this.Panel1.Controls.Add(this.Btn_Ellipse);
            this.Panel1.Controls.Add(this.Btn_Eraser);
            this.Panel1.Controls.Add(this.Btn_Pencil);
            this.Panel1.Controls.Add(this.Btn_Fill);
            this.Panel1.Controls.Add(this.Btn_Color);
            this.Panel1.Controls.Add(this.Pic_Color);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1278, 150);
            this.Panel1.TabIndex = 0;
            // 
            // Btn_Square
            // 
            this.Btn_Square.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Square.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Square.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Square.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Square.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Square.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Square.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Btn_Square.ForeColor = System.Drawing.Color.White;
            this.Btn_Square.Location = new System.Drawing.Point(997, 85);
            this.Btn_Square.Name = "Btn_Square";
            this.Btn_Square.Size = new System.Drawing.Size(100, 55);
            this.Btn_Square.TabIndex = 12;
            this.Btn_Square.Text = "Square";
            this.Btn_Square.UseVisualStyleBackColor = true;
            this.Btn_Square.Click += new System.EventHandler(this.Btn_Square_Click);
            // 
            // Btn_Circle
            // 
            this.Btn_Circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Circle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Btn_Circle.ForeColor = System.Drawing.Color.White;
            this.Btn_Circle.Location = new System.Drawing.Point(997, 26);
            this.Btn_Circle.Name = "Btn_Circle";
            this.Btn_Circle.Size = new System.Drawing.Size(100, 58);
            this.Btn_Circle.TabIndex = 11;
            this.Btn_Circle.Text = "Circle";
            this.Btn_Circle.UseVisualStyleBackColor = true;
            this.Btn_Circle.Click += new System.EventHandler(this.Btn_Circle_Click);
            // 
            // TextBox_DYD
            // 
            this.TextBox_DYD.BackColor = System.Drawing.Color.Silver;
            this.TextBox_DYD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_DYD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.TextBox_DYD.Location = new System.Drawing.Point(23, 12);
            this.TextBox_DYD.Multiline = true;
            this.TextBox_DYD.Name = "TextBox_DYD";
            this.TextBox_DYD.Size = new System.Drawing.Size(168, 116);
            this.TextBox_DYD.TabIndex = 10;
            this.TextBox_DYD.Text = "Let\'s begin to \r\ndraw your dream!\r\n\r\n\r\n\r\n\r\n";
            this.TextBox_DYD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBox_WidthD
            // 
            this.TextBox_WidthD.BackColor = System.Drawing.Color.Silver;
            this.TextBox_WidthD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_WidthD.Location = new System.Drawing.Point(1112, 50);
            this.TextBox_WidthD.Multiline = true;
            this.TextBox_WidthD.Name = "TextBox_WidthD";
            this.TextBox_WidthD.Size = new System.Drawing.Size(100, 43);
            this.TextBox_WidthD.TabIndex = 9;
            this.TextBox_WidthD.Text = "Width\r\nof line";
            this.TextBox_WidthD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumericUpDown1
            // 
            this.NumericUpDown1.BackColor = System.Drawing.SystemColors.Window;
            this.NumericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NumericUpDown1.ForeColor = System.Drawing.Color.Black;
            this.NumericUpDown1.Location = new System.Drawing.Point(1112, 92);
            this.NumericUpDown1.Name = "NumericUpDown1";
            this.NumericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.NumericUpDown1.TabIndex = 8;
            this.NumericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Btn_Line
            // 
            this.Btn_Line.BackgroundImage = global::Painter.Properties.Resources.line;
            this.Btn_Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Line.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Btn_Line.ForeColor = System.Drawing.Color.White;
            this.Btn_Line.Location = new System.Drawing.Point(891, 26);
            this.Btn_Line.Name = "Btn_Line";
            this.Btn_Line.Size = new System.Drawing.Size(100, 114);
            this.Btn_Line.TabIndex = 7;
            this.Btn_Line.Text = "Line";
            this.Btn_Line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Line.UseVisualStyleBackColor = true;
            this.Btn_Line.Click += new System.EventHandler(this.Btn_Line_Click);
            // 
            // Btn_Rectangle
            // 
            this.Btn_Rectangle.BackgroundImage = global::Painter.Properties.Resources.rectangle;
            this.Btn_Rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Rectangle.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Btn_Rectangle.ForeColor = System.Drawing.Color.White;
            this.Btn_Rectangle.Location = new System.Drawing.Point(785, 26);
            this.Btn_Rectangle.Name = "Btn_Rectangle";
            this.Btn_Rectangle.Size = new System.Drawing.Size(100, 114);
            this.Btn_Rectangle.TabIndex = 6;
            this.Btn_Rectangle.Text = "Rectangle";
            this.Btn_Rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Rectangle.UseVisualStyleBackColor = true;
            this.Btn_Rectangle.Click += new System.EventHandler(this.Btn_Rectangle_Click);
            // 
            // Btn_Ellipse
            // 
            this.Btn_Ellipse.BackgroundImage = global::Painter.Properties.Resources.circle;
            this.Btn_Ellipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Ellipse.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ellipse.ForeColor = System.Drawing.Color.White;
            this.Btn_Ellipse.Location = new System.Drawing.Point(679, 26);
            this.Btn_Ellipse.Name = "Btn_Ellipse";
            this.Btn_Ellipse.Size = new System.Drawing.Size(100, 114);
            this.Btn_Ellipse.TabIndex = 5;
            this.Btn_Ellipse.Text = "Ellipse";
            this.Btn_Ellipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Ellipse.UseVisualStyleBackColor = true;
            this.Btn_Ellipse.Click += new System.EventHandler(this.Btn_Ellipse_Click);
            // 
            // Btn_Eraser
            // 
            this.Btn_Eraser.BackgroundImage = global::Painter.Properties.Resources.eraser;
            this.Btn_Eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eraser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Eraser.ForeColor = System.Drawing.Color.White;
            this.Btn_Eraser.Location = new System.Drawing.Point(573, 26);
            this.Btn_Eraser.Name = "Btn_Eraser";
            this.Btn_Eraser.Size = new System.Drawing.Size(100, 114);
            this.Btn_Eraser.TabIndex = 4;
            this.Btn_Eraser.Text = "Eraser";
            this.Btn_Eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Eraser.UseVisualStyleBackColor = true;
            this.Btn_Eraser.Click += new System.EventHandler(this.Btn_Eraser_Click);
            // 
            // Btn_Pencil
            // 
            this.Btn_Pencil.BackgroundImage = global::Painter.Properties.Resources.pencil;
            this.Btn_Pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Pencil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Pencil.ForeColor = System.Drawing.Color.White;
            this.Btn_Pencil.Location = new System.Drawing.Point(467, 26);
            this.Btn_Pencil.Name = "Btn_Pencil";
            this.Btn_Pencil.Size = new System.Drawing.Size(100, 114);
            this.Btn_Pencil.TabIndex = 3;
            this.Btn_Pencil.Text = "Pencil";
            this.Btn_Pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Pencil.UseVisualStyleBackColor = true;
            this.Btn_Pencil.Click += new System.EventHandler(this.Btn_Pencil_Click);
            // 
            // Btn_Fill
            // 
            this.Btn_Fill.BackgroundImage = global::Painter.Properties.Resources.bucket;
            this.Btn_Fill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Fill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Fill.ForeColor = System.Drawing.Color.White;
            this.Btn_Fill.Location = new System.Drawing.Point(361, 26);
            this.Btn_Fill.Name = "Btn_Fill";
            this.Btn_Fill.Size = new System.Drawing.Size(100, 114);
            this.Btn_Fill.TabIndex = 2;
            this.Btn_Fill.Text = "Fill";
            this.Btn_Fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Fill.UseVisualStyleBackColor = true;
            this.Btn_Fill.Click += new System.EventHandler(this.Btn_Fill_Click);
            // 
            // Btn_Color
            // 
            this.Btn_Color.BackgroundImage = global::Painter.Properties.Resources.colors;
            this.Btn_Color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Color.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Color.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Color.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Color.ForeColor = System.Drawing.Color.White;
            this.Btn_Color.Location = new System.Drawing.Point(255, 26);
            this.Btn_Color.Name = "Btn_Color";
            this.Btn_Color.Size = new System.Drawing.Size(100, 114);
            this.Btn_Color.TabIndex = 1;
            this.Btn_Color.Text = "Color";
            this.Btn_Color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Color.UseVisualStyleBackColor = true;
            this.Btn_Color.Click += new System.EventHandler(this.Btn_Color_Click);
            // 
            // Pic_Color
            // 
            this.Pic_Color.BackColor = System.Drawing.Color.White;
            this.Pic_Color.Location = new System.Drawing.Point(210, 67);
            this.Pic_Color.Name = "Pic_Color";
            this.Pic_Color.Size = new System.Drawing.Size(39, 39);
            this.Pic_Color.TabIndex = 0;
            this.Pic_Color.UseVisualStyleBackColor = false;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.Controls.Add(this.Btn_Cats_Image);
            this.Panel2.Controls.Add(this.Btn_Background);
            this.Panel2.Controls.Add(this.TextBox_CreatedBy);
            this.Panel2.Controls.Add(this.Btn_Load_image);
            this.Panel2.Controls.Add(this.Btn_Clear);
            this.Panel2.Controls.Add(this.Btn_Save);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 564);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1278, 80);
            this.Panel2.TabIndex = 1;
            // 
            // Btn_Cats_Image
            // 
            this.Btn_Cats_Image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Cats_Image.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Cats_Image.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Btn_Cats_Image.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Cats_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cats_Image.ForeColor = System.Drawing.Color.White;
            this.Btn_Cats_Image.Location = new System.Drawing.Point(964, 3);
            this.Btn_Cats_Image.Name = "Btn_Cats_Image";
            this.Btn_Cats_Image.Size = new System.Drawing.Size(120, 65);
            this.Btn_Cats_Image.TabIndex = 9;
            this.Btn_Cats_Image.Text = "Random\r\nCats";
            this.Btn_Cats_Image.UseVisualStyleBackColor = true;
            this.Btn_Cats_Image.Click += new System.EventHandler(this.Btn_Cats_Image_Click);
            // 
            // Btn_Background
            // 
            this.Btn_Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_Background.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Background.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Background.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.Btn_Background.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Background.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Background.ForeColor = System.Drawing.Color.White;
            this.Btn_Background.Location = new System.Drawing.Point(712, 3);
            this.Btn_Background.Name = "Btn_Background";
            this.Btn_Background.Size = new System.Drawing.Size(120, 65);
            this.Btn_Background.TabIndex = 8;
            this.Btn_Background.Text = "Background Color";
            this.Btn_Background.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Background.UseVisualStyleBackColor = true;
            this.Btn_Background.Click += new System.EventHandler(this.Btn_Background_Click);
            // 
            // TextBox_CreatedBy
            // 
            this.TextBox_CreatedBy.Location = new System.Drawing.Point(23, 32);
            this.TextBox_CreatedBy.Name = "TextBox_CreatedBy";
            this.TextBox_CreatedBy.Size = new System.Drawing.Size(310, 26);
            this.TextBox_CreatedBy.TabIndex = 3;
            this.TextBox_CreatedBy.Text = "Created by : Daniel Ladijinsky & Orel Arussi";
            // 
            // Btn_Load_image
            // 
            this.Btn_Load_image.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Load_image.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Load_image.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Btn_Load_image.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Load_image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Load_image.ForeColor = System.Drawing.Color.White;
            this.Btn_Load_image.Location = new System.Drawing.Point(838, 3);
            this.Btn_Load_image.Name = "Btn_Load_image";
            this.Btn_Load_image.Size = new System.Drawing.Size(120, 65);
            this.Btn_Load_image.TabIndex = 2;
            this.Btn_Load_image.Text = "Load Image";
            this.Btn_Load_image.UseVisualStyleBackColor = true;
            this.Btn_Load_image.Click += new System.EventHandler(this.Btn_Load_image_Click);
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Clear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Btn_Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.Location = new System.Drawing.Point(1090, 3);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(85, 65);
            this.Btn_Clear.TabIndex = 1;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.Btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Save.ForeColor = System.Drawing.Color.White;
            this.Btn_Save.Location = new System.Drawing.Point(1181, 3);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(85, 65);
            this.Btn_Save.TabIndex = 0;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.Location = new System.Drawing.Point(0, 146);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(1278, 720);
            this.Pic.TabIndex = 2;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint_1);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // Painter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 644);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Pic);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Painter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Draw Your Dream";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown1)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button Pic_Color;
        private System.Windows.Forms.Button Btn_Color;
        private System.Windows.Forms.Button Btn_Fill;
        private System.Windows.Forms.Button Btn_Pencil;
        private System.Windows.Forms.Button Btn_Eraser;
        private System.Windows.Forms.Button Btn_Ellipse;
        private System.Windows.Forms.Button Btn_Rectangle;
        private System.Windows.Forms.Button Btn_Line;
        private System.Windows.Forms.Button Btn_Load_image;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.TextBox TextBox_CreatedBy;
        private System.Windows.Forms.Button Btn_Background;
        private System.Windows.Forms.NumericUpDown NumericUpDown1;
        private System.Windows.Forms.TextBox TextBox_WidthD;
        private System.Windows.Forms.TextBox TextBox_DYD;
        private System.Windows.Forms.Button Btn_Cats_Image;
        private System.Windows.Forms.Button Btn_Circle;
        private System.Windows.Forms.Button Btn_Square;
    }
}

