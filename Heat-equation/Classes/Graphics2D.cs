using OpenTK;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;
using System.ComponentModel;

namespace Heat_equation.Classes
{
    class Graphics2D : GameWindow
    {
        public HeatPoint[,] Points { get; set; } = null;
        public int SizeX { get; set; }
        public int SizeY { get; set; }

        public double MaxU { get; set; }
        public double MinU { get; set; }

        private Calculation testCalc;
        private delegate void Method(int x, int y);
        private Method methodDraw;

        public Graphics2D(string title = "Graphics window", int width = 800, int height = 600)
        {
            Title = title;
            Width = width;
            Height = height;

            testCalc = new Calculation();
        }

        public Graphics2D(double[,] arr, string title = "Test", int width = 800, int height = 600)
        {
            Title = title;
            Width = width;
            Height = height;

            SizeX = arr.GetLength(0);
            SizeY = arr.GetLength(1);
            Points = new HeatPoint[SizeX, SizeY];

            int x = 0;
            int y = 0;
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    x = (int)Math.Truncate((double)(Width - 1) * (i - 0) / SizeX);
                    y = (int)Math.Truncate((double)(Height - 1) * (j - 0) / SizeY);
                    Points[i, j] = new HeatPoint(x, y, arr[i, j]);
                }
            }
            MinU = 0.0;
            MaxU = 250.0;
        }


        protected override void OnLoad(EventArgs e)
        {
            VSync = VSyncMode.Off;
            testCalc.Init();
            InitValues(testCalc.Unew);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Console.Write("EXIT HAS DONE\n");
        }

        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            GL.MatrixMode(MatrixMode.Projection);  //  Создать ортографическую проекцию
            GL.LoadIdentity();
            GL.Ortho(0.0, Width, Height, 0.0, -1.0, 1.0);
            GL.MatrixMode(MatrixMode.Modelview); //  Вернуться назад к модельной проекции
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            KeyboardState input = Keyboard.GetState();
            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
        }


        protected override void OnRenderFrame(FrameEventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            testCalc.CalcIteration();
            GetTemp(testCalc.U);
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    methodDraw(i, j);
                }
            }
            Title = string.Format("Tau = {0} Iteration = {1} Fps = {2:f1}", Global.Tau, testCalc.NumIteration, RenderFrequency);
            SwapBuffers();
        }

        private void InitValues(double[,] arr)
        {
            SizeX = arr.GetLength(0);
            SizeY = arr.GetLength(1);
            Points = new HeatPoint[SizeX, SizeY];

            if (SizeX < Width || SizeY < Height)
            {
                methodDraw = DrawRect;
            }
            else
            {
                methodDraw = DrawPixel;
            }

            int x = 0;
            int y = 0;
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    x = (int)Math.Truncate((double)(Width - 1) * (i - 0) / SizeX);
                    y = (int)Math.Truncate((double)(Height - 1) * (j - 0) / SizeY);
                    Points[i, j] = new HeatPoint(x, y, arr[i, j]);
                }
            }
            MinU = Global.MinTemp;
            MaxU = Global.MaxTemp;
        }

        private void DrawPixel(int x, int y)
        {
            float value = (float)((Points[x, y].U - MinU) / (MaxU - MinU));
            float cR = 0, cG = 0, cB = 0;
            if (0.0f <= value && value < 0.2f)
            {
                cG = value * 5.0f;
                cB = 1.0f;
            }
            else if (0.2f <= value && value < 0.4f)
            {
                cG = 1.0f;
                cB = 1.0f - (value - 0.2f) * 5.0f;
            }
            else if (0.4f <= value && value < 0.6f)
            {
                cG = 1.0f;
                cB = (value - 0.4f) * 5.0f;
            }
            else if (0.6f <= value && value < 0.8f)
            {
                cR = 1.0f;
                cG = 1.0f - (value - 0.6f) * 5.0f;
            }
            else
            {
                cR = 1.0f;
                cG = (value - 0.8f) * 5.0f;
                cB = cG;
            }
            GL.Begin(PrimitiveType.Points);
                GL.Color3(cR, cG, cB);
                GL.Vertex2(x, y);
            GL.End();
        }

        private void DrawRect(int x, int y)
        {
            //float redColor = (float)((Points[x, y].U - MinU) / (MaxU - MinU));
            //float blueColor = 1 - redColor;
            float value = (float)((Points[x, y].U - MinU) / (MaxU - MinU));
            float cR = 0, cG = 0, cB = 0;
            if (0.0f <= value && value < 0.2f)
            {
                cG = value * 5.0f;
                cB = 1.0f;
            }
            else if (0.2f <= value && value < 0.4f)
            {
                cG = 1.0f;
                cB = 1.0f - (value - 0.2f) * 5.0f;
            }
            else if (0.4f <= value && value < 0.6f)
            {
                cG = 1.0f;
                cB = (value - 0.4f) * 5.0f;
            }
            else if (0.6f <= value && value < 0.8f)
            {
                cR = 1.0f;
                cG = 1.0f - (value - 0.6f) * 5.0f;
            }
            else
            {
                cR = 1.0f;
                cG = (value - 0.8f) * 5.0f;
                cB = cG;
            }
            GL.Begin(PrimitiveType.Quads);
                GL.Color3(cR, cG, cB);
                GL.Vertex2(x * Width / SizeX, y * Height / SizeY); 
                GL.Vertex2((x + 1) * Width / SizeX, y * Height / SizeY); 
                GL.Vertex2((x + 1) * Width / SizeX, (y + 1) * Height / SizeY); 
                GL.Vertex2(x * Width / SizeX, (y + 1) * Height / SizeY);
            GL.End();
        }

        private void GetTemp(double[,] arr)
        {
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    Points[i, j].U = arr[i, j];
                }
            }
        }

        private void FindMaxMinU()
        {
            MaxU = Points[0, 0].U;
            MinU = MaxU;
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    if (MaxU < Points[i, j].U)
                    {
                        MaxU = Points[i, j].U;
                    }
                    if (MinU > Points[i, j].U)
                    {
                        MinU = Points[i, j].U;
                    }
                }
            }
        }
    }
}
