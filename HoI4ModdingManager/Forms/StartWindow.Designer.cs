
namespace HoI4ModdingManager.Forms
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
            this.startWindowControl = new HoI4ModdingManager.UserControls.StartWindowControl();
            this.SuspendLayout();
            // 
            // startWindowControl
            // 
            this.startWindowControl.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startWindowControl.Location = new System.Drawing.Point(12, 13);
            this.startWindowControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startWindowControl.Name = "startWindowControl";
            this.startWindowControl.Size = new System.Drawing.Size(560, 349);
            this.startWindowControl.TabIndex = 0;
            // 
            // StartWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 375);
            this.Controls.Add(this.startWindowControl);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartWindow";
            this.Text = "StartWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.StartWindowControl startWindowControl;
    }
}