using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CKOT
{
    public partial class Form1 : Form
    {
        Bitmap bmp; //изображение
        Triangle T; //шаблон - рисование треугольника
        Point A, B, C; //координаты вершин
        int step; //текущий шаг фрактала
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(screen.Width, screen.Height); //создаем холст
            //создаем исходный треугольник
            A = new Point(0, 0); //
            B = new Point(500, 0); //
            C = new Point(500, 500); //<---- задаем координаты вершин
            T = new Triangle(A, B, C);
            screen.Image = T.draw_triangle(bmp); //<----- отрисовываем треугольник
            step = 0; //<-------- исходный треугольник соответствует нулевому шагу
        }
        private void draw_Click(object sender, EventArgs e)
        {
            if (step < 10)
            {
                step++; //следующий шаг
                t_step.Text = Convert.ToString(step);
                Draw(T, step);
            }
        }
        private void Draw(Triangle _T, int _n) //построение фрактала (на входе - треугольник и число оставшихся итерации)
        {
            //СУТЬ - разбиваем больший треугольник на 3 подобных и меньших по размеру, далее рекурсивно выполняем
            //это же самое разбиение уже для дочерних треугольников, и делаем так нужное количество раз
            if (_n >= 0) //всего n шагов, включая нулевой
            {
                screen.Image = _T.draw_triangle(bmp); //<--- это рисуем родительский треугольник
                //координаты новых вершин - середин сторон треугольника
                // Xan = (Xcn-1 - Xan-1) / 2 + Xan-1
                // Yan = (Ycn-1 - Yan-1) / 2 + Yan-1
                //т.е сумма половины разности предыдущих координат конца и начала стороны треугольника и координат начала
                Point _A = new Point((_T.C.X - _T.A.X) / 2 + _T.A.X, (_T.C.Y - _T.A.Y) / 2 + _T.A.Y);
                Point _B = new Point((_T.B.X - _T.A.X) / 2 + _T.A.X, _T.B.Y);
                Point _C = new Point(_T.C.X, (_T.C.Y - _T.B.Y) / 2 + _T.B.Y);
                //дочерние треугольники
                Triangle _f = new Triangle(_T.A, _B, _A);
                Triangle _s = new Triangle(_B, _T.B, _C);
                Triangle _t = new Triangle(_A, _C, _T.C);
                //рекурсивно вызываем функции для дочерних треугольников
                //параметр итерации НЕ МЕНЯЕТСЯ, просто в каждую функцию передается входной, уменьшеный на единицу
                //таким образом, все функции вызовятся одинаковое количество раз
                Draw(_f, _n - 1);
                Draw(_s, _n - 1);
                Draw(_t, _n - 1);
            }
        }
        private void res_Click(object sender, EventArgs e) //<--- сброс на нулевой шаг
        {
            bmp = new Bitmap(screen.Width, screen.Height); //старый холст выбрасываем и создаем новый
            screen.Image = T.draw_triangle(bmp); //рисуем на нем исходный треугольник
            step = 0; //сбрасываем шаг
            t_step.Text = Convert.ToString(step);
        }

        private void draw_back_Click(object sender, EventArgs e) //деструкция, рисование в обратную сторону
        {
            if (step > 0)
            {
                bmp = new Bitmap(screen.Width, screen.Height); //перед рисованием очищаем холст
                step--; //предыдущий шаг
                t_step.Text = Convert.ToString(step);
                Draw(T, step);
            }
        }
    }
}
