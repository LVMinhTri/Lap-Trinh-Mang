namespace LanChat.Common
{

    public enum MessageType
    {
        #region Connection

        Login,
        Logout,
        LoginSuccess,
        LoginFailed,

        #endregion

        #region User

        OnlineUsers,
        UserJoined,
        UserLeft,

        #endregion

        #region Chat

        GlobalChat,
        PrivateChat,

        #endregion

        #region File

        FileRequest,
        FileData,
        FileProgress,
        FileComplete,
        FileReject,

        #endregion

        #region System

        Error,
        System

        #endregion
    }
}