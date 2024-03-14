using Aspose.Cells;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Orange_Corp
{
    public partial class Form1 : Form
    {
        private PictureBox pb_box;
        private bool drawCircle = false;
        private bool drawRektangle = false;
        private bool drawSquare = false;
        private bool drawTriangle = false;
        private bool background = false;
        private Stack<Shapes> popStack = new();
        private Stack<Shapes> redoStack = new();
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.InitialDirectory =
                 Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.Filter = 
                "PNG files (*.png)|*.png|" +
                "BMP Files (*.bmp)|*.bmp|" +
                "JPG Files (*.jpg)|*.jpg|" +
                "SYN Files (*.syn)|*.syn|" +
                "All files (*.*)|*.*"; 
        }
        //H�r best�mmer man om shapes f�rg, strorlek, plats, och vilken typ �r den samt sparar den till Stack
        private void pb_box_Click(object sender, EventArgs e)
        {
            Colors farg = new();
            Color color = new();
            try
            {
                color = farg.colors[(string)comboBox1.SelectedItem];
                var mouse = (MouseEventArgs)e;
                if (drawCircle)
                {
                    var circle = new Circle()
                    {
                        A_Shape = "Circle",
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
                        A_Shape = "Rektangle",
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
                        A_Shape = "Square",
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
                        A_Shape = "Triangle",
                        Points =
                        [new(x - 100, y),
                         new(x + 100, y),
                         new(x, y -200)
                        ],
                        Color = color,
                        Center = mouse.Location
                    };
                    popStack.Push(tri);
                }
                else if (background)
                {
                    pb_box.BackColor = color;
                }
                pb_box.Refresh();
            }
            catch//Om man har inte valt f�rg d� programmet kraschar inte
            {
                if (color == null)
                {
                    pb_box.Refresh();
                    //string msg = "Choose a color first";
                    //string title = "Error";
                    //MessageBox.Show(msg, title);
                }
            }
        }

        //Den h�r metod skriver ut shapes efter egenskaper som de har f�tt i metoden ovanf�r
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

        //Rensar prim�r Stack
        private void clear_btn_Click(object sender, EventArgs e)
        {
            popStack.Clear();
            pb_box.BackColor = Color.AntiqueWhite;
            pb_box.Refresh();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            switchElement(popStack, redoStack);
        }

        private void redo_btn_Click(object sender, EventArgs e)
        {
            switchElement(redoStack, popStack);
        }

        //Metoden Switch som har motagare och givare g�r en swap p� respektiva Stack
        private void switchElement(Stack<Shapes> giver, Stack<Shapes> receiver)
        {
            if (giver.Any())
            {
                receiver.Push(giver.Pop());
                pb_box.Refresh();
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            
            //F�r Json Variant
            ////G�r Stack till json fil och spara den lokalt
            //var json = JsonConvert.SerializeObject(popStack, Formatting.Indented);
            var open = saveFileDialog1.ShowDialog();
            var extension = Path.GetExtension(saveFileDialog1.FileName).ToLower();//H�mtar den valda extension av filen

            if (open == DialogResult.OK)
            {
                if (extension == ".png")
                {
                    //F�r Png variant
                    Bitmap bitmap = new Bitmap(pb_box.Width, pb_box.Height);

                    pb_box.DrawToBitmap(bitmap, new Rectangle(0, 0, pb_box.Width, pb_box.Height));
                    bitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
                else if (extension == "*.bmp")
                {
                    //F�r Bmp variant
                    Bitmap bitmap = new Bitmap(pb_box.Width, pb_box.Height);

                    pb_box.DrawToBitmap(bitmap, new Rectangle(0, 0, pb_box.Width, pb_box.Height));
                    bitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
                else if (extension == "*.jpg")
                {
                    //F�r Jpeg variant
                    Bitmap bitmap = new Bitmap(pb_box.Width, pb_box.Height);

                    pb_box.DrawToBitmap(bitmap, new Rectangle(0, 0, pb_box.Width, pb_box.Height));
                    bitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
                else if (extension == ".syn")
                {
                    //F�r Json Variant
                    //G�r Stack till json fil och spara den lokalt
                    var json = JsonConvert.SerializeObject(popStack, Formatting.Indented);
                    File.AppendAllText(saveFileDialog1.FileName, json);
                    File.WriteAllText(saveFileDialog1.FileName, json);
                }
            }
            //File.WriteAllText(saveFileDialog1.FileName, json);
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        //Metod som ladda ner lokalfiler till programmet
        private void load_file_btn_Click(object sender, EventArgs e)
        {
            var res = openFileDialog1.ShowDialog(this);
            if (res == DialogResult.OK)
            {
                var file = openFileDialog1.FileName; // h�mtar filen fr�n FileDialog
                var content = File.ReadAllText(file);// l�ser och spara filen till en str�ng variabel

                var jArray = JArray.Parse(content);//G�r om str�ng/json fil in Json Array

                //G�r genom JArray och kontrollerar om objektet �r en av specifik typ
                //Sparar alla properties av onjektet till en ny objekt och sparar den till Stack
                foreach (var jToken in jArray)
                {
                    var shapeJson = jToken.ToString();
                    Circle circle = new();
                    Rektangle rekt = new();
                    Square sqr = new();
                    Triangle tri = new();

                    if (shapeJson.Contains("Circle"))
                    {
                        circle = JsonConvert.DeserializeObject<Circle>(shapeJson);
                        popStack.Push(circle);
                    }
                    else if (shapeJson.Contains("Rektangle"))
                    {
                        rekt = JsonConvert.DeserializeObject<Rektangle>(shapeJson);
                        popStack.Push(rekt);
                    }
                    else if (shapeJson.Contains("Square"))
                    {
                        sqr = JsonConvert.DeserializeObject<Square>(shapeJson);
                        popStack.Push(sqr);
                    }
                    else if (shapeJson.Contains("Triangle"))
                    {
                        tri = JsonConvert.DeserializeObject<Triangle>(shapeJson);
                        popStack.Push(tri);
                    }
                }
                pb_box.Refresh();
            }
        }


        //Knappar som �ndra respektiva bool variablar f�r att aktivera operationer
        private void rectangle_btn_Click(object sender, EventArgs e)
        {
            drawRektangle = true;
            drawSquare = false;
            drawTriangle = false;
            drawCircle = false;
            background = false;
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            drawCircle = true;
            drawRektangle = false;
            drawSquare = false;
            drawTriangle = false;
            background = false;
        }
        private void triangle_btn_Click(object sender, EventArgs e)
        {
            drawTriangle = true;
            drawSquare = false;
            drawRektangle = false;
            drawCircle = false;
            background = false;
        }

        private void square_btn_Click(object sender, EventArgs e)
        {
            drawSquare = true;
            drawRektangle = false;
            drawCircle = false;
            drawTriangle = false;
            background = false;
        }

        private void fill_bgrd_btn_Click(object sender, EventArgs e)
        {
            background = true;
            drawSquare = false;
            drawRektangle = false;
            drawCircle = false;
            drawTriangle = false;
        }
    }
}
