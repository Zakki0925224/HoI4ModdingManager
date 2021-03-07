using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HoI4ModdingManager.Common.Forms
{
    public partial class SetStringListWindow : Form
    {
        public List<string> ResultData { get; set; }


        public SetStringListWindow(string[] data, string windowTitle)
        {
            InitializeComponent();

            stringListBox.Items.Clear();

            if (data.Length > 0)
            {
                foreach (string dataString in data)
                    stringListBox.Items.Add(dataString);
            }

            this.Text = windowTitle;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
                stringListBox.Items.Add(textBox.Text);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            stringListBox.Items.Remove(stringListBox.SelectedItem);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (stringListBox.Items.Count > 0)
                this.ResultData = stringListBox.Items.Cast<string>().ToList();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
