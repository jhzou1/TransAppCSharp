using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Trans_C_Sharp
{
    [XmlRoot]
    public   class UpdateInfo
    {
        [XmlElement]
        public string VerNum { get; set; }
        [XmlElement]
        public string VerDesc { get; set; }
    }
}
