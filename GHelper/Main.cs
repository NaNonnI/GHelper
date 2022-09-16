using GHelper.panels;
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
using GHelper.utils;

namespace GHelper
{
    public partial class Main : Form
    {

        ConfigSaver configSaver = new ConfigSaver();
        string configpathTxt;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            configpathTxt = configSaver.configpath;

            if (!Directory.Exists(configpathTxt))
            {
                Directory.CreateDirectory(configpathTxt);
            }

            configSaver.startMain();
            configSaver.gmodConfig(false);

            if(configSaver.gmodpath == "Non défini")
            {
                resetColors();
                loadforms(new optionPanel());
                optionsw.BackColor = Color.SkyBlue;
            }

        }

        public void loadforms(object userControl)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.Clear();
            UserControl uc = userControl as UserControl;
            uc.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(uc);
            this.mainpanel.Tag = uc;
            uc.Show();
        }

        private void optionsw_Click(object sender, EventArgs e)
        {
            resetColors();
            loadforms(new optionPanel());
            optionsw.BackColor = Color.SkyBlue;
        }

        private void resetColors()
        {
            patchersw.BackColor = Color.White;
            midiplayersw.BackColor = Color.White;
            optionsw.BackColor = Color.White;
        }

        private void patchersw_Click(object sender, EventArgs e)
        {
            resetColors();
            loadforms(new patcherPanel());
            patchersw.BackColor = Color.SkyBlue;
        }

        private void midiplayersw_Click(object sender, EventArgs e)
        {
            resetColors();
            loadforms(new midiPanel());
            midiplayersw.BackColor = Color.SkyBlue;
        }
    }
}
