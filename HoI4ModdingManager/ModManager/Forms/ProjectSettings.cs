﻿using HoI4ModdingManager.Common.Providers;
using HoI4ModdingManager.ModdingProjectManager.DataHangers;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace HoI4ModdingManager.ModManager.Forms
{
    public partial class ProjectSettings : Form
    {
        public ProjectDataHanger ProjectDataContainer { get; set; }

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
            modNameTextBox.Text = this.ProjectDataContainer.ProjectName;

            if (this.ProjectDataContainer.SupportedGameVersion != "")
            {
                string[] game_version = this.ProjectDataContainer.SupportedGameVersion.Split('.');
                targetGameVersionMajor.Value = int.Parse(game_version[0]);
                targetGameVersionMinor.Value = int.Parse(game_version[1]);
                targetGameVersionRevision.Value = int.Parse(game_version[2]);
            }

            foreach (string tag in this.ProjectDataContainer.Tags)
            {
                int id = modTagListBox.FindStringExact(tag);
                modTagListBox.SetItemChecked(id, true);
            }

            if (this.ProjectDataContainer.ThumbnailPicturePath != "")
            {
                modPictureBox.Image = new Bitmap(this.ProjectDataContainer.ThumbnailPicturePath);
                modPictureBox.ImageLocation = this.ProjectDataContainer.ThumbnailPicturePath;
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

            this.ProjectDataContainer.ProjectName = modNameTextBox.Text;
            this.ProjectDataContainer.Tags = modTagListBox.CheckedItems.OfType<string>().ToArray();

            this.ProjectDataContainer.SupportedGameVersion = $"{targetGameVersionMajor.Value}.{targetGameVersionMinor.Value}.{targetGameVersionRevision.Value}";

            if (modPictureBox.Image == null)
                this.ProjectDataContainer.ThumbnailPicturePath = "";
            else
                this.ProjectDataContainer.ThumbnailPicturePath = modPictureBox.ImageLocation;

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

        private void ModPictureRemoveButton_Click(object sender, EventArgs e)
        {
            modPictureBox.Image = null;
            modPictureBox.ImageLocation = null;
            modPictureInfoLabel.Text = "";
        }

        private void ModPictureReferenceButton_Click(object sender, EventArgs e)
        {
            string filePath = DialogProvider.ShowOpenFileDialog("PNG画像 (*.png)|*.png", "画像を開く...", true);

            if (filePath == "")
                return;

            modPictureBox.Image = new Bitmap(filePath);
            modPictureBox.ImageLocation = filePath;
            modPictureInfoLabel.Text = $"{modPictureBox.Image.Width}x{modPictureBox.Image.Height} pixel";
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ReflectData();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ReflectData())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
