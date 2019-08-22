using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

namespace Trans_C_Sharp
{
    public partial class WebMainfrm : Form
    {
        public WebMainfrm()
        {
            InitializeComponent();

            //屏蔽错误
            webBr1.ScriptErrorsSuppressed = true;
            //屏蔽测试按钮
            this.btnGet.Visible = false;

            this.lblInfo.Text = "UncleTrans App 叔叔翻译 beta 1.2.4";

            this.SizeChanged += MainFrm_SizeChanged;
        }
        private void MainFrm_SizeChanged(object sender, EventArgs e)
        {
            //判断是否选择的是最小化按钮
            if (WindowState == FormWindowState.Minimized)
            {
                //隐藏任务栏区图标
                this.ShowInTaskbar = false;
                //图标显示在托盘区
                notifyIcon1.Visible = true;
            }
        }

        private void WebMainfrm_Shown(object sender, EventArgs e)
        {
            webBr1.Navigate(new Uri("https://fanyi.baidu.com"));

            //不显示滚动条
            webBr1.ScrollBarsEnabled = false;

            webBr1.IsWebBrowserContextMenuEnabled = false;
        }
        private void webBr1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBr1.ReadyState != WebBrowserReadyState.Complete) return;
            Size szb = new Size(webBr1.Document.Body.OffsetRectangle.Width,
                webBr1.Document.Body.OffsetRectangle.Height);//网页的尺寸
            webBr1.Size = szb;
            webBr1.Invalidate();

            //设置滚动条最右边
            HtmlDocument document = this.webBr1.Document;//获取控件中的html文档，类似于网页中的document对象。
            //webBr1.Document.Body.ScrollRectangle.Width+130
            //MessageBox.Show(webBr1.Document.Body.ScrollRectangle.Width.ToString());
            document.Window.ScrollTo(webBr1.Document.Body.ScrollRectangle.Width/12, 0);

            //设置顶层遮罩
            this.topPanel.Height = this.Height /7;
        }

        #region 抓取网页部分
        private void button1_Click(object sender, EventArgs e)
        {
            GetHtml();
        }

        public void GetHtml()
        {
            var url = "https://fanyi.baidu.com/#zh/en/垃圾风";
            string strBuff = "";//定义文本字符串，用来保存下载的html  
            int byteRead = 0;

            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse();
            //若成功取得网页的内容，则以System.IO.Stream形式返回，若失败则产生ProtoclViolationException错 误。在此正确的做法应将以下的代码放到一个try块中处理。这里简单处理   
            Stream reader = webResponse.GetResponseStream();
            ///返回的内容是Stream形式的，所以可以利用StreamReader类获取GetResponseStream的内容，并以StreamReader类的Read方法依次读取网页源程序代码每一行的内容，直至行尾（读取的编码格式：UTF8）  
            StreamReader respStreamReader = new StreamReader(reader, Encoding.UTF8);

            ///分段，分批次获取网页源码  
            char[] cbuffer = new char[1024];
            byteRead = respStreamReader.Read(cbuffer, 0, 256);

            while (byteRead != 0)
            {
                string strResp = new string(cbuffer, 0, byteRead);

                strBuff = strBuff + strResp;
                byteRead = respStreamReader.Read(cbuffer, 0, 256);
            }
            using (StreamWriter sw = new StreamWriter("e:\\ouput.txt"))//将获取的内容写入文本  
            {
                //htm = sw.ToString();//测试StreamWriter流的输出状态，非必须  
                sw.Write(strBuff);
            }
        }

        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCheckForUpdate_Click(object sender, EventArgs e)
        {
            //015.3vftp.com
            if (File.Exists("UpdateFrm.exe"))
            {
                File.Delete("UpdateFrm.exe");

                //【1】更新更新软件先
                this.lblMsg.Text = "正在启动更新.........";
                FtpService ftpService = new FtpService();
                ftpService.Download("TransApp/UpdateFrm.exe", "UpdateFrm.exe");

                //【2】启动更新软件
                System.Diagnostics.Process.Start("UpdateFrm.exe");
            }
            else
            {
                this.lblMsg.Text = "正在启动更新.........";
                FtpService ftpService = new FtpService();
                ftpService.Download("TransApp/UpdateFrm.exe", "UpdateFrm.exe");

                //【2】启动更新软件
                System.Diagnostics.Process.Start("UpdateFrm.exe");
            }

            //Closed the main program
            this.Tag = "Close for update";
            this.Close();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutFrm aboutFrm = new AboutFrm();
            aboutFrm.ShowDialog();
        }

        private void WebMainfrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag != null)
            {
                string msg = this.Tag.ToString();
                if (msg == "Close for update")
                {
                    e.Cancel = false;
                }
            }
            else
            {
                //弹出询问窗口
                AskFrm askFrm = new AskFrm();

                DialogResult dialogResult = askFrm.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    e.Cancel = true;
                    this.WindowState = FormWindowState.Minimized;
                }
                else
                {
                    string ReturnMsg = askFrm.Tag.ToString();
                    if (ReturnMsg == "ClosedByBtn")
                    {
                        e.Cancel = true;
                    }
                }

            }
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

            //隐藏任务栏区图标
            this.ShowInTaskbar = false;
            //图标显示在托盘区
            notifyIcon1.Visible = true;
        }

        #region  拖动窗体的实现

        private Point mouseOff;//鼠标移动位置变量
        private bool leftFlag;//标签是否为左键
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y); //得到变量的值
                leftFlag = true;                  //点击左键按下时标注为true;
            }
        }
        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);  //设置移动后的位置
                Location = mouseSet;
            }
        }
        private void FrmMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;//释放鼠标后标注为false;
            }
        }

        #endregion

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MouseEventArgs msg = (MouseEventArgs)e;
            string msg1 = msg.Button.ToString();

            if (msg.Button.ToString() == "Left")
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    //还原窗体显示    
                    WindowState = FormWindowState.Normal;
                    //激活窗体并给予它焦点
                    this.Activate();
                    //任务栏区显示图标
                    this.ShowInTaskbar = true;
                    //托盘区图标隐藏
                    notifyIcon1.Visible = false;
                }
            }
        }

        private void 显示界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                //还原窗体显示    
                WindowState = FormWindowState.Normal;
                //激活窗体并给予它焦点
                this.Activate();
                //任务栏区显示图标
                this.ShowInTaskbar = true;
                //托盘区图标隐藏
                notifyIcon1.Visible = false;
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingFrm settingFrm = new SettingFrm();

            settingFrm.ShowDialog();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Tag = "Close for update";

            this.Close();
        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            MouseEventArgs msg = (MouseEventArgs)e;
            string msg1 = msg.Button.ToString();

            if (msg.Button.ToString() == "Left")
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    //还原窗体显示    
                    WindowState = FormWindowState.Normal;
                    //激活窗体并给予它焦点
                    this.Activate();
                    //任务栏区显示图标
                    this.ShowInTaskbar = true;
                    //托盘区图标隐藏
                    notifyIcon1.Visible = false;
                }
            }
        }

        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);
        private void btnSettings_Click(object sender, EventArgs e)
        {
            //this.IsMdiContainer = true;

            SettingFrm settingFrm = new SettingFrm();
            //settingFrm.MdiParent = this;
            //settingFrm.StartPosition = FormStartPosition.CenterScreen;
            //settingFrm.Top =this.Top;
            //settingFrm.Left= this.Left;

            settingFrm.ShowDialog();

            //SetParent((int)settingFrm.Handle, (int)this.Handle);
        }
    }
}
