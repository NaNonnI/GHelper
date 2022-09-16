using GHelper.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GHelper.panels
{
    public partial class optionPanel : UserControl
    {

        ConfigSaver configSaver = new ConfigSaver();

        public optionPanel()
        {
            InitializeComponent();
        }

        private void optionPanel_Load(object sender, EventArgs e)
        {
            configSaver.gmodConfig(false);
            if (configSaver.gmodpath == "Non défini")
            {
                getPath.Enabled = true;
            }
            else
            {
                txtPath.Text = configSaver.gmodpath;
            }
        }

        private void getPath_Click(object sender, EventArgs e)
        {
            getPathFunction();
        }

        private void getPathFunction()
        {
            OpenFileDialog folderBrowser = openFileDialog;
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Séléctionne le dossier de Garry's Mod.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                getFolderPath(folderBrowser);
            }
        }

        private void getFolderPath(OpenFileDialog folderBrowser)
        {
            string gmodPathTXT = Path.GetDirectoryName(folderBrowser.FileName) + @"\hl2.exe";
            string folderPath = Path.GetDirectoryName(folderBrowser.FileName) + @"\";

            if (!File.Exists(gmodPathTXT))
            {
                const string message = "Veuillez séléctionné le dossier de votre GMOD.";
                const string caption = "Mauvais dossier séléctionné";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Exclamation);
                if (result == DialogResult.OK)
                {
                    getPathFunction();
                }
            }
            txtPath.Text = folderPath;
            configSaver.gmodpath = folderPath;
            configSaver.gmodConfig(true);
        }
    }
}
