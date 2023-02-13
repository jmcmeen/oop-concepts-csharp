namespace _05_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vals= { 71, 102, 405, 100, 5 , 14, 32, 50};

            int index = ArrayAlgorithms.LinearSearch(vals, 100);

            if(index == -1) 
            {
                Console.WriteLine("Value not found");
            }
            else
            {
                Console.WriteLine("Value found at index " + index);
            }

            int[] vals2 = {1,2,3,4,5,6,7,8,9,10};

            index = ArrayAlgorithms.BinarySearch(vals, 5);

            if (index == -1)
            {
                Console.WriteLine("Value not found");
            }
            else
            {
                Console.WriteLine("Value found at index " + index);
            }

            int[] rand = new int[1000];

            Random r = new Random();

            for(int i = 0; i < rand.Length; i++)
            {
                rand[i] = r.Next();
            }

            ArrayAlgorithms.BubbleSort(rand);
            ArrayAlgorithms.OptimizedBubbleSort(rand);

            foreach(int i in vals)
            {
               // Console.WriteLine(i);
            }

        }
    }
}