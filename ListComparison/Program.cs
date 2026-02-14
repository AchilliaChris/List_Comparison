namespace List_Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var listA = new List<int> { 1, 2, 3 };
            var listB = new List<int> { 4, 5, 6 };

            Console.Write("List A contains: ");
            foreach (var number in listA)
            {
                Console.Write(number);
                Console.Write(", ");
            } ;
            Console.WriteLine();
            Console.Write("List B contains: " );
            foreach (var number in listB)
            {
                Console.Write(number);
                Console.Write(", ");
            }  ;
            Console.WriteLine();
            Console.WriteLine("Swapping the lists without references, and checking the presence of values.");
            SwapLists(listA, listB); // This will not swap the original lists as the reference copies passed to the method are swapped, not the original references.
            Console.Write("List A contains: ");
            foreach (var number in listA)
            {
                Console.Write(number);
                Console.Write(", ");
            } ;
            Console.WriteLine();
            Console.Write("List B contains: ");
            foreach (var number in listB)
            {
                Console.Write(number);
                Console.Write(", ");
            };
            Console.WriteLine();
            Console.WriteLine(listA.Any(listA => listA == 4));
            listA.Add(5);
            Console.WriteLine(listA.Any(listA => listA == 5));
            listA.RemoveAt(listA.Count - 1);
            Console.WriteLine("Swapping the lists with references, and checking the presence of values.");
            SwapLists(ref listA, ref listB); // this passes the original references by reference, so the swap affects the original lists.
            Console.Write("List A contains: ");
            foreach (var number in listA)
            {
                Console.Write(number);
                Console.Write(", ");
            };
            Console.WriteLine();
            Console.Write("List B contains: ");
            foreach (var number in listB)
            {
                Console.Write(number);
                Console.Write(", ");
            };
            Console.WriteLine();
            Console.WriteLine(listA.Any(listA => listA == 4));
            AddValueToList(listA, 5);
            Console.WriteLine(listA.Any(listA => listA == 5));
            Console.ReadLine();
        }

        public static void SwapLists(List<int> listA, List<int> listB)
        {
            var temp = listA;
            listA = listB;
            listB = temp;
        }
        public static void SwapLists<T>(ref List<T> listA, ref List<T> listB)
        {
            var temp = listA;
            listA = listB;
            listB = temp;
        }
        public static void AddValueToList(List<int> list, int value)
        {
            list.Add(value);
        }
    }
}
