using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heat_equation.Classes
{
    class Calculation
    {
        double[,] U = null;             // Значения температуры в узле в k-ый момент времени
        double[,] Unew = null;          // Значения температуру в узле в (k+1)-ый момент времени
        public int SizeX { get; set; }  // Количество узлов по OX
        public int SizeY { get; set; }  // Количество узлов по OY

        public Calculation()
        {
            SizeX = (int)(Global.Lx / Global.Hx) + 1;
            SizeY = (int)(Global.Ly / Global.Hy) + 1;

            U = new double[SizeX, SizeY];
            Unew = new double[SizeX, SizeY];
        }

        // Инициализация начальных значений границ и внутренней области
        public void Init()
        {
            for (int i = 1; i < SizeX - 1; i++)
            {
                for (int j = 1; j < SizeY - 1; j++)
                {
                    U[i, j] = Fx(i * Global.Hx, j * Global.Hy);
                }
            }
            for (int i = 0; i < SizeY; i++)
            {
                U[0, i] = Left_1(0.0, i * Global.Hy);
            }

            for (int i = 0; i < SizeX; i++)
            {
                U[i, 0] = Up_1(i * Global.Hx, Global.Ly);
            }

            for (int i = 0; i < SizeY; i++)
            {
                U[SizeX - 1, i] = Right_1(Global.Lx, i * Global.Hy);
            }

            for (int i = 0; i < SizeX; i++)
            {
                U[i, SizeY - 1] = Bottom_1(i * Global.Lx, 0.0);
            }

            // Копирование значений
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    Unew[i, j] = U[i, j];
                }
            }
        }

        // Основное итерационное вычисление
        public void Calc()
        {
            double R = Global.A * Global.A * Global.Tau;
            for (int k = 0; k < Global.MaxIteration; k++)
            {
                for (int i = 1; i < SizeX - 1; i++)
                {
                    for (int j = 1; j < SizeY - 1; j++)
                    {
                        Unew[i, j] = U[i, j] + R * ((U[i + 1, j] + U[i - 1, j] - 2 * U[i, j]) / (Global.Hx * Global.Hx) +
                            (U[i, j + 1] + U[i, j - 1] - 2 * U[i, j]) / (Global.Hy * Global.Hy));
                    }
                }

                // Копирование значений
                for (int i = 0; i < SizeX; i++)
                {
                    for (int j = 0; j < SizeY; j++)
                    {
                        U[i, j] = Unew[i, j];
                    }
                }
            }
        }

        // Напечатать текущее состояние
        public void Print(RichTextBox rtb)
        {
            for (int j = 0; j < SizeY; j++)
            {
                for (int i = 0; i < SizeX; i++)
                {
                    string str = String.Format("{0:f4}", Unew[i, j]);
                    rtb.AppendText(str + "   ");
                }
                rtb.AppendText(Environment.NewLine);
            }
        }

        // Рассчет внутренней области
        private double Fx(double x = 0.0, double y = 0.0)
        {
            return x + y;
        }

        // Границы 1-го рода
        private double Left_1(double x, double y)
        {
            return 0.0;
        }

        private double Up_1(double x, double y)
        {
            return 0.0;
        }

        private double Right_1(double x, double y)
        {
            return 0.0;
        }

        private double Bottom_1(double x, double y)
        {
            return 0.0;
        }

        // Границы 2-го рода - ДОДЕЛАТЬ
        private double Left_2(double x, double y)
        {
            return 0.0;
        }
        private double Up_2(double x, double y)
        {
            return 0.0;
        }
        private double Right_2(double x, double y)
        {
            return 0.0;
        }
        private double Bottom_2(double x, double y)
        {
            return 0.0;
        }

        // Границы 3-го рода - ДОДЕЛАТЬ
        private double Left_3(double x, double y)
        {
            return 0.0;
        }
        private double Up_3(double x, double y)
        {
            return 0.0;
        }
        private double Right_3(double x, double y)
        {
            return 0.0;
        }
        private double Bottom_3(double x, double y)
        {
            return 0.0;
        }
    }
}
