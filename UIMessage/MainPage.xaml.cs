using System.Collections.Generic;

namespace UIMessage
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            this.MessageList.ItemsSource = new List<Message>(4)
            {
                new Message() {MessageType = MessageType.Info, Text = "For your info, this is a message", Title = "INFORMATION"},
                new Message() {MessageType = MessageType.Success, Text = "Well done, you're a winner!", Title = "SUCCESS!"},
                new Message() {MessageType = MessageType.Error, Text = "Output your error message here", Title = "ERROR"},
                new Message() {MessageType = MessageType.Question, Text = "Why?", Title = "QUESTION"}
            };
        }
    }
}
