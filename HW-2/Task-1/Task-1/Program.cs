namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[500];
            FillRandomArray(array);
            Sort(array);

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }



            void FillRandomArray(int[] array)
            {
                Random r = new Random();
                for(int i = 0; i < array.Length; i++)
                {
                    array[i] = r.Next(0, array.Length);
                }
            } 

            void Sort(int[] array)
            {
                for(int i = array.Length / 2 -1; i >= 0; i--)
                    Heapify(array, array.Length, i);

                for(int i = array.Length - 1; i >= 0; i--)
                {
                    int temp = array[0];
                    array[0] = array[i];
                    array[i] = temp;

                    Heapify(array, i, 0);
                }
            }

            void Heapify(int[] array, int heapSize, int rootIndex)
            {
                int largest = rootIndex;
                int leftChild = 2 * rootIndex + 1;
                int rightChild = 2 * rootIndex + 2;

                if(leftChild < heapSize && array[leftChild] > array[largest])
                    largest = leftChild;

                if(rightChild < heapSize && array[rightChild] > array[largest])
                    largest = rightChild;

                if(largest != rootIndex)
                {
                    int temp = array[rootIndex];
                    array[rootIndex] = array[largest];
                    array[largest] = temp;

                    Heapify(array, heapSize, largest);
                }
            }
        }
    }
}