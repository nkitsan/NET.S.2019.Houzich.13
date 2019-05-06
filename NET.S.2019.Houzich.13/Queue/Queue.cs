using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace NET.S._2019.Houzich._13.Queue
{
    public class Queue<T> : IEnumerable<T>
    {
        private List<T> _elements = new List<T>();

        public void Enqueue(T element)
        {
            _elements.Add(element);
        }

        public T Peak()
        {
            return _elements.FirstOrDefault();
        }

        public T Dequeue()
        {
            var el = _elements.FirstOrDefault();
            if (_elements.Count > 0)
            {
                _elements.RemoveAt(0);
            }
            return el;
        }

        public void Clear()
        {
            _elements.Clear();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new QueueEnumerator<T>(_elements);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
