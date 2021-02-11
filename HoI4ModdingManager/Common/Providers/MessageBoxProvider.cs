using System.Windows.Forms;

namespace HoI4ModdingManager.Common.Providers
{
    /// <summary>
    /// メッセージボックス関連の処理
    /// </summary>
    static class MessageBoxProvider
    {
        /// <summary>
        /// エラーメッセージ
        /// </summary>
        /// <param name="message">表示したいメッセージ</param>
        public static void ShowErrorMessageBox(string message)
        {
            MessageBox.Show(message, "Error - HoI4 Modding Supporter", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// インフォメーションメッセージ
        /// </summary>
        /// <param name="message">表示したいメッセージ</param>
        public static void ShowInfoMessageBox(string message)
        {
            MessageBox.Show(message, "Info - HoI4 Modding Supporter", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// セーブするかどうか
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static DialogResult SaveMessageBox(string filePath)
        {
            return MessageBox.Show($"\"{filePath}\"を保存しますか?", "Save", MessageBoxButtons.YesNoCancel);
        }
    }
}
