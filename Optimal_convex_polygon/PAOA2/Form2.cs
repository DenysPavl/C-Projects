using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAOA2
{
    public partial class Form2 : Form
    {
        Point[] arr;
        Point[] arrtrue;
        Point controlPoint;
        public Form2(List <Point> truelist, bool tochka,Point controlPoint,List<Point> listpoint)
        {
            InitializeComponent();
            arr = listpoint.ToArray();
            arrtrue = truelist.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].X = 200+ (arr[i].X*10);
                arr[i].Y = 200- (arr[i].Y*10);
            }
            for (int i = 0; i < arrtrue.Length; i++)
            {
                arrtrue[i].X = 200 + (arrtrue[i].X * 10);
                arrtrue[i].Y = 200 - (arrtrue[i].Y * 10);
            }
            if (tochka)
                label1.Text = "Точка входить";
            else if (tochka==false)
                label1.Text = "Точка не входить";
            this.controlPoint.X = 200+(10*controlPoint.X);
            this.controlPoint.Y = 200-(10*controlPoint.Y);

            }
        Graphics g;
        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g;
            Font myFont = new Font("Arial", 9, FontStyle.Bold | FontStyle.Italic);
            g =CreateGraphics();
            Pen pen= new Pen(Color.Red,2);
            g.DrawLine(pen, 0, 200, 1000, 200);
            g.DrawLine(pen, 200, 0, 200, 1000);
            g.DrawPolygon(Pens.Black, arr);
            g.DrawPolygon(Pens.DarkBlue, arrtrue);
            g.FillRectangle(Brushes.Black, controlPoint.X,controlPoint.Y, 4,4);
            for (int i = 0; i < arrtrue.Length; i++)
            {
               // g.FillRectangle(Brushes.Black, arr[i].X,arr[i].Y, 2, 2);
                g.DrawString($"{i + 1}", myFont, Brushes.DarkBlue, arrtrue[i].X - 2, arrtrue[i].Y - 2);
            }
            for (int i = 0;i < 1000;i+=10)
            {
                g.FillRectangle(Brushes.Red, i, 198, 2, 6);
                g.FillRectangle(Brushes.Red, 198, i, 6, 2);
            }
        }
    }
}
