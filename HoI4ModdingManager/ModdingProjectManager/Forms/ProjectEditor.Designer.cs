
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
            this.projectEditorNavigationControl1 = new HoI4ModdingManager.ModdingProjectManager.UserControls.ProjectEditorNavigationControl();
            this.SuspendLayout();
            // 
            // projectEditorNavigationControl1
            // 
            this.projectEditorNavigationControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectEditorNavigationControl1.Location = new System.Drawing.Point(0, 0);
            this.projectEditorNavigationControl1.Name = "projectEditorNavigationControl1";
            this.projectEditorNavigationControl1.Size = new System.Drawing.Size(800, 450);
            this.projectEditorNavigationControl1.TabIndex = 0;
            // 
            // ProjectEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.projectEditorNavigationControl1);
            this.Name = "ProjectEditor";
            this.Text = "ProjectEditor";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ProjectEditorNavigationControl projectEditorNavigationControl1;
    }
}