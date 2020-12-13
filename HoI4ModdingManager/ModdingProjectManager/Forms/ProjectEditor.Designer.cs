
namespace HoI4ModdingManager.ModdingProjectManager.Forms
{
    partial class ProjectEditor
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
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.testTab1 = new System.Windows.Forms.TabPage();
            this.testTab2 = new System.Windows.Forms.TabPage();
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
            this.startToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.fileToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.startToolStripMenuItem.Text = "スタート(&S)";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
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
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.projectToolStripMenuItem.Text = "プロジェクト(&P)";
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.toolToolStripMenuItem.Text = "ツール(&T)";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "ヘルプ(&H)";
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
            this.mainTab.Size = new System.Drawing.Size(873, 439);
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
            this.testTab1.Size = new System.Drawing.Size(725, 431);
            this.testTab1.TabIndex = 0;
            this.testTab1.Text = "HolyRomanEmpire";
            this.testTab1.UseVisualStyleBackColor = true;
            // 
            // testTab2
            // 
            this.testTab2.Location = new System.Drawing.Point(144, 4);
            this.testTab2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testTab2.Name = "testTab2";
            this.testTab2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testTab2.Size = new System.Drawing.Size(725, 431);
            this.testTab2.TabIndex = 1;
            this.testTab2.Text = "Japan";
            this.testTab2.UseVisualStyleBackColor = true;
            // 
            // ProjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 463);
            this.Controls.Add(this.mainTab);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProjectEditor";
            this.Text = "ProjectEditor";
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
    }
}