using System;
using System.Collections.Generic;

namespace NET.S._2019.Houzich._13.Matrix
{
    public class DiagonalMatrix<T> : SquareMatrix<T>
    {
        public DiagonalMatrix(int n) : base(n)
        {
        }

        public override void Set(int i, int j, T element, bool silent = false)
        {
            if (i == j)
            {
                base.Set(j, i, element, silent);
            }
        }
    }
}
