using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text15._05
{
    class MyUniqueList
    {
        //Test - Part 2: Question 3

        List<int> list = new List<int>();

        public MyUniqueList()
        {

        }

        public bool Add(int item)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
                throw new ItemNotFoundException($"{item} Has Not Been Found!");
            }

            throw new ItemAlreadyExistException($"{item} Already Exist!");
        }

        public bool Remove(int item)
        {
            if (list.Contains(item))
            {
                list.Remove(item);
                throw new IndexOutOfRangeException($"{item} is Out of Range!");
            }

            throw new ItemNotFoundException($"{item} Has Not Been Found!");
        }

        public int Peek(int index)
        {
            return list[index];
        }

        public int this[int index]
        {
            get
            {
                return this.list[index];
            }
            set
            {
                if (list[index] == value)
                    return;
                if (list.Contains(value))
                    return;
                list[index] = value;
            }
        }
    }
}