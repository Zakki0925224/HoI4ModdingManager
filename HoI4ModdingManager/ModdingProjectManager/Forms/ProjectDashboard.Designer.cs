
namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    partial class ProjectDashBoard
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.countryManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ideologyManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focusManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.testTab1 = new System.Windows.Forms.TabPage();
            this.testTab2 = new System.Windows.Forms.TabPage();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(873, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startToolStripMenuItem.Text = "スタート(&T)";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "プロジェクトを開く(&O)...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "プロジェクトの保存(&S)";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "プロジェクトを閉じる(&C)";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "終了(&E)";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.editToolStripMenuItem.Text = "編集(&E)";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.viewToolStripMenuItem.Text = "表示(&V)";
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.projectSettingsToolStripMenuItem,
            this.toolStripSeparator3,
            this.countryManagerToolStripMenuItem,
            this.ideologyManagerToolStripMenuItem,
            this.mapManagerToolStripMenuItem,
            this.focusManagerToolStripMenuItem,
            this.eventManagerToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.projectToolStripMenuItem.Text = "プロジェクト(&P)";
            // 
            // projectSettingsToolStripMenuItem
            // 
            this.projectSettingsToolStripMenuItem.Name = "projectSettingsToolStripMenuItem";
            this.projectSettingsToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.projectSettingsToolStripMenuItem.Text = "プロジェクト設定(&P)...";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(184, 6);
            // 
            // countryManagerToolStripMenuItem
            // 
            this.countryManagerToolStripMenuItem.Name = "countryManagerToolStripMenuItem";
            this.countryManagerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.countryManagerToolStripMenuItem.Text = "CountryManager(&C)...";
            // 
            // ideologyManagerToolStripMenuItem
            // 
            this.ideologyManagerToolStripMenuItem.Name = "ideologyManagerToolStripMenuItem";
            this.ideologyManagerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.ideologyManagerToolStripMenuItem.Text = "IdeologyManager(&I)...";
            // 
            // mapManagerToolStripMenuItem
            // 
            this.mapManagerToolStripMenuItem.Name = "mapManagerToolStripMenuItem";
            this.mapManagerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.mapManagerToolStripMenuItem.Text = "MapManager(&M)...";
            // 
            // focusManagerToolStripMenuItem
            // 
            this.focusManagerToolStripMenuItem.Name = "focusManagerToolStripMenuItem";
            this.focusManagerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.focusManagerToolStripMenuItem.Text = "FocusManager(&F)...";
            // 
            // eventManagerToolStripMenuItem
            // 
            this.eventManagerToolStripMenuItem.Name = "eventManagerToolStripMenuItem";
            this.eventManagerToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.eventManagerToolStripMenuItem.Text = "EventManager(&E)...";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.toolToolStripMenuItem.Text = "ツール(&T)";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.settingsToolStripMenuItem.Text = "アプリケーション設定(&S)...";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.aboutToolStripMenuItem.Text = "バージョン情報(&A)";
            // 
            // mainTab
            // 
            this.mainTab.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.mainTab.Controls.Add(this.testTab1);
            this.mainTab.Controls.Add(this.testTab2);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.mainTab.ItemSize = new System.Drawing.Size(50, 140);
            this.mainTab.Location = new System.Drawing.Point(0, 24);
            this.mainTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTab.Multiline = true;
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(873, 417);
            this.mainTab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTab.TabIndex = 3;
            this.mainTab.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.MainTab_DrawItem);
            // 
            // testTab1
            // 
            this.testTab1.Location = new System.Drawing.Point(144, 4);
            this.testTab1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testTab1.Name = "testTab1";
            this.testTab1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testTab1.Size = new System.Drawing.Size(725, 409);
            this.testTab1.TabIndex = 0;
            this.testTab1.Text = "Test1";
            this.testTab1.UseVisualStyleBackColor = true;
            // 
            // testTab2
            // 
            this.testTab2.Location = new System.Drawing.Point(144, 4);
            this.testTab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testTab2.Name = "testTab2";
            this.testTab2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testTab2.Size = new System.Drawing.Size(725, 409);
            this.testTab2.TabIndex = 1;
            this.testTab2.Text = "Test2";
            this.testTab2.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 441);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(873, 22);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // ProjectDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 463);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(720, 480);
            this.Name = "ProjectDashBoard";
            this.Text = "ProjectDashboard";
            this.Load += new System.EventHandler(this.ProjectEditor_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage testTab1;
        private System.Windows.Forms.TabPage testTab2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem projectSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ideologyManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mapManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focusManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventManagerToolStripMenuItem;
    }
}