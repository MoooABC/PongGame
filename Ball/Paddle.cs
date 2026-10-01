using SkiaSharp;

namespace Ball
{
    public class Paddle
    {
        private int[] p;
        private bool isUp = true;
        private ushort speed;
        private SKColor color;

        private ushort[] size;

        public Paddle(int[] _p, ushort _speed, SKColor _color, ushort[] _size)
        {
            this.p = _p;
            this.speed = _speed;
            this.color = _color;
            this.size = _size;
        }


        public void Move()
        {
            if (isUp)
            {
                p[1] -= speed;
            }
            else
            {
                p[1] += speed;
            }
        }

        public void Update(int screenWidth, int screenHeight)
        {
            Move();

            if (p[1] < 0)
            {
                p[1] = 0;
            }
            else if (p[1] + size[1] > screenHeight)
            {
                p[1] = screenHeight - size[1];
            }
        }


        public void Up() => isUp = true;
        public void Down() => isUp = false;

        public int[] GetPosition() => p;
        public ushort[] GetSize() => size;

        public ushort GetSpeed() => speed;
        public void SetSpeed(ushort _speed) => speed = _speed;

        public void SetPosition(int[] _p) => p = _p;

        public void Render(SKCanvas canvas)
        {
            canvas.DrawRect(p[0], p[1], size[0], size[1], new SKPaint() { Style = SKPaintStyle.Fill, Color = color });
        }
    }
}