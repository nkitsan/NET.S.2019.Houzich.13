using NUnit.Framework;
using NET.S._2019.Houzich._13.Matrix;

namespace Tests
{
    public class MatrixTests
    {
        [Test]
        public void SumSquareMatrixTest()
        {
            var matrix = new SquareMatrix<int>(5);
            for (int i = 0; i < 5; i++)
            {
                matrix.Set(0, i, i);
            }

            var expected = new SquareMatrix<int>(5);
            for (int i = 0; i < 5; i++)
            {
                expected.Set(0, i, 2*i);
            }


            var result = matrix.Add(matrix);

            Assert.AreEqual(expected.Get(0, 0), result.Get(0, 0));
            Assert.AreEqual(expected.Get(0, 1), result.Get(0, 1));
            Assert.AreEqual(expected.Get(0, 2), result.Get(0, 2));
            Assert.AreEqual(expected.Get(0, 3), result.Get(0, 3));
            Assert.AreEqual(expected.Get(0, 4), result.Get(0, 4));
        }

        [Test]
        public void SumSymmetricMatrixTest()
        {
            var matrix = new SymmetricMatrix<int>(5);
            for (int i = 0; i < 5; i++)
            {
                matrix.Set(i, 0, i);
            }

            var expected = new SymmetricMatrix<int>(5);
            for (int i = 0; i < 5; i++)
            {
                expected.Set(i, 0, 2 * i);
            }


            var result = matrix.Add(matrix);

            Assert.AreEqual(expected.Get(0, 0), result.Get(0, 0));
            Assert.AreEqual(expected.Get(0, 1), result.Get(0, 1));
            Assert.AreEqual(expected.Get(0, 2), result.Get(0, 2));
            Assert.AreEqual(expected.Get(0, 3), result.Get(0, 3));
            Assert.AreEqual(expected.Get(0, 4), result.Get(0, 4));
        }

        [Test]
        public void SumDiagonalMatrixTest()
        {
            var matrix = new DiagonalMatrix<int>(5);
            for (int i = 0; i < 5; i++)
            {
                matrix.Set(i, i, i);
            }

            var expected = new DiagonalMatrix<int>(5);
            for (int i = 0; i < 5; i++)
            {
                expected.Set(i, i, 2 * i);
            }


            var result = matrix.Add(matrix);

            Assert.AreEqual(expected.Get(0, 0), result.Get(0, 0));
            Assert.AreEqual(expected.Get(1, 1), result.Get(1, 1));
            Assert.AreEqual(expected.Get(2, 2), result.Get(2, 2));
            Assert.AreEqual(expected.Get(3, 3), result.Get(3, 3));
            Assert.AreEqual(expected.Get(4, 4), result.Get(4, 4));
        }
    }
}