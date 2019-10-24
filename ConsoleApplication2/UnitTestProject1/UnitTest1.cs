using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestStack
    {
        [TestMethod]
        public void TestPush()
        {
            //push 3 items, check Count 
            Stack s = new Stack(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Count());
        }
         [TestMethod]
        public void TestPop()
        {
            Stack s = new Stack(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Pop());
            Assert.AreEqual(2, s.Pop());
        }
         [TestMethod]
        public void TestPeek()
        {
            Stack s = new Stack(3);
            s.Push(1);
            s.Push(2);
            s.Push(3);
            Assert.AreEqual(3, s.Peek());
            Assert.AreEqual(3, s.Peek());
        }
         [TestMethod]
        public void TestClear()
         {
             Stack s = new Stack(3);
             s.Push(1);
             s.Push(2);
             s.Push(3);
             s.Clear();
             Assert.AreEqual(3, s.Count());
            
         }
    }
}
