using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1__492_
{
    class Program
    {
        static void Main(string[] args)
        {
            //программа решает задачу https://acmp.ru/index.asp?main=task&id_task=492

            //начальные координаты, вектор скорости, скоростьб время, расстояние
            long x0, y0, vx, vy, v, t, d;

            StreamReader sr = new StreamReader("input.txt");//входной файл
            StreamWriter sw = new StreamWriter("output.txt");//выходной файл

            //запись данных из входного файла
            string s = sr.ReadToEnd();
            s = s.Replace(Environment.NewLine, " ");
            string[] str = s.Split();
            x0 = Convert.ToInt64(str[0]);
            y0 = Convert.ToInt64(str[1]);
            vx = Convert.ToInt64(str[2]);
            vy = Convert.ToInt64(str[3]);
            v = Convert.ToInt64(str[4]);
            t = Convert.ToInt64(str[5]);
            d = Convert.ToInt64(str[6]);
            //конец записи данных из входного файла
            
            // квадрат расстояния между крйсером и целью
            long distSquare = (x0 + vx * t) * (x0 + vx * t) + (y0 + vy * t) * (y0 + vy * t);

            //если цель расположена слишком далеко или слишком близко
            if (distSquare > (v * t + d) * (v * t + d) || (d - v * t >= 0 && distSquare < (d - v * t) * (d - v * t)))
                sw.WriteLine("NO");
            else//цель на достижимом расстоянии
                sw.WriteLine("YES");
            sr.Close();
            sw.Close();
        }
    }
}
