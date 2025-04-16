using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.ConcurrentProgramming.Data;

namespace TP.ConcurrentProgramming.BusinessLogic
{
    public class LogicService : ILogicService
    {
        private List<ICircle> _balls = new();
        private Random _rand = new();

        public IEnumerable<ICircle> GetBalls() => _balls;

        public void InitializeBalls(int count, double width, double height)
        {
            _balls.Clear();
            for (int i = 0; i < count; i++)
            {
                var ball = new Circle
                {
                    Radius = 10,
                    X = _rand.NextDouble() * (width - 20) + 10,
                    Y = _rand.NextDouble() * (height - 20) + 10
                };
                _balls.Add(ball);
            }
        }

        public void UpdatePositions()
        {
            foreach (var ball in _balls)
            {
                double dx = (_rand.NextDouble() - 0.5) * 10;
                double dy = (_rand.NextDouble() - 0.5) * 10;

                ball.X = Math.Max(ball.Radius, Math.Min(ball.X + dx, 800 - ball.Radius));
                ball.Y = Math.Max(ball.Radius, Math.Min(ball.Y + dy, 600 - ball.Radius));
            }
        }
    }
}
