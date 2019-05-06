using System.Collections;
using System.Collections.Generic;

namespace NET.S._2019.Houzich._13.Queue
{
    public class QueueEnumerator<T> : IEnumerator<T>
    {
        private List<T> _queue = new List<T>();
        private int _current = -1;

        public QueueEnumerator(List<T> queue)
        {
            this._queue = queue;
        }

        public T Current => this._queue[_current];

        object IEnumerator.Current => this._queue[_current];

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            this._current++;
            return this._current < this._queue.Count;
        }

        public void Reset()
        {
        }
    }
}
