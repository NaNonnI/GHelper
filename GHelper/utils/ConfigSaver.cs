using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GHelper.utils
{
    public class ConfigSaver
    {
        Config readconfig;
        public bool cssbool;
        public bool htmlbool;
        public string gmodpath;

        public string configpath = $@"{System.IO.Path.GetTempPath()}\ghelper\";
        private string configfile = $@"{System.IO.Path.GetTempPath()}\ghelper\config.json";

        public void startMain()
        {
            if(!File.Exists(configfile))
            {
                gmodpath = "Non défini";
                cssbool = false;
                htmlbool = false;
                gmodConfig(true);
            }
        }

        public void gmodConfig(bool write)
        {
            var config = new Config()
            {
                gmod = new Gmod()
                {
                    path = gmodpath,
                    patcher = new Patcher()
                    {
                        css = cssbool,
                        html = htmlbool,
                    },
                },
            };

            if (write)
            {
                string json = JsonConvert.SerializeObject(config);
                File.WriteAllText(configfile, json);
            }
            else
            {
                string json = File.ReadAllText(configfile);
                readconfig = JsonConvert.DeserializeObject<Config>(json);
                gmodpath = readconfig.gmod.path;
                cssbool = readconfig.gmod.patcher.css;
                htmlbool = readconfig.gmod.patcher.css;
            }
        }

    }
}