namespace Orange_Corp
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
            pb_box = new PictureBox();
            clear_btn = new Button();
            back_btn = new Button();
            save_btn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            redo_btn = new Button();
            load_file_btn = new Button();
            openFileDialog1 = new OpenFileDialog();
            comboBox1 = new ComboBox();
            openFileDialog2 = new OpenFileDialog();
            triangle_btn = new Button();
            square_btn = new Button();
            imageList1 = new ImageList(components);
            circle_btn = new Button();
            rectangle_btn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            fill_bgrd_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_box).BeginInit();
            SuspendLayout();
            // 
            // pb_box
            // 
            pb_box.BackColor = Color.AntiqueWhite;
            pb_box.BorderStyle = BorderStyle.Fixed3D;
            pb_box.Cursor = Cursors.Cross;
            pb_box.Location = new Point(12, 102);
            pb_box.Margin = new Padding(3, 1, 3, 1);
            pb_box.Name = "pb_box";
            pb_box.Size = new Size(1657, 613);
            pb_box.TabIndex = 0;
            pb_box.TabStop = false;
            pb_box.Click += pb_box_Click;
            pb_box.Paint += picture_paint;
            // 
            // clear_btn
            // 
            clear_btn.Image = (Image)resources.GetObject("clear_btn.Image");
            clear_btn.Location = new Point(809, 60);
            clear_btn.Margin = new Padding(3, 1, 3, 1);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(35, 35);
            clear_btn.TabIndex = 2;
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Image = (Image)resources.GetObject("back_btn.Image");
            back_btn.Location = new Point(579, 60);
            back_btn.Margin = new Padding(3, 1, 3, 1);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(35, 35);
            back_btn.TabIndex = 3;
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // save_btn
            // 
            save_btn.Image = (Image)resources.GetObject("save_btn.Image");
            save_btn.Location = new Point(744, 60);
            save_btn.Margin = new Padding(3, 1, 3, 1);
            save_btn.Name = "save_btn";
            save_btn.RightToLeft = RightToLeft.No;
            save_btn.Size = new Size(39, 35);
            save_btn.TabIndex = 9;
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "image";
            saveFileDialog1.FileName = "syn";
            saveFileDialog1.Filter = "Shape YrkeshogskolaN|*.syn|Alla filer|*.*";
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // redo_btn
            // 
            redo_btn.Image = (Image)resources.GetObject("redo_btn.Image");
            redo_btn.Location = new Point(630, 60);
            redo_btn.Margin = new Padding(3, 1, 3, 1);
            redo_btn.Name = "redo_btn";
            redo_btn.Size = new Size(35, 35);
            redo_btn.TabIndex = 10;
            redo_btn.UseVisualStyleBackColor = true;
            redo_btn.Click += redo_btn_Click;
            // 
            // load_file_btn
            // 
            load_file_btn.Image = (Image)resources.GetObject("load_file_btn.Image");
            load_file_btn.Location = new Point(686, 60);
            load_file_btn.Margin = new Padding(3, 1, 3, 1);
            load_file_btn.Name = "load_file_btn";
            load_file_btn.Size = new Size(35, 35);
            load_file_btn.TabIndex = 11;
            load_file_btn.UseVisualStyleBackColor = true;
            load_file_btn.Click += load_file_btn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Red", "Blue", "Green", "Yellow", "Orange", "Black", "Purple", "Pink", "White" });
            comboBox1.Location = new Point(331, 68);
            comboBox1.Margin = new Padding(3, 1, 3, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(174, 27);
            comboBox1.TabIndex = 13;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog2";
            // 
            // triangle_btn
            // 
            triangle_btn.AutoSize = true;
            triangle_btn.Cursor = Cursors.Hand;
            triangle_btn.FlatAppearance.BorderColor = Color.Black;
            triangle_btn.FlatAppearance.BorderSize = 0;
            triangle_btn.FlatStyle = FlatStyle.Flat;
            triangle_btn.Image = (Image)resources.GetObject("triangle_btn.Image");
            triangle_btn.Location = new Point(157, 62);
            triangle_btn.Name = "triangle_btn";
            triangle_btn.Size = new Size(41, 41);
            triangle_btn.TabIndex = 14;
            triangle_btn.UseVisualStyleBackColor = true;
            triangle_btn.Click += triangle_btn_Click;
            // 
            // square_btn
            // 
            square_btn.FlatAppearance.BorderSize = 0;
            square_btn.FlatStyle = FlatStyle.Flat;
            square_btn.Image = (Image)resources.GetObject("square_btn.Image");
            square_btn.Location = new Point(111, 68);
            square_btn.Name = "square_btn";
            square_btn.Size = new Size(30, 30);
            square_btn.TabIndex = 15;
            square_btn.UseVisualStyleBackColor = true;
            square_btn.Click += square_btn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // circle_btn
            // 
            circle_btn.FlatAppearance.BorderSize = 0;
            circle_btn.FlatStyle = FlatStyle.Flat;
            circle_btn.Image = (Image)resources.GetObject("circle_btn.Image");
            circle_btn.Location = new Point(60, 68);
            circle_btn.Name = "circle_btn";
            circle_btn.Size = new Size(30, 30);
            circle_btn.TabIndex = 17;
            circle_btn.UseVisualStyleBackColor = true;
            circle_btn.Click += circle_btn_Click;
            // 
            // rectangle_btn
            // 
            rectangle_btn.FlatAppearance.BorderSize = 0;
            rectangle_btn.FlatStyle = FlatStyle.Flat;
            rectangle_btn.Image = (Image)resources.GetObject("rectangle_btn.Image");
            rectangle_btn.Location = new Point(12, 68);
            rectangle_btn.Name = "rectangle_btn";
            rectangle_btn.Size = new Size(30, 30);
            rectangle_btn.TabIndex = 18;
            rectangle_btn.UseVisualStyleBackColor = true;
            rectangle_btn.Click += rectangle_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tempus Sans ITC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 18);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 19;
            label1.Text = "Shapes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tempus Sans ITC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(379, 18);
            label2.Name = "label2";
            label2.Size = new Size(80, 28);
            label2.TabIndex = 20;
            label2.Text = "Colors";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tempus Sans ITC", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(686, 18);
            label3.Name = "label3";
            label3.Size = new Size(92, 28);
            label3.TabIndex = 21;
            label3.Text = "Settings";
            // 
            // fill_bgrd_btn
            // 
            fill_bgrd_btn.FlatAppearance.BorderSize = 0;
            fill_bgrd_btn.FlatStyle = FlatStyle.Flat;
            fill_bgrd_btn.Image = (Image)resources.GetObject("fill_bgrd_btn.Image");
            fill_bgrd_btn.Location = new Point(218, 68);
            fill_bgrd_btn.Name = "fill_bgrd_btn";
            fill_bgrd_btn.Size = new Size(30, 30);
            fill_bgrd_btn.TabIndex = 22;
            fill_bgrd_btn.UseVisualStyleBackColor = true;
            fill_bgrd_btn.Click += fill_bgrd_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(1678, 725);
            Controls.Add(fill_bgrd_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rectangle_btn);
            Controls.Add(circle_btn);
            Controls.Add(square_btn);
            Controls.Add(triangle_btn);
            Controls.Add(comboBox1);
            Controls.Add(load_file_btn);
            Controls.Add(redo_btn);
            Controls.Add(save_btn);
            Controls.Add(back_btn);
            Controls.Add(clear_btn);
            Controls.Add(pb_box);
            Font = new Font("Tempus Sans ITC", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 1, 3, 1);
            Name = "Form1";
            Text = "NikosPaint2.0";
            ((System.ComponentModel.ISupportInitialize)pb_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button clear_btn;
        private Button back_btn;
        private Button save_btn;
        private SaveFileDialog saveFileDialog1;
        private Button redo_btn;
        private Button load_file_btn;
        private OpenFileDialog openFileDialog1;
        private ComboBox comboBox1;
        private OpenFileDialog openFileDialog2;
        private Button triangle_btn;
        private Button square_btn;
        private ImageList imageList1;
        private Button circle_btn;
        private Button rectangle_btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button fill_bgrd_btn;

        #endregion

        //private PictureBox pb_box;
        //private Button circle_btn;
        //private bool drawCircle = false;

    }
}
