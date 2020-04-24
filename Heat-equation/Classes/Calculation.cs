﻿using System;
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
                U[SizeX - 1, i] = Right_1(Global.Lx, i * Global.Hy);
            }

            for (int i = 0; i < SizeX; i++)
            {
                U[i, 0] = Up_1(i * Global.Hx, Global.Ly);
                U[i, SizeY - 1] = Bottom_1(i * Global.Lx, 0.0);
            }

            Copy(U, Unew);
        }

        // Основное итерационное вычисление
        public void Calc()
        {
            for (int k = 0; k < Global.MaxIteration; k++)
            {
                //SimpleAlgorithm();
                ContourAlgorithm();

                Copy(Unew, U);
            }
        }

        // Напечатать текущее состояние
        public void Print(RichTextBox rtb)
        {
            for (int j = 0; j < SizeY; j++)
            {
                for (int i = 0; i < SizeX; i++)
                {
                    string str = string.Format("{0:f4}", U[i, j]);
                    rtb.AppendText(str + "   ");
                }
                rtb.AppendText(Environment.NewLine);
            }
        }

        // Последовательный расчет
        private void SimpleAlgorithm()
        {
            for (int i = 1; i < SizeX - 1; i++)
            {
                for (int j = 1; j < SizeY - 1; j++)
                {
                    Unew[i, j] = MainFormula(i, j);
                }
            }

            // Пересчет границ с учетом теполового потока
            switch (Global.IndexTypeBorders)
            {
                case 1:
                    Borders_2();
                    break;
                case 2:
                    Borders_3();
                    break;
                default:
                    break;
            }
        }

        // Проход по контурам
        private void ContourAlgorithm()
        {
            // Временные границы для движения к центру пластины
            int left = 1;
            int up = 1;
            int right = SizeX - 1;
            int bottom = SizeY - 1;

            // Внешний контур
            switch (Global.IndexTypeBorders)
            {
                case 1:
                    Borders_2();
                    break;
                case 2:
                    Borders_3();
                    break;
                default:
                    break;
            }

            // Внутренние контуры
            while ((bottom - up > 1) && (right - left > 1))
            {
                for (int i = up; i < bottom; i++)
                {
                    Unew[left, i] = MainFormula(left, i);
                    Unew[right - 1, i] = MainFormula(right - 1, i);
                }
                for (int i = left; i < right; i++)
                {
                    Unew[i, up] = MainFormula(i, up);
                    Unew[i, bottom - 1] = MainFormula(i, bottom - 1);
                }
                // Сдвиг временных границ к центру
                left++;
                up++;
                right--;
                bottom--;
            }

            // Остаток
            for (int i = left; i < right; i++)
            {
                for (int j = up; j < bottom; j++)
                {
                    Unew[i, j] = MainFormula(i, j);
                }
            }
        }

        // Копирование массивов
        private void Copy(double[,] sourceArr, double[,] destinationArr)
        {
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    destinationArr[i, j] = sourceArr[i, j];
                }
            }
        }

        // Основная расчетная формула пятиточечного шаблона
        private double MainFormula(int i, int j)
        {
            return U[i, j] + Global.A * Global.A * Global.Tau * 
                ((U[i + 1, j] + U[i - 1, j] - 2 * U[i, j]) / (Global.Hx * Global.Hx) +
                        (U[i, j + 1] + U[i, j - 1] - 2 * U[i, j]) / (Global.Hy * Global.Hy)) + 
                        Global.Tau * ExtraFunc(i, j);
        }

        // Функция, описывающая возможное дополнительное воздействие
        private double ExtraFunc(int i, int j)
        {
            return 0.0;
        }

        // Рассчет внутренней области
        private double Fx(double x = 0.0, double y = 0.0)
        {
            return x + y;
        }

        // Вычисление границ 2-го рода
        private void Borders_2()
        {
            for (int i = 0; i < SizeY; i++)
            {
                Unew[0, i] = Left_2(i);
                Unew[SizeX - 1, i] = Right_2(i);
            }
            for (int i = 0; i < SizeX; i++)
            {
                Unew[i, 0] = Up_2(i);
                Unew[i, SizeY - 1] = Bottom_2(i);
            }
        }

        // Вычисление границ 3-го рода
        private void Borders_3()
        {
            // Границы без углов
            for (int i = 1; i < SizeY - 1; i++)
            {
                Unew[0, i] = Left_3(i);
                Unew[SizeX - 1, i] = Right_3(i);
            }
            for (int i = 1; i < SizeX - 1; i++)
            {
                Unew[i, 0] = Up_3(i);
                Unew[i, SizeY - 1] = Bottom_3(i);
            }

            // Угловые точки
            Unew[0, 0] = LeftUp_3(U);
            Unew[0, SizeY - 1] = LeftBottom_3(U);
            Unew[SizeX - 1, 0] = RightUp_3(U);
            Unew[SizeX - 1, SizeY - 1] = RightBottom_3(U);
        }

        #region Границы 1-го рода
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
        #endregion

        #region Границы 2-го рода
        private double Left_2(int i)
        {
            return U[1, i] + Global.Q1 * Global.Hx / Global.Lamda;
        }
        
        private double Up_2(int i)
        {
            return U[i, 1] + Global.Q2 * Global.Hy / Global.Lamda;
        }

        private double Right_2(int i)
        {
            return U[SizeX - 2, i] + Global.Q3 * Global.Hx / Global.Lamda;
        }

        private double Bottom_2(int i)
        {
            return U[i, SizeY - 2] + Global.Q4 * Global.Hy / Global.Lamda;
        }
        #endregion

        #region Границы 3-го рода
        private double Left_3(int i)
        {
            return (U[1, i] * Global.Lamda + Global.Alpha1 * Global.Hx * Global.Tout1) / (Global.Lamda + Global.Alpha1 * Global.Hx);
        }

        private double Up_3(int i)
        {
            return (U[i, 1] * Global.Lamda + Global.Alpha2 * Global.Hy * Global.Tout2) / (Global.Lamda + Global.Alpha2 * Global.Hy); ;
        }

        private double Right_3(int i)
        {
            return (U[SizeX - 2, i] * Global.Lamda + Global.Alpha3 * Global.Hx * Global.Tout3) / (Global.Lamda + Global.Alpha3 * Global.Hx);
        }
        
        private double Bottom_3(int i)
        {
            return (U[i, SizeY - 2] * Global.Lamda + Global.Alpha4 * Global.Hy * Global.Tout4) / (Global.Lamda + Global.Alpha4 * Global.Hy);
        }

        // Угловые точки
        private double LeftUp_3(double[,] T)
        {
            return 0.5 * ((Global.Lamda * T[1, 0] + Global.Alpha1 * Global.Tout1 * Global.Hx) / (Global.Lamda + Global.Alpha1 * Global.Hx) +
                (Global.Lamda * T[0, 1] + Global.Alpha2 * Global.Tout2 * Global.Hy) / (Global.Lamda + Global.Alpha2 * Global.Hy));
        }

        private double RightUp_3(double[,] T)
        {
            return 0.5 * ((Global.Lamda * T[SizeX - 1, 1] + Global.Alpha2 * Global.Tout2 * Global.Hy) / (Global.Lamda + Global.Alpha2 * Global.Hy) +
                (Global.Lamda * T[SizeX - 2, 0] + Global.Alpha3 * Global.Tout3 * Global.Hx) / (Global.Lamda + Global.Alpha3 * Global.Hx));
        }

        private double LeftBottom_3(double[,] T)
        {
            return 0.5 * ((Global.Lamda * T[1, SizeY - 1] + Global.Alpha1 * Global.Tout1 * Global.Hx) / (Global.Lamda + Global.Alpha1 * Global.Hx) +
                (Global.Lamda * T[0, SizeY - 2] + Global.Alpha4 * Global.Tout4 * Global.Hy) / (Global.Lamda + Global.Alpha4 * Global.Hy));
        }

        private double RightBottom_3(double[,] T)
        {
            return 0.5 * ((Global.Lamda * T[SizeX - 2, SizeY - 1] + Global.Alpha3 * Global.Tout3 * Global.Hx) / (Global.Lamda + Global.Alpha3 * Global.Hx) +
                (Global.Lamda * T[SizeX - 1, SizeY - 2] + Global.Alpha4 * Global.Tout4 * Global.Hy) / (Global.Lamda + Global.Alpha4 * Global.Hy));
        }
        #endregion
    }
}
