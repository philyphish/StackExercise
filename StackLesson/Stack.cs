using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLesson
{
    public class Stack
    {
        public List<int> numbers { get; set; }

        public Stack()
        {
            numbers = new List<int>();

        }

        public void Push(object obj)
        {
            numbers.Add((int) obj);
        }

        public object Pop()
        {
            return numbers;

        }

        void Clear()
        {

        }
    }
}
