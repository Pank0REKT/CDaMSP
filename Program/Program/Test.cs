using System;
using NUnit.Framework;

namespace Program
{
	[TestFixture]
    public class QueueTests
    {

        [Test()]
        public void DenequeueEmptyQueueTest()
        {
            IQueue<string> queue = new DoublyLinkedListQueue<string>();
            string actual;
            Assert.Throws<NullReferenceException>(
            () => { actual = queue.Dequeue(); }
            );
        }
        [Test()]
        public void EnqueueElementInQueueTest()
        {
            IQueue<string> queue = new DoublyLinkedListQueue<string>();
            string TestData = "SomeText";
            queue.Enqueue(TestData);
            Assert.NotNull(queue);
        }
        [Test()]
        public void DenequeueElementInQueueTest()
        {
            IQueue<string> queue = new DoublyLinkedListQueue<string>();
            string TestData = "SomeText";
            queue.Enqueue(TestData);
            queue.Enqueue(TestData);
            queue.Enqueue(TestData);
            string ResultData = queue.Dequeue();
            Assert.AreEqual(TestData, ResultData);
        }
        [Test()]
        public void DenequeueLastElementInQueueTest()
        {
            IQueue<string> queue = new DoublyLinkedListQueue<string>();
            string TestData = "SomeText";
            queue.Enqueue(TestData);
            queue.Dequeue();
            Assert.IsTrue(queue.IsEmpty);
        }
        [Test()]
        public void CountTest()
        {
            int ExpectedCount = 10;
            IQueue<int> queue = new DoublyLinkedListQueue<int>();
            for (int i = 0; i < ExpectedCount; i++)
            {
                queue.Enqueue(i);
            }
            Assert.AreEqual(ExpectedCount, queue.Count);
        }
    }
}
