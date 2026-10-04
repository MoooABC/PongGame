using SkiaSharp;

namespace Ball
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    public class Paddle
    {
        private int[] p;
        private Direction direction;
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
            switch (direction)
            {
                case Direction.Up:
                    p[1] -= speed;
                    break;
                case Direction.Down:
                    p[1] += speed;
                    break;
                case Direction.Left:
                    p[0] -= speed;
                    break;
                case Direction.Right:
                    p[0] += speed;
                    break;
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


        public void Up() => direction = Direction.Up;
        public void Down() => direction = Direction.Down;
        public void Left() => direction = Direction.Left;
        public void Right() => direction = Direction.Right;

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