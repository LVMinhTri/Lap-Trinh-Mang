namespace LANChat.Common
{
    /// Chứa các hằng số sử dụng trong hệ thống Chat LAN.
    public static class Constants
    {
        /// Cổng TCP mà Server sẽ lắng nghe.
        public const int SERVER_PORT = 5000;

        /// Kích thước bộ đệm khi gửi/nhận dữ liệu.
        public const int BUFFER_SIZE = 4096;

        /// Kích thước mỗi gói dữ liệu khi truyền file.
        public const int FILE_CHUNK_SIZE = 4096;

        /// Địa chỉ IP mặc định của Server.
        /// Có thể thay đổi khi chạy thực tế.
        public const string DEFAULT_IP = "127.0.0.1";

        /// Thời gian chờ (ms) khi nhận dữ liệu.
        public const int RECEIVE_TIMEOUT = 30000;

        /// Thời gian chờ (ms) khi gửi dữ liệu.
        public const int SEND_TIMEOUT = 30000;

        /// Độ dài tối đa của nickname.
        public const int MAX_NICKNAME_LENGTH = 20;

        /// Độ dài tối đa của một tin nhắn.
        public const int MAX_MESSAGE_LENGTH = 1000;
    }
}