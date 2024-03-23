namespace _02_3_Lists
{
    /// <summary>
    /// A program to demonstrate some basic List functionality
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //This is a reference to a List object, it doesn't reference anything until you tell it to
            List<int> listOfIntegers;

            //This is how it asks for memory to hold the integers
            listOfIntegers = new List<int>();

            //Now that it has memory, we can add some values
            listOfIntegers.Add(5641);
            listOfIntegers.Add(5744);
            listOfIntegers.Add(239485);

            //Ask the List, "List, how many items do thou have?" by using the Count property in the List
            Console.WriteLine($"I have {listOfIntegers.Count} values in memory");

            //Ask the List, "List, what is thy storage capacity?" by using the Capacity property in List
            Console.WriteLine($"I can hold {listOfIntegers.Capacity} values in memory before I have to ask for more memory");

            //Lists automatically resize for you once you hit capacity,
            //no need to call new again yourself. Let's add two ints
            listOfIntegers.Add(231423);
            listOfIntegers.Add(32984);

            //Ask the List, "List, what is thy storage capacity?" 
            Console.WriteLine($"I can hold {listOfIntegers.Capacity} values in memory before I have to ask for more memory");

            //Ask the List, "List, what is thy current storage utilization?"
            //since List.Capacity and List.Count are integers, I need to cast one to a float below so it will perform float math
            Console.WriteLine($"I am holding {listOfIntegers.Count} out of {listOfIntegers.Capacity} possible values for {(float)listOfIntegers.Count / listOfIntegers.Capacity * 100.0} utilization.");

            //loop through a list and print each int twice on its own line
            for (int i = 0; i < listOfIntegers.Count; i++)
            {
                //you can use array notation to access element at index i
                Console.WriteLine($"the element at index={i} is {listOfIntegers[i]}");

                //you can do the same things as above but a bit more object oriented by calling a method
                Console.WriteLine($"the element at index={i} is {listOfIntegers.ElementAt(i)}");
            }

            //loop through a list using foreach print each int once on the same line
            foreach (int item in listOfIntegers)
            {
                //that was way less typing but if you need to change the value of
                //the item at current iteration, you will need to use a for loop
                Console.Write(item + " ");
            }

            //TrimExcess and Capacity
            Console.WriteLine($"I am holding {listOfIntegers.Count} out of {listOfIntegers.Capacity} possible values for {(float)listOfIntegers.Count / listOfIntegers.Capacity * 100.0} utilization.");

            listOfIntegers.TrimExcess();

            Console.WriteLine($"I am holding {listOfIntegers.Count} out of {listOfIntegers.Capacity} possible values for {(float)listOfIntegers.Count / listOfIntegers.Capacity * 100.0} utilization.");

            listOfIntegers.Add(4);

            Console.WriteLine($"I am holding {listOfIntegers.Count} out of {listOfIntegers.Capacity} possible values for {(float)listOfIntegers.Count / listOfIntegers.Capacity * 100.0} utilization.");

            listOfIntegers.Capacity = 7;

            Console.WriteLine($"I am holding {listOfIntegers.Count} out of {listOfIntegers.Capacity} possible values for {(float)listOfIntegers.Count / listOfIntegers.Capacity * 100.0} utilization.");
        }
    }
}