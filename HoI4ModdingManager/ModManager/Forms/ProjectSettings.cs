using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace HoI4ModdingManager.ModManager.Forms
{
    public partial class ProjectSettings : Form
    {
        public ProjectDataHanger ProjectDataContainer {get; set;}

        public ProjectSettings(ProjectDataHanger projectData)
        {
            InitializeComponent();
            this.ProjectDataContainer = projectData;
            Initialize();
            SetData();
        }

        /// <summary>
        /// データの設定
        /// </summary>
        private void SetData()
        {
            modNameTextBox.Text = this.ProjectDataContainer.Project_name;

            string[] game_version = this.ProjectDataContainer.Game_version.Split('.');
            targetGameVersionMajor.Value = int.Parse(game_version[0]);
            targetGameVersionMinor.Value = int.Parse(game_version[1]);
            targetGameVersionRevision.Value = int.Parse(game_version[2]);

            foreach (string tag in this.ProjectDataContainer.Tags)
            {
                int id = modTagListBox.FindStringExact(tag);
                modTagListBox.SetItemChecked(id, true);
            }

            if (this.ProjectDataContainer.Thumbnail_picture_path != "")
            {
                modPictureBox.Image = new Bitmap(this.ProjectDataContainer.Thumbnail_picture_path);
                modPictureBox.ImageLocation = this.ProjectDataContainer.Thumbnail_picture_path;
            }
        }

        /// <summary>
        /// 初期化
        /// </summary>
        private void Initialize()
        {
            modPictureBox.Image = null;
            modPictureBox.ImageLocation = null;
            modPictureInfoLabel.Text = "";

            for (int i = 0; i < modTagListBox.Items.Count; i++)
                modTagListBox.SetItemChecked(i, false);
        }

        /// <summary>
        /// データコンテナにデータを反映
        /// </summary>
        private bool ReflectData()
        {
            if (!CanUseThisValues())
                return false;

            this.ProjectDataContainer.Project_name = modNameTextBox.Text;
            // created_at, updated_at, number_of_countries, number_of_ideologiesはまだ反映させない
            this.ProjectDataContainer.Tags.Clear();
            foreach (string item in modTagListBox.CheckedItems)
                this.ProjectDataContainer.Tags.Add(item);

            this.ProjectDataContainer.Game_version = $"{targetGameVersionMajor.Value}.{targetGameVersionMinor.Value}.{targetGameVersionRevision.Value}";

            if (modPictureBox.Image == null)
                this.ProjectDataContainer.Thumbnail_picture_path = "";
            else
                this.ProjectDataContainer.Thumbnail_picture_path = modPictureBox.ImageLocation;

            return true;
        }

        /// <summary>
        /// 設定されたデータが正しいかチェック
        /// </summary>
        private bool CanUseThisValues()
        {
            if (modTagListBox.CheckedItems.Count == 0)
            {
                MessageBoxProvider.ShowErrorMessageBox("タグは1つ以上設定する必要があります。");
                return false;
            }

            return true;
        }

        private void ModPictureRemoveButton_Click(object sender, System.EventArgs e)
        {
            modPictureBox.Image = null;
            modPictureBox.ImageLocation = null;
            modPictureInfoLabel.Text = "";
        }

        private void ModPictureReferenceButton_Click(object sender, System.EventArgs e)
        {
            string filePath = DialogProvider.ShowOpenFileDialog("PNG画像 (*.png)|*.png", "画像を開く...", true);

            if (filePath == "")
                return;

            modPictureBox.Image = new Bitmap(filePath);
            modPictureBox.ImageLocation = filePath;
            modPictureInfoLabel.Text = $"{modPictureBox.Image.Width}x{modPictureBox.Image.Height} pixel";
        }

        private void ApplyButton_Click(object sender, System.EventArgs e)
        {
            ReflectData();
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void OKButton_Click(object sender, System.EventArgs e)
        {
            if (ReflectData())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
