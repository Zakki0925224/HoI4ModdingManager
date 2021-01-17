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
            textBox1.Text = this.ProjectDataContainer.Project_name;

            string[] game_version = this.ProjectDataContainer.Game_version.Split('.');
            numericUpDown1.Value = int.Parse(game_version[0]);
            numericUpDown2.Value = int.Parse(game_version[1]);
            numericUpDown3.Value = int.Parse(game_version[2]);

            foreach (string tag in this.ProjectDataContainer.Tags)
            {
                int id = checkedListBox1.FindStringExact(tag);
                checkedListBox1.SetItemChecked(id, true);
            }

            if (this.ProjectDataContainer.Thumbnail_picture_path != "")
            {
                pictureBox1.Image = new Bitmap(this.ProjectDataContainer.Thumbnail_picture_path);
                pictureBox1.ImageLocation = this.ProjectDataContainer.Thumbnail_picture_path;
            }
        }

        /// <summary>
        /// 初期化
        /// </summary>
        private void Initialize()
        {
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = null;
            label3.Text = "";

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                checkedListBox1.SetItemChecked(i, false);
        }

        /// <summary>
        /// データコンテナにデータを反映
        /// </summary>
        private bool ReflectData()
        {
            if (!CanUseThisValues())
                return false;

            this.ProjectDataContainer.Project_name = textBox1.Text;
            // created_at, updated_at, number_of_countries, number_of_ideologiesはまだ反映させない
            this.ProjectDataContainer.Tags.Clear();
            foreach (string item in checkedListBox1.CheckedItems)
                this.ProjectDataContainer.Tags.Add(item);

            this.ProjectDataContainer.Game_version = $"{numericUpDown1.Value}.{numericUpDown2.Value}.{numericUpDown3.Value}";

            if (pictureBox1.Image == null)
                this.ProjectDataContainer.Thumbnail_picture_path = "";
            else
                this.ProjectDataContainer.Thumbnail_picture_path = pictureBox1.ImageLocation;

            return true;
        }

        /// <summary>
        /// 設定されたデータが正しいかチェック
        /// </summary>
        private bool CanUseThisValues()
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBoxProvider.ShowErrorMessageBox("タグは1つ以上設定する必要があります。");
                return false;
            }

            return true;
        }

        private void Button5_Click(object sender, System.EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.ImageLocation = null;
            label3.Text = "";
        }

        private void Button4_Click(object sender, System.EventArgs e)
        {
            string filePath = DialogProvider.ShowOpenFileDialog("PNG画像 (*.png)|*.png", "画像を開く...", true);

            if (filePath == "")
                return;

            pictureBox1.Image = new Bitmap(filePath);
            pictureBox1.ImageLocation = filePath;
            label3.Text = $"{pictureBox1.Image.Width}x{pictureBox1.Image.Height} pixel";
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            ReflectData();
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            if (ReflectData())
                this.Close();
        }
    }
}
