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
        private ThemeService themeService = null;
        public AskFrm(ThemeService TService)
        {
            InitializeComponent();

            this.rdMin.Checked = true;

            //设置选择
            this.rdMin.Checked = Program.GlbAppConfig.IsMinimized;
            this.rdExit.Checked = Program.GlbAppConfig.IsExitProgram;
            this.ckRemember.Checked = Program.GlbAppConfig.RememberSelected;

            themeService = TService;

            themeService.NotityEvent += SetTheme;
            if (Program.GlbAppConfig.theme != null)
                themeService.NotifyAll();

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (this.ckRemember.Checked)
            {
                Program.GlbAppConfig.IsMinimized=this.rdMin.Checked?true:false;
                Program.GlbAppConfig.IsExitProgram= this.rdExit.Checked ? true : false;
                Program.GlbAppConfig.RememberSelected= this.ckRemember.Checked ? true : false;
                //Common.ObjSerialize.SaveToXml(Program.GlbAppConfig, "_AppConfig.xml");
                Program.GlbAppConfig = (_AppConfig)Common.ObjSerialize.Deserialize("_AppConfig.obj");
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

        //通知动作
        private void SetTheme()
        {
            //设置当前窗体主题
            themeService.SetFormTheme(Program.GlbAppConfig.theme, this);
        }
    }
}
