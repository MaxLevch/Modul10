using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public interface ILogger
    {
        void Event(int sum);
        void Error(string message);
    }
}
