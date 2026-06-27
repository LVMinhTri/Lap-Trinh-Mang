using System;
using System.Net.Sockets;

namespace LANChat.Server.Models
{
    /// Lưu trữ thông tin của một Client đang kết nối đến Server.
    public class ClientInfo
    {
        /// Tên người dùng (Nickname).
        public string Nickname { get; set; }

        /// <summary>
        /// Socket TCP của Client.
        /// </summary>
        public TcpClient TcpClient { get; set; }

        /// Luồng Network dùng để gửi/nhận dữ liệu.
        public NetworkStream Stream { get; set; }

        /// Thời điểm Client kết nối.
        public DateTime ConnectedTime { get; set; }

        /// Địa chỉ IP của Client.
        public string IPAddress { get; set; }

        /// Trạng thái kết nối.
        public bool IsConnected { get; set; }

        /// Khởi tạo đối tượng ClientInfo.
        public ClientInfo()
        {
            ConnectedTime = DateTime.Now;
            IsConnected = true;
        }
    }
}