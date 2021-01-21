
namespace HoI4ModdingManager.ModManager.Forms
{
    partial class ProjectSettings
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
            this.modNameLabel = new System.Windows.Forms.Label();
            this.modNameTextBox = new System.Windows.Forms.TextBox();
            this.modTagGroupBox = new System.Windows.Forms.GroupBox();
            this.modTagListBox = new System.Windows.Forms.CheckedListBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.applyButton = new System.Windows.Forms.Button();
            this.targetGameVersionLabel = new System.Windows.Forms.Label();
            this.targetGameVersionMajor = new System.Windows.Forms.NumericUpDown();
            this.targetGameVersionMinor = new System.Windows.Forms.NumericUpDown();
            this.targetGameVersionRevision = new System.Windows.Forms.NumericUpDown();
            this.dotLabel1 = new System.Windows.Forms.Label();
            this.dotLabel2 = new System.Windows.Forms.Label();
            this.modPictureGroupBox = new System.Windows.Forms.GroupBox();
            this.modPictureRemoveButton = new System.Windows.Forms.Button();
            this.modPictureInfoLabel = new System.Windows.Forms.Label();
            this.modPictureBox = new System.Windows.Forms.PictureBox();
            this.modPictureReferenceButton = new System.Windows.Forms.Button();
            this.modTagGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.targetGameVersionMajor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetGameVersionMinor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetGameVersionRevision)).BeginInit();
            this.modPictureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // modNameLabel
            // 
            this.modNameLabel.AutoSize = true;
            this.modNameLabel.Location = new System.Drawing.Point(12, 15);
            this.modNameLabel.Name = "modNameLabel";
            this.modNameLabel.Size = new System.Drawing.Size(56, 15);
            this.modNameLabel.TabIndex = 0;
            this.modNameLabel.Text = "Mod名：";
            // 
            // modNameTextBox
            // 
            this.modNameTextBox.Location = new System.Drawing.Point(132, 12);
            this.modNameTextBox.Name = "modNameTextBox";
            this.modNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.modNameTextBox.TabIndex = 1;
            // 
            // modTagGroupBox
            // 
            this.modTagGroupBox.Controls.Add(this.modTagListBox);
            this.modTagGroupBox.Location = new System.Drawing.Point(288, 12);
            this.modTagGroupBox.Name = "modTagGroupBox";
            this.modTagGroupBox.Size = new System.Drawing.Size(144, 225);
            this.modTagGroupBox.TabIndex = 2;
            this.modTagGroupBox.TabStop = false;
            this.modTagGroupBox.Text = "タグ";
            // 
            // modTagListBox
            // 
            this.modTagListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modTagListBox.FormattingEnabled = true;
            this.modTagListBox.Items.AddRange(new object[] {
            "Alternative Historey",
            "Events",
            "Gameplay",
            "Graphics",
            "Historical",
            "Ideologies",
            "Map",
            "National Focuses",
            "Technologies",
            "Sound",
            "Translation"});
            this.modTagListBox.Location = new System.Drawing.Point(3, 19);
            this.modTagListBox.Name = "modTagListBox";
            this.modTagListBox.Size = new System.Drawing.Size(138, 203);
            this.modTagListBox.TabIndex = 0;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(195, 246);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 3;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(276, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(357, 246);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 5;
            this.applyButton.Text = "適用";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // targetGameVersionLabel
            // 
            this.targetGameVersionLabel.AutoSize = true;
            this.targetGameVersionLabel.Location = new System.Drawing.Point(12, 43);
            this.targetGameVersionLabel.Name = "targetGameVersionLabel";
            this.targetGameVersionLabel.Size = new System.Drawing.Size(114, 15);
            this.targetGameVersionLabel.TabIndex = 6;
            this.targetGameVersionLabel.Text = "対象ゲームバージョン：";
            // 
            // targetGameVersionMajor
            // 
            this.targetGameVersionMajor.Location = new System.Drawing.Point(132, 41);
            this.targetGameVersionMajor.Name = "targetGameVersionMajor";
            this.targetGameVersionMajor.Size = new System.Drawing.Size(36, 23);
            this.targetGameVersionMajor.TabIndex = 7;
            this.targetGameVersionMajor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // targetGameVersionMinor
            // 
            this.targetGameVersionMinor.Location = new System.Drawing.Point(189, 41);
            this.targetGameVersionMinor.Name = "targetGameVersionMinor";
            this.targetGameVersionMinor.Size = new System.Drawing.Size(36, 23);
            this.targetGameVersionMinor.TabIndex = 8;
            this.targetGameVersionMinor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // targetGameVersionRevision
            // 
            this.targetGameVersionRevision.Location = new System.Drawing.Point(246, 41);
            this.targetGameVersionRevision.Name = "targetGameVersionRevision";
            this.targetGameVersionRevision.Size = new System.Drawing.Size(36, 23);
            this.targetGameVersionRevision.TabIndex = 9;
            this.targetGameVersionRevision.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // dotLabel1
            // 
            this.dotLabel1.AutoSize = true;
            this.dotLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dotLabel1.Location = new System.Drawing.Point(174, 51);
            this.dotLabel1.Name = "dotLabel1";
            this.dotLabel1.Size = new System.Drawing.Size(9, 13);
            this.dotLabel1.TabIndex = 11;
            this.dotLabel1.Text = ".";
            // 
            // dotLabel2
            // 
            this.dotLabel2.AutoSize = true;
            this.dotLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dotLabel2.Location = new System.Drawing.Point(231, 51);
            this.dotLabel2.Name = "dotLabel2";
            this.dotLabel2.Size = new System.Drawing.Size(9, 13);
            this.dotLabel2.TabIndex = 12;
            this.dotLabel2.Text = ".";
            // 
            // modPictureGroupBox
            // 
            this.modPictureGroupBox.Controls.Add(this.modPictureRemoveButton);
            this.modPictureGroupBox.Controls.Add(this.modPictureInfoLabel);
            this.modPictureGroupBox.Controls.Add(this.modPictureBox);
            this.modPictureGroupBox.Controls.Add(this.modPictureReferenceButton);
            this.modPictureGroupBox.Location = new System.Drawing.Point(172, 70);
            this.modPictureGroupBox.Name = "modPictureGroupBox";
            this.modPictureGroupBox.Size = new System.Drawing.Size(110, 167);
            this.modPictureGroupBox.TabIndex = 13;
            this.modPictureGroupBox.TabStop = false;
            this.modPictureGroupBox.Text = "画像";
            // 
            // modPictureRemoveButton
            // 
            this.modPictureRemoveButton.Location = new System.Drawing.Point(81, 138);
            this.modPictureRemoveButton.Name = "modPictureRemoveButton";
            this.modPictureRemoveButton.Size = new System.Drawing.Size(23, 23);
            this.modPictureRemoveButton.TabIndex = 14;
            this.modPictureRemoveButton.Text = "✕";
            this.modPictureRemoveButton.UseVisualStyleBackColor = true;
            this.modPictureRemoveButton.Click += new System.EventHandler(this.Button5_Click);
            // 
            // modPictureInfoLabel
            // 
            this.modPictureInfoLabel.AutoSize = true;
            this.modPictureInfoLabel.Location = new System.Drawing.Point(6, 114);
            this.modPictureInfoLabel.Name = "modPictureInfoLabel";
            this.modPictureInfoLabel.Size = new System.Drawing.Size(71, 15);
            this.modPictureInfoLabel.TabIndex = 14;
            this.modPictureInfoLabel.Text = "???x??? pixel";
            // 
            // modPictureBox
            // 
            this.modPictureBox.BackColor = System.Drawing.Color.Silver;
            this.modPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modPictureBox.Location = new System.Drawing.Point(6, 21);
            this.modPictureBox.Name = "modPictureBox";
            this.modPictureBox.Size = new System.Drawing.Size(90, 90);
            this.modPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modPictureBox.TabIndex = 1;
            this.modPictureBox.TabStop = false;
            // 
            // modPictureReferenceButton
            // 
            this.modPictureReferenceButton.Location = new System.Drawing.Point(6, 138);
            this.modPictureReferenceButton.Name = "modPictureReferenceButton";
            this.modPictureReferenceButton.Size = new System.Drawing.Size(75, 23);
            this.modPictureReferenceButton.TabIndex = 0;
            this.modPictureReferenceButton.Text = "参照";
            this.modPictureReferenceButton.UseVisualStyleBackColor = true;
            this.modPictureReferenceButton.Click += new System.EventHandler(this.Button4_Click);
            // 
            // ProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 281);
            this.Controls.Add(this.modPictureGroupBox);
            this.Controls.Add(this.dotLabel2);
            this.Controls.Add(this.dotLabel1);
            this.Controls.Add(this.targetGameVersionRevision);
            this.Controls.Add(this.targetGameVersionMinor);
            this.Controls.Add(this.targetGameVersionMajor);
            this.Controls.Add(this.targetGameVersionLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.modTagGroupBox);
            this.Controls.Add(this.modNameTextBox);
            this.Controls.Add(this.modNameLabel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "ProjectSettings";
            this.Text = "ProjectSettings - HoI4ModdingManager";
            this.modTagGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.targetGameVersionMajor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetGameVersionMinor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetGameVersionRevision)).EndInit();
            this.modPictureGroupBox.ResumeLayout(false);
            this.modPictureGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label modNameLabel;
        private System.Windows.Forms.TextBox modNameTextBox;
        private System.Windows.Forms.GroupBox modTagGroupBox;
        private System.Windows.Forms.CheckedListBox modTagListBox;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label targetGameVersionLabel;
        private System.Windows.Forms.NumericUpDown targetGameVersionMajor;
        private System.Windows.Forms.NumericUpDown targetGameVersionMinor;
        private System.Windows.Forms.NumericUpDown targetGameVersionRevision;
        private System.Windows.Forms.Label dotLabel1;
        private System.Windows.Forms.Label dotLabel2;
        private System.Windows.Forms.GroupBox modPictureGroupBox;
        private System.Windows.Forms.Label modPictureInfoLabel;
        private System.Windows.Forms.PictureBox modPictureBox;
        private System.Windows.Forms.Button modPictureReferenceButton;
        private System.Windows.Forms.Button modPictureRemoveButton;
    }
}