namespace _8_7_DeepCopy
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //Create some players
            Player playerOne = new Player { Username = "KorraZZ8" };
            Player playerTwo = new Player { Username = "XxEmoGirlxX" };
            Player playerThree = new Player { Username = "sk8er_boi" };
            Player playerFour = new Player { Username = "TheRealSlimShady2" };
            Player playerFive = new Player { Username = "404ErrorUsernameNotFound" };
            Player playerSix = new Player { Username = "b33p" };

            //Create some Guilds
            Guild guildOne = new Guild { Name = "The Best Guild" };
            Guild guildTwo = new Guild { Name = "PWNKS" };

            //Create a Server
            Server serverOne = new Server { Name = "MegaServer 0xAD" };

            //Add Players to GuildOne
            guildOne.Players.Add(playerOne);
            guildOne.Players.Add(playerTwo);
            guildOne.Players.Add(playerThree);

            //Add Players to GuildTwo
            guildTwo.Players.Add(playerFour);
            guildTwo.Players.Add(playerFive);
            guildTwo.Players.Add(playerSix);

            //Add Guilds to Server
            serverOne.Guilds.Add(guildOne);
            serverOne.Guilds.Add(guildTwo);

            //Display the Server
            Console.WriteLine($"The original server\n{serverOne}");
            Console.WriteLine();

            //Clone the Server, Server's clone method is a deep copy
            Server? serverTwo = (Server)serverOne.Clone();

            //Display the cloned server
            Console.WriteLine($"The cloned server\n{serverTwo}");

            Console.WriteLine("Making some changes to the servers");

            //Since the Clone methods in our data classes always create new objects for reference types, it is a Deep Copy.
            //We should be able to make changes to one server and not see changes in the other

            //Here we will Clear the Guilds list in serverTwo
            serverTwo.Guilds.Clear();

            //Then in serverOne, we will access the Guild at index 0 and clear all the Players
            serverOne.Guilds[0].Players.Clear();

            //If this were a shallow copy, this would have caused a thrown exception because the server would
            //have shared a reference to Guilds and we are Clearing the Guilds List for one object. Since
            //we made sure to perform a Deep Copy on all clones, we can make changes to each independently,
            //because they have their own object reference for their reference types

            Console.WriteLine($"The original server\n{serverOne}");
            Console.WriteLine();

            Console.WriteLine($"The cloned server\n{serverTwo}");
        }
    }
}