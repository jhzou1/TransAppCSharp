using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Threading;

namespace Trans_C_Sharp
{
    public partial class MainFrm : Form
    {
        //private BaiduService baiduService = new BaiduService();

        //private LanguageModel languageModel = null;

        public MainFrm()
        {
            InitializeComponent();

            //languageModel = new LanguageModel();

            Inital();

            this.timer1.Interval = 1000;
            this.btnCopy.Visible = false;
            this.Text = "UncleTrans App 叔叔翻译 beta 1.2.0";

        }
        #region 初始化语言格式
        private void Inital()
        {
            List<TagerType> listType = new List<TagerType>();
            listType.Add(new TagerType()
            {
                ToLanguage = "zh",
                DescName = "中文"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "en",
                DescName = "英文"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "yue",
                DescName = "粤语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "wyw",
                DescName = "文言文"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "jp",
                DescName = "日文"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "kor",
                DescName = "韩文"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "fra",
                DescName = "法语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "spa",
                DescName = "西班牙语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "th",
                DescName = "泰语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "ara",
                DescName = "阿拉伯语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "ru",
                DescName = "俄语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "pt",
                DescName = "葡萄牙语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "de",
                DescName = "德语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "it",
                DescName = "意大利语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "el",
                DescName = "希腊语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "nl",
                DescName = "荷兰语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "pl",
                DescName = "波兰语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "bul",
                DescName = "保加利亚语"
            });
            listType.Add(new TagerType()
            {
                ToLanguage = "est",
                DescName = "爱沙尼亚语"
            });

            this.cbTransType.DataSource = listType;
            this.cbTransType.ValueMember = "ToLanguage";
            this.cbTransType.DisplayMember = "DescName";
            this.cbTransType.SelectedValue = "en";
        }
        #endregion

        #region 翻译服务
        /// <summary>
        /// 检查更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        //private static Semaphore myLockSemaphore = new Semaphore(1, 10);//第一个参数表示同时可以允许的线程数，第二个是最大值
        //private static int SemaphoreNUm = 0;
        //private string oldTargetStr = "";
        private int CountDown = 0;
        private void txtSourceStr_TextChanged(object sender, EventArgs e)
        {
            if (Common.DataValidate.IsChines(this.txtSourceStr.Text.Trim()))
            {
                this.lblNowTranc.Text = $"语言自动检测:中文--->";
                //if (this.cbTransType.SelectedValue.ToString() == "zh")
                //{
                //    this.cbTransType.SelectedValue = "en";
                //}
            }
            if (Common.DataValidate.IsEnglish(this.txtSourceStr.Text.Trim()))
            {
                this.lblNowTranc.Text = $"语言自动检测:英文--->";
                //if (this.cbTransType.SelectedValue.ToString() == "en")
                //{
                //    this.cbTransType.SelectedValue = "zh";
                //}
            }
            //if (this.richTargetStr.Text != "")
            //{
            //    this.oldTargetStr = this.richTargetStr.Text;
            //}

            if (txtSourceStr.Text.Length > 0)
            {
                //string reuslt = "";
                //string toType = this.cbTransType.SelectedValue.ToString();
                //string fromStr = this.txtSourceStr.Text;

                //try
                //{
                //    //Task.Factory.StartNew(() =>
                //    //{
                //    //    myLockSemaphore.WaitOne();
                //    //    SemaphoreNUm++;

                //    //    reuslt = DoQuery(toType, fromStr);

                //    //    myLockSemaphore.Release();
                //    //}).ContinueWith((t) =>
                //    //{
                //    //    this.richTargetStr.Text = reuslt;

                //    //    if (this.richTargetStr.Text == "")
                //    //    {
                //    //        reuslt = DoQuery(toType, fromStr);

                //    //        this.richTargetStr.Text = reuslt;
                //    //    }

                //    //}, TaskScheduler.FromCurrentSynchronizationContext());

                //    //reuslt = DoQuery(toType, fromStr);
                //    //this.richTargetStr.Text = reuslt;

                //}
                //catch (Exception ex)
                //{
                //    this.richTargetStr.Text = ex.Message;
                //}
                CountDown = 0;
                this.timer1.Start();
            }
            else
            {
                richTargetStr.Text = "";
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CountDown>1)
            {
                if (txtSourceStr.Text.Length > 0)
                {
                    string toType = this.cbTransType.SelectedValue.ToString();
                    string fromStr = this.txtSourceStr.Text;

                    this.richTargetStr.Text=DoQuery(toType, fromStr);
                    if (this.richTargetStr.Text.Trim().Length == 0)
                    {
                        this.richTargetStr.Text = DoQuery(toType, fromStr);

                        if (this.richTargetStr.Text.Trim().Length == 0)
                        {
                            this.richTargetStr.Text = DoQuery(toType, fromStr);
                        }
                    }
                }
            }
            else
            {
                CountDown++;
            }
        }

        //查询翻译
        private string DoQuery(string toType, string fromStr)
        {
            LanguageModel languageModel = new LanguageModel();

            languageModel.FromType = "auto";//自动识别
            languageModel.ToType = toType;
            languageModel.FromStr = fromStr;

            try
            {
                string result = "";
                string jsonResult1 = new BaiduService().GetTransResult(languageModel);

                Rcver jsonStr1 = Newtonsoft.Json.JsonConvert.DeserializeObject<Rcver>(jsonResult1);

                if (jsonStr1.trans_Result != null)
                {
                    result = jsonStr1.trans_Result[0].dst;
                }

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                CountDown = 0;
                timer1.Stop();
            }
        }

        //图片翻译
        private void btnImgTrans_Click(object sender, EventArgs e)
        {
            YouDaoService youDaoService = new YouDaoService();

            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(*.jpg,*.png,*.jpeg,*.bmp)|*.jgp;*.png;*.jpeg;*.bmp;";

            if (DialogResult.OK == fileDialog.ShowDialog())
            {
                string fileName = fileDialog.FileName;
                try
                {
                    string jsonStr = youDaoService.MainTransByImg(fileName);

                    YouDaoImgModel model = Newtonsoft.Json.JsonConvert.DeserializeObject<YouDaoImgModel>(jsonStr);
                    if (model != null)
                    {
                        //this.txtSourceStr.TextChanged -= txtSourceStr_TextChanged;
                        this.cbTransType.SelectedIndexChanged -= cbTransType_SelectedValueChanged;

                        this.txtSourceStr.Text = model.resRegions[0].context;

                        if (model.lanFrom == "en")
                        {
                            this.lblNowTranc.Text = $"语言自动检测:英文--->";
                            if (this.cbTransType.SelectedValue.ToString() == "en")
                            {
                                this.cbTransType.SelectedValue = "zh";
                            }
                        }
                        else if (model.lanFrom.Contains("zh"))
                        {
                            this.lblNowTranc.Text = $"语言自动检测:中文--->";
                            if (this.cbTransType.SelectedValue.ToString() == "zh")
                            {
                                this.cbTransType.SelectedValue = "en";
                            }
                        }

                        //btnTrans_Click(null, null);
                        this.timer1.Start();

                        //this.txtSourceStr.TextChanged += txtSourceStr_TextChanged;
                        this.cbTransType.SelectedIndexChanged += cbTransType_SelectedValueChanged;
                    }
                }
                catch (Exception ex)
                {
                    this.richTargetStr.Text = ex.Message;
                }

            }


        }

        //点击查询
        private void btnTrans_Click(object sender, EventArgs e)
        {
            if (txtSourceStr.Text.Length > 0)
            {
                string reuslt = "";
                string toType = this.cbTransType.SelectedValue.ToString();
                string fromStr = this.txtSourceStr.Text;

                try
                {
                    reuslt = DoQuery(toType, fromStr);

                    this.richTargetStr.Text = reuslt;
                }
                catch (Exception ex)
                {
                    this.richTargetStr.Text = ex.Message;
                }
            }
            else
            {
                richTargetStr.Text = "";
            }
        }
        #endregion

        #region 辅助设置
        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
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

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void cbTransType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (txtSourceStr.Text.Length > 0)
            {
                string reuslt = "";
                string toType = this.cbTransType.SelectedValue.ToString();
                string fromStr = this.txtSourceStr.Text;

                try
                {
                    //Task.Factory.StartNew(() =>
                    //{
                    //    myLockSemaphore.WaitOne();
                    //    SemaphoreNUm++;
                    //    reuslt = DoQuery(toType, fromStr);

                    //    myLockSemaphore.Release();
                    //}).ContinueWith((t) =>
                    //{
                    //    this.richTargetStr.Text = reuslt;

                    //}, TaskScheduler.FromCurrentSynchronizationContext());

                    reuslt = DoQuery(toType, fromStr);
                    this.richTargetStr.Text = reuslt;
                }
                catch (Exception ex)
                {
                    this.richTargetStr.Text = ex.Message;
                }
                //countNum = 0;
                //timer1.Start();
            }
            else
            {
                richTargetStr.Text = "";
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutFrm aboutFrm = new AboutFrm();
            aboutFrm.ShowDialog();
        }

        private void richTargetStr_TextChanged(object sender, EventArgs e)
        {
            if (this.richTargetStr.Text.Trim().Length > 0)
            {
                this.btnCopy.Visible = true;
                this.lblMsg.Text = "";
            }
            else
            {
                this.btnCopy.Visible = false;
                this.lblMsg.Text = "";
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Tag = "Close for update";

            this.Close();
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

        private void txtSourceStr_KeyPress(object sender, KeyPressEventArgs e)
        {
            CountDown = 0;
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Clipboard.SetDataObject(this.richTargetStr.Text);
                this.lblMsg.Text = "成功复制到粘贴板!";
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        #endregion

        private void btnOpenWeb_Click(object sender, EventArgs e)
        {
            WebMainfrm webMainfrm = new WebMainfrm();

            webMainfrm.Show();
        }
    }
}
