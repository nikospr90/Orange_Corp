using Newtonsoft.Json;

namespace Orange_Corp
{
    public partial class Form1 : Form
    {
        private PictureBox pb_box;
        private bool drawCircle = false;
        private bool drawRektangle = false;
        private bool drawSquare = false;
        private bool drawTriangle = false;
        private List<Shapes> shapes = new();
        private Stack<Shapes> popStack = new();
        private Stack<Shapes> redoStack = new();
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.InitialDirectory =
                 Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }
        private void rektangle_btn_Click(object sender, EventArgs e)
        {
            drawRektangle = true;
        }
        private void pb_box_Click(object sender, EventArgs e)
        {
            Colors farg = new();
            var color = farg.colors[(string)comboBox1.SelectedItem];

            var mouse = (MouseEventArgs)e;
            if (drawCircle)
            {
                var circle = new Circle()
                {
                    Color = color,
                    Radius = 100,
                    Center = mouse.Location
                };
                popStack.Push(circle);
            }
            else if (drawRektangle)
            {
                var rekt = new Rektangle()
                {
                    Height = 200,
                    Width = 100,
                    Color = color,
                    Center = mouse.Location
                };
                popStack.Push(rekt);
            }
            else if (drawSquare)
            {
                var sqr = new Square()
                {
                    Side = 100,
                    Color = color,
                    Center = mouse.Location
                };
                popStack.Push(sqr);
            }
            else if (drawTriangle)
            {
                int x = mouse.X;
                int y = mouse.Y;
                var tri = new Triangle()
                {
                    Points = new Point[]
                    {new(x - 100, y),
                     new(x + 100, y),
                     new(x, y -200)
                    },
                    Color = color,
                    Center = mouse.Location
                };
                popStack.Push(tri);
            }
            pb_box.Refresh();
        }

        private void picture_paint(object sender, PaintEventArgs e)
        {
            foreach (var shape in popStack)
            {
                var pen = new Pen(shape.Color);
                if (shape is Circle c)
                {
                    e.Graphics.DrawEllipse(pen,
                        c.Center.X - c.Radius / 2,
                        c.Center.Y - c.Radius / 2,
                        c.Radius,
                        c.Radius
                        );
                }
                else if (shape is Rektangle rekt)
                {
                    e.Graphics.DrawRectangle(pen,
                        rekt.Center.X - rekt.Width / 2,
                        rekt.Center.Y - rekt.Height / 2,
                        rekt.Width,
                        rekt.Height
                        );
                }
                else if (shape is Square sqr)
                {
                    e.Graphics.DrawRectangle(pen,
                        sqr.Center.X - sqr.Side / 2,
                        sqr.Center.Y - sqr.Side / 2,
                        sqr.Side,
                        sqr.Side
                        );
                }
                else if (shape is Triangle tri)
                {
                    e.Graphics.DrawPolygon(pen, tri.Points);
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            popStack.Clear();
            pb_box.Refresh();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            switchElement(popStack, redoStack);
            //if (popStack.Any()) 
            //{
            //    redoStack.Push(popStack.Pop());
            //}
            //pb_box.Refresh();
        }

        private void redo_btn_Click(object sender, EventArgs e)
        {
            switchElement(redoStack, popStack);
            //if (redoStack.Any())
            //{
            //    popStack.Push(redoStack.Pop());
            //}
            //pb_box.Refresh();   
        }

        private void switchElement(Stack<Shapes> giver, Stack<Shapes> receiver)
        {
            if (giver.Any())
            {
                receiver.Push(giver.Pop());
                pb_box.Refresh();
            }

        }


        private void circle_box_CheckedChanged(object sender, EventArgs e)
        {
            if (circle_box.Checked)
            {
                drawCircle = true;
                rektangle_box.Checked = false;
                square_box.Checked = false;
                triangle_box.Checked = false;
            }
            else { drawCircle = false; }
        }

        private void rektangle_box_CheckedChanged(object sender, EventArgs e)
        {
            if (rektangle_box.Checked)
            {
                drawRektangle = true;
                square_box.Checked = false;
                triangle_box.Checked = false;
                circle_box.Checked = false;
            }
            else
            { drawRektangle = false; }
        }

        private void square_box_CheckedChanged(object sender, EventArgs e)
        {
            if (square_box.Checked)
            {
                drawSquare = true;
                circle_box.Checked = false;
                rektangle_box.Checked = false;
                triangle_box.Checked = false;
            }
            else { drawSquare = false; }
        }

        private void triangle_box_CheckedChanged(object sender, EventArgs e)
        {
            if (triangle_box.Checked)
            {
                drawTriangle = true;
                square_box.Checked = false;
                rektangle_box.Checked = false;
                circle_box.Checked = false;
            }
            else { drawTriangle = false; }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //
            //
            //Does the List to Json file and saves it in the chosen folder
            //
            //
            var json = JsonConvert.SerializeObject(shapes, Formatting.Indented);

            var open = saveFileDialog1.ShowDialog();
            if (open == DialogResult.OK)
            {
                File.AppendAllText(saveFileDialog1.FileName, json);
            }

            File.WriteAllText(saveFileDialog1.FileName, json);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void load_file_btn_Click(object sender, EventArgs e)
        {
            //var res = openFileDialog1.ShowDialog(this);
            //if (res == DialogResult.OK)
            //{
            //    var file = openFileDialog1.FileName;
            //    var content = File.ReadAllText(file);
            //    popStack.Push(JsonSerializer.Deserialize<Stack<Shapes>>(content));
            //}
        }
        
        
    }
}
