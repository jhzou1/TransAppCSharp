using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trans_C_Sharp
{
    [Serializable]
 public    class Theme
    {
        public string ThemeKey { get; set; }
        //背景颜色
        public System.Drawing.Color _BackgroudColor { get; set; }
        //按钮或者标签 文字颜色
        public System.Drawing.Color _FontColor { get; set; }
    }
}
