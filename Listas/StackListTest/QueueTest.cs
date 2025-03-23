using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace StackListTest
{
    [TestClass]
    public sealed class QueueTest
    {
        [TestMethod]
        public void PushTest()
        {
            //Arrange
            Queue<int> stack = new Queue<int>();

            //Act
            stack.Enqueue(40);
            stack.Enqueue(30);
            stack.Enqueue(20);

            //Assert
            Assert.AreEqual(3, stack.Count(), "La lista es de tamaño 3");
        }

        [TestMethod]
        public void PopTest()
        {
            //Arrange
            Queue<int> stack = new Queue<int>();
            stack.Enqueue(40);
            stack.Enqueue(30);
            stack.Enqueue(20);

            //Act
            int value = stack.Dequeue();

            //Assert
            Assert.AreEqual(40, value, "El valor eliminado es el primero que entro");
            Assert.AreEqual(2, stack.Count(), "La lista es de tamaño 2");
        }

        [TestMethod]
        public void ErrorPopTest()
        {
            //Arrange
            Queue<int> stack = new Queue<int>();

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => stack.Dequeue(), "Da eror si la pila esta vacia");

        }

        [TestMethod]
        public void TopTest()
        {
            //Arrange
            Queue<int> stack = new Queue<int>();
            stack.Enqueue(40);
            stack.Enqueue(30);
            stack.Enqueue(20);

            //Act
            int value = stack.Front();

            //Assert
            Assert.AreEqual(40, value, "El primero de la cola es 40");
            Assert.AreEqual(3, stack.Count(), "La lista es de tamaño 3");
        }

        [TestMethod]
        public void ErrorTopTest()
        {
            //Arrange
            Queue<int> stack = new Queue<int>();

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => stack.Front(), "Da eror si la pila esta vacia");
        }
    }
}