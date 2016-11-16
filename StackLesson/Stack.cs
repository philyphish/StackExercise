using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLesson
{
    public class Stack
    {
        public int numbers { get; set; }
        public void Push(object obj)
        {
            numbers = (int)obj;
        }

        public object Pop()
        {
            var stack = new Stack();

            return numbers;

        }

        void Clear()
        {

        }
    }
}
