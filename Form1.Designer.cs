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
            pb_box = new PictureBox();
            clear_btn = new Button();
            back_btn = new Button();
            circle_box = new CheckBox();
            rektangle_box = new CheckBox();
            square_box = new CheckBox();
            triangle_box = new CheckBox();
            save_btn = new Button();
            saveFileDialog1 = new SaveFileDialog();
            redo_btn = new Button();
            load_file_btn = new Button();
            openFileDialog1 = new OpenFileDialog();
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pb_box).BeginInit();
            SuspendLayout();
            // 
            // pb_box
            // 
            pb_box.Location = new Point(460, 29);
            pb_box.Name = "pb_box";
            pb_box.Size = new Size(1393, 853);
            pb_box.TabIndex = 0;
            pb_box.TabStop = false;
            pb_box.Click += pb_box_Click;
            pb_box.Paint += picture_paint;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(71, 797);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(281, 85);
            clear_btn.TabIndex = 2;
            clear_btn.Text = "clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // back_btn
            // 
            back_btn.Location = new Point(71, 699);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(120, 62);
            back_btn.TabIndex = 3;
            back_btn.Text = "back";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // circle_box
            // 
            circle_box.AutoSize = true;
            circle_box.Location = new Point(71, 114);
            circle_box.Name = "circle_box";
            circle_box.Size = new Size(105, 36);
            circle_box.TabIndex = 5;
            circle_box.Text = "Circle";
            circle_box.UseVisualStyleBackColor = true;
            circle_box.CheckedChanged += circle_box_CheckedChanged;
            // 
            // rektangle_box
            // 
            rektangle_box.AutoSize = true;
            rektangle_box.Location = new Point(71, 168);
            rektangle_box.Name = "rektangle_box";
            rektangle_box.Size = new Size(151, 36);
            rektangle_box.TabIndex = 6;
            rektangle_box.Text = "Rektangle";
            rektangle_box.UseVisualStyleBackColor = true;
            rektangle_box.CheckedChanged += rektangle_box_CheckedChanged;
            // 
            // square_box
            // 
            square_box.AutoSize = true;
            square_box.Location = new Point(71, 220);
            square_box.Name = "square_box";
            square_box.Size = new Size(120, 36);
            square_box.TabIndex = 7;
            square_box.Text = "Square";
            square_box.UseVisualStyleBackColor = true;
            square_box.CheckedChanged += square_box_CheckedChanged;
            // 
            // triangle_box
            // 
            triangle_box.AutoSize = true;
            triangle_box.Location = new Point(71, 276);
            triangle_box.Name = "triangle_box";
            triangle_box.Size = new Size(130, 36);
            triangle_box.TabIndex = 8;
            triangle_box.Text = "Triangle";
            triangle_box.UseVisualStyleBackColor = true;
            triangle_box.CheckedChanged += triangle_box_CheckedChanged;
            // 
            // save_btn
            // 
            save_btn.Location = new Point(218, 607);
            save_btn.Name = "save_btn";
            save_btn.RightToLeft = RightToLeft.No;
            save_btn.Size = new Size(127, 60);
            save_btn.TabIndex = 9;
            save_btn.Text = "save";
            save_btn.UseVisualStyleBackColor = true;
            save_btn.Click += save_btn_Click;
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "syn";
            saveFileDialog1.FileName = "syn";
            saveFileDialog1.Filter = "Shape YrkeshogskolaN|*.syn|Alla filer|*.*";
            saveFileDialog1.FileOk += saveFileDialog1_FileOk;
            // 
            // redo_btn
            // 
            redo_btn.Location = new Point(218, 699);
            redo_btn.Name = "redo_btn";
            redo_btn.Size = new Size(134, 62);
            redo_btn.TabIndex = 10;
            redo_btn.Text = "Redo";
            redo_btn.UseVisualStyleBackColor = true;
            redo_btn.Click += redo_btn_Click;
            // 
            // load_file_btn
            // 
            load_file_btn.Location = new Point(71, 607);
            load_file_btn.Name = "load_file_btn";
            load_file_btn.Size = new Size(120, 60);
            load_file_btn.TabIndex = 11;
            load_file_btn.Text = "Load File";
            load_file_btn.UseVisualStyleBackColor = true;
            load_file_btn.Click += load_file_btn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "Red", "Blue", "Green", "Black", "Yellow", "Purple" });
            listBox1.Location = new Point(77, 388);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(252, 36);
            listBox1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Red", "Blue", "Green", "Yellow", "Orange", "Black", "Purple" });
            comboBox1.Location = new Point(81, 439);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(250, 40);
            comboBox1.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1878, 988);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(load_file_btn);
            Controls.Add(redo_btn);
            Controls.Add(save_btn);
            Controls.Add(triangle_box);
            Controls.Add(square_box);
            Controls.Add(rektangle_box);
            Controls.Add(circle_box);
            Controls.Add(back_btn);
            Controls.Add(clear_btn);
            Controls.Add(pb_box);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pb_box).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Button clear_btn;
        private Button back_btn;
        private CheckBox circle_box;
        private CheckBox rektangle_box;
        private CheckBox square_box;
        private CheckBox triangle_box;
        private Button save_btn;
        private SaveFileDialog saveFileDialog1;
        private Button redo_btn;
        private Button load_file_btn;
        private OpenFileDialog openFileDialog1;
        private ListBox listBox1;
        private ComboBox comboBox1;

        #endregion

        //private PictureBox pb_box;
        //private Button circle_btn;
        //private bool drawCircle = false;

    }
}
