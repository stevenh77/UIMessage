
namespace UIMessage
{
    public enum MessageType
    {
        NotSet = 0,
        Error,
        Info,
        Success,
        Question
    }

    public class Message
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public MessageType MessageType { get; set; }
    }
}
