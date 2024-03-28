using System.Text;

namespace _8_7_DeepCopy
{
    internal class Guild : ICloneable
    {
        public string? Name { get; set; }
        public List<Player> Players { get; set; }

        public Guild()
        {
            Players = new List<Player>();
        }

        /// <summary>
        /// Clone (Deep Copy)
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //Create a new Guild so it is a Deep Copy
            Guild guild = new Guild
            {
                Name = Name,
            };

            //Player.Clone() creates a new Player
            foreach (Player player in Players)
            {
                guild.Players.Add((Player)player.Clone());
            }

            return guild;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder($"Guild: {{ \n\t\tName: {Name}\n");
            foreach (Player player in Players)
            {
                sb.Append($"\n\t\t{player}");
            }
            sb.Append("\n\t}\n");
            return sb.ToString();
        }
    }
}
