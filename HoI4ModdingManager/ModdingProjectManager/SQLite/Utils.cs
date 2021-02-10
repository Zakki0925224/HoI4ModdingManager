namespace HoI4ModdingManager.ModdingProjectManager.SQLite
{
    /// <summary>
    /// データベース用独自ルール
    /// </summary>
    static class Utils
    {
        /// <summary>
        /// bool値を取得(0 -> false それ以外 -> true)
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool GetBool(int value)
        {
            if (value == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// bool値からintを取得
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ConvertInt(bool value)
        {
            if (value)
                return 1;
            else
                return 0;
        }

        public static string[] GetArray(string data)
        {
            if (data == "" || data == null)
                return new string[] { "" };

            if (data.IndexOf(',') == -1)
                return new string[] {data};

            return data.Split(',');
        }
    }
}
