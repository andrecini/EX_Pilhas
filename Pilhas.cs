using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosSobrePilhas
{
    class Pilhas
    {
        private const int capacity = 5;
        static private Employees[] data = new Employees[capacity];
        private int top = -1;
        

        public int Size()
        {
            return top + 1;
        }

        public void Push(Employees x)
        {
            if (Size() != capacity)
            {
                top++;
                data[top] = x;
            }
            else
            {
                throw new Exception(" The stack is full. Use the method 'pop' for to free up space!");
            }
        }

        public Employees Pop()
        {
            if (Size() == 0)
            {
                throw new Exception(" The stack is empty. Use the method 'push' for add elements!");
            }
            else
            {
                Employees employ = data[top];
                Array.Clear(data, top, 1);
                top--;
                return employ;
            }
        }

        public Employees Peek()
        {
            if (Size() == 0)
            {
                throw new Exception(" The stack is empty. Use the method 'push' for add elements!");
            }
            else
            {
                return data[top];
            }
        }
    }
}
