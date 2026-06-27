namespace LANChat.Common
{
    public enum MessageType
    {
        Login,
        Logout,
        LoginSuccess,
        LoginFailed,

        OnlineUsers,
        UserJoined,
        UserLeft,

        GlobalChat,
        PrivateChat,

        FileRequest,
        FileData,
        FileProgress,
        FileComplete,
        FileReject,

        Error,
        System
    }
}