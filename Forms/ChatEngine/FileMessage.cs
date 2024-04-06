namespace ChatEngine
{
    public class FileMessage
    {
        public String sender { get; set; }
        public String receiver { get; set; }
        public String lenght { get; set; }
        public String extension { get; set; }
        public FileMessage(string sender, string receiver, string lenght, string extension)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.lenght = lenght;
            this.extension = extension;
        }
    }
}
