﻿using System;
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
            if (File.Exists("_AppConfig.xml"))
            {
                File.Delete("_AppConfig.xml");
            }
           
            _AppConfig = new _AppConfig()
            {
                IsExitProgram = false,
                IsMinimized = true,
                RememberSelected = false
            };
            Common.ObjSerialize.SaveToXml(_AppConfig, "_AppConfig.xml");
            MessageBox.Show("重置成功，退出询问恢复默认.");
        }
    }
}
