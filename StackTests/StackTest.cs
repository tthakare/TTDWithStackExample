using System;
using NUnit.Framework;
using Stack;

namespace StackTests
{
    [TestFixture]
    class StackTest
    {
        [Test]
        public void Creation()
        {
            Stack<int> s = new Stack<int>(3);
            Assert.AreEqual(0, s.Size);
        }

        [Test]
        public void Push_Pop()
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            int PopValue = stack.Pop();

            Assert.AreEqual(3, PopValue);
            Assert.AreEqual(2, stack.Size);
        }

        [Test]
        public void Too_Many_Pop()
        {
            Stack<int> stack = new Stack<int>(3);
            Assert.Throws<ExpenditureProhibitedException>(() => stack.Pop());
        }

        [Test]
        public void Too_Much_Push()
        {
            Stack<int> stack = new Stack<int>(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Assert.Throws<ExceededSizeException>(() => stack.Push(4));
        }

        [Test]
        public void Peek_Exception()
        {
            Stack<int> stack = new Stack<int>(3);

            Assert.Throws<ExpenditureProhibitedException>(() => stack.Peek());
        }

        [Test]
        public void Peek_Element()
        {
            Stack<int> stack = new Stack<int>(2);
            stack.Push(1);
            stack.Push(2);
            int peekValue = stack.Peek();

            Assert.AreEqual(2, peekValue);
            Assert.AreEqual(2, stack.Size);
        }
    }
}
