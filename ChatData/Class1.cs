using System;

namespace WindowsFormsApp1
{
    public enum MessageType
    {
        Login,
        Logout,
        GlobalChat,
        PrivateChat,
        UpdateUserList
    }

    [Serializable]
    public class ChatMessage
    {
        public MessageType Type { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public byte[] FileData { get; set; }
    }
}