namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);




            Node<int> node = list.First();

            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.next;
            }

            Console.WriteLine("------------------------------------------------------");

            list.ReverseList();

            Node<int> node2 = list.First();

            while (node2 != null)
            {
                Console.WriteLine(node2.value);
                node2 = node2.next;
            }
        }
    }
}