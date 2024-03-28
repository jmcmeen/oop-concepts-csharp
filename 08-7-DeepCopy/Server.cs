using System.Text;

namespace _8_7_DeepCopy
{
    internal class Server : ICloneable
    {
        public string? Name { get; set; }
        public List<Guild> Guilds { get; set; }

        public Server()
        {
            Guilds = new List<Guild>();
        }

        /// <summary>
        /// Clone (Deep Copy)
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //Create a new Server object
            Server server = new Server
            {
                Name = Name,
            };

            //Call each Guild's deep copy Clone method and add to a new Server object Guilds
            foreach (Guild guild in Guilds)
            {
                server.Guilds.Add((Guild)guild.Clone());
            }

            return server;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            StringBuilder sb = new StringBuilder($"Server: {{ \n\tName: {Name}\n");
            foreach (Guild guild in Guilds)
            {
                sb.Append($"\n\t{guild}");
            }
            sb.Append("\n}");
            return sb.ToString();
        }
    }
}
