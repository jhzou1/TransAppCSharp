using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpdateFrm
{
    public partial class UpdateMainFrm : Form
    {
        private static string FTPCONSTR = "ftp://015.3vftp.com/TransApp/";//FTP的服务器地址，格式为ftp://192.168.1.234:8021/。ip地址和端口换成自己的，这些建议写在配置文件中，方便修改
        private static string FTPUSERNAME = "unclezou";//FTP服务器的用户名
        private static string FTPPASSWORD = "Ads!234";//FTP服务器的密码

        public UpdateMainFrm()
        {
            InitializeComponent();
        }

        #region 从ftp服务器下载文件

        /// <summary>
        /// 从ftp服务器下载文件的功能
        /// </summary>
        /// <param name="ftpfilepath">ftp下载的地址</param>
        /// <param name="filePath">存放到本地的路径</param>
        /// <param name="fileName">保存的文件名称</param>
        /// <returns></returns>
        public bool Download(string ftpfilepath, string fileName)
        {
            try
            {
                //本程序启动路径
                string filePath = Environment.CurrentDirectory;

                //新的文件路径
                string newFileName = fileName;
                //检查是否存在
                if (File.Exists(newFileName))
                {
                    File.Delete(newFileName);
                }

                string url = FTPCONSTR + ftpfilepath;

                FtpWebRequest reqFtp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(FTPUSERNAME, FTPPASSWORD);
                FtpWebResponse response = (FtpWebResponse)reqFtp.GetResponse();
                Stream ftpStream = response.GetResponseStream();
                long cl = response.ContentLength;
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                FileStream outputStream = new FileStream(newFileName, FileMode.Create);

                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                }
                ftpStream.Close();
                outputStream.Close();
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// 遍历ftp文件夹下的所有文件
        /// </summary>
        /// <param name="FolderName"></param>
        /// <returns></returns>
        private List<string> GetFtpFileListByFolder(string FolderName)
        {
            List<string> result = new List<string>();

            FtpWebRequest ftp;

            string url = FTPCONSTR + FolderName;

            ftp = (FtpWebRequest)FtpWebRequest.Create(new Uri(url));
            ftp.Credentials = new NetworkCredential(FTPUSERNAME, FTPPASSWORD);
            ftp.Method = WebRequestMethods.Ftp.ListDirectory;
            WebResponse response = ftp.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string line = reader.ReadLine();
            //string fn = System.Web.HttpUtility.UrlDecode(line, System.Text.Encoding.GetEncoding("GB2312"));

            while (line != null)
            {
                //result.Append(line);
                //result.Append("\n");
                result.Add(line);
                line = reader.ReadLine();

            }
            //result.Remove(result.ToString().LastIndexOf("\n"), 1);
            reader.Close();
            response.Close();

            return result;
        }

        #endregion

        private void UpdateMainFrm_Shown(object sender, EventArgs e)
        {
            this.lblUpdateState.Text = "开始下载文件.......";
            Task.Factory.StartNew(delegate ()
            {
                List<string> ftpFileListByFolder = this.GetFtpFileListByFolder("");
                foreach (string text in ftpFileListByFolder)
                {
                    bool flag = text != "UpdateFrm.exe";
                    if (flag)
                    {
                        this.Download(text, text);
                    }
                }
            }).ContinueWith(delegate (Task t)
            {
                bool flag = File.Exists("Trans_C_Sharp.exe");
                if (flag)
                {
                    System.Diagnostics.Process.Start("Trans_C_Sharp.exe");
                }
                Thread.Sleep(1000);
                base.Close();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
