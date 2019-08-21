using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trans_C_Sharp
{
 public    class YouDaoImgModel
    {
        public string orientation { get; set; }

        public string lanFrom { get; set; }

        public string textAngle { get; set; }

        public string errorCode { get; set; }

        public string lanTo { get; set; }

        public List<resRegions> resRegions { get; set; }
    }
    public class resRegions
    {
        public string boundingBox { get; set; }

        public string linesCount { get; set; }

        public string lineheight { get; set; }

        public string context { get; set; }

        public string tranContent { get; set; }

        public string dir { get; set; }

        public string lang { get; set; }
    }
}
