using NUnit.Framework;
using Custom = NET.S._2019.Houzich._13;
using System.Collections.Generic;

namespace Tests
{
    public class QueueTests
    {
        [Test]
        public void QueueEnumeratorTest()
        {
            var expected = new List<string>() { "a", "b", "c", "d", "e", "f" };
            var actual = new List<string>();
            var queue = new Custom.Queue.Queue<string>();

            foreach (var el in expected)
            {
                queue.Enqueue(el);
            }

            foreach (var el in queue)
            {
                actual.Add(el);
            }

            Assert.AreEqual(expected, actual);
        }
    }
}