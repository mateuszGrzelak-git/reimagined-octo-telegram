using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.ConcurrentProgramming.Data;

namespace TP.ConcurrentProgramming.BusinessLogic
{
    public interface ILogicService
    {
        IEnumerable<ICircle> GetBalls();
        void InitializeBalls(int count, double width, double height);
        void UpdatePositions();
    }
}
