using HoI4ModdingManager.ModdingProjectManager;
using System;
using System.Windows.Forms;

namespace HoI4ModdingManager.CountryManager.Forms
{
    public partial class CountryDataEditor : Form
    {
        public DataContainer DataContainer { get; set; }

        public CountryDataEditor(DataContainer container)
        {
            InitializeComponent();
            this.DataContainer = container;
        }

        private void Initialize()
        {

        }

        private bool ReflectData()
        {
            return true;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ReflectData();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if (ReflectData())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
