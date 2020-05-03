using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    public partial class SecondTaskCoordinate : Form
    {
        private const int PIX_IN_ONE = 10;
        private const float RADIUS = 12f;
        private const int Ox = 18 * PIX_IN_ONE; // Центр 
        private const int Oy = 12 * PIX_IN_ONE; // координат
        public SecondTaskCoordinate()
        {
            InitializeComponent();
        }

        private void drawButtonListener(object sender, EventArgs e)
        {
            
            if(textBox1.Text != "" && isValueTypeValid(textBox1.Text))
            drawCoordinatePlane(textBox1.Text,textBox2.Text);
        }
        private void drawCoordinatePlane(String X, String Y)
        {
            Bitmap btm = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics graphics = Graphics.FromImage(btm);
            Pen pen = new Pen(Brushes.Black);
            Pen pen1 = new Pen(Brushes.DarkGray);
            

            //рисуем вертикальные линии
            int ver = 0;
            while (ver < pictureBox.Width)
            {
                graphics.DrawLine(pen1, ver, 0, ver, pictureBox.Height);
                ver += PIX_IN_ONE;
            }
            //рисуем горизонтальные линии
            int gor = 0;
            while (gor < pictureBox.Height)
            {
                graphics.DrawLine(pen1, 0, gor, pictureBox.Width, gor);
                gor += PIX_IN_ONE;
            }
            //рисуем координатные оси

            //Y
            graphics.DrawLine(pen, 18 * PIX_IN_ONE, 0, 18 * PIX_IN_ONE, pictureBox.Height);

            //X
            graphics.DrawLine(pen, 0, 12 * PIX_IN_ONE, pictureBox.Width, 12 * PIX_IN_ONE);

            //рисуем окружность
            graphics.DrawEllipse(pen, 6 * PIX_IN_ONE, 0, 24 * PIX_IN_ONE, 24 * PIX_IN_ONE);

            //рисуем делящий отрезок
            graphics.DrawLine(pen, 6 * PIX_IN_ONE, 24 * PIX_IN_ONE, 29 * PIX_IN_ONE, 1 * PIX_IN_ONE);

            //рисуем заштрихованную область
            int x1 = 10 * PIX_IN_ONE, y1 = 20 * PIX_IN_ONE;
            float x1Real = -8, y1Real = -8;
            int x2 = 10 * PIX_IN_ONE, y2 = 20 * PIX_IN_ONE;
            float x2Real = -8, y2Real = -8;

            while (x1Real * x1Real + y1Real * y1Real < RADIUS * RADIUS)
            {
                while (x2Real * x2Real + y2Real * y2Real < RADIUS * RADIUS)
                {
                    x2 += 1;
                    y2 += 1;
                    x2Real += 0.1f;
                    y2Real -= 0.1f;
                }
                graphics.DrawLine(pen, x1, y1, x2, y2);
                x1 += PIX_IN_ONE / 2;
                y1 -= PIX_IN_ONE / 2;
                x1Real+=0.5f;
                y1Real+=0.5f;
                x2 = x1;
                y2 = y1;
                x2Real = x1Real;
                y2Real = y1Real;
            }
            //рисуем точку
            graphics.FillEllipse(Brushes.Red, Ox + (Convert.ToInt32(X) * PIX_IN_ONE) - 5 , Oy - (Convert.ToInt32(Y)* PIX_IN_ONE) - 5, 10, 10);
            textBox3.Text = getResult(float.Parse(X), float.Parse(Y));
            pictureBox.Image = btm;
            

        }
        private bool isValueTypeValid(String str)
        {
            char[] chArr = str.ToCharArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                if (!(chArr[i] >= '0' && chArr[i] <= '9') && chArr[i] != '-')
                {
                    return false;
                }
            }
            return true;
        }
        private static String getResult(float x, float y)
        {
            if (x == y && x * x + y * y < RADIUS * RADIUS || x * x + y * y == RADIUS * RADIUS && y < x)
            {
                return "На границе";

            }
            else if (y < x && x * x + y * y < RADIUS * RADIUS)
            {
                return "Да";

            }
            else
            {
                return "Нет";
            }
        }
    }
}
