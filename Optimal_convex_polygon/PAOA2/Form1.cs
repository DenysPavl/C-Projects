using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PAOA2
{
    public partial class Form1 : Form
    {
        List<Point> listpoint = new List<Point>();
        List<Point> list_grehema = new List<Point>();
        List<Point> list_jarvisa = new List<Point>();
        bool perevirka3number= true;
        Point point;
        Point controlPoint;
        int count = 0;
        double sumAngle = 0;
        public Form1()
        {
            InitializeComponent();
            labeleror.Visible=false;
        }

        private void NextPhase_Click(object sender, EventArgs e)
        {
            Alg_Greckhem();
            bool perevirka = false;
            if (textBoxControlX.Text != "" || textBoxControlY.Text!="")
            {
                int x = int.Parse(textBoxControlX.Text);
                int y = int.Parse(textBoxControlY.Text);
                controlPoint.X = x; controlPoint.Y = y;
                perevirka = ProvirkaControlPoint(x, y, list_grehema);
            }
            if (perevirka3number == true)
            {   
                Form2 form2 = new Form2(list_grehema, perevirka, controlPoint, listpoint);
                form2.Show();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Alg_Jervisa();
            bool perevirka = false;
            if (textBoxControlX.Text != "" || textBoxControlY.Text != "")
            {
                int x = int.Parse(textBoxControlX.Text);
                int y = int.Parse(textBoxControlY.Text);
                controlPoint.X = x; controlPoint.Y = y;
                 perevirka = ProvirkaControlPoint(x, y, list_grehema);
            }
            if (perevirka3number == true)
            {
                Form2 form2 = new Form2(list_jarvisa, perevirka, controlPoint,listpoint);
                form2.Show();
            }
           
        }
        private void Alg_Greckhem()
        {
            int vecY_pa, vecX_pa;
            Point[] masspoint = listpoint.ToArray();
            if (count < 3 || ( count==3 && !Perevirka(masspoint[0], masspoint[1], masspoint[2])))
            {
                perevirka3number = false;
                labeleror.Visible = true;
            }
            else
            {
                ///////////////////////////////////////////////////// min
                double minY = masspoint[0].Y;
                double minX = masspoint[0].X;
                int minIndex = 0;
                for (int i = 0; i < masspoint.Length; i++)
                {
                    if (minY > masspoint[i].Y || (minY == masspoint[i].Y && minX > masspoint[i].X))
                    {
                        minY = masspoint[i].Y;
                        minX = masspoint[i].X;
                        minIndex = i;
                    }
                }
                Point courent = masspoint[0];
                masspoint[0] = masspoint[minIndex];
                masspoint[minIndex] = courent;
                Point p = masspoint[0];
                Array.Sort(masspoint, (a, b) => Math.Atan2(a.Y - p.Y, a.X - p.X).CompareTo(Math.Atan2(b.Y - p.Y, b.X - p.X)));
                /////////////////////////////////////////////////// Algoritm
                Stack<Point> stack = new Stack<Point>();
                stack.Push(masspoint[0]);
                stack.Push(masspoint[1]);
                for (int i = 2; i < masspoint.Length; i++)
                {
                    Point head = stack.Pop();
                    Point nextHead = stack.Peek();
                    stack.Push(head);
                    while (Perevirka(nextHead, head, masspoint[i]))
                    {
                        stack.Pop();            
                        head = stack.Pop();
                        nextHead = stack.Peek();
                        stack.Push(head);
                    }
                    stack.Push(masspoint[i]);
                }
                for (int i = 0; i < masspoint.Length; i++)
                    list_grehema = stack.ToList();
                list_grehema.Reverse();
            }
        }

        private void Alg_Jervisa()
        {
            Point[] masspoint = listpoint.ToArray();
            if (count < 3 || (count == 3 && !Perevirka(masspoint[0], masspoint[1], masspoint[2])))
            {
                perevirka3number = false;
                labeleror.Visible = true;
            }
            else
            {
                //////////////////////////////////////////////////min
                double minY = masspoint[0].Y;
                double minX = masspoint[0].X;
                int minIndex = 0;
                for (int k = 0; k < masspoint.Length; k++)
                {
                    if ((minX > masspoint[k].X) || (minX == masspoint[k].X && minY > masspoint[k].Y))
                    {
                        minY = masspoint[k].Y;
                        minX = masspoint[k].X;
                        minIndex = k;
                    }
                }
                Point courent = masspoint[0];
                masspoint[0] = masspoint[minIndex];
                masspoint[minIndex] = courent;
                ////////////////////////////////////////////////// alg
                int index = 0;
                int nexti;
                do
                {
                    list_jarvisa.Add(masspoint[index]);
                    nexti = (index + 1) % masspoint.Length;
                    for (int k = 0; k < masspoint.Length; k++)
                        if (nexti == index || Perevirka(masspoint[index], masspoint[k], masspoint[nexti]))
                            nexti = k;
                    index = nexti;
                }
                while (index != 0);
            }
        }
        private bool Perevirka(Point a,Point b, Point c)
        {
                int vecX_ab = b.X - a.X;
                int vecY_ab = b.Y - a.Y;
                int vecX_ac = c.X - a.X;
                int vecY_ac = c.Y - a.Y;
                double vector_dobutok = vecX_ab * vecY_ac - vecY_ab * vecX_ac;
                if (vector_dobutok == 0 || vector_dobutok > 0)
                        return false;
                else
                        return true;
        }

        private void addPoint_Click(object sender, EventArgs e)
        {
            count++;
            int x = int.Parse(lineX.Text);
            int y = int.Parse(lineY.Text);
            point = new Point(x, y);
            listpoint.Add(point);
            Console.WriteLine(listpoint);
            lineX.Text = null; lineY.Text=null;
        }
       private bool ProvirkaControlPoint(int x,int y,List<Point> listofpoints) 
        {
            double scaldobutok, modAB,modAC;
            Point[] masspoint = listofpoints.ToArray();
            for (int i = 0; i < masspoint.Length; i++)
            {
                double AngleCos = 0;
                int vect1X = masspoint[i].X-x;
                int vect1Y = masspoint[i].Y - y;
                int vect2X = masspoint[(i + 1) % masspoint.Length].X-x;
                int vect2Y = masspoint[(i + 1) % masspoint.Length].Y-y;
                scaldobutok = vect1X*vect2X+vect1Y*vect2Y;
                modAB = Math.Sqrt(Math.Pow(vect2X, 2) + Math.Pow(vect2Y, 2));
                modAC = Math.Sqrt(Math.Pow(vect1X, 2) + Math.Pow(vect1Y, 2));
                AngleCos = scaldobutok / (modAB * modAC);
                double angleInRadians = Math.Acos(AngleCos);
                sumAngle += angleInRadians * (180.0 / Math.PI);
            }
            double epsilon = 1.08e-19;
            if (Math.Abs(sumAngle - 360) < epsilon) // 2Pi
                return true; 
            else 
                return false;
        }
    }
}
