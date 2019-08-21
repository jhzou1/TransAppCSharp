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
    public partial class AskFrm : Form
    {
        private _AppConfig _AppConfig = null;
        public AskFrm()
        {
            InitializeComponent();

            this.rdMin.Checked = true;

            //载入配置文件读取是否已经记住选择，如果配置文件不存在就创建一个
            if (!File.Exists("_AppConfig.xml"))
            {
                _AppConfig = new _AppConfig()
                {
                    IsExitProgram = false,
                    IsMinimized = true,
                    RememberSelected = false
                };
                Common.ObjSerialize.SaveToXml(_AppConfig, "_AppConfig.xml");
            }
            else
            {
                _AppConfig = (_AppConfig)Common.ObjSerialize.GetFromXml<_AppConfig>("_AppConfig.xml");
            }
            //设置选择
            this.rdMin.Checked = _AppConfig.IsMinimized;
            this.rdExit.Checked = _AppConfig.IsExitProgram;
            this.ckRemember.Checked = _AppConfig.RememberSelected;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.ckRemember.Checked)
            {
                _AppConfig.IsMinimized=this.rdMin.Checked?true:false;
                _AppConfig.IsExitProgram= this.rdExit.Checked ? true : false;
                _AppConfig.RememberSelected= this.ckRemember.Checked ? true : false;
                Common.ObjSerialize.SaveToXml(_AppConfig, "_AppConfig.xml");
            }

            if (this.rdMin.Checked)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.Tag = "SelectedClose";
                this.Close();
            }
        }

        private void AskFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag is null)
            {
                this.Tag = "ClosedByBtn";
            }
        }

        private void AskFrm_Shown(object sender, EventArgs e)
        {
            if (this.ckRemember.Checked)
            {
                btnOk_Click(null, null);
            }
        }
    }
}
