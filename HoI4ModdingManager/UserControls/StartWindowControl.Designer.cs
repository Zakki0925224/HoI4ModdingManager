
namespace HoI4ModdingManager.UserControls
{
    partial class StartWindowControl
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.openProjectButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.referenceButton = new System.Windows.Forms.Button();
            this.projectPlaceLabel = new System.Windows.Forms.Label();
            this.projectPlaceTextBox = new System.Windows.Forms.TextBox();
            this.createButton = new System.Windows.Forms.Button();
            this.createProjectSettingsPanel = new System.Windows.Forms.Panel();
            this.createProjectSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(14, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(105, 25);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "[TitleLabel]";
            // 
            // createProjectButton
            // 
            this.createProjectButton.BackColor = System.Drawing.Color.Gainsboro;
            this.createProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProjectButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createProjectButton.ForeColor = System.Drawing.Color.Black;
            this.createProjectButton.Location = new System.Drawing.Point(19, 60);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(179, 67);
            this.createProjectButton.TabIndex = 1;
            this.createProjectButton.Text = "プロジェクトの新規作成";
            this.createProjectButton.UseVisualStyleBackColor = false;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // openProjectButton
            // 
            this.openProjectButton.BackColor = System.Drawing.Color.Gainsboro;
            this.openProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.openProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProjectButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.openProjectButton.ForeColor = System.Drawing.Color.Black;
            this.openProjectButton.Location = new System.Drawing.Point(19, 133);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(179, 67);
            this.openProjectButton.TabIndex = 2;
            this.openProjectButton.Text = "プロジェクトを開く...";
            this.openProjectButton.UseVisualStyleBackColor = false;
            this.openProjectButton.Click += new System.EventHandler(this.openProjectButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.Location = new System.Drawing.Point(19, 206);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(179, 67);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.Text = "アプリケーション設定";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.projectNameLabel.Location = new System.Drawing.Point(3, 10);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(91, 17);
            this.projectNameLabel.TabIndex = 5;
            this.projectNameLabel.Text = "プロジェクト名：";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.projectNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectNameTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.projectNameTextBox.Location = new System.Drawing.Point(6, 30);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(341, 25);
            this.projectNameTextBox.TabIndex = 6;
            // 
            // referenceButton
            // 
            this.referenceButton.BackColor = System.Drawing.Color.Gainsboro;
            this.referenceButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.referenceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.referenceButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.referenceButton.ForeColor = System.Drawing.Color.Black;
            this.referenceButton.Location = new System.Drawing.Point(272, 79);
            this.referenceButton.Name = "referenceButton";
            this.referenceButton.Size = new System.Drawing.Size(75, 25);
            this.referenceButton.TabIndex = 8;
            this.referenceButton.Text = "参照";
            this.referenceButton.UseVisualStyleBackColor = false;
            this.referenceButton.Click += new System.EventHandler(this.referenceButton_Click);
            // 
            // projectPlaceLabel
            // 
            this.projectPlaceLabel.AutoSize = true;
            this.projectPlaceLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.projectPlaceLabel.Location = new System.Drawing.Point(3, 59);
            this.projectPlaceLabel.Name = "projectPlaceLabel";
            this.projectPlaceLabel.Size = new System.Drawing.Size(115, 17);
            this.projectPlaceLabel.TabIndex = 8;
            this.projectPlaceLabel.Text = "プロジェクトの場所：";
            // 
            // projectPlaceTextBox
            // 
            this.projectPlaceTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.projectPlaceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projectPlaceTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.projectPlaceTextBox.Location = new System.Drawing.Point(6, 79);
            this.projectPlaceTextBox.Name = "projectPlaceTextBox";
            this.projectPlaceTextBox.Size = new System.Drawing.Size(260, 25);
            this.projectPlaceTextBox.TabIndex = 7;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Gainsboro;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createButton.ForeColor = System.Drawing.Color.Black;
            this.createButton.Location = new System.Drawing.Point(272, 258);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 25);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "作成";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // createProjectSettingsPanel
            // 
            this.createProjectSettingsPanel.Controls.Add(this.projectNameLabel);
            this.createProjectSettingsPanel.Controls.Add(this.createButton);
            this.createProjectSettingsPanel.Controls.Add(this.projectNameTextBox);
            this.createProjectSettingsPanel.Controls.Add(this.referenceButton);
            this.createProjectSettingsPanel.Controls.Add(this.projectPlaceTextBox);
            this.createProjectSettingsPanel.Controls.Add(this.projectPlaceLabel);
            this.createProjectSettingsPanel.Location = new System.Drawing.Point(207, 60);
            this.createProjectSettingsPanel.Name = "createProjectSettingsPanel";
            this.createProjectSettingsPanel.Size = new System.Drawing.Size(350, 286);
            this.createProjectSettingsPanel.TabIndex = 11;
            this.createProjectSettingsPanel.Visible = false;
            // 
            // StartWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.createProjectSettingsPanel);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.openProjectButton);
            this.Controls.Add(this.createProjectButton);
            this.Controls.Add(this.titleLabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StartWindowControl";
            this.Size = new System.Drawing.Size(560, 349);
            this.createProjectSettingsPanel.ResumeLayout(false);
            this.createProjectSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.Label projectPlaceLabel;
        private System.Windows.Forms.TextBox projectPlaceTextBox;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Panel createProjectSettingsPanel;
    }
}
