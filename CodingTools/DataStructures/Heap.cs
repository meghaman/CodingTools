using System.Collections.Generic;
using System;

namespace CodingTools.DataStructures
{
	public class Heap
	{
		private List<int> values;

		public Heap(List<int> initialHeap)
		{
			values = new List<int>();

			foreach(int value in initialHeap)
			{
				Insert(value);
			}
		}

		public void Insert(int value)
		{
			values.Add(value);
			Heapify(values.Count - 1);
		}

		private void Heapify(int index)
		{
			if (index == 0)
				return;
			
			int parentIndex = (int)Math.Floor((decimal)(index - 1) / 2);

			if (Compare(values[index], values[parentIndex]))
			{
				int temp = values[parentIndex];
				values[parentIndex] = values[index];
				values[index] = temp;

				Heapify(parentIndex);
			}
		}

		public int Pop()
		{
			if (values.Count <= 0)
				throw new IndexOutOfRangeException();

			int root = values[0];
			
			values[0] = values[values.Count - 1];
			values.RemoveAt(values.Count - 1);

			CorrectTree(0);

			return root;
		}

		private bool Compare(int a, int b)
		{
			return a <= b;
		}

		private void CorrectTree(int currentIndex)
		{
			int lowestChild;
			int lowestChildIndex = currentIndex * 2 + 1;

			if (values.Count > currentIndex * 2 + 1)
				lowestChild = values[currentIndex * 2 + 1];
			else
				return;

			if (values.Count > currentIndex * 2 + 2 && Compare(values[currentIndex * 2 + 2], lowestChild))
			{
				lowestChild = values[currentIndex * 2 + 2];
				lowestChildIndex++;
			}

			if (Compare(lowestChild, values[currentIndex]))
			{
				int temp = values[lowestChildIndex];
				values[lowestChildIndex] = values[currentIndex];
				values[currentIndex] = temp;

				CorrectTree(lowestChildIndex);
			}
		}
	}
}
