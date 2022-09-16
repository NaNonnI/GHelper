using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GHelper.utils
{
    internal class jsonHelper
    {
    }

    class Config
    {
        public Gmod gmod { get; set; }
    }

    class Gmod
    {
        public string path { get; set; }
        public Patcher patcher { get; set; }
    }

    class Patcher
    {
        public bool css { get; set; }
        public bool html { get; set; }
    }
}
