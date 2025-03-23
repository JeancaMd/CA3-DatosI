using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1
{
    class Program
    {
        static void Main()
        {
            Pila<string> pila1 = new Pila<string>();
            pila1.Push("Abcd");
            pila1.Push("Ekd");
            pila1.Pop();
            pila1.Push("Dmsn");
            pila1.Show();

            Pila<int> pila2 = new Pila<int>();
            pila2.Push(40);
            pila2.Push(30);
            pila2.Push(20);
            pila2.Show();
            Console.WriteLine(pila2.Top());


            Queue<string> pila3 = new Queue<string>();
            pila3.Enqueue("Abcd");
            pila3.Enqueue("Ekd");
            pila3.Dequeue();
            pila3.Enqueue("Dmsn");
            pila3.Show();

            Queue<int> pila4 = new Queue<int>();
            pila4.Enqueue(40);
            pila4.Enqueue(30);
            pila4.Enqueue(20);
            pila4.Show();
            Console.WriteLine(pila4.Front());
        }
    }
}
