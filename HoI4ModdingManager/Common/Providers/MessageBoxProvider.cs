using System.Windows.Forms;

namespace HoI4ModdingManager.Common.Providers
{
    /// <summary>
    /// メッセージボックス関連の処理
    /// </summary>
    class MessageBoxProvider
    {
        /// <summary>
        /// エラーメッセージ
        /// </summary>
        /// <param name="message">表示したいメッセージ</param>
        public void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Error - HoI4 Modding Supporter", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// インフォメーションメッセージ
        /// </summary>
        /// <param name="message">表示したいメッセージ</param>
        public void ShowInfoMessageBox(string message)
        {
            MessageBox.Show(message, "Info - HoI4 Modding Supporter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
