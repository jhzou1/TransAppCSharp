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

namespace Trans_C_Sharp
{
    public partial class SettingFrm : Form
    {
        private _AppConfig _AppConfig = null;
        public SettingFrm()
        {
            InitializeComponent();
        }

        private void btnResetExitConfig_Click(object sender, EventArgs e)
        {
            //载入配置文件读取是否已经记住选择，如果配置文件不存在就创建一个
            if (File.Exists("_AppConfig.obj"))
            {
                File.Delete("_AppConfig.obj");
            }

            Program.GlbAppConfig = new _AppConfig()
            {
                IsExitProgram = false,
                IsMinimized = true,
                RememberSelected = false,
                theme=null
            };
            //Common.ObjSerialize.SaveToXml(_AppConfig, "_AppConfig.xml");
            //保存主题设置
            Common.ObjSerialize.SerializeObj(Program.GlbAppConfig, "_AppConfig.obj");

            MessageBox.Show("重置成功，退出询问恢复默认.");
        }
    }
}
