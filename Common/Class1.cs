using System;

namespace CommonLib // Đổi namespace theo tên project mới
{
    [Serializable]
    public class ChatMessage
    {
        public MessageType Type { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public byte[] FileData { get; set; }
    }

    public enum MessageType
    {
        Login,
        Logout,
        GlobalChat,
        PrivateChat,
        UpdateUserList
    }
}