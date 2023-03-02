using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGroupProject_106
{
    internal class Bulatov
    {
        int count = 0;
        public int Count { get => count; }
        public Bulatov() { }

        public Bulatov(int count) {
            this.count = count;
        }

        public void Step(int value = 1)
        {
            count += value;
        }
    }
}
