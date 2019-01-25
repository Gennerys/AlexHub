using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace graph_lab2
{
    public partial class Form1 : Form
    {

        Bitmap my_bitmap;
        Graphics gr;
        Point3D[] points3D;
        Point3D[] auxiliary3D;
        Point3D[] Move3D;
        Point[] points;
        int[] order = new int[14];
        int number_of_3D_points;
        Pen p = new Pen(Color.Black, 2);
        bool[,] line = new bool[24, 24];
        Pen axes = new Pen(Color.Aquamarine, 3);
        Point p0 = new Point(300, 350);
        int move_x, move_y, move_z, alpha, beta, ax, ay, az;
        double scale_x, scale_y, scale_z, v0;
        int t_transfer = 0, t_scale = 0, t_rotate = 0;
        double t_move = 0;
        bool animation = false;
        Face[] faces = new Face[14];
        SolidBrush[] brushes = new SolidBrush[23];
        int k = 800;


        public Form1()
        {
            InitializeComponent();
            my_bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gr = Graphics.FromImage(my_bitmap);
            pictureBox1.Image = my_bitmap;

            //brushes[0] = new SolidBrush(Color.Red);
            //brushes[1] = new SolidBrush(Color.Orange);
            //brushes[2] = new SolidBrush(Color.Yellow);
            //brushes[3] = new SolidBrush(Color.Green);
            //brushes[4] = new SolidBrush(Color.Blue);
            //brushes[5] = new SolidBrush(Color.Violet);

            for (int i = 0; i < 3; i++)
            {
                brushes[i] = new SolidBrush(Color.ForestGreen);
            }

            for (int i = 3; i < 7; i++)
            {
                brushes[i] = new SolidBrush(Color.Gold);
            }

            for (int i = 7; i < 9; i++)
            {
                brushes[i] = new SolidBrush(Color.Coral);
            }

            for (int i = 9; i <14; i++)
            {
                brushes[i] = new SolidBrush(Color.Crimson);
            }

           
        }

        public bool OutOfPictureBox()
        {
            for (int i = 0; i < number_of_3D_points; i++)
            {
                if (points[i].X < pictureBox1.Location.X || points[i].Y < pictureBox1.Location.Y 
                    || points[i].X > pictureBox1.Location.X + pictureBox1.Width 
                    || points[i].Y > pictureBox1.Location.Y + pictureBox1.Height)
                    return true;
            }
            return false;

        }

        public void From3DTo2D(Point3D[] points3D)
        {
            points = new Point[points3D.Length];
            for (int i = 0; i < points.Length; i++)
            {
                points[i].X = Convert.ToInt32(p0.X + (k * points3D[i].X / (points3D[i].Z + k)));
                points[i].Y = Convert.ToInt32(p0.Y - (k * points3D[i].Y / (points3D[i].Z + k)));
            }
        }


        public void DrawLetter()
        {
            gr.Clear(pictureBox1.BackColor);
             
            gr.DrawLine(axes, p0, new Point(p0.X + 300, p0.Y));
            gr.DrawLine(axes, p0, new Point(p0.X, p0.Y - 300));
            gr.DrawLine(axes, p0, new Point(p0.X - 150, p0.Y + 150));

            foreach (Face face in faces)
            {
                face.CalculateAvgZ(points3D);
                face.CalculateAvgY(points3D);
                face.CalculateAvgX(points3D);
            }

            Face temp;
            for (int i = 0; i < faces.Length - 1; i++)
            {
                for (int j = i + 1; j < faces.Length; j++)
                {
                    if (faces[i].average_z < faces[j].average_z)
                    {
                        temp = faces[i];
                        faces[i] = faces[j];
                        faces[j] = temp;
                    }

                    if (faces[i].average_z == faces[j].average_z && (faces[i].average_x < faces[j].average_x))
                    {
                        temp = faces[i];
                        faces[i] = faces[j];
                        faces[j] = temp;
                    }

                }
            }

            foreach (Face face in faces)
            {
                face.DrawFace(gr, points, p);
            }

          
            pictureBox1.Image = my_bitmap;
        }

        private void BuildTheLetter_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                MessageBox.Show("Дождитесь окончания запущеной анимации", "Слишком рано!");
                return;
            }
            StreamReader coordinates_file = null;
            StreamReader connections_file = null;

            try
            {
                coordinates_file = new StreamReader(Application.StartupPath + @"\coords.txt");
                string line, buffer = null;
                int count = 0;
                number_of_3D_points = 0;
                while ((line = coordinates_file.ReadLine()) != null)
                {
                    number_of_3D_points++;
                    buffer += line;
                }
                char[] splitters =  {' ', '\n', '\r'};
                points3D = new Point3D[number_of_3D_points];
                string[] substrings = buffer.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < number_of_3D_points; i++)
                {
                    points3D[i].X = Convert.ToDouble(substrings[count++]);
                    points3D[i].Y = Convert.ToDouble(substrings[count++]);
                    points3D[i].Z = Convert.ToDouble(substrings[count++]);
                }

                connections_file = new StreamReader(Application.StartupPath + @"\myconnections.txt");
                count = 0;

                while ((line = connections_file.ReadLine()) != null)
                {
                   string[] temps = line.Split(splitters, StringSplitOptions.RemoveEmptyEntries);
                   int[] tempi = new int[temps.Length];

                   for(int i = 0; i < temps.Length; i++)
                   {
                        tempi[i] = Convert.ToInt32(temps[i]); 
                   }

                    faces[count] = new Face(tempi, brushes[count]);
                    count++;
                }
               

                From3DTo2D(points3D);
                DrawLetter();
                Scale.Enabled = true;
                Transfer.Enabled = true;
                Reflect.Enabled = true;
                Rotate.Enabled = true;
                Move.Enabled = true;
                Turn.Enabled = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("При считывании файла произошла ошибка. " + ex.Message, "Ошибка при считывании");
            }
            
          
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                MessageBox.Show("Дождитесь окончания запущеной анимации", "Слишком рано!");
                return;
            }
            try
            {
                move_x = Convert.ToInt32(textBoxMoveX.Text);
                move_y = Convert.ToInt32(textBoxMoveY.Text);
                move_z = Convert.ToInt32(textBoxMoveZ.Text);
                t_transfer = 0;
                animation = true;
                transferTimer.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Допустимы только целые числовые значения", "Ошибка приведения");
            }
            
        }

        private void transferTimer_Tick(object sender, EventArgs e)
        {
            if (t_transfer == 100)
            {
                animation = false;
                transferTimer.Enabled = false;
            }
                double step_x = move_x / 100.0;
                double step_y = move_y / 100.0;
                double step_z = move_z / 100.0;

                for (int i = 0; i < number_of_3D_points; i++)
                {
                    points3D[i].X += step_x;
                    points3D[i].Y += step_y;
                    points3D[i].Z -= step_z;
                }
                From3DTo2D(points3D);

                if (OutOfPictureBox())
                {
                    animation = false;
                    transferTimer.Enabled = false;
                    MessageBox.Show("Выход за границы PictureBox");
                }

                else
                {
                    DrawLetter();
                    t_transfer++;
                }
        }

        private void Reflect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < number_of_3D_points; i++)
            {
                if(checkBoxReflectY.Checked)
                    points3D[i].X = - points3D[i].X;
                if (checkBoxReflectX.Checked)
                    points3D[i].Y = - points3D[i].Y;
                if (checkBoxReflectZ.Checked)
                    points3D[i].Z = - points3D[i].Z;
            }

            From3DTo2D(points3D);
            if (OutOfPictureBox())
            {
                MessageBox.Show("Выход за границы PictureBox");
                return;
            }
            DrawLetter();
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                MessageBox.Show("Дождитесь окончания запущеной анимации", "Слишком рано!");
                return;
            }
            try
            {
                scale_x = Convert.ToDouble(textBoxScaleX.Text);
                scale_y = Convert.ToDouble(textBoxScaleY.Text);
                scale_z = Convert.ToDouble(textBoxScaleZ.Text);

                if (scale_x <= 0 || scale_y <= 0 || scale_z <= 0)
                {
                    MessageBox.Show("Допустимы только положительные числовые значения", "Ошибка приведения");
                    return;
                }

                auxiliary3D = new Point3D[number_of_3D_points];

                for (int i = 0; i < number_of_3D_points; i++)
                {
                    auxiliary3D[i].X = (points3D[i].X * scale_x - points3D[i].X) / 100;
                    auxiliary3D[i].Y = (points3D[i].Y * scale_y - points3D[i].Y) / 100;
                    auxiliary3D[i].Z = (points3D[i].Z * scale_z - points3D[i].Z) / 100;
                }

                t_scale = 0;
                animation = true;
                scaleTimer.Enabled = true;

            }
            catch
            {
                MessageBox.Show("Допустимы только положительные числовые значения", "Ошибка приведения");
            }
        }

        private void scaleTimer_Tick(object sender, EventArgs e)
        {
            if (t_scale == 100)
            {
                animation = false;
                scaleTimer.Enabled = false;
            }
            for (int i = 0; i < number_of_3D_points; i++)
            {
                points3D[i].X += auxiliary3D[i].X;
                points3D[i].Y += auxiliary3D[i].Y;
                points3D[i].Z += auxiliary3D[i].Z;
            }

            From3DTo2D(points3D);
            if (OutOfPictureBox())
            {
                animation = false;
                scaleTimer.Enabled = false;
                MessageBox.Show("Выход за границы PictureBox");
            }
            else
            {
                DrawLetter();
                t_scale++;
            }
        }
  
        private void Rotate_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                MessageBox.Show("Дождитесь окончания запущеной анимации", "Слишком рано!");
                return;
            }

            t_rotate = 0;
            animation = true;
            rotateTimer.Enabled = true;
        }

        private void rotateTimer_Tick(object sender, EventArgs e)
        {
            if (t_rotate == 360)
            {
                animation = false;
                rotateTimer.Enabled = false;
            }
            if (checkBoxRotateX.Checked)
            {
                for (int i = 0; i < number_of_3D_points; i++)
                {
                    points3D[i].Y = points3D[i].Y * Math.Cos(Math.PI / 180) + points3D[i].Z * Math.Sin(Math.PI / 180);
                    points3D[i].Z = - points3D[i].Y * Math.Sin(Math.PI / 180) + points3D[i].Z * Math.Cos(Math.PI / 180);
                }
            }

            if (checkBoxRotateY.Checked)
            {
                for (int i = 0; i < number_of_3D_points; i++)
                {
                    points3D[i].X = points3D[i].X * Math.Cos(Math.PI / 180) + points3D[i].Z * Math.Sin(Math.PI / 180);
                    points3D[i].Z =  - points3D[i].X * Math.Sin(Math.PI / 180) + points3D[i].Z * Math.Cos(Math.PI / 180);
                }
            }

            if (checkBoxRotateZ.Checked)
            {
                for (int i = 0; i < number_of_3D_points; i++)
                {
                    points3D[i].X = points3D[i].X * Math.Cos(Math.PI / 180) - points3D[i].Y * Math.Sin(Math.PI / 180);
                    points3D[i].Y = points3D[i].X * Math.Sin(Math.PI / 180) + points3D[i].Y * Math.Cos(Math.PI / 180);
                }
            }

            From3DTo2D(points3D);
            if (OutOfPictureBox())
            {
                animation = false;
                rotateTimer.Enabled = false;
                MessageBox.Show("Выход за границы PictureBox");
            }
            else
            {
                DrawLetter();
                t_rotate++;
            }
        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                MessageBox.Show("Дождитесь окончания запущеной анимации", "Слишком рано!");
                return;
            }

            try
            {
                v0 = Convert.ToDouble(textBoxSpeed.Text);
                
                alpha = Convert.ToInt32(textBoxAlpha.Text);
                beta = Convert.ToInt32(textBoxBeta.Text);
                if (v0 < 0||alpha<0||beta<0)
                {
                    MessageBox.Show("В графе Скорость и для углов допускаются тольо неотрицательные значения.", "Ошибка приведения");
                    return;
                }
                Move3D = new Point3D[number_of_3D_points];
                animation = true;
                t_move = 0;
                moveTimer.Enabled = true;
            }
            catch
            {
                MessageBox.Show("В графе Угол допускаются только целочисленные значения, а в графе Скорость  - только положительные", "Ошибка приведения");

            }
        }

        private void moveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < number_of_3D_points; i++)
            {
                Move3D[i].X = points3D[i].X + v0 * t_move * Math.Cos(alpha * Math.PI / 180);
                Move3D[i].Y = points3D[i].Y + v0 * t_move * Math.Sin(alpha * Math.PI / 180) - 9.81 * t_move * t_move / 2;
                Move3D[i].Z = points3D[i].Z + v0 * t_move * Math.Cos((beta + 180) * Math.PI / 180);
            }
            From3DTo2D(Move3D);
            if (OutOfPictureBox())
            {
                animation = false;
                moveTimer.Enabled = false;
                MessageBox.Show("Выход за границы PictureBox");

            }
            else
            {
                DrawLetter();
                t_move += 0.1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gr.DrawLine(axes, p0, new Point(p0.X + 300, p0.Y));
            gr.DrawLine(axes, p0, new Point(p0.X, p0.Y - 300));
            gr.DrawLine(axes, p0, new Point(p0.X - 150, p0.Y + 150));


            pictureBox1.Image = my_bitmap;
        }

        private void Turn_Click(object sender, EventArgs e)
        {
            if (animation)
            {
                MessageBox.Show("Дождитесь окончания запущеной анимации", "Слишком рано!");
                return;
            }

            try
            {
                t_rotate = 0;
                ax = Convert.ToInt32(textBoxTurnX.Text);
                ay = Convert.ToInt32(textBoxTurnY.Text);
                az = Convert.ToInt32(textBoxTurnZ.Text);
                if (ax < 0 || ay < 0 || az < 0)
                    throw new FormatException();

                animation = true;
                turnTimer.Enabled = true;
                
            }
            catch
            {
                MessageBox.Show("Углы могут быть только целыми положительными", "Ошибка приведения");

            }
        }

        private void turnTimer_Tick(object sender, EventArgs e)
        {
            if (t_rotate > ax && t_rotate > ay && t_rotate > az)
            {
                animation = false;
                turnTimer.Enabled = false;
            }
            if (t_rotate<ax)
            {
                for (int i = 0; i < number_of_3D_points; i++)
                {
                    points3D[i].Y = points3D[i].Y * Math.Cos(Math.PI / 180) + points3D[i].Z * Math.Sin(Math.PI / 180);
                    points3D[i].Z = - points3D[i].Y * Math.Sin(Math.PI / 180) + points3D[i].Z * Math.Cos(Math.PI / 180);
                }
            }

            if (t_rotate<ay)
            {
                for (int i = 0; i < number_of_3D_points; i++)
                {
                    points3D[i].X = points3D[i].X * Math.Cos(Math.PI / 180) + points3D[i].Z * Math.Sin(Math.PI / 180);
                    points3D[i].Z = - points3D[i].X * Math.Sin(Math.PI / 180) + points3D[i].Z * Math.Cos(Math.PI / 180);
                }
            }

            if (t_rotate<az)
            {
                for (int i = 0; i < number_of_3D_points; i++)
                {
                    points3D[i].X = points3D[i].X * Math.Cos(Math.PI / 180) - points3D[i].Y * Math.Sin(Math.PI / 180);
                    points3D[i].Y = points3D[i].X * Math.Sin(Math.PI / 180) + points3D[i].Y * Math.Cos(Math.PI / 180);
                }
            }
           
            From3DTo2D(points3D);
            if (OutOfPictureBox())
            {
                animation = false;
                turnTimer.Enabled = false;
                MessageBox.Show("Выход за границы PictureBox");
            }
            else
            {
                DrawLetter();
                t_rotate++;
            }
        }

      
    }
}

