﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heat_equation.Classes
{
    public static class Global
    {
        public static double Lx = 2.0;                  // Длина пластины
        public static double Ly = 2.0;                  // Ширина пластины

        public static double Q1 = -4.0;                 // Тепловой поток слева
        public static double Q2 = -4.0;                 // Тепловой поток сверху
        public static double Q3 = 4.0;                  // Тепловой поток справа
        public static double Q4 = 4.0;                  // Тепловой поток снизу

        public static double Lamda = 1.51;              // Коэффициент теплопроводности (бетон)
        public static double A = 0.000619;              // Коэффициент температуропроводности (бетон)
        public static double Alpha1 = 23.0;             // Коэффициент теплообмена(теплоотдачи) слева
        public static double Alpha2 = 23.0;             // Коэффициент теплообмена(теплоотдачи) сверху
        public static double Alpha3 = 23.0;             // Коэффициент теплообмена(теплоотдачи) справа
        public static double Alpha4 = 23.0;             // Коэффициент теплообмена(теплоотдачи) снизу

        public static double Tout1 = 100.0;              // Температура снаружи слева
        public static double Tout2 = 240.0;              // Температура снаружи сверху
        public static double Tout3 = 0.0;              // Температура снаружи справа
        public static double Tout4 = 240.0;              // Температура снаружи снизу

        public static double Hx = 0.2;                  // Шаг по OX
        public static double Hy = 0.2;                  // Шаг по OY
        public static double Tau = 10000;                 // Шаг по времени

        public static long MaxIteration = 100000;       // Количество итераций
        public static double MinTemp = 0.0;
        public static double MaxTemp = 240.0;

        public static int IndexTypeBorders = 2;         // Индекс выбранного типа границ
    }
}
