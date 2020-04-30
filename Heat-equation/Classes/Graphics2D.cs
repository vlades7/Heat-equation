using System;
using System.Threading;
using System.ComponentModel;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using OpenTK.Input;

namespace Heat_equation.Classes
{
    class Graphics2D : GameWindow
    {
        public HeatPoint[,] Points { get; set; } = null;
        public int SizeX { get; set; }
        public int SizeY { get; set; }
        public double MaxU { get; set; }
        public double MinU { get; set; }

        private Calculation mathSolver;
        private delegate void Method(int x, int y);
        private Method methodDraw;
  
        public Graphics2D(string title = "Graphics window", int width = 800, int height = 600)
        {
            Title = title;
            Width = width;
            Height = height;

            mathSolver = new Calculation();
            mathSolver.Init();
            InitValues(mathSolver.Unew);
        }

        public Graphics2D(double[,] arr, string title = "Graphics window", int width = 800, int height = 600)
        {
            Title = title;
            Width = width;
            Height = height;

            mathSolver = new Calculation();
            mathSolver.Init();
            InitValues(mathSolver.Unew);
        }

        protected override void OnLoad(EventArgs e)
        {
            VSync = VSyncMode.Off;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            if (Global.SaveFile)
            {
                mathSolver.SaveState();
            }
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
            Draw();
            Title = string.Format("Tau = {0} Iteration = {1} Fps = {2:f1}", Global.Tau, mathSolver.NumIteration, RenderFrequency);
            SwapBuffers();
        }

        protected override void OnMouseMove(MouseMoveEventArgs e)
        {
            int x = (int)Math.Truncate((double)(SizeX - 1) * e.X / Width);
            int y = (int)Math.Truncate((double)(SizeY - 1) * e.Y / Height);
            if (e.Mouse.IsButtonDown(MouseButton.Left))
            {
                HeatPointDraw(x, y, MaxU);
            }
            if (e.Mouse.IsButtonDown(MouseButton.Right))
            {   
                HeatPointDraw(x, y, MinU);
            }
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            int x = (int)Math.Truncate((double)(SizeX - 1) * e.X / Width);
            int y = (int)Math.Truncate((double)(SizeY - 1) * e.Y / Height);
            if (e.Mouse.IsButtonDown(MouseButton.Left))
            {
                HeatPointDraw(x, y, MaxU);
            }
            if (e.Mouse.IsButtonDown(MouseButton.Right))
            {
                HeatPointDraw(x, y, MinU);
            }
            if (e.Mouse.IsButtonDown(MouseButton.Middle))
            {
                if ((0 <= x) && (x < SizeX) && (0 <= y) && (y < SizeY))
                {
                    Title = string.Format("Temp = {0:f5}", mathSolver.U[x, y]);
                    Thread.Sleep(2000);
                }
            }
        }

        protected override void OnMouseWheel(MouseWheelEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (Global.SizePoint < (SizeX & SizeY) / 4)
                {
                    Global.SizePoint += 1;
                }
            }
            else
            {
                if (Global.SizePoint > 1)
                {
                    Global.SizePoint -= 1;
                }
            }
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

        private void Draw()
        {
            mathSolver.CalcIteration();
            GetTemp(mathSolver.U);
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    methodDraw(i, j);
                }
            }
        }

        private void DrawPixel(int x, int y)
        {
            float value = (float)((Points[x, y].U - MinU) / (MaxU - MinU));
            float cR = 0, cG = 0, cB = 0;
            GetColor(value, ref cR, ref cG, ref cB);
            GL.Begin(PrimitiveType.Points);
                GL.Color3(cR, cG, cB);
                GL.Vertex2(x, y);
            GL.End();
        }

        private void DrawRect(int x, int y)
        {
            float value = (float)((Points[x, y].U - MinU) / (MaxU - MinU));
            float cR = 0, cG = 0, cB = 0;
            GetColor(value, ref cR, ref cG, ref cB);
            GL.Begin(PrimitiveType.Quads);
                GL.Color3(cR, cG, cB);
                GL.Vertex2(x * Width / SizeX, y * Height / SizeY); 
                GL.Vertex2((x + 1) * Width / SizeX, y * Height / SizeY); 
                GL.Vertex2((x + 1) * Width / SizeX, (y + 1) * Height / SizeY); 
                GL.Vertex2(x * Width / SizeX, (y + 1) * Height / SizeY);
            GL.End();
        }

        private void GetColor(float value, ref float R, ref float G, ref float B)
        {
            if (0.0f <= value && value < 0.2f)
            {
                G = value * 5.0f;
                B = 1.0f;
            }
            else if (0.2f <= value && value < 0.4f)
            {
                G = 1.0f;
                B = 1.0f - (value - 0.2f) * 5.0f;
            }
            else if (0.4f <= value && value < 0.6f)
            {
                G = 1.0f;
                B = (value - 0.4f) * 5.0f;
            }
            else if (0.6f <= value && value < 0.8f)
            {
                R = 1.0f;
                G = 1.0f - (value - 0.6f) * 5.0f;
            }
            else
            {
                R = 1.0f;
                G = (value - 0.8f) * 5.0f;
                B = G;
            }
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

        private void HeatPointDraw(int x, int y, double value)
        {
            for (int i = -Global.SizePoint; i < Global.SizePoint; i++)
            {
                for (int j = -Global.SizePoint; j < Global.SizePoint; j++)
                {
                    if ((0 <= x + i) && (x + i < SizeX) && (0 <= y + j) && (y + j < SizeY))
                    {
                        mathSolver.U[x + i, y + j] = value;
                    }
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
