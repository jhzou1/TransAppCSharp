using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Trans_C_Sharp
{
    /// <summary>
    /// 软件配置信息类
    /// </summary>
    /// 
    [XmlRoot]
    public    class _AppConfig
    {
        [XmlElement]
        public bool IsMinimized { get; set; }

        [XmlElement]
        public bool IsExitProgram { get; set; }
        [XmlElement]
        public bool RememberSelected { get; set; }
    }
}
