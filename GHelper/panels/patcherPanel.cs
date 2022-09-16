using GHelper.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHelper.panels
{
    public partial class patcherPanel : UserControl
    {

        ConfigSaver configSaver = new ConfigSaver();

        public patcherPanel()
        {
            InitializeComponent();
        }

        private void patcherPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
