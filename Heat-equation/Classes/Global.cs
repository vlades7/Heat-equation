using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heat_equation.Classes
{
    public static class Global
    {
        public static double Lx = 2.0;                 // Длина пластины
        public static double Ly = 3.0;                 // Ширина пластины

        public static double Q1 = -4.0;                // Тепловой поток слева
        public static double Q2 = -4.0;                // Тепловой поток сверху
        public static double Q3 = 4.0;                 // Тепловой поток справа
        public static double Q4 = 4.0;                 // Тепловой поток снизу

        public static double Lamda = 1.51;             // Коэффициент теплопроводности (бетон)
        public static double A = 0.000619;             // Коэффициент температуропроводности (бетон)
        public static double Alpha = 23.0;             // Коэффициент теплообмена(теплоотдачи) (бетон)

        public static double Tout1 = 10.0;             // Температура снаружи слева
        public static double Tout2 = 10.0;             // Температура снаружи сверху
        public static double Tout3 = 10.0;             // Температура снаружи справа
        public static double Tout4 = 10.0;             // Температура снаружи снизу

        public static double Hx = 0.2;                 // Шаг по OX
        public static double Hy = 0.2;                 // Шаг по OY
        public static double Tau = 0.1;                // Шаг по времени

        public static double Zx = Alpha * Hx / Lamda;  
        public static double Zy = Alpha * Hy / Lamda;
    }
}
