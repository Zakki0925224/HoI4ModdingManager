using System.Windows.Forms;

namespace HoI4ModdingManager.Common.Providers
{
    /// <summary>
    /// ダイアログを表示
    /// </summary>
    class DialogProvider
    {
        /// <summary>
        /// ファイルを開く
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="title"></param>
        /// <param name="restoreDirectory"></param>
        /// <param name="filterIndex"></param>
        /// <returns>ファイルパスを返す</returns>
        public string OpenFile(string filter, string title, bool restoreDirectory, int filterIndex = 0)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = filter;
                ofd.FilterIndex = filterIndex;
                ofd.Title = title;
                ofd.RestoreDirectory = restoreDirectory;

                if (ofd.ShowDialog() == DialogResult.OK)
                    return ofd.FileName;
                else
                    return null;
            }
        }

        /// <summary>
        /// ファイルを保存
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="title"></param>
        /// <param name="restoreDirectory"></param>
        /// <param name="filterIndex"></param>
        /// <returns>ファイルパスを返す</returns>
        public string SaveFile(string filter, string title, bool restoreDirectory, int filterIndex = 0)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = filter;
                sfd.FilterIndex = filterIndex;
                sfd.Title = title;
                sfd.RestoreDirectory = restoreDirectory;

                if (sfd.ShowDialog() == DialogResult.OK)
                    return sfd.FileName;
                else
                    return null;
            }
        }
    }
}
