namespace ChatEngine.Models
{
    public class Startup
    {
        public string onlUser { get; set; }
        public string group { get; set; }
        public Startup(string onlUser, string group)
        {
            this.onlUser = onlUser;
            this.group = group;
        }
    }
}
