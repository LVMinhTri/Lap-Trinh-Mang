using System.Collections.Generic;
using System.Linq;
using LANChat.Server.Models;

namespace LANChat.Server.Services
{
    /// Quản lý danh sách các Client đang kết nối đến Server.
    public class UserManager
    {
        /// Danh sách Client đang online.
        private readonly List<ClientInfo> _clients;

        /// Khởi tạo UserManager.
        public UserManager()
        {
            _clients = new List<ClientInfo>();
        }

        /// Thêm Client mới.
        public void AddClient(ClientInfo client)
        {
            lock (_clients)
            {
                _clients.Add(client);
            }
        }

        /// Xóa Client khỏi danh sách.
        public void RemoveClient(ClientInfo client)
        {
            lock (_clients)
            {
                _clients.Remove(client);
            }
        }

        /// Kiểm tra Nickname đã tồn tại chưa.
        public bool IsNicknameExists(string nickname)
        {
            lock (_clients)
            {
                return _clients.Any(c => c.Nickname == nickname);
            }
        }

        /// Tìm Client theo Nickname.
        public ClientInfo GetClient(string nickname)
        {
            lock (_clients)
            {
                return _clients.FirstOrDefault(c => c.Nickname == nickname);
            }
        }

        /// Lấy danh sách tất cả Client.
        public List<ClientInfo> GetAllClients()
        {
            lock (_clients)
            {
                return new List<ClientInfo>(_clients);
            }
        }

        /// Lấy danh sách Nickname đang online.
        public List<string> GetOnlineUsers()
        {
            lock (_clients)
            {
                return _clients
                    .Select(c => c.Nickname)
                    .ToList();
            }
        }

        /// Số lượng Client đang online.
        public int Count
        {
            get
            {
                lock (_clients)
                {
                    return _clients.Count;
                }
            }
        }
    }
}