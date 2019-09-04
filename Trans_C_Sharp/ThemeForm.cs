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
    public partial class ThemeForm : Form
    {
        public ThemeService themeService = null;

        public ThemeForm(ThemeService TService)
        {
            InitializeComponent();
            themeService = TService;

            themeService.NotityEvent += SetTheme;
            if(Program.GlbAppConfig.theme!=null)
            themeService.NotifyAll();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefaultTheme_Click(object sender, EventArgs e)
        {
            PictureBox objPic = (PictureBox)sender;

            switch (objPic.Name)
            {
                //默认主题
                case "DefaultTheme":
                    Program.GlbAppConfig.theme = null;
                    Program.GlbAppConfig.theme = new Theme();
                    Program.GlbAppConfig.theme._BackgroudColor
                        = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(128)))), ((int)(((byte)(138)))));
                    Program.GlbAppConfig.theme._FontColor = System.Drawing.Color.White;

                    //保存主题设置
                    Common.ObjSerialize.SerializeObj(Program.GlbAppConfig, "_AppConfig.obj");

                    themeService.NotifyAll();
                    break;

                //蓝色海洋主题
                case "pb2":
                    Program.GlbAppConfig.theme = null;
                    Program.GlbAppConfig.theme = new Theme();
                    Program.GlbAppConfig.theme._BackgroudColor 
                        = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(208)))), ((int)(((byte)(248)))));
                    Program.GlbAppConfig.theme._FontColor = System.Drawing.Color.White;
                   
                    //保存主题设置
                    Common.ObjSerialize.SerializeObj(Program.GlbAppConfig, "_AppConfig.obj");

                    themeService.NotifyAll();
                    break;
                    //绿色
                case "pb3":
                    Program.GlbAppConfig.theme = null;
                    Program.GlbAppConfig.theme = new Theme();
                    Program.GlbAppConfig.theme._BackgroudColor
                        = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
                    Program.GlbAppConfig.theme._FontColor = System.Drawing.Color.White;

                    //保存主题设置
                    Common.ObjSerialize.SerializeObj(Program.GlbAppConfig, "_AppConfig.obj");

                    themeService.NotifyAll();
                    break;
                case "pb4":
                    Program.GlbAppConfig.theme = null;
                    Program.GlbAppConfig.theme = new Theme();
                    Program.GlbAppConfig.theme._BackgroudColor
                        = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(206)))), ((int)(((byte)(235)))));
                    Program.GlbAppConfig.theme._FontColor = System.Drawing.Color.White;

                    //保存主题设置
                    Common.ObjSerialize.SerializeObj(Program.GlbAppConfig, "_AppConfig.obj");

                    themeService.NotifyAll();
                    break;
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
