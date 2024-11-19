using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class MinHeap<T> where T : IComparable
    {
        private List<T> elements = new List<T>();

        public int Count => elements.Count;

        public void Insert(T item)
        {
            elements.Add(item);
            HeapifyUp(elements.Count - 1);
        }

        public T ExtractMin()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Heap is empty");

            T min = elements[0];
            elements[0] = elements[^1]; // Replace root with last element
            elements.RemoveAt(elements.Count - 1);

            HeapifyDown(0);
            return min;
        }

        public T Peek()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Heap is empty");

            return elements[0];
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;

                if (elements[index].CompareTo(elements[parentIndex]) >= 0)
                    break;

                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

        private void HeapifyDown(int index)
        {
            while (index < elements.Count)
            {
                int leftChildIndex = 2 * index + 1;
                int rightChildIndex = 2 * index + 2;
                int smallest = index;

                if (leftChildIndex < elements.Count && elements[leftChildIndex].CompareTo(elements[smallest]) < 0)
                    smallest = leftChildIndex;

                if (rightChildIndex < elements.Count && elements[rightChildIndex].CompareTo(elements[smallest]) < 0)
                    smallest = rightChildIndex;

                if (smallest == index)
                    break;

                Swap(index, smallest);
                index = smallest;
            }
        }

        private void Swap(int index1, int index2)
        {
            T temp = elements[index1];
            elements[index1] = elements[index2];
            elements[index2] = temp;
        }
    }

}
