using System;

namespace HoI4ModdingManager.ModdingProjectManager.SQLite
{
    class NotConnectingException : Exception
    {
        public NotConnectingException() : base("データベースに接続されていません") { }
    }
}
