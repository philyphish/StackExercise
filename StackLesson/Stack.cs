using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLesson
{

    public class Stack
    {
        List<object> input = new List<object>();
        private string _error = "Something went wrong";
        private int _count;

        public void Push(object obj)
        {
            
            if (input != null){
                input.Add(obj);

                _count = input.Count - 1;
               
            }
            else
            {
                throw new InvalidOperationException(_error);         
            }
        }

        public object Pop()
        {
            

            if (input.Count > 0){
                input.RemoveAt(_count);
                var holder = input[_count];

                return holder;

            }




        }

        void Clear()
        {
            
        }
    }
}
