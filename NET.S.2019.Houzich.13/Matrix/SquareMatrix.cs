using System;
using System.Collections.Generic;
using System.Linq;

namespace NET.S._2019.Houzich._13.Matrix
{
    public class SquareMatrix<T>
    {
        private readonly int _n;
        private readonly T[,] _data;

        public event EventHandler<ElementChangeEventArgs> ElementChange;

        public int N => this._n;

        public SquareMatrix(int n)
        {
            this._n = n;
            this._data = new T[n, n];
        }

        public virtual void Set(int i, int j, T element, bool silent = false)
        {
            if (i > this._n || j > this._n)
            {
                return;
            }

            this._data[i, j] = element;
            if (!silent)
            {
                OnElementChange(new ElementChangeEventArgs
                {
                    I = i,
                    J = j,
                });
            }
        }

        public T Get(int i, int j)
        {
            return this._data[i, j];
        }

        public SquareMatrix<T> Add(SquareMatrix<T> matrix)
        {
            if (N != matrix.N)
            {
                return this;
            }

            var result = new SquareMatrix<T>(N);

            for (var i = 0; i < N; i += 1)
            {
                for (var j = 0; j < N; j += 1)
                {
                    result.Set(i, j, (dynamic)this.Get(i, j) + (dynamic)matrix.Get(i, j), true);
                }
            }

            return result;
        }

        protected void OnElementChange(ElementChangeEventArgs e)
        {
            EventHandler<ElementChangeEventArgs> handler = ElementChange;
            handler?.Invoke(this, e);
        }
    }
}
