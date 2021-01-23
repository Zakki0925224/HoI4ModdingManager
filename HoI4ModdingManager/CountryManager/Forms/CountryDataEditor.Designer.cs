
namespace HoI4ModdingManager.CountryManager.Forms
{
    partial class CountryDataEditor
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
            this.applyButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.testTabPage = new System.Windows.Forms.TabPage();
            this.mainTab = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel.SuspendLayout();
            this.testTabPage.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(855, 535);
            this.applyButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 8;
            this.applyButton.Text = "適用";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(774, 535);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "キャンセル";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(693, 535);
            this.OKButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 4;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel.Controls.Add(this.cancelButton, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.mainTab, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.applyButton, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.OKButton, 1, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.Size = new System.Drawing.Size(933, 562);
            this.tableLayoutPanel.TabIndex = 10;
            // 
            // testTabPage
            // 
            this.testTabPage.Controls.Add(this.textBox1);
            this.testTabPage.Controls.Add(this.label1);
            this.testTabPage.Location = new System.Drawing.Point(4, 24);
            this.testTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testTabPage.Name = "testTabPage";
            this.testTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.testTabPage.Size = new System.Drawing.Size(919, 495);
            this.testTabPage.TabIndex = 0;
            this.testTabPage.Text = "testTabPage";
            this.testTabPage.UseVisualStyleBackColor = true;
            // 
            // mainTab
            // 
            this.tableLayoutPanel.SetColumnSpan(this.mainTab, 4);
            this.mainTab.Controls.Add(this.testTabPage);
            this.mainTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTab.Location = new System.Drawing.Point(3, 4);
            this.mainTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size(927, 523);
            this.mainTab.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "国家タグ：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(45, 23);
            this.textBox1.TabIndex = 1;
            // 
            // CountryDataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 562);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CountryDataEditor";
            this.Text = "CountryDataEditor";
            this.tableLayoutPanel.ResumeLayout(false);
            this.testTabPage.ResumeLayout(false);
            this.testTabPage.PerformLayout();
            this.mainTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage testTabPage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}