using System;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Text;
using System.Web;
using System.Security.Cryptography;
using System.Drawing;
using System.Collections.Generic;

namespace Trans_C_Sharp
{
public     class YouDaoService
    {
        public string MainTransByImg(string FileName)
        {
            String url = "http://openapi.youdao.com/ocrtransapi";
            Dictionary<string,string> dic = new Dictionary<string, string>();

            string img = ImgToBase64String(FileName);

            string appKey = "33c764747b001056";
            string detectType = "auto";
            string langType = "zh-CHS";
            String imageType = "1";
            string salt = DateTime.Now.Millisecond.ToString();
            string appSecret = "qxN3pSMGv2MTVfzoQfG5SOmeoT65HLh7";

            MD5 md5 = new MD5CryptoServiceProvider();
            string md5Str = appKey + img + salt + appSecret;
            byte[] output = md5.ComputeHash(System.Text.Encoding.UTF8.GetBytes(md5Str));
            string sign = BitConverter.ToString(output).Replace("-", "");

            dic.Add("q", System.Web.HttpUtility.UrlEncode(img));
            dic.Add("appKey", appKey);
            dic.Add("from", detectType);
            dic.Add("to", langType);
            dic.Add("type", imageType);
            dic.Add("salt", salt);
            dic.Add("sign", sign);

            string result = Post(url, dic);

            return result;
        }

        protected  string ImgToBase64String(string Imagefilename)
        {
            try
            {
                System.Drawing.Bitmap bmp = new System.Drawing.Bitmap(Imagefilename);

                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public  string Post(string url, Dictionary<string,string> dic)
        {
            string result = "";
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
            req.Method = "POST";
            req.ContentType = "application/x-www-form-urlencoded";

            #region 添加Post 参数
            StringBuilder builder = new StringBuilder();
            int i = 0;
            foreach (var item in dic)
            {
                if (i > 0)
                {
                    builder.Append("&");
                }
                builder.AppendFormat("{0}={1}", item.Key, item.Value);
                i++;
            }
            //Console.WriteLine(builder.ToString());
            byte[] data = Encoding.UTF8.GetBytes(builder.ToString());
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
                reqStream.Close();
            }
            #endregion

            HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
            Stream stream = resp.GetResponseStream();
            //获取响应内容
            using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }

            return result;
        }
    }
}
