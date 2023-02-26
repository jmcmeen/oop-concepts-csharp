namespace _06_3_IComparer
{
    /// <summary>
    /// Utility class for generating random content
    /// </summary>
    internal class RandomGen
    {
        private static readonly Random r = new Random();
        /// <summary>
        /// Generates a random proper name.. probably not a lot that you've heard before
        /// </summary>
        /// <param name="maxLength">The max possible length the random name should be</param>
        /// <returns>A random name. The creator of this algorithm takes no responsibility for the content that
        /// may be generated, this is a random simulation. Consider using an word filter to remove 
        /// undesirable content</returns>
        public static string NextName(int maxLength)
        {
            //chose a random name length and make sure maxLength is longer than 3
            int nameLength = r.Next(3, maxLength <= 3 ? 4 : maxLength + 1);

            //create a list of consanant sounds
            List<string> consonants = new List<string> { "b", "c", "d", "f", "g", "h", "j", "k",
                "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };

            //create a base list of vowels
            List<string> vowels = new List<string> { "a", "e", "i", "o", "u", "y" };

            //let's make it spicy by combining every vowel with every other vowel
            List<string> spicyVowels = new List<string>();

            foreach (var v in vowels)
            {
                foreach (var vv in vowels)
                {
                    spicyVowels.Add(v + vv);
                }
            }

            //Start building the name
            string randName = "";

            //~30% chance name will start with spicy vowels
            if (r.NextDouble() < 0.30)
            {
                //Add from the list of spicy vowels
                randName += spicyVowels[r.Next(spicyVowels.Count)];

                //Captialize the first letter
                randName = randName.Substring(0, 1).ToUpper() + randName.Substring(1);
            }
            else
            {
                //Add from the list of consonants
                randName += consonants[r.Next(consonants.Count)].ToUpper();
            }

            //Add from the list of spicy vowels
            randName += spicyVowels[r.Next(spicyVowels.Count)];

            //Loop over
            while (randName.Length < nameLength)
            {
                //If the last character is in the consanants List, time to add a vowel
                if (consonants.Contains(randName.Substring(randName.Length - 1)))
                {
                    //~30% chance name to add spicy vowels
                    if (r.NextDouble() < 0.30)
                    {
                        //Add from the list of spicy vowels
                        randName += spicyVowels[r.Next(spicyVowels.Count)];
                    }
                    else //otherwise, add a regular vowel
                    {
                        //Add from the list of vowels
                        randName += vowels[r.Next(vowels.Count)];
                    }
                }
                else //otherwise add,a consanant
                {
                    //Add from the list of consonants
                    randName += consonants[r.Next(consonants.Count)];
                }

            }

            return randName;
        }


        /// <summary>
        /// Generates a random Monster
        /// </summary>
        /// <returns>Monster</returns>
        public static Monster NextMonster()
        {
            const int MIN_HP = 50;
            const int MAX_HP = 500;
            const int MAX_NAME_LENGTH = 8;
            return new Monster
            {
                Name = NextName(MAX_NAME_LENGTH),
                HitPoints = r.Next(MIN_HP, MAX_HP + 1)
            };
        }
    }
}
