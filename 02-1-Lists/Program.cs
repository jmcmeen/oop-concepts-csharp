namespace _02_1_Lists
{
    /// <summary>
    /// A program to demonstrate some basic List functionality 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //This is a reference to a List object, it doesn't reference anything until you tell it to
            List<int> list;
            
            //This is how it asks for memory to hold the integers
            list = new List<int>();

            //Now that it has memory, 
            list.Add(5641);
            list.Add(5744);
            list.Add(239485);

            //Ask the List, "List, how many items do thou have?" by using the Count property in the List
            Console.WriteLine($"I have {list.Count} values in memory");

            //Ask the List, "List, what is thy storage capacity?" by using the Capacity property in List
            Console.WriteLine($"I can hold {list.Capacity} values in memory before I have to ask for more memory");

            //Lists automatically resize for you once you hit capacity,
            //no need to call new again yourself. Let's add two ints
            list.Add(231423);
            list.Add(32984);

            //Ask the List, "List, what is thy storage capacity?" 
            Console.WriteLine($"I can hold {list.Capacity} values in memory before I have to ask for more memory");

            //Ask the List, "List, what is thy current storage utilization?"
            //since List.Capacity and List.Count are integers, I need to cast one to a float below so it will perform float math
            Console.WriteLine($"I am holding {list.Count} out of {list.Capacity} possible values for {(float)list.Count/list.Capacity * 100.0} utilization.");

            //loop through a list and print each int twice on its own line
            for (int i = 0; i < list.Count; i++)
            {
                //you can use array notation to access element at index i
                Console.WriteLine($"the element at index={i} is {list[i]}");

                //you can do the same things as above but a bit more object oriented by calling a method
                Console.WriteLine($"the element at index={i} is {list.ElementAt(i)}");
            }

            //loop through a list using foreach print each int once on the same line
            foreach (int item in list)
            {
                //that was way less typing but if you need to change the value of
                //the item at current iteration, you will need to use a for loop
                Console.Write(item + " ");
            }
        }
    }
}