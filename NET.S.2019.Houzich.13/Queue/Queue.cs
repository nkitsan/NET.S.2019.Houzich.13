using System;
using System.Collections;
using System.Collections.Generic;

namespace NET.S._2019.Houzich._13.Queue
{
    public class Queue<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
