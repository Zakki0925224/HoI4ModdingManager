
namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    partial class StartWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.settingsButton = new System.Windows.Forms.Button();
            this.openProjectButton = new System.Windows.Forms.Button();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.Button();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.referenceButton = new System.Windows.Forms.Button();
            this.projectPlaceTextBox = new System.Windows.Forms.TextBox();
            this.projectPlaceLabel = new System.Windows.Forms.Label();
            this.createProjectSettingsPanel = new System.Windows.Forms.Panel();
            this.modDescriptionButton = new System.Windows.Forms.Button();
            this.modDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.modDescriptionLabel = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.createProjectSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingsButton
            // 
            this.settingsButton.BackColor = System.Drawing.Color.Gainsboro;
            this.settingsButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.settingsButton.ForeColor = System.Drawing.Color.Black;
            this.settingsButton.Location = new System.Drawing.Point(12, 203);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(179, 67);
            this.settingsButton.TabIndex = 15;
            this.settingsButton.Text = "アプリケーション設定";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // openProjectButton
            // 
            this.openProjectButton.BackColor = System.Drawing.Color.Gainsboro;
            this.openProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.openProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openProjectButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.openProjectButton.ForeColor = System.Drawing.Color.Black;
            this.openProjectButton.Location = new System.Drawing.Point(12, 130);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(179, 67);
            this.openProjectButton.TabIndex = 14;
            this.openProjectButton.Text = "プロジェクトを開く...";
            this.openProjectButton.UseVisualStyleBackColor = false;
            this.openProjectButton.Click += new System.EventHandler(this.OpenProjectButton_Click);
            // 
            // createProjectButton
            // 
            this.createProjectButton.BackColor = System.Drawing.Color.Gainsboro;
            this.createProjectButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createProjectButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createProjectButton.ForeColor = System.Drawing.Color.Black;
            this.createProjectButton.Location = new System.Drawing.Point(12, 57);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(179, 67);
            this.createProjectButton.TabIndex = 13;
            this.createProjectButton.Text = "プロジェクトの新規作成";
            this.createProjectButton.UseVisualStyleBackColor = false;
            this.createProjectButton.Click += new System.EventHandler(this.CreateProjectButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(105, 25);
            this.titleLabel.TabIndex = 12;
            this.titleLabel.Text = "[TitleLabel]";
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
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.Gainsboro;
            this.createButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.createButton.ForeColor = System.Drawing.Color.Black;
            this.createButton.Location = new System.Drawing.Point(272, 215);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 25);
            this.createButton.TabIndex = 9;
            this.createButton.Text = "作成";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.CreateButton_Click);
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
            // createProjectSettingsPanel
            // 
            this.createProjectSettingsPanel.Controls.Add(this.modDescriptionButton);
            this.createProjectSettingsPanel.Controls.Add(this.modDescriptionTextBox);
            this.createProjectSettingsPanel.Controls.Add(this.modDescriptionLabel);
            this.createProjectSettingsPanel.Controls.Add(this.checkBox);
            this.createProjectSettingsPanel.Controls.Add(this.projectNameLabel);
            this.createProjectSettingsPanel.Controls.Add(this.createButton);
            this.createProjectSettingsPanel.Controls.Add(this.projectNameTextBox);
            this.createProjectSettingsPanel.Controls.Add(this.referenceButton);
            this.createProjectSettingsPanel.Controls.Add(this.projectPlaceTextBox);
            this.createProjectSettingsPanel.Controls.Add(this.projectPlaceLabel);
            this.createProjectSettingsPanel.Location = new System.Drawing.Point(197, 57);
            this.createProjectSettingsPanel.Name = "createProjectSettingsPanel";
            this.createProjectSettingsPanel.Size = new System.Drawing.Size(350, 250);
            this.createProjectSettingsPanel.TabIndex = 16;
            this.createProjectSettingsPanel.Visible = false;
            // 
            // modDescriptionButton
            // 
            this.modDescriptionButton.BackColor = System.Drawing.Color.Gainsboro;
            this.modDescriptionButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.modDescriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modDescriptionButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.modDescriptionButton.ForeColor = System.Drawing.Color.Black;
            this.modDescriptionButton.Location = new System.Drawing.Point(272, 154);
            this.modDescriptionButton.Name = "modDescriptionButton";
            this.modDescriptionButton.Size = new System.Drawing.Size(75, 25);
            this.modDescriptionButton.TabIndex = 13;
            this.modDescriptionButton.Text = "参照";
            this.modDescriptionButton.UseVisualStyleBackColor = false;
            this.modDescriptionButton.Visible = false;
            // 
            // modDescriptionTextBox
            // 
            this.modDescriptionTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.modDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modDescriptionTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.modDescriptionTextBox.Location = new System.Drawing.Point(6, 154);
            this.modDescriptionTextBox.Name = "modDescriptionTextBox";
            this.modDescriptionTextBox.Size = new System.Drawing.Size(260, 25);
            this.modDescriptionTextBox.TabIndex = 12;
            this.modDescriptionTextBox.Visible = false;
            // 
            // modDescriptionLabel
            // 
            this.modDescriptionLabel.AutoSize = true;
            this.modDescriptionLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.modDescriptionLabel.Location = new System.Drawing.Point(3, 134);
            this.modDescriptionLabel.Name = "modDescriptionLabel";
            this.modDescriptionLabel.Size = new System.Drawing.Size(112, 17);
            this.modDescriptionLabel.TabIndex = 14;
            this.modDescriptionLabel.Text = "Mod定義ファイル：";
            this.modDescriptionLabel.Visible = false;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.checkBox.Location = new System.Drawing.Point(6, 110);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(194, 21);
            this.checkBox.TabIndex = 10;
            this.checkBox.Text = "既存Modからプロジェクトを作成";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 317);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.openProjectButton);
            this.Controls.Add(this.createProjectButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.createProjectSettingsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartWindow";
            this.Text = "StartWindow";
            this.createProjectSettingsPanel.ResumeLayout(false);
            this.createProjectSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Button referenceButton;
        private System.Windows.Forms.TextBox projectPlaceTextBox;
        private System.Windows.Forms.Label projectPlaceLabel;
        private System.Windows.Forms.Panel createProjectSettingsPanel;
        private System.Windows.Forms.Button modDescriptionButton;
        private System.Windows.Forms.TextBox modDescriptionTextBox;
        private System.Windows.Forms.Label modDescriptionLabel;
        private System.Windows.Forms.CheckBox checkBox;
    }
}