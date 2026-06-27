using LANChat.Common;
using System;

namespace LANChat.Common
{
    
    /// Đại diện cho một thông điệp được gửi giữa Client và Server.
    
    [Serializable]
    public class Message
    {
        
        /// Loại thông điệp.
        public MessageType Type { get; set; }
        
        /// Người gửi.
        public string Sender { get; set; }

        /// Người nhận (dùng cho chat riêng hoặc gửi file).
        public string Receiver { get; set; }

        /// Nội dung tin nhắn.
        public string Content { get; set; }

        
        /// Tên file (nếu gửi file).
        public string FileName { get; set; }

        /// Kích thước file.
        public long FileSize { get; set; }

        /// Dữ liệu của file.
        public byte[] FileData { get; set; }

        /// Thời gian gửi.
        public DateTime TimeStamp { get; set; }

        /// Khởi tạo đối tượng Message.
        public Message()
        {
            TimeStamp = DateTime.Now;
        }
    }
}