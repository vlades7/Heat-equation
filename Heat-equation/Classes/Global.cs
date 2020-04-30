namespace Heat_equation.Classes
{
    public static class Global
    {
        public static double Lx = 50.0;                 // Длина пластины
        public static double Ly = 50.0;                 // Ширина пластины
        public static double Hx = 0.2;                  // Шаг по OX
        public static double Hy = 0.2;                  // Шаг по OY
        public static double Tau = 10000;               // Шаг по времени
        public static double A = 0.000619;              // Коэффициент температуропроводности (бетон)
        public static double Lamda = 1.51;              // Коэффициент теплопроводности (бетон)

        public static double T1 = -100.0;               // Температура слева
        public static double T2 = 100.0;                // Температура сверху
        public static double T3 = -100.0;               // Температура справа
        public static double T4 = 100.0;                // Температура снизу

        public static double Q1 = -4.0;                 // Тепловой поток слева
        public static double Q2 = -4.0;                 // Тепловой поток сверху
        public static double Q3 = 4.0;                  // Тепловой поток справа
        public static double Q4 = 4.0;                  // Тепловой поток снизу

        public static double Tout1 = -10.0;             // Температура снаружи слева
        public static double Tout2 = -10.0;             // Температура снаружи сверху
        public static double Tout3 = 10.0;              // Температура снаружи справа
        public static double Tout4 = 10.0;              // Температура снаружи снизу
        public static double Alpha1 = 23.0;             // Коэффициент теплообмена(теплоотдачи) слева
        public static double Alpha2 = 23.0;             // Коэффициент теплообмена(теплоотдачи) сверху
        public static double Alpha3 = 23.0;             // Коэффициент теплообмена(теплоотдачи) справа
        public static double Alpha4 = 23.0;             // Коэффициент теплообмена(теплоотдачи) снизу

        public static int LastIteration = 10000;        // Номер последней итерации
        public static int SizePoint = 3;                // Размер точечного источника тепла
        public static double MinTemp = -11.0;           // Минимальная температура для визуализации
        public static double MaxTemp = 11.0;            // Максимальная температура для визуализации

        public static int IndexTypeBorders = 2;         // Индекс выбранного типа границ

        public static bool SaveFile = false;            // Сохранять файл после вычислений
    }
}
