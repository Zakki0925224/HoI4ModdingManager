using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoI4ModdingManager.Common.Workers
{
    /// <summary>
    /// OpenFileDialog
    /// </summary>
    class OpenDialogShower
    {
        public string OpenFile(string filter, string title, bool restoreDirectory, int filterIndex = 0)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = filter;
                ofd.FilterIndex = filterIndex;
                ofd.Title = title;
                ofd.RestoreDirectory = restoreDirectory;

                if (ofd.ShowDialog() == DialogResult.OK)
                    return ofd.FileName;
                else
                    return null;
            }
        }
    }
}
