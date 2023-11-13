using System;



    public abstract class GeometrischeFigur
    {
        protected float x;
        protected float y;

        public GeometrischeFigur(float x = 100.0f, float y = 100.0f)
        {
            this.x = x;
            this.y = y;
        }

        public void PrintPosition()
        {
            Console.WriteLine($"Position: ({x}, {y})");
        }

        public abstract void PrintArea();
        public abstract void Rotate90Degrees();
    }
