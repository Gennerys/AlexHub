using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace graph_lab2
{
    class Face
    {
        public int[] face;
        public double average_z;
        public double average_y;
        public double average_x;
        SolidBrush color;

        public Face(int[] face, SolidBrush color)
        {
            this.face = face;
            this.color = color;
        }

        public void CalculateAvgZ(Point3D[] points3D)
        {
           
            double sumz = 0;
            for (int i = 0; i < face.Length-1; i++)
            {
                sumz += points3D[face[i]].Z;
            }

            average_z = sumz / (face.Length-1);
        }

        public void CalculateAvgX(Point3D[] points3D)
        {
            double sumx = 0;
            for (int i = 0; i < face.Length-1; i++)
            {
                sumx += points3D[face[i]].X;
            }

            average_x = sumx / (face.Length-1);
        }

        public void CalculateAvgY(Point3D[] points3D)
        {
            double sumy = 0;

            for (int i = 0; i < face.Length - 1; i++)
            {
                sumy += points3D[face[i]].Y;
            }

            average_y = sumy / (face.Length-1);
        }

        public void DrawFace(Graphics gr, Point[] points, Pen p)
        {
            GraphicsPath path = new GraphicsPath();

            for (int i = 0; i < face.Length-2; i++)
            {
                path.AddLine(points[face[i]], points[face[i+1]]);
            }

            gr.FillPath(color, path);
            //gr.DrawPath(p, path);
        }


    }
}
