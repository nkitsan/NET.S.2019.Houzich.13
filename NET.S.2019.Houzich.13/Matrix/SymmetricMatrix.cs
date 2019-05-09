using System;
using System.Collections.Generic;

namespace NET.S._2019.Houzich._13.Matrix
{
    public class SymmetricMatrix<T> : SquareMatrix<T>
    {
        public SymmetricMatrix(int n) : base(n)
        {
        }

        public override void Set(int i, int j, T element, bool silent = false)
        {
            base.Set(i, j, element, silent);

            if (i != j)
            {
                base.Set(j, i, element, silent);
            }
        }
    }
}
