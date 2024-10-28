using LabUtils;

namespace _08_3_IComparer
{
    /// <summary>
    /// Utility class for generating random content
    /// </summary>
    internal static class RandomMonsterFactory
    {
        private static readonly Random r = new Random();

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
                Name = RandomGen.NextName(MAX_NAME_LENGTH),
                HitPoints = r.Next(MIN_HP, MAX_HP + 1)
            };
        }
    }
}
