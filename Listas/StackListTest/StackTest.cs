using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace StackListTest
{
    [TestClass]
    public sealed class StackTest
    {
        [TestMethod]
        public void PushTest()
        {
            //Arrange
            Pila<int> stack = new Pila<int>();

            //Act
            stack.Push(40);
            stack.Push(30);
            stack.Push(20);

            //Assert
            Assert.AreEqual(3, stack.Count(), "La lista es de tamaño 3");
        }

        [TestMethod]
        public void PopTest()
        {
            //Arrange
            Pila<int> stack = new Pila<int>();
            stack.Push(40);
            stack.Push(30);
            stack.Push(20);

            //Act
            int value = stack.Pop();

            //Assert
            Assert.AreEqual(20, value, "El valor eliminado es 20");
            Assert.AreEqual(2, stack.Count(), "La lista es de tamaño 2");
        }

        [TestMethod]
        public void ErrorPopTest()
        {
            //Arrange
            Pila<int> stack = new Pila<int>();

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => stack.Pop(), "Da eror si la pila esta vacia");

        }

        [TestMethod]
        public void TopTest()
        {
            //Arrange
            Pila<int> stack = new Pila<int>();
            stack.Push(40);
            stack.Push(30);
            stack.Push(20);

            //Act
            int value = stack.Top();

            //Assert
            Assert.AreEqual(20, value, "El ultimo agregado es 20");
            Assert.AreEqual(3, stack.Count(), "La lista es de tamaño 3");
        }

        [TestMethod]
        public void ErrorTopTest()
        {
            //Arrange
            Pila<int> stack = new Pila<int>();

            //Assert
            Assert.ThrowsException<InvalidOperationException>(() => stack.Top(), "Da eror si la pila esta vacia");
        }
    }
}