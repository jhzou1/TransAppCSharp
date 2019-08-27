using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trans_C_Sharp
{
    public partial class AboutFrm : Form
    {
        public AboutFrm()
        {
            InitializeComponent();

            this.txtAbout.Enabled = true;

            this.txtAbout.AppendText("1.优化翻译性能.\n");
            this.txtAbout.AppendText("2.新增退出询问窗体记住用户选择功能.\n");
            this.txtAbout.AppendText("3.在线升级程序与主程序实现互相更新.\n");
            this.txtAbout.AppendText("4.修复更新中关闭主程序托盘图标还显示的问题.\n");
            this.txtAbout.AppendText("5.FTP更新下载改为遍历FTP目录下载.\n");
            this.txtAbout.AppendText("6.新增软件设置重置退出选项功能，退出选择可自动执行.\n");
            this.txtAbout.AppendText("7.新增图片识别翻译功能.\n");
            this.txtAbout.AppendText("8.新增翻译结果复制功能.\n");
            this.txtAbout.AppendText("9.直连百度翻译功能，优化延迟.\n");
            this.txtAbout.AppendText("10.色差优化.\n");
            this.txtAbout.AppendText("11.优化子窗体显示位置问题，自动跟随父窗体定位.\n");
            this.txtAbout.AppendText("12.修复托盘显示设置时候位置混乱问题.\n");
            this.txtAbout.AppendText("13.程序运行添加请求权限功能，确保程序需要的升级权限正常运行.\n");
        }
    }
}
