using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salida_restringida
{
    class OutputRestrictedDeque<T>
    {
        private LinkedList<T> deque = new LinkedList<T>();

        public void AddRear(T item)
        {
            deque.AddLast(item);
        }

        public T RemoveRear()
        {
            if (deque.Count == 0)
            {
                throw new InvalidOperationException("La bicola está vacía.");
            }

            T item = deque.Last.Value;
            deque.RemoveLast();
            return item;
        }

        public int Count()
        {
            return deque.Count;
        }
    }

    internal class Program
    {

        static void Main(string[] args)
        {
            OutputRestrictedDeque<int> deque = new OutputRestrictedDeque<int>();

            deque.AddRear(1);
            deque.AddRear(2);
            deque.AddRear(3);

            Console.WriteLine("Elemento trasero removido: " + deque.RemoveRear());

            Console.WriteLine("Número de elementos en la bicola: " + deque.Count());

            Console.ReadKey();
        }


    
    }
}
